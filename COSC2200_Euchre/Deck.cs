using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COSC2200_Euchre
{
    internal class Deck
    {
        // TODO: make sure number of cards in a deck is right. - NW
        const int NumCards = 32;
        const int NumSuites = 4;
        const string SuiteHearts = "Hearts";
        const string SuiteClubs = "Clubs";
        const string SuiteDiamonds = "Diamonds";
        const string SuiteSpades = "Spades";
        const string RankAce = "Ace";
        const string RankKing = "King";
        const string RankQueen = "Queen";
        const string RankJack = "Jack";


        public Card[] cards = new Card[NumCards];
       
        /// <summary>
        /// Constructer that automatically makes a new deck. - NW
        /// </summary>
        public Deck() 
        {
            for (int i = 0; i < (NumCards / NumSuites); i++)
            {
                cards[i]                              = CardMaker(i + (NumCards / NumSuites - 1), 0);
                cards[i + NumCards/NumSuites]         = CardMaker(i + (NumCards / NumSuites - 1), 1);
                cards[i + 2 * (NumCards / NumSuites)] = CardMaker(i + (NumCards / NumSuites - 1), 2);
                cards[i + 3 * (NumCards / NumSuites)] = CardMaker(i + (NumCards / NumSuites - 1), 3);
            }
        }

        /// <summary>
        /// Function that creates a new card with just integer paramaters. - NW
        /// </summary>
        /// <param name="rank"> The integer rank of the card.</param>
        /// <param name="suite"> The integer suite of the card.</param>
        /// <returns> A new card.</returns>
        private Card CardMaker(int rank, int suite)
        {
            string strSuite;
            string strRank;

            if (rank == 14)
            {
                strRank = RankAce;
            }
            else if (rank == 13)
            {
                strRank = RankKing;
            }
            else if (rank == 12)
            {
                strRank = RankQueen;
            }
            else if (rank == 11)
            {
                strRank = RankJack;
            }
            else
            {
                strRank = rank.ToString();
            }

            if (suite == 0)
            {
                strSuite = SuiteHearts;
            }
            else if (suite == 1)
            {
                strSuite = SuiteClubs;
            }
            else if (suite == 2)
            {
                strSuite = SuiteDiamonds;
            }
            else
            {
                strSuite = SuiteSpades;
            }

            return new Card(suite, rank, strSuite, strRank);

        }
    }
}
