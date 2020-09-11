# TLSReproductionCase
 
# Known Results
![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) - Working Functionality
![#f03c15](https://via.placeholder.com/15/f03c15/000000?text=+) - Not Working Functionality
## Unity Editor - Non-Cert
- Create Game Session - ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+)
- Keep Alive Pings - ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+)
- Join Group - ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+)
- Group Alive Pings - ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+)
- Send Message - ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+)

## Unity Editor - Cert w/ TLS&DTLS
- Create Game Session - ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+)
- Keep Alive Pings - ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+)
- Join Group - ![#f03c15](https://via.placeholder.com/15/f03c15/000000?text=+) **CRASH**
- Group Alive Pings - n/a
- Send Message - ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) (only with SendMessage(), ![#f03c15](https://via.placeholder.com/15/f03c15/000000?text=+) **SendEvent() will crash**)

## Windows Standalone - Non-Cert
- Create Game Session - ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+)
- Keep Alive Pings - ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+)
- Join Group - ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+)
- Group Alive Pings - ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+)
- Send Message - ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+)

## Windows Standalone - Cert w/ TLS&DTLS
- Create Game Session - ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+)
- Keep Alive Pings - ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+)
- Join Group - ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+)
- Group Alive Pings - ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+)
- Send Message - ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+)

## Windows Standalone x86 - Non-Cert
- Create Game Session - ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+)
- Keep Alive Pings - ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+)
- Join Group - ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+)
- Group Alive Pings - ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+)
- Send Message - ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+)

## Windows Standalone x86 - Cert w/ TLS&DTLS
- Create Game Session - ![#f03c15](https://via.placeholder.com/15/f03c15/000000?text=+)
- Keep Alive Pings - Can't Test
- Join Group - Can't Test
- Group Alive Pings - Can't Test
- Send Message - Can't Test

This seems like the usual result of the connection not being completed after creating the session. 

## Android App - Non-Cert
- Create Game Session - ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+)
- Keep Alive Pings - ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+)
- Join Group - ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+)
- Group Alive Pings - ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+)
- Send Message - ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+)

## Android App - Cert w/ TLS&DTLS
- Create Game Session - ![#f03c15](https://via.placeholder.com/15/f03c15/000000?text=+)
- Keep Alive Pings - Can't Test
- Join Group - Can't Test
- Group Alive Pings - Can't Test
- Send Message - Can't Test

## iOS App - Non-Cert
- Create Game Session - ![#f03c15](https://via.placeholder.com/15/f03c15/000000?text=+) **Freezes application**
```
[INFO] Client requested fast connection, but not currently setup -- falling back to reliable
[ERROR] Exception occurred sending data. Exception: The type initializer for 'Com.Gamelift.Rt.Proto.PacketReflection' threw an exception.
System.Action`1:Invoke(T)
Aws.GameLift.Realtime.ClientLogger:Output(LogLevel, String)
Aws.GameLift.Realtime.Network.BaseConnection:Send(Packet)
Aws.GameLift.Realtime.Client:Send(RTMessage)
Aws.GameLift.Realtime.Client:OnConnectionOpen(Object, EventArgs)
System.EventHandler:Invoke(Object, EventArgs)
System.EventHandler:Invoke(Object, EventArgs)
WebSocket4Net.Command.Handshake:ExecuteCommand(WebSocket, WebSocketCommandInfo)
WebSocket4Net.WebSocket:ExecuteCommand(WebSocketCommandInfo)
WebSocket4Net.WebSocket:OnDataReceived(Byte[], Int32, Int32)
System.EventHandler`1:Invoke(Object, TEventArgs)
SuperSocket.ClientEngine.AsyncTcpSession:ProcessReceive(SocketAsyncEventArgs)
System.EventHandler`1:Invoke(Object, TEventArgs)
System.Net.Sockets.<>c:<.cctor>b__309_7(IAsyncResult)
System.AsyncCallback:Invoke(IAsyncResult)
System.Threading.WaitCallback:Invoke(Object)
System.Threading.ThreadPoolWorkQueue:Dispatch()
```
- Keep Alive Pings - Untested
- Join Group - Untested
- Group Alive Pings - Untested
- Send Message - Untested

## iOS App - Cert w/ TLS&DTLS
- Create Game Session - ![#f03c15](https://via.placeholder.com/15/f03c15/000000?text=+) **Same as Non-Cert**
- Keep Alive Pings - Untested
- Join Group - Untested
- Group Alive Pings - Untested
- Send Message - Untested
