namespace COSC2200_Euchre
{
    public partial class EuchreCardGame : Form
    {
        private string _SelectedTrump = string.Empty;
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
            var game = new EuchreGame(5);

            game.Show(this);
        }

        private void comboBoxSelectTrump_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SelectedTrump = comboBoxSelectTrump.Text;
        }

        private void buttonAcceptTrump_Click(object sender, EventArgs e)
        {
            labelCurrentTrumpDisplay.Text = _SelectedTrump;
        }

        private void groupBoxCurrentStats_Enter(object sender, EventArgs e)
        {

        }
    }
}