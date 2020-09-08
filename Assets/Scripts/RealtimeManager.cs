using System;
using System.Net;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;
using Aws.GameLift.Realtime;
using Aws.GameLift.Realtime.Command;
using Aws.GameLift.Realtime.Event;
using Aws.GameLift.Realtime.Types;
using Newtonsoft.Json;

public class PS
{
    public PlayerSessionObject PlayerSession { get; set; }
}

[System.Serializable]
public class PlayerSessionObject
{
    public string PlayerSessionId { get; set; }
    public string PlayerId { get; set; }
    public string GameSessionId { get; set; }
    public string FleetId { get; set; }
    public string FleetArn { get; set; }
    public DateTime CreationTime { get; set; }
    public string Status { get; set; }
    public string IpAddress { get; set; }
    public string DnsName { get; set; }
    public int Port { get; set; }
}

public class GS
{
    public GameSession GameSession { get; set; }
}

[System.Serializable]
public class GameSession
{
    public string GameSessionId { get; set; }
    public string Name { get; set; }
    public string FleetId { get; set; }
    public string FleetArn { get; set; }
    public DateTime CreationTime { get; set; }
    public int CurrentPlayerSessionCount { get; set; }
    public int MaximumPlayerSessionCount { get; set; }
    public string Status { get; set; }
    public string IpAddress { get; set; }
    public int Port { get; set; }
}

public class PassingJson
{
    public string game;
    public string player;
}

public static class Extensions
{
    public static Task<HttpResponseMessage> PostAsJsonAsync<T>(
            this HttpClient httpClient, string url, T data)
    {
        var dataAsString = JsonUtility.ToJson(data);
        var content = new StringContent(dataAsString);
        content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        return httpClient.PostAsync(url, content);
    }
}

public class RealtimeManager : MonoBehaviour
{
    public bool usingTLS = false;
    public ClientManager clientManager;
    public string apiURL = "";
    public string noCertGameEndpoint = "";
    public string yesCertGameEndpoint = "";
    public string addPlayerSessionEndpoint = "";
    public static readonly HttpClient client = new HttpClient();
    private GS gameSession;
    private PS playerSession;

    void Start()
    {

    }

    void Update()
    {
        RunMainThreadQueueActions();
    }

    public void StartSession()
    {
        AddSession();
    }

    string targetSessionID;
    async void AddSession()
    {
        HttpResponseMessage result;
        if (!usingTLS)
            result = await client.GetAsync(apiURL + noCertGameEndpoint);
        else
            result = await client.GetAsync(apiURL + yesCertGameEndpoint);

        var response = await result.Content.ReadAsStringAsync();
        Debug.Log(response);
        gameSession = Newtonsoft.Json.JsonConvert.DeserializeObject<GS>(response);

        StartPlayerSession();
    }

    async void StartPlayerSession()
    {
        var json = new PassingJson
        {
            game = gameSession.GameSession.GameSessionId,
            player = "skytech6"
        };
        var result = await client.PostAsJsonAsync(apiURL + addPlayerSessionEndpoint, json);
        var response = await result.Content.ReadAsStringAsync();
        playerSession = Newtonsoft.Json.JsonConvert.DeserializeObject<PS>(response);

        StartCoroutine(ConnectToServer(playerSession.PlayerSession.DnsName, playerSession.PlayerSession.Port, playerSession.PlayerSession.PlayerSessionId));

    }

