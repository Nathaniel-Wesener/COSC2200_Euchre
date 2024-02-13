namespace COSC2200_Euchre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // TODO: Make a lot of function comments. - NW

        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            Form FormAbout = new FormAbout();
            FormAbout.ShowDialog();
        }

        private void toolStripMenuItemHowToPlay_Click(object sender, EventArgs e)
        {
            Form FormHowToPlay = new FormHowToPlay();
            FormHowToPlay.ShowDialog();
        }

        private void toolStripMenuItemCredits_Click(object sender, EventArgs e)
        {
            Form FormCredits = new FormCredits();
            FormCredits.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}