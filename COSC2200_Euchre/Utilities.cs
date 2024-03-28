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
        


        public void WinMessage() 
        {
            MessageBox.Show("Congratulations You Won!!!!");
        }

    }
}
