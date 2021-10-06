# TLSReproductionCase
![MIT licensed](https://img.shields.io/badge/license-MIT-blue.svg)
[![CodeFactor](https://www.codefactor.io/repository/github/skytech6/awsrealtimetlstester/badge/master)](https://www.codefactor.io/repository/github/skytech6/awsrealtimetlstester/overview/master)
 
# Known Results
![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) - Working Functionality

![#f03c15](https://via.placeholder.com/15/f03c15/000000?text=+) - Not Working Functionality

? - Unable to test due to prior failure

## Unity Editor 2020.3 - Windows 10

|**Action** | **Non-Cert** | **Cert w/[D]TLS** |
| ----- |:-------:|:---:|
|Create Game Session | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) |
|KeepAlive Pings | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) |
|Join Group | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) |
|GroupAlive Pings | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) |
|Send Message | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) |

## Unity Editor 2020.3 - OSX Big Sur

|**Action** | **Non-Cert** | **Cert w/[D]TLS** |
| ----- |:-------:|:---:|
|Create Game Session | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) |
|KeepAlive Pings | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#f03c15](https://via.placeholder.com/15/f03c15/000000?text=+) |
|Join Group | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#f03c15](https://via.placeholder.com/15/f03c15/000000?text=+) |
|GroupAlive Pings | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#f03c15](https://via.placeholder.com/15/f03c15/000000?text=+) |
|Send Message | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#f03c15](https://via.placeholder.com/15/f03c15/000000?text=+) |


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
|Create Game Session | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | Not Tested |
|KeepAlive Pings | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | - |
|Join Group | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | - |
|GroupAlive Pings | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | - |
|Send Message | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | - |

Haven't tested the x86 since we haven't attempted to make a target compiled dll (if someone does test this, feel free to fork & PR). 

## Mac OSX Standalone

|**Action** | **Non-Cert** | **Cert w/[D]TLS** |
| ----- |:-------:|:---:|
|Create Game Session | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#f03c15](https://via.placeholder.com/15/f03c15/000000?text=+) *1 |
|KeepAlive Pings | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | - |
|Join Group | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | - |
|GroupAlive Pings | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | - |
|Send Message | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | - |

*1 - We have attempted to make a dylib for Mac, but haven't been able to get one working yet

## Android App (Mono JIT)

|**Action** | **Non-Cert** | **Cert w/[D]TLS** |
| ----- |:-------:|:---:|
|Create Game Session | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) |
|KeepAlive Pings | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) |
|Join Group | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) |
|GroupAlive Pings | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) |
|Send Message | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) |

## Android App (IL2CPP AOT)

|**Action** | **Non-Cert** | **Cert w/[D]TLS** |
| ----- |:-------:|:---:|
|Create Game Session | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) |
|KeepAlive Pings | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) |
|Join Group | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) |
|GroupAlive Pings | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) |
|Send Message | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) |

## iOS App 

|**Action** | **Non-Cert** | **Cert w/[D]TLS** |
| ----- |:-------:|:---:|
|Create Game Session | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) |
|KeepAlive Pings | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) |
|Join Group | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) |
|GroupAlive Pings | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) |
|Send Message | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) | ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+) |
