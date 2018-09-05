using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace JSONAPP
{
    class Server
    {
        static void Main(string[] args)
        {
            IPAddress iPAddress = IPAddress.Parse("127.0.0.1");

            int port = 8888;
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, port);
            socket.Bind(iPEndPoint);
            socket.Listen(10);
            Console.WriteLine("Waiting for connections");
            Socket handler =  socket.Accept();
            Console.WriteLine("Connected");
            handler.Connect(iPEndPoint);


        }
    }
}
