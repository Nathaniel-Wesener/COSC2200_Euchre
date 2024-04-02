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
            menuStripForm1.Size = new Size(1091, 28);
            menuStripForm1.TabIndex = 0;
            // 
            // toolStripMenuItemControl
            // 
            toolStripMenuItemControl.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemNewGame, toolStripMenuItemExit });
            toolStripMenuItemControl.Name = "toolStripMenuItemControl";
            toolStripMenuItemControl.Size = new Size(78, 24);
            toolStripMenuItemControl.Text = "Controls";
            // 
            // toolStripMenuItemNewGame
            // 
            toolStripMenuItemNewGame.Name = "toolStripMenuItemNewGame";
            toolStripMenuItemNewGame.Size = new Size(165, 26);
            toolStripMenuItemNewGame.Text = "New Game";
            // 
            // toolStripMenuItemExit
            // 
            toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            toolStripMenuItemExit.Size = new Size(165, 26);
            toolStripMenuItemExit.Text = "Exit";
            toolStripMenuItemExit.Click += buttonExit_Click;
            // 
            // toolStripMenuItemInfo
            // 
            toolStripMenuItemInfo.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemAbout, toolStripMenuItemHowToPlay, toolStripMenuItemCredits });
            toolStripMenuItemInfo.Name = "toolStripMenuItemInfo";
            toolStripMenuItemInfo.Size = new Size(49, 24);
            toolStripMenuItemInfo.Text = "Info";
            // 
            // toolStripMenuItemAbout
            // 
            toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            toolStripMenuItemAbout.Size = new Size(174, 26);
            toolStripMenuItemAbout.Text = "About";
            toolStripMenuItemAbout.Click += toolStripMenuItemAbout_Click;
            // 
            // toolStripMenuItemHowToPlay
            // 
            toolStripMenuItemHowToPlay.Name = "toolStripMenuItemHowToPlay";
            toolStripMenuItemHowToPlay.Size = new Size(174, 26);
            toolStripMenuItemHowToPlay.Text = "How To Play";
            toolStripMenuItemHowToPlay.Click += toolStripMenuItemHowToPlay_Click;
            // 
            // toolStripMenuItemCredits
            // 
            toolStripMenuItemCredits.Name = "toolStripMenuItemCredits";
            toolStripMenuItemCredits.Size = new Size(174, 26);
            toolStripMenuItemCredits.Text = "Credits";
            toolStripMenuItemCredits.Click += toolStripMenuItemCredits_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = SystemColors.ControlLight;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Location = new Point(20, 52);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 31);
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
            groupBoxControls.Location = new Point(12, 31);
            groupBoxControls.Name = "groupBoxControls";
            groupBoxControls.Size = new Size(135, 92);
            groupBoxControls.TabIndex = 1;
            groupBoxControls.TabStop = false;
            groupBoxControls.Text = "Game Controls";
            // 
            // buttonNewGame
            // 
            buttonNewGame.BackColor = SystemColors.ControlLight;
            buttonNewGame.FlatStyle = FlatStyle.Flat;
            buttonNewGame.Location = new Point(20, 19);
            buttonNewGame.Name = "buttonNewGame";
            buttonNewGame.Size = new Size(94, 27);
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
            groupBoxStats.Location = new Point(12, 120);
            groupBoxStats.Name = "groupBoxStats";
            groupBoxStats.Size = new Size(135, 139);
            groupBoxStats.TabIndex = 2;
            groupBoxStats.TabStop = false;
            groupBoxStats.Text = "Overall Stats";
            // 
            // labelAIWinCounterDisplay
            // 
            labelAIWinCounterDisplay.AutoSize = true;
            labelAIWinCounterDisplay.Location = new Point(57, 107);
            labelAIWinCounterDisplay.Name = "labelAIWinCounterDisplay";
            labelAIWinCounterDisplay.Size = new Size(17, 20);
            labelAIWinCounterDisplay.TabIndex = 3;
            labelAIWinCounterDisplay.Text = "0";
            toolTip1.SetToolTip(labelAIWinCounterDisplay, "Show how many times A.I / CPU opponent wont so far");
            // 
            // labelAIWinCounter
            // 
            labelAIWinCounter.AutoSize = true;
            labelAIWinCounter.Location = new Point(20, 87);
            labelAIWinCounter.Name = "labelAIWinCounter";
            labelAIWinCounter.Size = new Size(101, 20);
            labelAIWinCounter.TabIndex = 2;
            labelAIWinCounter.Text = "AI game wins:";
            // 
            // labelPlayerWinCounterDisplay
            // 
            labelPlayerWinCounterDisplay.AutoSize = true;
            labelPlayerWinCounterDisplay.Location = new Point(57, 55);
            labelPlayerWinCounterDisplay.Name = "labelPlayerWinCounterDisplay";
            labelPlayerWinCounterDisplay.Size = new Size(17, 20);
            labelPlayerWinCounterDisplay.TabIndex = 1;
            labelPlayerWinCounterDisplay.Text = "0";
            toolTip1.SetToolTip(labelPlayerWinCounterDisplay, "Shows how many times you won so far");
            // 
            // labelPlayerWinCounter
            // 
            labelPlayerWinCounter.AutoSize = true;
            labelPlayerWinCounter.Location = new Point(6, 35);
            labelPlayerWinCounter.Name = "labelPlayerWinCounter";
            labelPlayerWinCounter.Size = new Size(127, 20);
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
            groupBoxCurrentStats.Location = new Point(154, 31);
            groupBoxCurrentStats.Name = "groupBoxCurrentStats";
            groupBoxCurrentStats.Size = new Size(926, 83);
            groupBoxCurrentStats.TabIndex = 3;
            groupBoxCurrentStats.TabStop = false;
            groupBoxCurrentStats.Text = "Current Game Stats";
            // 
            // btnShuffle
            // 
            btnShuffle.BackColor = SystemColors.ControlLight;
            btnShuffle.FlatStyle = FlatStyle.Flat;
            btnShuffle.Location = new Point(807, 26);
            btnShuffle.Name = "btnShuffle";
            btnShuffle.Size = new Size(94, 27);
            btnShuffle.TabIndex = 10;
            btnShuffle.Text = "&Shuffle";
            toolTip1.SetToolTip(btnShuffle, "Press Shuffle to randomly order the current deck ");
            btnShuffle.UseVisualStyleBackColor = false;
            // 
            // labelCurrentTrumpDisplay
            // 
            labelCurrentTrumpDisplay.AutoSize = true;
            labelCurrentTrumpDisplay.Location = new Point(524, 52);
            labelCurrentTrumpDisplay.Name = "labelCurrentTrumpDisplay";
            labelCurrentTrumpDisplay.Size = new Size(0, 20);
            labelCurrentTrumpDisplay.TabIndex = 9;
            // 
            // labelCurrentTrump
            // 
            labelCurrentTrump.AutoSize = true;
            labelCurrentTrump.Location = new Point(199, 52);
            labelCurrentTrump.Name = "labelCurrentTrump";
            labelCurrentTrump.Size = new Size(106, 20);
            labelCurrentTrump.TabIndex = 8;
            labelCurrentTrump.Text = "Current Trump:";
            toolTip1.SetToolTip(labelCurrentTrump, "Trump for the game in progress");
            // 
            // labelCurrentMakerDisplay
            // 
            labelCurrentMakerDisplay.AutoSize = true;
            labelCurrentMakerDisplay.Location = new Point(524, 23);
            labelCurrentMakerDisplay.Name = "labelCurrentMakerDisplay";
            labelCurrentMakerDisplay.Size = new Size(0, 20);
            labelCurrentMakerDisplay.TabIndex = 7;
            // 
            // labelCurrentMaker
            // 
            labelCurrentMaker.AutoSize = true;
            labelCurrentMaker.Location = new Point(199, 23);
            labelCurrentMaker.Name = "labelCurrentMaker";
            labelCurrentMaker.Size = new Size(105, 20);
            labelCurrentMaker.TabIndex = 6;
            labelCurrentMaker.Text = "Current Maker:";
            toolTip1.SetToolTip(labelCurrentMaker, "Current trump maker ");
            // 
            // labelAITrickCounterDisplay
            // 
            labelAITrickCounterDisplay.AutoSize = true;
            labelAITrickCounterDisplay.Location = new Point(108, 52);
            labelAITrickCounterDisplay.Name = "labelAITrickCounterDisplay";
            labelAITrickCounterDisplay.Size = new Size(17, 20);
            labelAITrickCounterDisplay.TabIndex = 3;
            labelAITrickCounterDisplay.Text = "0";
            // 
            // labelPlayerTrickCounterDisplay
            // 
            labelPlayerTrickCounterDisplay.AutoSize = true;
            labelPlayerTrickCounterDisplay.Location = new Point(108, 23);
            labelPlayerTrickCounterDisplay.Name = "labelPlayerTrickCounterDisplay";
            labelPlayerTrickCounterDisplay.Size = new Size(17, 20);
            labelPlayerTrickCounterDisplay.TabIndex = 2;
            labelPlayerTrickCounterDisplay.Text = "0";
            // 
            // labelAITrickCounter
            // 
            labelAITrickCounter.AutoSize = true;
            labelAITrickCounter.Location = new Point(6, 52);
            labelAITrickCounter.Name = "labelAITrickCounter";
            labelAITrickCounter.Size = new Size(70, 20);
            labelAITrickCounter.TabIndex = 1;
            labelAITrickCounter.Text = "AI Tricks: ";
            toolTip1.SetToolTip(labelAITrickCounter, "A.I. opponent tricks counter ");
            // 
            // labelPlayerTricksCounter
            // 
            labelPlayerTricksCounter.AutoSize = true;
            labelPlayerTricksCounter.Location = new Point(6, 23);
            labelPlayerTricksCounter.Name = "labelPlayerTricksCounter";
            labelPlayerTricksCounter.Size = new Size(96, 20);
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
            groupBoxPlayerControls.Location = new Point(12, 265);
            groupBoxPlayerControls.Name = "groupBoxPlayerControls";
            groupBoxPlayerControls.Size = new Size(1068, 200);
            groupBoxPlayerControls.TabIndex = 4;
            groupBoxPlayerControls.TabStop = false;
            groupBoxPlayerControls.Text = "Your Controls";
            // 
            // buttonPlayCard
            // 
            buttonPlayCard.BackColor = SystemColors.ControlLight;
            buttonPlayCard.FlatStyle = FlatStyle.Flat;
            buttonPlayCard.Location = new Point(512, 98);
            buttonPlayCard.Name = "buttonPlayCard";
            buttonPlayCard.Size = new Size(94, 29);
            buttonPlayCard.TabIndex = 7;
            buttonPlayCard.Text = "&Play Card";
            buttonPlayCard.UseVisualStyleBackColor = false;
            // 
            // labelPlayCard
            // 
            labelPlayCard.AutoSize = true;
            labelPlayCard.Location = new Point(512, 25);
            labelPlayCard.Name = "labelPlayCard";
            labelPlayCard.Size = new Size(138, 20);
            labelPlayCard.TabIndex = 6;
            labelPlayCard.Text = "Select Card To Play:";
            // 
            // comboBoxPlayCard
            // 
            comboBoxPlayCard.FormattingEnabled = true;
            comboBoxPlayCard.Location = new Point(512, 48);
            comboBoxPlayCard.Name = "comboBoxPlayCard";
            comboBoxPlayCard.Size = new Size(151, 28);
            comboBoxPlayCard.TabIndex = 5;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(185, 23);
            label.Name = "label";
            label.Size = new Size(81, 20);
            label.TabIndex = 4;
            label.Text = "&Your Hand:";
            // 
            // listBoxYourHand
            // 
            listBoxYourHand.FormattingEnabled = true;
            listBoxYourHand.ItemHeight = 20;
            listBoxYourHand.Location = new Point(185, 48);
            listBoxYourHand.Name = "listBoxYourHand";
            listBoxYourHand.Size = new Size(211, 124);
            listBoxYourHand.TabIndex = 3;
            toolTip1.SetToolTip(listBoxYourHand, "Your current hand ");
            // 
            // buttonAcceptTrump
            // 
            buttonAcceptTrump.BackColor = SystemColors.ControlLight;
            buttonAcceptTrump.FlatStyle = FlatStyle.Flat;
            buttonAcceptTrump.Location = new Point(6, 35);
            buttonAcceptTrump.Name = "buttonAcceptTrump";
            buttonAcceptTrump.Size = new Size(135, 29);
            buttonAcceptTrump.TabIndex = 2;
            buttonAcceptTrump.Text = "&Accept Trump";
            buttonAcceptTrump.UseVisualStyleBackColor = false;
            // 
            // labelTrumpSelect
            // 
            labelTrumpSelect.AutoSize = true;
            labelTrumpSelect.Location = new Point(6, 107);
            labelTrumpSelect.Name = "labelTrumpSelect";
            labelTrumpSelect.Size = new Size(95, 20);
            labelTrumpSelect.TabIndex = 0;
            labelTrumpSelect.Text = "Select Trump";
            // 
            // comboBoxSelectTrump
            // 
            comboBoxSelectTrump.FormattingEnabled = true;
            comboBoxSelectTrump.Location = new Point(6, 143);
            comboBoxSelectTrump.Name = "comboBoxSelectTrump";
            comboBoxSelectTrump.Size = new Size(151, 28);
            comboBoxSelectTrump.TabIndex = 1;
            // 
            // groupBoxAI
            // 
            groupBoxAI.Location = new Point(688, 120);
            groupBoxAI.Name = "groupBoxAI";
            groupBoxAI.Size = new Size(391, 139);
            groupBoxAI.TabIndex = 5;
            groupBoxAI.TabStop = false;
            groupBoxAI.Text = "AI Opponent";
            toolTip1.SetToolTip(groupBoxAI, "A.I. player");
            // 
            // groupBoxPlayFieldPlayer
            // 
            groupBoxPlayFieldPlayer.BackColor = SystemColors.ControlLight;
            groupBoxPlayFieldPlayer.FlatStyle = FlatStyle.Flat;
            groupBoxPlayFieldPlayer.Location = new Point(153, 120);
            groupBoxPlayFieldPlayer.Name = "groupBoxPlayFieldPlayer";
            groupBoxPlayFieldPlayer.Size = new Size(529, 139);
            groupBoxPlayFieldPlayer.TabIndex = 6;
            groupBoxPlayFieldPlayer.TabStop = false;
            groupBoxPlayFieldPlayer.Text = "The Players's Table";
            // 
            // EuchreCardGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 470);
            Controls.Add(groupBoxPlayFieldPlayer);
            Controls.Add(groupBoxAI);
            Controls.Add(groupBoxPlayerControls);
            Controls.Add(groupBoxCurrentStats);
            Controls.Add(groupBoxStats);
            Controls.Add(groupBoxControls);
            Controls.Add(menuStripForm1);
            MainMenuStrip = menuStripForm1;
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