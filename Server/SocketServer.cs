using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace Server
{
    class Server
    {
        private Socket ServerSocket;
        private List<Socket> ClientSockets;
        private const int BUFFER_SIZE = 2048;
        private byte[] buffer;
        GameFlow GameState;
        public int Port
        {
            get;
            private set;
        }
        public bool isListening
        {
            get;
            private set;
        }

        public IPAddress ServerIP
        {
            get;
            private set;
        }

        public Server(int _port)
        {
            Port = _port;
            buffer = new byte[BUFFER_SIZE];
            GameState = new GameFlow();

            IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
            ServerIP = hostEntry.AddressList[0];

            ServerSocket = new Socket(ServerIP.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            ClientSockets = new List<Socket>();

        }
        public void SetupServer()
        {
            if (isListening)
            {
                Console.WriteLine("Server is listening on port {0}", Port);
                return;
            }
            Console.WriteLine("Setting up server...");
            isListening = true;
            ServerSocket.Bind(new IPEndPoint(ServerIP,Port));
            ServerSocket.Listen(10);
            ServerSocket.BeginAccept(AcceptCallback, null);
            Console.WriteLine("Finish setting up server...");
        }

        private void AcceptCallback(IAsyncResult AR)
        {
            Socket current;
      
            try
            {
                current = ServerSocket.EndAccept(AR);
                if (GameState.isStart) // New player cannot connect if the game is started
                {
                    byte[] data = Encoding.ASCII.GetBytes("The game is started, you cannot connect to the server");
                    current.Send(data);
                    current.Shutdown(SocketShutdown.Both);
                    current.Close();
                    return;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Accept failed: {0}", e.Message);
                return;
            }
            current.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveCallback, current);
            Console.WriteLine("Client {0} connected, waiting for request...", current.RemoteEndPoint);
            ServerSocket.BeginAccept(AcceptCallback, null);
        }

        private void ReceiveCallback (IAsyncResult AR)
        {
            Socket current = (Socket)AR.AsyncState;
            int received;

            try
            {
                received = current.EndReceive(AR);
            }
            catch (SocketException)
            {
                Console.WriteLine("Client forcefully disconnected");
                current.Close();
                ClientSockets.Remove(current);
                return;
            }

            byte[] receiveBuffer = new byte[received];
            Array.Copy(buffer, receiveBuffer, received);
            string text = Encoding.ASCII.GetString(receiveBuffer);
            Console.WriteLine("Received Text: " + text);

            if (text.ToLower().StartsWith("register_new_user:")) {
                string newPlayerName = text.Split(' ')[1]; // Get the player name from response
                if (GameState.addNewPlayer(newPlayerName, current))
                {
                    byte[] data = Encoding.ASCII.GetBytes("Failed");
                    current.Send(data);
                } else
                {
                    byte[] data = Encoding.ASCII.GetBytes("Successfully");
                    current.Send(data);

                    if (GameState.getNumberOfPlayers() == 1)
                    {
                        byte[] data2 = Encoding.ASCII.GetBytes("You are host");
                        current.Send(data);
                    }
                }
            } else if (text.ToLower() == "start_game")
            {
                // byte[] data = Encoding.ASCII.
            }
            else if (text.ToLower() == "no_answer") // Timeout 
            {
                // Update the game flow: remove this player out of the game, next player, , next question

            }
            else if (text.ToLower() == "skipped_the_turn")
            {
                // Update the game flow: next player, same question 
                // Send the question to the next player
            }
            else if (text.ToLower().StartsWith("my_answer_is:"))// User answer the question
            {
                // Case 1: User answer the correct answer
                // Update the game flow: remove this player out of the game, next player, next question

                // Case 2: User answer the wrong answer
                // Update the game flow: remove this player out of the game, next player, , next question
            }

            current.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveCallback, current);
        }

        public void CloseAllSockets()
        {
            Console.WriteLine("Close and Shutdown all the sockets...");
            foreach(Socket s in ClientSockets)
            {
                s.Shutdown(SocketShutdown.Both);
                s.Close();
            }
            ServerSocket.Close();
        }
    }

}
