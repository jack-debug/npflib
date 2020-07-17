# npflib
NPF C# .NET Core library. Let's you use NPF's flooding methods inside your own project.
## Disclaimer
This software is intended for educational and testing purposes. The creator does not allow you to use this software in malicious ways. The creator does not hold liability for anything you do with this software. 
## How to use in your project
1. Reference npflib in your project `using npflib;`

2. Add this line to your code `Flood npf = new Flood();`

3. Enjoy :)
## What commands?
`npf.Udp(ipaddress, port, message)` - floods the targeted ip address with 100000 packets using UDP. You need more instances of the command or to edit the code to get more packets. Make sure to include the target port and the message in the command as well.

`npf.Tcp(ipaddress, port, message)` - floods the targeted ip address with 100000 packets using TCP. Make sure to include the target port and the message in the command as well.
