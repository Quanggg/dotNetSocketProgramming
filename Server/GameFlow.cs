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

        public int currentQuestion;

        public List<string> setOfPlayers;

        public List<string> setOfEliminatedPlayers;

        public List<string> setOfSkippedPlayers;

        public Dictionary<string, Socket> SocketAndPlayerMapping;

        public List<string> setOfQuestions;

        public string GameInformation;

        public Database db = new Database();

        public GameFlow()
        {
            currentPlayer = -1;
            isStart = false;
            setOfPlayers = new List<string>();
            SocketAndPlayerMapping = new Dictionary<string, Socket>();
            db.readAllQuizzes();
        }

        public bool checkExistingPlayerName(string newPlayerName)
        {
            return setOfPlayers.Contains(newPlayerName);
        }

        public void updateGameInformation()
        {
            GameInformation = String.Format("{0}~{1}", getNumberOfPlayers(), setOfQuestions.Count);
        }

        public bool addNewPlayer(string newPlayer, Socket playerSocket)
        {
            if (checkExistingPlayerName(newPlayer))
            {
                return false;
            }
            setOfPlayers.Add(newPlayer);
            SocketAndPlayerMapping.Add(newPlayer, playerSocket);

            return true;
        }
        public int getNumberOfPlayers() { return setOfPlayers.Count; }

        public void Start()
        {
            isStart = true;
            setOfQuestions = db.getRandomQuizzes(this.getNumberOfPlayers() * 3);
            Random rnd = new Random();
            setOfPlayers = setOfPlayers.OrderBy(x => rnd.Next()).ToList();
            currentPlayer = 0;
            currentQuestion = 0;
            setOfEliminatedPlayers = new List<string>();
            setOfSkippedPlayers = new List<string>();
        }

        public string getCurrentQuestion()
        {
            return setOfQuestions[currentQuestion];
        }

        public string getCurrentPlayer()
        {
            return setOfPlayers[currentPlayer];
        }

        public void nextQuestion()
        {
            currentQuestion++;
        }

        public void nextPlayer()
        {
            while (!setOfEliminatedPlayers.Contains(setOfPlayers[currentPlayer]))
            {
                if (currentPlayer == setOfPlayers.Count- 1)
                {
                    currentPlayer = 0;
                }
                else
                {
                    currentPlayer++;
                }
            }
        }

        public void eliminatePlayer(string player)
        {
            setOfEliminatedPlayers.Add(player);
        }

        public void playerSkip(string player)
        {
            setOfSkippedPlayers.Add(player);
        }

        public bool isWin()
        {
            if (setOfEliminatedPlayers.Count == setOfPlayers.Count - 1)
            {
                return true;
            }
            if (currentQuestion == setOfQuestions.Count - 1) 
            { 
                return true; 
            }
            return false;
        }
    }
}
