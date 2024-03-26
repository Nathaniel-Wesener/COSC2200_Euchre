using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COSC2200_Euchre
{
    internal class EuchreGame
    {
        public Player humanPlayer;
        public Player aiPlayer;
        public int pointsToWin;
        public int currentTrump;
        public Card? trumpCard;
        public List<Card>? winningcards;
        public Deck deck;


        public void GenerateList(int suiteTrump, int suitePlayed)
        {
            winningcards = new List<Card>();
            winningcards.Clear();
            Card card = deck.CardMaker(11, suiteTrump);
            winningcards.Add(card);

            if (suiteTrump > 1)
            {
                card = deck.CardMaker(11, suiteTrump + 2);
            }
            else
            {
                card = deck.CardMaker(11, suiteTrump - 2);
            }
            winningcards.Add(card);

            for (int i = 14; i < 9; i--)
            {
                if (i != 11)
                {
                    card = deck.CardMaker(i, suiteTrump);
                    winningcards.Add(card);
                }
            }
            if (suitePlayed != suiteTrump)
            {
                

                for (int y = 14; y < 9; y--)
                {
                    card = deck.CardMaker(y, suitePlayed);
                    winningcards.Add(card);
                }
            }

        }



    }
}
