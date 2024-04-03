namespace COSC2200_Euchre
{
    partial class EuchreCardGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStripForm1 = new MenuStrip();
            toolStripMenuItemControl = new ToolStripMenuItem();
            toolStripMenuItemNewGame = new ToolStripMenuItem();
            toolStripMenuItemExit = new ToolStripMenuItem();
            toolStripMenuItemInfo = new ToolStripMenuItem();
            toolStripMenuItemAbout = new ToolStripMenuItem();
            toolStripMenuItemHowToPlay = new ToolStripMenuItem();
            toolStripMenuItemCredits = new ToolStripMenuItem();
            buttonExit = new Button();
            groupBoxControls = new GroupBox();
            buttonNewGame = new Button();
            groupBoxStats = new GroupBox();
            labelAIWinCounterDisplay = new Label();
            labelAIWinCounter = new Label();
            labelPlayerWinCounterDisplay = new Label();
            labelPlayerWinCounter = new Label();
            groupBoxCurrentStats = new GroupBox();
            btnShuffle = new Button();
            labelCurrentTrumpDisplay = new Label();
            labelCurrentTrump = new Label();
            labelCurrentMakerDisplay = new Label();
            labelCurrentMaker = new Label();
            labelAITrickCounterDisplay = new Label();
            labelPlayerTrickCounterDisplay = new Label();
            labelAITrickCounter = new Label();
            labelPlayerTricksCounter = new Label();
            groupBoxPlayerControls = new GroupBox();
            buttonPlayCard = new Button();
            labelPlayCard = new Label();
            comboBoxPlayCard = new ComboBox();
            label = new Label();
            listBoxYourHand = new ListBox();
            buttonAcceptTrump = new Button();
            labelTrumpSelect = new Label();
            comboBoxSelectTrump = new ComboBox();
            groupBoxAI = new GroupBox();
            groupBoxPlayFieldPlayer = new GroupBox();
            toolTip1 = new ToolTip(components);
            menuStripForm1.SuspendLayout();
            groupBoxControls.SuspendLayout();
            groupBoxStats.SuspendLayout();
            groupBoxCurrentStats.SuspendLayout();
            groupBoxPlayerControls.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripForm1
            // 
            menuStripForm1.ImageScalingSize = new Size(20, 20);
            menuStripForm1.Items.AddRange(new ToolStripItem[] { toolStripMenuItemControl, toolStripMenuItemInfo });
            menuStripForm1.Location = new Point(0, 0);
            menuStripForm1.Name = "menuStripForm1";
            menuStripForm1.Padding = new Padding(15, 5, 0, 5);
            menuStripForm1.Size = new Size(2728, 62);
            menuStripForm1.TabIndex = 0;
            // 
            // toolStripMenuItemControl
            // 
            toolStripMenuItemControl.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemNewGame, toolStripMenuItemExit });
            toolStripMenuItemControl.Name = "toolStripMenuItemControl";
            toolStripMenuItemControl.Size = new Size(181, 52);
            toolStripMenuItemControl.Text = "Controls";
            // 
            // toolStripMenuItemNewGame
            // 
            toolStripMenuItemNewGame.Name = "toolStripMenuItemNewGame";
            toolStripMenuItemNewGame.Size = new Size(393, 66);
            toolStripMenuItemNewGame.Text = "New Game";
            // 
            // toolStripMenuItemExit
            // 
            toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            toolStripMenuItemExit.Size = new Size(393, 66);
            toolStripMenuItemExit.Text = "Exit";
            toolStripMenuItemExit.Click += buttonExit_Click;
            // 
            // toolStripMenuItemInfo
            // 
            toolStripMenuItemInfo.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemAbout, toolStripMenuItemHowToPlay, toolStripMenuItemCredits });
            toolStripMenuItemInfo.Name = "toolStripMenuItemInfo";
            toolStripMenuItemInfo.Size = new Size(110, 52);
            toolStripMenuItemInfo.Text = "Info";
            // 
            // toolStripMenuItemAbout
            // 
            toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            toolStripMenuItemAbout.Size = new Size(411, 66);
            toolStripMenuItemAbout.Text = "About";
            toolStripMenuItemAbout.Click += toolStripMenuItemAbout_Click;
            // 
            // toolStripMenuItemHowToPlay
            // 
            toolStripMenuItemHowToPlay.Name = "toolStripMenuItemHowToPlay";
            toolStripMenuItemHowToPlay.Size = new Size(411, 66);
            toolStripMenuItemHowToPlay.Text = "How To Play";
            toolStripMenuItemHowToPlay.Click += toolStripMenuItemHowToPlay_Click;
            // 
            // toolStripMenuItemCredits
            // 
            toolStripMenuItemCredits.Name = "toolStripMenuItemCredits";
            toolStripMenuItemCredits.Size = new Size(411, 66);
            toolStripMenuItemCredits.Text = "Credits";
            toolStripMenuItemCredits.Click += toolStripMenuItemCredits_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = SystemColors.ControlLight;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Location = new Point(50, 125);
            buttonExit.Margin = new Padding(8, 7, 8, 7);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(235, 74);
            buttonExit.TabIndex = 1;
            buttonExit.Text = "E&xit";
            toolTip1.SetToolTip(buttonExit, "Press exit to exit and finish the game");
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // groupBoxControls
            // 
            groupBoxControls.Controls.Add(buttonNewGame);
            groupBoxControls.Controls.Add(buttonExit);
            groupBoxControls.Location = new Point(30, 74);
            groupBoxControls.Margin = new Padding(8, 7, 8, 7);
            groupBoxControls.Name = "groupBoxControls";
            groupBoxControls.Padding = new Padding(8, 7, 8, 7);
            groupBoxControls.Size = new Size(338, 221);
            groupBoxControls.TabIndex = 1;
            groupBoxControls.TabStop = false;
            groupBoxControls.Text = "Game Controls";
            // 
            // buttonNewGame
            // 
            buttonNewGame.BackColor = SystemColors.ControlLight;
            buttonNewGame.FlatStyle = FlatStyle.Flat;
            buttonNewGame.Location = new Point(50, 46);
            buttonNewGame.Margin = new Padding(8, 7, 8, 7);
            buttonNewGame.Name = "buttonNewGame";
            buttonNewGame.Size = new Size(235, 65);
            buttonNewGame.TabIndex = 0;
            buttonNewGame.Text = "&New Game ";
            toolTip1.SetToolTip(buttonNewGame, "Press New game to start the game");
            buttonNewGame.UseVisualStyleBackColor = false;
            buttonNewGame.Click += buttonNewGame_Click;
            // 
            // groupBoxStats
            // 
            groupBoxStats.Controls.Add(labelAIWinCounterDisplay);
            groupBoxStats.Controls.Add(labelAIWinCounter);
            groupBoxStats.Controls.Add(labelPlayerWinCounterDisplay);
            groupBoxStats.Controls.Add(labelPlayerWinCounter);
            groupBoxStats.Location = new Point(30, 288);
            groupBoxStats.Margin = new Padding(8, 7, 8, 7);
            groupBoxStats.Name = "groupBoxStats";
            groupBoxStats.Padding = new Padding(8, 7, 8, 7);
            groupBoxStats.Size = new Size(338, 334);
            groupBoxStats.TabIndex = 2;
            groupBoxStats.TabStop = false;
            groupBoxStats.Text = "Overall Stats";
            // 
            // labelAIWinCounterDisplay
            // 
            labelAIWinCounterDisplay.AutoSize = true;
            labelAIWinCounterDisplay.Location = new Point(142, 257);
            labelAIWinCounterDisplay.Margin = new Padding(8, 0, 8, 0);
            labelAIWinCounterDisplay.Name = "labelAIWinCounterDisplay";
            labelAIWinCounterDisplay.Size = new Size(39, 48);
            labelAIWinCounterDisplay.TabIndex = 3;
            labelAIWinCounterDisplay.Text = "0";
            toolTip1.SetToolTip(labelAIWinCounterDisplay, "Show how many times A.I / CPU opponent wont so far");
            // 
            // labelAIWinCounter
            // 
            labelAIWinCounter.AutoSize = true;
            labelAIWinCounter.Location = new Point(50, 209);
            labelAIWinCounter.Margin = new Padding(8, 0, 8, 0);
            labelAIWinCounter.Name = "labelAIWinCounter";
            labelAIWinCounter.Size = new Size(240, 48);
            labelAIWinCounter.TabIndex = 2;
            labelAIWinCounter.Text = "AI game wins:";
            // 
            // labelPlayerWinCounterDisplay
            // 
            labelPlayerWinCounterDisplay.AutoSize = true;
            labelPlayerWinCounterDisplay.Location = new Point(142, 132);
            labelPlayerWinCounterDisplay.Margin = new Padding(8, 0, 8, 0);
            labelPlayerWinCounterDisplay.Name = "labelPlayerWinCounterDisplay";
            labelPlayerWinCounterDisplay.Size = new Size(39, 48);
            labelPlayerWinCounterDisplay.TabIndex = 1;
            labelPlayerWinCounterDisplay.Text = "0";
            toolTip1.SetToolTip(labelPlayerWinCounterDisplay, "Shows how many times you won so far");
            // 
            // labelPlayerWinCounter
            // 
            labelPlayerWinCounter.AutoSize = true;
            labelPlayerWinCounter.Location = new Point(15, 84);
            labelPlayerWinCounter.Margin = new Padding(8, 0, 8, 0);
            labelPlayerWinCounter.Name = "labelPlayerWinCounter";
            labelPlayerWinCounter.Size = new Size(303, 48);
            labelPlayerWinCounter.TabIndex = 0;
            labelPlayerWinCounter.Text = "Player game wins:";
            // 
            // groupBoxCurrentStats
            // 
            groupBoxCurrentStats.Controls.Add(btnShuffle);
            groupBoxCurrentStats.Controls.Add(labelCurrentTrumpDisplay);
            groupBoxCurrentStats.Controls.Add(labelCurrentTrump);
            groupBoxCurrentStats.Controls.Add(labelCurrentMakerDisplay);
            groupBoxCurrentStats.Controls.Add(labelCurrentMaker);
            groupBoxCurrentStats.Controls.Add(labelAITrickCounterDisplay);
            groupBoxCurrentStats.Controls.Add(labelPlayerTrickCounterDisplay);
            groupBoxCurrentStats.Controls.Add(labelAITrickCounter);
            groupBoxCurrentStats.Controls.Add(labelPlayerTricksCounter);
            groupBoxCurrentStats.Location = new Point(385, 74);
            groupBoxCurrentStats.Margin = new Padding(8, 7, 8, 7);
            groupBoxCurrentStats.Name = "groupBoxCurrentStats";
            groupBoxCurrentStats.Padding = new Padding(8, 7, 8, 7);
            groupBoxCurrentStats.Size = new Size(2315, 199);
            groupBoxCurrentStats.TabIndex = 3;
            groupBoxCurrentStats.TabStop = false;
            groupBoxCurrentStats.Text = "Current Game Stats";
            // 
            // btnShuffle
            // 
            btnShuffle.BackColor = SystemColors.ControlLight;
            btnShuffle.FlatStyle = FlatStyle.Flat;
            btnShuffle.Location = new Point(2018, 62);
            btnShuffle.Margin = new Padding(8, 7, 8, 7);
            btnShuffle.Name = "btnShuffle";
            btnShuffle.Size = new Size(235, 65);
            btnShuffle.TabIndex = 10;
            btnShuffle.Text = "&Shuffle";
            toolTip1.SetToolTip(btnShuffle, "Press Shuffle to randomly order the current deck ");
            btnShuffle.UseVisualStyleBackColor = false;
            // 
            // labelCurrentTrumpDisplay
            // 
            labelCurrentTrumpDisplay.AutoSize = true;
            labelCurrentTrumpDisplay.Location = new Point(1310, 125);
            labelCurrentTrumpDisplay.Margin = new Padding(8, 0, 8, 0);
            labelCurrentTrumpDisplay.Name = "labelCurrentTrumpDisplay";
            labelCurrentTrumpDisplay.Size = new Size(0, 48);
            labelCurrentTrumpDisplay.TabIndex = 9;
            // 
            // labelCurrentTrump
            // 
            labelCurrentTrump.AutoSize = true;
            labelCurrentTrump.Location = new Point(498, 125);
            labelCurrentTrump.Margin = new Padding(8, 0, 8, 0);
            labelCurrentTrump.Name = "labelCurrentTrump";
            labelCurrentTrump.Size = new Size(258, 48);
            labelCurrentTrump.TabIndex = 8;
            labelCurrentTrump.Text = "Current Trump:";
            toolTip1.SetToolTip(labelCurrentTrump, "Trump for the game in progress");
            // 
            // labelCurrentMakerDisplay
            // 
            labelCurrentMakerDisplay.AutoSize = true;
            labelCurrentMakerDisplay.Location = new Point(1310, 55);
            labelCurrentMakerDisplay.Margin = new Padding(8, 0, 8, 0);
            labelCurrentMakerDisplay.Name = "labelCurrentMakerDisplay";
            labelCurrentMakerDisplay.Size = new Size(0, 48);
            labelCurrentMakerDisplay.TabIndex = 7;
            // 
            // labelCurrentMaker
            // 
            labelCurrentMaker.AutoSize = true;
            labelCurrentMaker.Location = new Point(498, 55);
            labelCurrentMaker.Margin = new Padding(8, 0, 8, 0);
            labelCurrentMaker.Name = "labelCurrentMaker";
            labelCurrentMaker.Size = new Size(257, 48);
            labelCurrentMaker.TabIndex = 6;
            labelCurrentMaker.Text = "Current Maker:";
            toolTip1.SetToolTip(labelCurrentMaker, "Current trump maker ");
            // 
            // labelAITrickCounterDisplay
            // 
            labelAITrickCounterDisplay.AutoSize = true;
            labelAITrickCounterDisplay.Location = new Point(270, 125);
            labelAITrickCounterDisplay.Margin = new Padding(8, 0, 8, 0);
            labelAITrickCounterDisplay.Name = "labelAITrickCounterDisplay";
            labelAITrickCounterDisplay.Size = new Size(39, 48);
            labelAITrickCounterDisplay.TabIndex = 3;
            labelAITrickCounterDisplay.Text = "0";
            // 
            // labelPlayerTrickCounterDisplay
            // 
            labelPlayerTrickCounterDisplay.AutoSize = true;
            labelPlayerTrickCounterDisplay.Location = new Point(270, 55);
            labelPlayerTrickCounterDisplay.Margin = new Padding(8, 0, 8, 0);
            labelPlayerTrickCounterDisplay.Name = "labelPlayerTrickCounterDisplay";
            labelPlayerTrickCounterDisplay.Size = new Size(39, 48);
            labelPlayerTrickCounterDisplay.TabIndex = 2;
            labelPlayerTrickCounterDisplay.Text = "0";
            // 
            // labelAITrickCounter
            // 
            labelAITrickCounter.AutoSize = true;
            labelAITrickCounter.Location = new Point(15, 125);
            labelAITrickCounter.Margin = new Padding(8, 0, 8, 0);
            labelAITrickCounter.Name = "labelAITrickCounter";
            labelAITrickCounter.Size = new Size(169, 48);
            labelAITrickCounter.TabIndex = 1;
            labelAITrickCounter.Text = "AI Tricks: ";
            toolTip1.SetToolTip(labelAITrickCounter, "A.I. opponent tricks counter ");
            // 
            // labelPlayerTricksCounter
            // 
            labelPlayerTricksCounter.AutoSize = true;
            labelPlayerTricksCounter.Location = new Point(15, 55);
            labelPlayerTricksCounter.Margin = new Padding(8, 0, 8, 0);
            labelPlayerTricksCounter.Name = "labelPlayerTricksCounter";
            labelPlayerTricksCounter.Size = new Size(232, 48);
            labelPlayerTricksCounter.TabIndex = 0;
            labelPlayerTricksCounter.Text = "Player Tricks: ";
            toolTip1.SetToolTip(labelPlayerTricksCounter, "Your tricks counter");
            // 
            // groupBoxPlayerControls
            // 
            groupBoxPlayerControls.Controls.Add(buttonPlayCard);
            groupBoxPlayerControls.Controls.Add(labelPlayCard);
            groupBoxPlayerControls.Controls.Add(comboBoxPlayCard);
            groupBoxPlayerControls.Controls.Add(label);
            groupBoxPlayerControls.Controls.Add(listBoxYourHand);
            groupBoxPlayerControls.Controls.Add(buttonAcceptTrump);
            groupBoxPlayerControls.Controls.Add(labelTrumpSelect);
            groupBoxPlayerControls.Controls.Add(comboBoxSelectTrump);
            groupBoxPlayerControls.Location = new Point(30, 636);
            groupBoxPlayerControls.Margin = new Padding(8, 7, 8, 7);
            groupBoxPlayerControls.Name = "groupBoxPlayerControls";
            groupBoxPlayerControls.Padding = new Padding(8, 7, 8, 7);
            groupBoxPlayerControls.Size = new Size(2670, 480);
            groupBoxPlayerControls.TabIndex = 4;
            groupBoxPlayerControls.TabStop = false;
            groupBoxPlayerControls.Text = "Your Controls";
            groupBoxPlayerControls.Enter += groupBoxPlayerControls_Enter;
            // 
            // buttonPlayCard
            // 
            buttonPlayCard.BackColor = SystemColors.ControlLight;
            buttonPlayCard.FlatStyle = FlatStyle.Flat;
            buttonPlayCard.Location = new Point(1280, 235);
            buttonPlayCard.Margin = new Padding(8, 7, 8, 7);
            buttonPlayCard.Name = "buttonPlayCard";
            buttonPlayCard.Size = new Size(235, 70);
            buttonPlayCard.TabIndex = 7;
            buttonPlayCard.Text = "&Play Card";
            buttonPlayCard.UseVisualStyleBackColor = false;
            // 
            // labelPlayCard
            // 
            labelPlayCard.AutoSize = true;
            labelPlayCard.Location = new Point(1280, 60);
            labelPlayCard.Margin = new Padding(8, 0, 8, 0);
            labelPlayCard.Name = "labelPlayCard";
            labelPlayCard.Size = new Size(327, 48);
            labelPlayCard.TabIndex = 6;
            labelPlayCard.Text = "Select Card To Play:";
            // 
            // comboBoxPlayCard
            // 
            comboBoxPlayCard.FormattingEnabled = true;
            comboBoxPlayCard.Location = new Point(1280, 115);
            comboBoxPlayCard.Margin = new Padding(8, 7, 8, 7);
            comboBoxPlayCard.Name = "comboBoxPlayCard";
            comboBoxPlayCard.Size = new Size(372, 56);
            comboBoxPlayCard.TabIndex = 5;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(462, 55);
            label.Margin = new Padding(8, 0, 8, 0);
            label.Name = "label";
            label.Size = new Size(194, 48);
            label.TabIndex = 4;
            label.Text = "&Your Hand:";
            // 
            // listBoxYourHand
            // 
            listBoxYourHand.FormattingEnabled = true;
            listBoxYourHand.ItemHeight = 48;
            listBoxYourHand.Location = new Point(462, 115);
            listBoxYourHand.Margin = new Padding(8, 7, 8, 7);
            listBoxYourHand.Name = "listBoxYourHand";
            listBoxYourHand.Size = new Size(648, 340);
            listBoxYourHand.TabIndex = 3;
            toolTip1.SetToolTip(listBoxYourHand, "Your current hand ");
            // 
            // buttonAcceptTrump
            // 
            buttonAcceptTrump.BackColor = SystemColors.ControlLight;
            buttonAcceptTrump.FlatStyle = FlatStyle.Flat;
            buttonAcceptTrump.Location = new Point(15, 84);
            buttonAcceptTrump.Margin = new Padding(8, 7, 8, 7);
            buttonAcceptTrump.Name = "buttonAcceptTrump";
            buttonAcceptTrump.Size = new Size(338, 70);
            buttonAcceptTrump.TabIndex = 2;
            buttonAcceptTrump.Text = "&Accept Trump";
            buttonAcceptTrump.UseVisualStyleBackColor = false;
            buttonAcceptTrump.Click += buttonAcceptTrump_Click;
            // 
            // labelTrumpSelect
            // 
            labelTrumpSelect.AutoSize = true;
            labelTrumpSelect.Location = new Point(15, 257);
            labelTrumpSelect.Margin = new Padding(8, 0, 8, 0);
            labelTrumpSelect.Name = "labelTrumpSelect";
            labelTrumpSelect.Size = new Size(226, 48);
            labelTrumpSelect.TabIndex = 0;
            labelTrumpSelect.Text = "Select Trump";
            // 
            // comboBoxSelectTrump
            // 
            comboBoxSelectTrump.FormattingEnabled = true;
            comboBoxSelectTrump.Items.AddRange(new object[] { "Hearts", "Diamonds", "Spades", "Clubs" });
            comboBoxSelectTrump.Location = new Point(15, 343);
            comboBoxSelectTrump.Margin = new Padding(8, 7, 8, 7);
            comboBoxSelectTrump.Name = "comboBoxSelectTrump";
            comboBoxSelectTrump.Size = new Size(372, 56);
            comboBoxSelectTrump.TabIndex = 1;
            comboBoxSelectTrump.SelectedIndexChanged += comboBoxSelectTrump_SelectedIndexChanged;
            // 
            // groupBoxAI
            // 
            groupBoxAI.Location = new Point(1720, 288);
            groupBoxAI.Margin = new Padding(8, 7, 8, 7);
            groupBoxAI.Name = "groupBoxAI";
            groupBoxAI.Padding = new Padding(8, 7, 8, 7);
            groupBoxAI.Size = new Size(978, 334);
            groupBoxAI.TabIndex = 5;
            groupBoxAI.TabStop = false;
            groupBoxAI.Text = "AI Opponent";
            toolTip1.SetToolTip(groupBoxAI, "A.I. player");
            groupBoxAI.Enter += groupBoxAI_Enter;
            // 
            // groupBoxPlayFieldPlayer
            // 
            groupBoxPlayFieldPlayer.BackColor = SystemColors.ControlLight;
            groupBoxPlayFieldPlayer.FlatStyle = FlatStyle.Flat;
            groupBoxPlayFieldPlayer.Location = new Point(382, 288);
            groupBoxPlayFieldPlayer.Margin = new Padding(8, 7, 8, 7);
            groupBoxPlayFieldPlayer.Name = "groupBoxPlayFieldPlayer";
            groupBoxPlayFieldPlayer.Padding = new Padding(8, 7, 8, 7);
            groupBoxPlayFieldPlayer.Size = new Size(1322, 334);
            groupBoxPlayFieldPlayer.TabIndex = 6;
            groupBoxPlayFieldPlayer.TabStop = false;
            groupBoxPlayFieldPlayer.Text = "The Players's Table";
            // 
            // EuchreCardGame
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2728, 1128);
            Controls.Add(groupBoxPlayFieldPlayer);
            Controls.Add(groupBoxAI);
            Controls.Add(groupBoxPlayerControls);
            Controls.Add(groupBoxCurrentStats);
            Controls.Add(groupBoxStats);
            Controls.Add(groupBoxControls);
            Controls.Add(menuStripForm1);
            MainMenuStrip = menuStripForm1;
            Margin = new Padding(8, 7, 8, 7);
            Name = "EuchreCardGame";
            Text = "Super Awesome Euchre Game!";
            menuStripForm1.ResumeLayout(false);
            menuStripForm1.PerformLayout();
            groupBoxControls.ResumeLayout(false);
            groupBoxStats.ResumeLayout(false);
            groupBoxStats.PerformLayout();
            groupBoxCurrentStats.ResumeLayout(false);
            groupBoxCurrentStats.PerformLayout();
            groupBoxPlayerControls.ResumeLayout(false);
            groupBoxPlayerControls.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripForm1;
        private ToolStripMenuItem toolStripMenuItemControl;
        private ToolStripMenuItem toolStripMenuItemNewGame;
        private ToolStripMenuItem toolStripMenuItemInfo;
        private ToolStripMenuItem toolStripMenuItemAbout;
        private ToolStripMenuItem toolStripMenuItemHowToPlay;
        private ToolStripMenuItem toolStripMenuItemCredits;
        private ToolStripMenuItem toolStripMenuItemExit;
        private Button buttonExit;
        private GroupBox groupBoxControls;
        private Button buttonNewGame;
        private GroupBox groupBoxStats;
        private Label labelAIWinCounter;
        private Label labelPlayerWinCounterDisplay;
        private Label labelPlayerWinCounter;
        private Label labelAIWinCounterDisplay;
        private GroupBox groupBoxCurrentStats;
        private Label labelPlayerTricksCounter;
        private Label labelAITrickCounterDisplay;
        private Label labelPlayerTrickCounterDisplay;
        private Label labelAITrickCounter;
        private Label labelCurrentMaker;
        private Label labelCurrentTrumpDisplay;
        private Label labelCurrentTrump;
        private Label labelCurrentMakerDisplay;
        private GroupBox groupBoxAI;
        private GroupBox groupBoxPlayFieldPlayer;
        private Label labelTrumpSelect;
        private ComboBox comboBoxSelectTrump;
        private ListBox listBoxYourHand;
        private Label labelPlayCard;
        private Label label;
        private ToolTip toolTip1;
        private Button btnShuffle;
        public Button buttonAcceptTrump;
        public GroupBox groupBoxPlayerControls;
        public Button buttonPlayCard;
        public ComboBox comboBoxPlayCard;
    }
}