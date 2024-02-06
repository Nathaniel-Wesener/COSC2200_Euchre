using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COSC2200_Euchre
{
    internal class Card
    {
        int cardSuiteNum;
        int cardRankNum;
        string cardSuiteStr;
        string cardRankStr;
        
        public Card(int cardSuitNum, int cardRankNum, string cardSuiteStr, string cardRankStr) 
        {
            this.cardSuiteNum = cardSuitNum;
            this.cardRankNum = cardRankNum;
            this.cardSuiteStr = cardSuiteStr;
            this.cardRankStr = cardRankStr;
        }
    }
}
