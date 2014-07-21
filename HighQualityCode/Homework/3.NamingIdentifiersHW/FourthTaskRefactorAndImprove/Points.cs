using System;
using System.Linq;

namespace FourthTaskRefactorAndImprove
{
    class Points
    {
        string playerName;
        int playerPoints;

        public string PlayerName
        {
            get { return this.playerName; }
            set { this.playerName = value; }
        }

        public int PlayerPoints
        {
            get { return this.playerPoints; }
            set { this.playerPoints = value; }
        }

        public Points()
        {
        }

        public Points(string playerGameName, int playerGamePoints)
        {
            this.playerName = playerGameName;
            this.playerPoints = playerGamePoints;
        }
    }
}
