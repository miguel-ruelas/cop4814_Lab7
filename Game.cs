using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This is a test comment added for Step 7 of Lab 7.
//Different branch test comment step 10 lab 7.

namespace GameLibrary
{
    public class Game
    {
        public Game()
        {

        }

        public Game(String tm1, int tm1Score, String tm2, int tm2Score)
        {
            Team1 = tm1;
            Team1Score = tm1Score;
            Team2 = tm2;
            Team2Score = tm2Score;

        }
        public string Team1 { get; set; }

        public int Team1Score { get; set; }

        public string Team2 { get; set; }

        public int Team2Score { get; set; }

        public override string ToString()
        {
            string txt = Team1 + " (" + Team1Score + ") - " + Team2 + " (" + Team2Score + ") ";
            return txt;
        }
    }
}
