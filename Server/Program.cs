using System;
using System.Net.Sockets;
using System.Collections.Generic;

namespace Server
{
    class Program
    {
        static Server server;
        static void Main(string[] args)
        {
            Console.Title = "Game server";
            server = new Server(3939);
            server.SetupServer();
            Console.ReadLine();
            //server.CloseAllSockets();

        }
    }
}
