using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COSC2200_Euchre
{
    internal class Utilities
    {
        // TODO: make a function comment. - NW
        public void ErrorMessage(string message)
        {
            MessageBox.Show("ERROR: " + message);
        }
        // TODO: make a function comment. - NW
        public List<Card> PriorityList(Card firstCard, int suiteTrump)
        {
            // TODO: Figure out how to design this function then design it. -NW
            // The idea behind this function is to create a list of cards for each trick
            // based of the first card played.
            Deck deck = new Deck();
            List<Card> cards = new List<Card>();

            if (firstCard.cardSuiteNum == suiteTrump) 
            {
                
            }
            else
            {
                
            }

            return cards;
        }
    }
}
