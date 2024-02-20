namespace COSC2200_Euchre
{
    partial class Form1
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
            labelCurrentTrumpDisplay = new Label();
            labelCurrentTrump = new Label();
            labelCurrentMakerDisplay = new Label();
            labelCurrentMaker = new Label();
            labelAITrickCounterDisplay = new Label();
            labelPlayerTrickCounterDisplay = new Label();
            labelAITrickCounter = new Label();
            labelPlayerTricksCounter = new Label();
            groupBoxPlayerControls = new GroupBox();
            groupBoxOpponent = new GroupBox();
            groupBoxPlayField = new GroupBox();
            menuStripForm1.SuspendLayout();
            groupBoxControls.SuspendLayout();
            groupBoxStats.SuspendLayout();
            groupBoxCurrentStats.SuspendLayout();
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
            buttonExit.Location = new Point(20, 52);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 25);
            buttonExit.TabIndex = 1;
            buttonExit.Text = "E&xit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // groupBoxControls
            // 
            groupBoxControls.Controls.Add(buttonNewGame);
            groupBoxControls.Controls.Add(buttonExit);
            groupBoxControls.Location = new Point(12, 31);
            groupBoxControls.Name = "groupBoxControls";
            groupBoxControls.Size = new Size(135, 83);
            groupBoxControls.TabIndex = 1;
            groupBoxControls.TabStop = false;
            groupBoxControls.Text = "Game Controls";
            // 
            // buttonNewGame
            // 
            buttonNewGame.Location = new Point(20, 19);
            buttonNewGame.Name = "buttonNewGame";
            buttonNewGame.Size = new Size(94, 27);
            buttonNewGame.TabIndex = 0;
            buttonNewGame.Text = "&New Game ";
            buttonNewGame.UseVisualStyleBackColor = true;
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
            groupBoxCurrentStats.Controls.Add(labelCurrentTrumpDisplay);
            groupBoxCurrentStats.Controls.Add(labelCurrentTrump);
            groupBoxCurrentStats.Controls.Add(labelCurrentMakerDisplay);
            groupBoxCurrentStats.Controls.Add(labelCurrentMaker);
            groupBoxCurrentStats.Controls.Add(labelAITrickCounterDisplay);
            groupBoxCurrentStats.Controls.Add(labelPlayerTrickCounterDisplay);
            groupBoxCurrentStats.Controls.Add(labelAITrickCounter);
            groupBoxCurrentStats.Controls.Add(labelPlayerTricksCounter);
            groupBoxCurrentStats.Location = new Point(153, 31);
            groupBoxCurrentStats.Name = "groupBoxCurrentStats";
            groupBoxCurrentStats.Size = new Size(926, 83);
            groupBoxCurrentStats.TabIndex = 3;
            groupBoxCurrentStats.TabStop = false;
            groupBoxCurrentStats.Text = "Current Game Stats";
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
            labelCurrentTrump.Location = new Point(413, 52);
            labelCurrentTrump.Name = "labelCurrentTrump";
            labelCurrentTrump.Size = new Size(106, 20);
            labelCurrentTrump.TabIndex = 8;
            labelCurrentTrump.Text = "Current Trump:";
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
            labelCurrentMaker.Location = new Point(413, 23);
            labelCurrentMaker.Name = "labelCurrentMaker";
            labelCurrentMaker.Size = new Size(105, 20);
            labelCurrentMaker.TabIndex = 6;
            labelCurrentMaker.Text = "Current Maker:";
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
            // 
            // labelPlayerTricksCounter
            // 
            labelPlayerTricksCounter.AutoSize = true;
            labelPlayerTricksCounter.Location = new Point(6, 23);
            labelPlayerTricksCounter.Name = "labelPlayerTricksCounter";
            labelPlayerTricksCounter.Size = new Size(96, 20);
            labelPlayerTricksCounter.TabIndex = 0;
            labelPlayerTricksCounter.Text = "Player Tricks: ";
            // 
            // groupBoxPlayerControls
            // 
            groupBoxPlayerControls.Location = new Point(12, 265);
            groupBoxPlayerControls.Name = "groupBoxPlayerControls";
            groupBoxPlayerControls.Size = new Size(1067, 200);
            groupBoxPlayerControls.TabIndex = 4;
            groupBoxPlayerControls.TabStop = false;
            groupBoxPlayerControls.Text = "Your Controls";
            // 
            // groupBoxOpponent
            // 
            groupBoxOpponent.Location = new Point(688, 120);
            groupBoxOpponent.Name = "groupBoxOpponent";
            groupBoxOpponent.Size = new Size(391, 139);
            groupBoxOpponent.TabIndex = 5;
            groupBoxOpponent.TabStop = false;
            groupBoxOpponent.Text = "CPU Opponent";
            // 
            // groupBoxPlayField
            // 
            groupBoxPlayField.Location = new Point(153, 120);
            groupBoxPlayField.Name = "groupBoxPlayField";
            groupBoxPlayField.Size = new Size(529, 139);
            groupBoxPlayField.TabIndex = 6;
            groupBoxPlayField.TabStop = false;
            groupBoxPlayField.Text = "The Table";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 470);
            Controls.Add(groupBoxPlayField);
            Controls.Add(groupBoxOpponent);
            Controls.Add(groupBoxPlayerControls);
            Controls.Add(groupBoxCurrentStats);
            Controls.Add(groupBoxStats);
            Controls.Add(groupBoxControls);
            Controls.Add(menuStripForm1);
            MainMenuStrip = menuStripForm1;
            Name = "Form1";
            Text = "Super Awesome Euchre Game!";
            menuStripForm1.ResumeLayout(false);
            menuStripForm1.PerformLayout();
            groupBoxControls.ResumeLayout(false);
            groupBoxStats.ResumeLayout(false);
            groupBoxStats.PerformLayout();
            groupBoxCurrentStats.ResumeLayout(false);
            groupBoxCurrentStats.PerformLayout();
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
        private GroupBox groupBoxPlayerControls;
        private GroupBox groupBoxOpponent;
        private GroupBox groupBoxPlayField;
    }
}