    private IEnumerator ConnectToServer(string ipAddr, int port, string tokenUID)
    {
        ClientLogger.LogHandler = (x) => Debug.Log(x);
        ConnectionToken token = new ConnectionToken(tokenUID, null);

        ClientConfiguration clientConfiguration;
        if (!usingTLS)
            clientConfiguration = new ClientConfiguration
            {
                ConnectionType = ConnectionType.RT_OVER_WS_UDP_UNSECURED
            };
        else
            clientConfiguration = new ClientConfiguration
            {
                ConnectionType = ConnectionType.RT_OVER_WSS_DTLS_TLS12
            };

        _client = new Aws.GameLift.Realtime.Client(clientConfiguration);

        _client.DataReceived += OnDataReceived;

        int ListenPort = 8921;

        // if (usingTLS)
        //     ListenPort = FindAvailableTCPPort(49664, 49670);

        clientManager.MessageReceived($"[client] TLS: {usingTLS} with Port: {ListenPort}");
        _client.Connect(ipAddr, port, ListenPort, token);

        while (true)
        {
            if (_client.ConnectedAndReady)
            {
                clientManager.MessageReceived("[client] Connected to server");
                break;
            }
            yield return null;
        }
    }

    private int FindAvailableTCPPort(int firstPort, int lastPort)
    {
        var TCPEndPoints = IPGlobalProperties.GetIPGlobalProperties().GetActiveTcpListeners();
        List<int> usedPorts = new List<int>();
        usedPorts.AddRange(from n in TCPEndPoints where n.Port >= firstPort && n.Port <= lastPort select n.Port);
        usedPorts.Sort();
        for (int testPort = firstPort; testPort <= lastPort; ++testPort)
        {
            Debug.Log(testPort);

            if (!usedPorts.Contains(testPort))
            {
                return testPort;
            }
        }
        return -1;
    }

    public void JoinGroupTen()
    {
        _client.JoinGroup(10);

    }

    private void OnDataReceived(object sender, DataReceivedEventArgs e)
    {
        string data = Encoding.Default.GetString(e.Data);
        string msgToInput = ($"OpCode: {e.OpCode} | {data}");

        if (e.OpCode == 500)
            QForMainThread(clientManager.KeepAlive);
        else if (e.OpCode == 400)
            QForMainThread(clientManager.GroupAlive);
        else if (e.OpCode == 200)
        {
            Debug.Log(msgToInput);
            QForMainThread(clientManager.MessageReceived, msgToInput);
        }
    }

    public void SendMessagePayload(string msg)
    {
        if (!usingTLS)
            _client.SendEvent(200, Encoding.ASCII.GetBytes(msg));
        else
        {
            RTMessage myRT = _client.NewMessage(200).WithTargetPlayer(-1).WithDeliveryIntent(DeliveryIntent.Reliable).WithPayload(Encoding.ASCII.GetBytes(msg));
            myRT.WithTargetPlayer(-1);

            _client.SendMessage(myRT);
        }
    }

    private Aws.GameLift.Realtime.Client _client;
    public bool isConnected()
    {
        if(_client == null)
            return false;

        return _client.ConnectedAndReady;
    }

    private Queue<Action> _mainThreadQueue = new Queue<Action>();

    private void QForMainThread(Action fn)
    {
        lock (_mainThreadQueue)
        {
            _mainThreadQueue.Enqueue(() => { fn(); });
        }
    }

    private void QForMainThread<T1>(Action<T1> fn, T1 p1)
    {
        lock (_mainThreadQueue)
        {
            _mainThreadQueue.Enqueue(() => { fn(p1); });
        }
    }

    private void QForMainThread<T1, T2>(Action<T1, T2> fn, T1 p1, T2 p2)
    {
        lock (_mainThreadQueue)
        {
            _mainThreadQueue.Enqueue(() => { fn(p1, p2); });
        }
    }

    private void QForMainThread<T1, T2, T3>(Action<T1, T2, T3> fn, T1 p1, T2 p2, T3 p3)
    {
        lock (_mainThreadQueue)
        {
            _mainThreadQueue.Enqueue(() => { fn(p1, p2, p3); });
        }
    }


    private void RunMainThreadQueueActions()
    {
        // as our server messages come in on their own thread
        // we need to queue them up and run them on the main thread
        // when the methods need to interact with Unity
        lock (_mainThreadQueue)
        {
            while (_mainThreadQueue.Count > 0)
            {
                _mainThreadQueue.Dequeue().Invoke();
            }
        }
    }
}
