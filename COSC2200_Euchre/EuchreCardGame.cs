namespace COSC2200_Euchre
{
    public partial class EuchreCardGame : Form
    {
        private string _SelectedTrump = string.Empty;
        public EuchreGame currentGame;


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
            var game = new EuchreGame(5, this);
            currentGame = game;
            //game.Show(this);
            game.gameStage();
        }

        private void comboBoxSelectTrump_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SelectedTrump = comboBoxSelectTrump.Text;
        }

        private void buttonAcceptTrump_Click(object sender, EventArgs e)
        {
            if (comboBoxSelectTrump.Enabled)
            {

            }
            else
            {

            }
        }

        private void groupBoxCurrentStats_Enter(object sender, EventArgs e)
        {

        }

        public void enableDisableButtonAcceptTrump(bool enDis)
        {
            buttonAcceptTrump.Enabled = enDis;
        }
        public void addNewItemsToCardsToPlay(List<Card> validCards)
        {
            comboBoxPlayCard.Enabled = true;
            buttonPlayCard.Enabled = true;
            comboBoxPlayCard.Items.Clear();
            foreach (Card card in validCards)
            {
                comboBoxPlayCard.Items.Add(card);
            }
        }
        public void displayTrumpCanditate(Card card)
        {
            textBoxTrumpCanditate.Text = card.toString();
        }
        public void displayCardsInHand(List<Card> cards)
        {
            List<String> list = new List<String>();
            foreach (Card card in cards)
            {
                list.Add(card.toString());
            }
            listBoxYourHand.DataSource = list;
        }
        public void changeCurrentMaker(string maker)
        {
            labelCurrentMakerDisplay.Text = maker;
        }
        public void changeCurrentTrump(string suite)
        {
            labelCurrentTrumpDisplay.Text = suite;
        }

        private void buttonPlayCard_Click(object sender, EventArgs e)
        {
            if (currentGame.aiPlayer.isMaker)
            {
                currentGame.playerResponded(comboBoxPlayCard.SelectedIndex);
            }
            else
            {
                currentGame.playerPlayed();
            }
        }
        public void displayAIPlayedCard(Card card)
        {
            textBoxAIPlayedCard.Text = card.toString();
        }
    }
}