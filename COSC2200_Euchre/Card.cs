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
        public  string cardSuiteStr;
        public string cardRankStr;
        public bool isRed;

        // TODO: finish comment - NW
        /// <summary>
        /// Constructer for a card object. - NW
        /// </summary>
        /// <param name="cardSuiteNum"></param>
        /// <param name="cardRankNum"></param>
        /// <param name="cardSuiteStr"></param>
        /// <param name="cardRankStr"></param>
        public Card(int cardSuiteNum, int cardRankNum, string cardSuiteStr, string cardRankStr, bool isRed)
        {
            this.cardSuiteNum = cardSuiteNum;
            this.cardRankNum = cardRankNum;
            this.cardSuiteStr = cardSuiteStr;
            this.cardRankStr = cardRankStr;
            this.isRed = isRed;
        }

        public string toString()
        {
            string cardString;
            cardString = this.cardRankStr + " of " + this.cardSuiteStr;
            return cardString;
        }
    }
}
