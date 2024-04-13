using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COSC2200_Euchre
{
    public class Deck
    {
        
        public const int NumCards = 24;
        public const int NumSuites = 4;
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
                cards[i]                              = CardMaker(i + 9, 0);
                cards[i + NumCards/NumSuites]         = CardMaker(i + 9, 1);
                cards[i + 2 * (NumCards / NumSuites)] = CardMaker(i + 9, 2);
                cards[i + 3 * (NumCards / NumSuites)] = CardMaker(i + 9, 3);
            }
        }



        /// <summary>
        /// Function that creates a new card with just integer paramaters. - NW
        /// </summary>
        /// <param name="rank"> The integer rank of the card.</param>
        /// <param name="suite"> The integer suite of the card.</param>
        /// <returns> A new card.</returns>
        public Card CardMaker(int rank, int suite)
        {
            string strSuite;
            string strRank;
            bool red;

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
                red = true;
            }
            else if (suite == 1)
            {
                strSuite = SuiteClubs;
                red = false;
            }
            else if (suite == 2)
            {
                strSuite = SuiteDiamonds;
                red = true;
            }
            else if (suite == 3)
            {
                strSuite = SuiteSpades;
                red = false;
            }
            else
            {
                red = true;
                strSuite = "error";
            }

            return new Card(suite, rank, strSuite, strRank, red);

        }

        //// Shuffle method to randomly reorder the cards in the deck
        public void Shuffle()
        {
            Random rng = new Random();
            int n = cards.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }
    }
}
