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
            toolStripMenuItemInfo = new ToolStripMenuItem();
            toolStripMenuItemNewGame = new ToolStripMenuItem();
            toolStripMenuItemAbout = new ToolStripMenuItem();
            toolStripMenuItemHowToPlay = new ToolStripMenuItem();
            toolStripMenuItemCredits = new ToolStripMenuItem();
            menuStripForm1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripForm1
            // 
            menuStripForm1.ImageScalingSize = new Size(20, 20);
            menuStripForm1.Items.AddRange(new ToolStripItem[] { toolStripMenuItemControl, toolStripMenuItemInfo });
            menuStripForm1.Location = new Point(0, 0);
            menuStripForm1.Name = "menuStripForm1";
            menuStripForm1.Size = new Size(1021, 28);
            menuStripForm1.TabIndex = 0;
            // 
            // toolStripMenuItemControl
            // 
            toolStripMenuItemControl.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemNewGame });
            toolStripMenuItemControl.Name = "toolStripMenuItemControl";
            toolStripMenuItemControl.Size = new Size(78, 24);
            toolStripMenuItemControl.Text = "Controls";
            // 
            // toolStripMenuItemInfo
            // 
            toolStripMenuItemInfo.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemAbout, toolStripMenuItemHowToPlay, toolStripMenuItemCredits });
            toolStripMenuItemInfo.Name = "toolStripMenuItemInfo";
            toolStripMenuItemInfo.Size = new Size(49, 24);
            toolStripMenuItemInfo.Text = "Info";
            // 
            // toolStripMenuItemNewGame
            // 
            toolStripMenuItemNewGame.Name = "toolStripMenuItemNewGame";
            toolStripMenuItemNewGame.Size = new Size(224, 26);
            toolStripMenuItemNewGame.Text = "New Game";
            // 
            // toolStripMenuItemAbout
            // 
            toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            toolStripMenuItemAbout.Size = new Size(224, 26);
            toolStripMenuItemAbout.Text = "About";
            // 
            // toolStripMenuItemHowToPlay
            // 
            toolStripMenuItemHowToPlay.Name = "toolStripMenuItemHowToPlay";
            toolStripMenuItemHowToPlay.Size = new Size(224, 26);
            toolStripMenuItemHowToPlay.Text = "How To Play";
            // 
            // toolStripMenuItemCredits
            // 
            toolStripMenuItemCredits.Name = "toolStripMenuItemCredits";
            toolStripMenuItemCredits.Size = new Size(224, 26);
            toolStripMenuItemCredits.Text = "Credits";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 466);
            Controls.Add(menuStripForm1);
            MainMenuStrip = menuStripForm1;
            Name = "Form1";
            Text = "Super Awesome Euchre Game!";
            menuStripForm1.ResumeLayout(false);
            menuStripForm1.PerformLayout();
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
    }
}