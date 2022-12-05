using System;
using System.Collections.Generic;
using System.Text;

namespace Server
{
    class GameFlow
    {
        public int numberOfPlayers
        {
            get; set;
        }
        public int turn
        {
            get; set;
        }

        public bool isStart
        {
            get; set;   
        }

        public string currentQuestion;

        public string currentAnswer;

        public GameFlow()
        {
            numberOfPlayers = 0;
            turn = 0;
            isStart = false;
        }
    }
}
