using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClientManager : MonoBehaviour
{
    public RealtimeManager realtime;
    public GameObject msgPrefab;
    public Button b_CreateSession;
    public Button b_SendMessage;
    public InputField inputField;
    public Transform msgBox;
    public Text t_KeepAliveCounter;
    private int keepAliveCounter;
    public Text t_GroupAliveCounter;
    private int groupAliveCounter;
    public Image toggle;

    private List<GameObject> msgs;

    void Start()
    {
        msgs = new List<GameObject>();
        b_CreateSession.onClick.AddListener(() => CreateSession());
        b_SendMessage.onClick.AddListener(() => SendMessage());
        toggle.GetComponent<Button>().onClick.AddListener(() => ToggleTLS());
        t_KeepAliveCounter.text = "";
        t_GroupAliveCounter.text = "";

        if(realtime.usingTLS)
            toggle.color = Color.blue;
        else
            toggle.color = Color.red;
    }

    void ToggleTLS()
    {
        if(realtime.isConnected())
            return;

        if(realtime.usingTLS)
        {
            toggle.color = Color.red;
            realtime.usingTLS = false;
        }
        else
        {
            toggle.color = Color.blue;
            realtime.usingTLS = true;
        }
    }

    public void MessageReceived(string text)
    {
        GameObject x = Instantiate(msgPrefab, new Vector3(0,0,0), Quaternion.identity);
        x.transform.SetParent(msgBox, false);
        x.GetComponentInChildren<Text>().text = text;
        msgs.Add(x);

        if(msgs.Count > 7)
        {
            Destroy(msgs[0].gameObject);
            msgs.Remove(msgs[0]);
            msgs.TrimExcess();
        }
    }

    void CreateSession()
    {
        realtime.StartSession();
        b_CreateSession.onClick.RemoveAllListeners();
        b_CreateSession.onClick.AddListener(() => JoinGroup());
        b_CreateSession.GetComponentInChildren<Text>().text = "Join Group";
    }

    void JoinGroup()
    {
        realtime.JoinGroupTen();
        b_CreateSession.gameObject.SetActive(false);
    }

    void SendMessage()
    {
        if(!realtime.isConnected())
            return;

        realtime.SendMessagePayload(inputField.text);
        inputField.text = "";
    }

    public void KeepAlive()
    {
        keepAliveCounter++;
        t_KeepAliveCounter.text = ($"KeepAlives: {keepAliveCounter}");
    }

    public void GroupAlive()
    {
        groupAliveCounter++;
        t_GroupAliveCounter.text = ($"GroupAlives: {groupAliveCounter}");
    }

}
