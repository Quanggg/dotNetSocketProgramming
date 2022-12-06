using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    class GameFlow
    {
        public bool isStart
        {
            get; set;   
        }

        public int currentPlayer;

        public string currentQuestion;

        public string currentAnswer;

        private List<string> setOfPlayers;

        public Dictionary<string, Socket> SocketAndPlayerMapping;

        private Dictionary<string, string> setOfQuestions;

        public Dictionary<string, string> GameInformation;

        public GameFlow()
        {
            currentPlayer = -1;
            isStart = false;
            setOfPlayers = new List<string>();
            SocketAndPlayerMapping = new Dictionary<string, Socket>();
            GameInformation = new Dictionary<string, string>();
            setOfQuestions = seedRandomQuestionFromDB();
        }

        private Dictionary<string, string> seedRandomQuestionFromDB() { return new Dictionary<string, string>(); }

        public bool checkExistingPlayerName(string newPlayerName)
        {
            return setOfPlayers.Contains(newPlayerName);
        }

        public void updateGameInformation(string key, string value, bool addNew=false)
        {
            if (!GameInformation.ContainsKey(key)) 
            { 
                if (addNew)
                {
                    GameInformation.Add(key, value);
                }
                return;
            };
            GameInformation[key] = value;
        }

        public Dictionary<string, string> getGameInformation()
        {
            // Update to current game state
            updateGameInformation("Number of players", setOfPlayers.Count.ToString());
            updateGameInformation("Status", isStart ? "Started": "Not start");
            updateGameInformation("Current player", currentPlayer.ToString());
            updateGameInformation("Number of question", setOfQuestions.Count.ToString());

            return GameInformation;
        }

        public bool addNewPlayer(string newPlayer, Socket playerSocket)
        {
            if (checkExistingPlayerName(newPlayer))
            {
                return false;
            }
            setOfPlayers.Add(newPlayer);
            SocketAndPlayerMapping.Add(newPlayer, playerSocket);
            setOfPlayers = setOfPlayers.OrderBy(a => Guid.NewGuid()).ToList(); // Shuffle the list
            return true;
        }

        public int getNumberOfPlayers() { return setOfPlayers.Count; }
    }
}
