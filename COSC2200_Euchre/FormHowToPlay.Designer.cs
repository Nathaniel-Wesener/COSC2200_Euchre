namespace COSC2200_Euchre
{
    partial class FormHowToPlay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonHowToPlayExit = new Button();
            SuspendLayout();
            // 
            // buttonHowToPlayExit
            // 
            buttonHowToPlayExit.Location = new Point(694, 409);
            buttonHowToPlayExit.Name = "buttonHowToPlayExit";
            buttonHowToPlayExit.Size = new Size(94, 29);
            buttonHowToPlayExit.TabIndex = 0;
            buttonHowToPlayExit.Text = "E&xit";
            buttonHowToPlayExit.UseVisualStyleBackColor = true;
            buttonHowToPlayExit.Click += buttonHowToPlayExit_Click;
            // 
            // FormHowToPlay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHowToPlayExit);
            Name = "FormHowToPlay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "How to Play 2 Person Euchre";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonHowToPlayExit;
    }
}