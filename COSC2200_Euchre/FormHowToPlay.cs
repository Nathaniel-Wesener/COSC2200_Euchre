using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSC2200_Euchre
{
    public partial class FormHowToPlay : Form
    {
        // TODO: Decide how the game will be played then describe how to play in this form - NW
        public FormHowToPlay()
        {
            InitializeComponent();
        }

        private void buttonHowToPlayExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
