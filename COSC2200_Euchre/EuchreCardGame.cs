namespace COSC2200_Euchre
{
    public partial class EuchreCardGame : Form
    {
        public string _SelectedTrump = string.Empty;
        public EuchreGame currentGame;


        public EuchreCardGame()
        {
            InitializeComponent();
        }

        public void setDefaults()
        {
            comboBoxSelectTrump.Enabled = false;
            comboBoxPlayCard.Enabled = false;
            buttonAcceptTrump.Enabled = false;
            buttonPlayCard.Enabled = false;
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
                if (comboBoxSelectTrump.SelectedIndex != -1)
                {
                    currentGame.playerChoseTrumpWild(comboBoxSelectTrump.SelectedIndex);
                    comboBoxSelectTrump.Enabled = false;
                    buttonAcceptTrump.Enabled = false;
                    buttonDeclineTrump.Enabled = false;
                }
                else
                {
                    MessageBox.Show("ERROR: Select a trump.");
                }
                
            }
            else
            {
                currentGame.AcceptTrump();
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
            comboBoxPlayCard.Text = "";
            buttonPlayCard.Enabled = true;
            comboBoxPlayCard.Items.Clear();
            comboBoxPlayCard.SelectedIndex = -1;
            foreach (Card card in validCards)
            {
                comboBoxPlayCard.Items.Add(card.toString());
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
            if (comboBoxPlayCard.SelectedIndex == -1)
            {
                MessageBox.Show("ERROR: pick a card to play!");
            }
            else
            {
                if (currentGame.aiPlayer.isMaker)
                {
                    currentGame.playerResponded(comboBoxPlayCard.SelectedIndex);
                }
                else
                {
                    currentGame.playerPlayed(comboBoxPlayCard.SelectedIndex);
                }
            }

        }
        public void displayAIPlayedCard(Card card)
        {
            textBoxAIPlayedCard.Text = card.toString();
        }
        public void displayHumanPlayedCard(Card card)
        {
            textBoxCardHumanPlayed.Text = card.toString();
        }

        private void EuchreCardGame_Load(object sender, EventArgs e)
        {
            setDefaults();
        }

        public void clearTextBoxes()
        {
            textBoxAIPlayedCard.Text = "";
            textBoxCardHumanPlayed.Text = "";
        }

        public void trickCounterLabelAI(int i)
        {
            labelAITrickCounterDisplay.Text = i.ToString();
        }

        public void trickCounterLabelHuman(int i)
        {
            labelPlayerTrickCounterDisplay.Text = i.ToString();
        }

        private void buttonDeclineTrump_Click(object sender, EventArgs e)
        {
            buttonDeclineTrump.Enabled = false;
            buttonAcceptTrump.Enabled = false;
            if (currentGame.trumpCard != null && currentGame.humanPlayer.isChoosing)
            {
                currentGame.aiChoice(currentGame.trumpCard);
            }
        }
    }
}