using System;
using System.Net.Sockets;
using System.Collections.Generic;

namespace Server
{
    class Program
    {
        static Server server;
        static Database db;
        static void Main(string[] args)
        {
            Console.Title = "Game server";
            server = new Server(3939);
            server.SetupServer();
            db = new Database();
            db.getAllQuizzes();
            Console.ReadLine();
            server.CloseAllSockets();

        }
    }
}
