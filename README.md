# TLSReproductionCase
![MIT licensed](https://img.shields.io/badge/license-MIT-blue.svg)
[![CodeFactor](https://www.codefactor.io/repository/github/skytech6/awsrealtimetlstester/badge/master)](https://www.codefactor.io/repository/github/skytech6/awsrealtimetlstester/overview/master)
 
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
- Create Game Session - ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+)
- Keep Alive Pings - ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+)
- Join Group - ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+)
- Group Alive Pings - ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+)
- Send Message - ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+)

## iOS App - Cert w/ TLS&DTLS
- Create Game Session - ![#1589F0](https://via.placeholder.com/15/1589F0/000000?text=+)
- Keep Alive Pings - ![#f03c15](https://via.placeholder.com/15/f03c15/000000?text=+) Session Created, Connection Not Fully Established
- Join Group - Untested
- Group Alive Pings - Untested
- Send Message - Untested
