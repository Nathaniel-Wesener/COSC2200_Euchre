using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COSC2200_Euchre
{
    internal class Player
    {

        public int tricksWon;
        public int points;
        public List<Card>? cardsInHand;
        public bool isAI;
        public bool isMaker;
        public bool hasPlayed;
        
        public Player(bool isAI)
        {
            tricksWon = 0;
            points = 0;
            cardsInHand = null;
            this.isAI = isAI;
        }

        public void addPoints()
        {
            if (isMaker && tricksWon < 5)
            {
                points++;
            }
            else if (isMaker)
            {
                points += 2;
            }
            else if (tricksWon < 5)
            {
                points += 2;
            }
            else
            {
                points += 4;
            }
        }

    }
}
