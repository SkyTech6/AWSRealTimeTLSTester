# TLSReproductionCase
![MIT licensed](https://img.shields.io/badge/license-MIT-blue.svg)
[![CodeFactor](https://www.codefactor.io/repository/github/skytech6/awsrealtimetlstester/badge/master)](https://www.codefactor.io/repository/github/skytech6/awsrealtimetlstester/overview/master)
 
# Known Results
![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) - Working Functionality
![#f03c15](https://via.placeholder.com/15/f03c15/000000?text=+) - Not Working Functionality
? - Unable to test due to prior failure

## Unity Editor

|**Action** | **Non-Cert** | **Cert w/[D]TLS** |
| ----- |:-------:|:---:|
|Create Game Session | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) |
|KeepAlive Pings | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) |
|Join Group | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#f03c15](https://via.placeholder.com/15/f03c15/000000?text=+) *1* |
|GroupAlive Pings | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ? |
|Send Message | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) *2* |

*1* - Join Group will cause the Unity Editor to crash on cert w/ TLS/DTLS

*2* - Only works with _client.SendMessage(), using _client.SendEvent() will cause a crash. (This tester by default will always use SendMessage() for cert and SendEvent() for non-cert; until or if Amazon's Gamelift team specifies that SendMessage is the appropriate method to always use.) 

## Windows Standalone - x64

|**Action** | **Non-Cert** | **Cert w/[D]TLS** |
| ----- |:-------:|:---:|
|Create Game Session | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) |
|KeepAlive Pings | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) |
|Join Group | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) |
|GroupAlive Pings | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) |
|Send Message | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) |


## Windows Standalone x86

|**Action** | **Non-Cert** | **Cert w/[D]TLS** |
| ----- |:-------:|:---:|
|Create Game Session | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#f03c15](https://via.placeholder.com/15/f03c15/000000?text=+) |
|KeepAlive Pings | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ? |
|Join Group | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ? |
|GroupAlive Pings | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ? |
|Send Message | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ? |

Note - This seems like the usual result of the connection not being completed after creating the session. 

## Android App (Mono JIT)

|**Action** | **Non-Cert** | **Cert w/[D]TLS** |
| ----- |:-------:|:---:|
|Create Game Session | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#f03c15](https://via.placeholder.com/15/f03c15/000000?text=+) |
|KeepAlive Pings | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ? |
|Join Group | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ? |
|GroupAlive Pings | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ? |
|Send Message | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ? |

## Android App (IL2CPP AOT)

|**Action** | **Non-Cert** | **Cert w/[D]TLS** |
| ----- |:-------:|:---:|
|Create Game Session | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#f03c15](https://via.placeholder.com/15/f03c15/000000?text=+) |
|KeepAlive Pings | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ? |
|Join Group | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ? |
|GroupAlive Pings | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ? |
|Send Message | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ? |

## iOS App 

|**Action** | **Non-Cert** | **Cert w/[D]TLS** |
| ----- |:-------:|:---:|
|Create Game Session | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) |
|KeepAlive Pings | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#f03c15](https://via.placeholder.com/15/f03c15/000000?text=+) *1* |
|Join Group | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ? |
|GroupAlive Pings | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ? |
|Send Message | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ? |

*1* - Session Created, Connection Not Fully Established
