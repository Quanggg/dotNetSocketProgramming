using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Media;

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

            ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
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
            ServerSocket.Bind(new IPEndPoint(IPAddress.Any,Port));
            ServerSocket.Listen(10);
            ServerSocket.BeginAccept(AcceptCallback, null);
            Console.WriteLine("Finish setting up server...");
        }

        private void AcceptCallback(IAsyncResult AR)
        {
            Socket current;
            Console.WriteLine("AcceptCallback");
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
            Console.WriteLine("Text: " + text);
            if (text.ToLower().StartsWith("register~")) {
                string newPlayerName = text.Split('~')[1]; // Get the player name from response
                if (!GameState.addNewPlayer(newPlayerName, current))
                {
                    Console.WriteLine("newPlayerName: " + newPlayerName);
                    byte[] data = Encoding.ASCII.GetBytes("register_fail");
                    current.Send(data);
                } else
                {
                    byte[] data4 = Encoding.ASCII.GetBytes("register_success");
                    current.Send(data4);    
                    if (GameState.getNumberOfPlayers() == 2)
                    {
                        GameState.Start();
                        Console.WriteLine("Game started!");

                        GameState.updateGameInformation();

                        // Announce to all players
                        for (int i = 0; i < GameState.setOfPlayers.Count;i++)
                        {
                            string playerName = GameState.setOfPlayers[i];
                            byte[] data1 = Encoding.ASCII.GetBytes("game~" + GameState.GameInformation + String.Format("~{0}", i));
                            Console.WriteLine(playerName + GameState.GameInformation + String.Format("~{0}", i));
                            GameState.SocketAndPlayerMapping[playerName].Send(data1);
                        }

                        // Send question to the first user
                        byte[] data2 = Encoding.ASCII.GetBytes(GameState.getCurrentQuestion());
                        Console.WriteLine(GameState.getCurrentPlayer() + " " + GameState.getCurrentQuestion());
                        GameState.SocketAndPlayerMapping[GameState.getCurrentPlayer()].Send(data2);
                    }
                }
            } 
            else if (text.ToLower() == "no_answer") // Timeout 
            {
                // Update the game flow: remove this player out of the game, next player, , next question
                GameState.eliminatePlayer(GameState.getCurrentPlayer());
                GameState.nextQuestion();
                GameState.nextPlayer();
                if (GameState.isWin())
                {
                    foreach(string player in GameState.setOfPlayers)
                    {
                        byte[] data1 = Encoding.ASCII.GetBytes("winner~" + GameState.currentPlayer);
                        GameState.SocketAndPlayerMapping[player].Send(data1);
                    }
                }
                else
                {
                    byte[] data2 = Encoding.ASCII.GetBytes(GameState.getCurrentQuestion());
                    GameState.SocketAndPlayerMapping[GameState.getCurrentPlayer()].Send(data2);
                }
            }
            else if (text.ToLower() == "skip_turn")
            {
                // Update the game flow: next player, same question 
                // Send the question to the next player
                if (!GameState.setOfSkippedPlayers.Contains(GameState.getCurrentPlayer()))
                {
                    GameState.playerSkip(GameState.getCurrentPlayer());
                    GameState.nextPlayer();
                    if (GameState.isWin())
                    {
                        foreach (string player in GameState.setOfPlayers)
                        {
                            byte[] data1 = Encoding.ASCII.GetBytes("winner~" + GameState.currentPlayer);
                            GameState.SocketAndPlayerMapping[player].Send(data1);
                        }
                    }
                    else
                    {
                        byte[] data = Encoding.ASCII.GetBytes(GameState.getCurrentQuestion());
                        GameState.SocketAndPlayerMapping[GameState.getCurrentPlayer()].Send(data);
                    }
                }
                else {
                    byte[] data5 = Encoding.ASCII.GetBytes("skip_invalid");
                    GameState.SocketAndPlayerMapping[GameState.getCurrentPlayer()].Send(data5);
                }

                
            }
            else if (text.ToLower().StartsWith("my_answer~"))// User answer the question
            {
                string answer = text.ToLower().Split("~")[1];
                string correct_answer = GameState.getCurrentQuestion().ToLower().Split("~")[1];
                // Case 1: User answer the correct answer
                // Update the game flow: remove this player out of the game, next player, next question
                if (answer == correct_answer) {
                    GameState.nextQuestion();
                    GameState.nextPlayer();
                }
                // Case 2: User answer the wrong answer
                // Update the game flow: remove this player out of the game, next player, , next question
                else
                {
                    GameState.eliminatePlayer(GameState.getCurrentPlayer());
                    GameState.nextPlayer();
                    GameState.nextQuestion();
                }

                if (GameState.isWin())
                {
                    foreach (string player in GameState.setOfPlayers)
                    {
                        byte[] data1 = Encoding.ASCII.GetBytes("winner~" + GameState.currentPlayer);
                        GameState.SocketAndPlayerMapping[player].Send(data1);
                    }
                }
                else
                {
                    byte[] data2 = Encoding.ASCII.GetBytes(GameState.getCurrentQuestion());
                    GameState.SocketAndPlayerMapping[GameState.getCurrentPlayer()].Send(data2);
                }
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
