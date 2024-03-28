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
        public List<Card> cardsInHand;
        public bool isAI;
        public bool isMaker;
        public bool isChoosing;
        public Card playedCard;
        
        public Player(bool isAI)
        {
            tricksWon = 0;
            points = 0;

            this.isAI = isAI;
            cardsInHand = new List<Card>();
        }

        public void addPoints()
        {
            if (isChoosing && tricksWon < 5)
            {
                points++;
            }
            else if (isChoosing)
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
