namespace COSC2200_Euchre
{
    public partial class EuchreCardGame : Form
    {
        public EuchreCardGame()
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

        private void buttonNewGame_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSelectTrump_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAcceptTrump_Click(object sender, EventArgs e)
        {
            EuchreGame.AcceptTrump();

        }

        private void groupBoxPlayerControls_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxAI_Enter(object sender, EventArgs e)
        {

        }
    }
}