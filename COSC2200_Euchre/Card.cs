using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COSC2200_Euchre
{
    internal class Card
    {
        public int cardSuiteNum;
        public int cardRankNum;
        public string cardSuiteStr;
        public string cardRankStr;
        public bool isRed;

        
        /// <summary>
        /// Constructer for a card object. - NW
        /// </summary>
        /// <param name="cardSuiteNum">The card suite number.</param>
        /// <param name="cardRankNum">The card rank number.</param>
        /// <param name="cardSuiteStr">The card suite name.</param>
        /// <param name="cardRankStr">the card rank name.</param>
        public Card(int cardSuiteNum, int cardRankNum, string cardSuiteStr, string cardRankStr, bool isRed)
        {
            this.cardSuiteNum = cardSuiteNum;
            this.cardRankNum = cardRankNum;
            this.cardSuiteStr = cardSuiteStr;
            this.cardRankStr = cardRankStr;
            this.isRed = isRed;
        }

        /// <summary>
        /// Function that returns a card as a string value.
        /// </summary>
        /// <returns> A string describing the card.</returns>
        public string toString()
        {
            string cardString;
            cardString = this.cardRankStr + " of " + this.cardSuiteStr;
            return cardString;
        }
    }
}
