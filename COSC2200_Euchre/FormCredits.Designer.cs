namespace COSC2200_Euchre
{
    partial class FormCredits
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
            buttonCreditsExit = new Button();
            labelCredits = new Label();
            SuspendLayout();
            // 
            // buttonCreditsExit
            // 
            buttonCreditsExit.Location = new Point(378, 164);
            buttonCreditsExit.Name = "buttonCreditsExit";
            buttonCreditsExit.Size = new Size(94, 29);
            buttonCreditsExit.TabIndex = 0;
            buttonCreditsExit.Text = "E&xit";
            buttonCreditsExit.UseVisualStyleBackColor = true;
            buttonCreditsExit.Click += buttonCreditsExit_Click;
            // 
            // labelCredits
            // 
            labelCredits.AutoSize = true;
            labelCredits.Location = new Point(12, 9);
            labelCredits.Name = "labelCredits";
            labelCredits.Size = new Size(450, 120);
            labelCredits.TabIndex = 1;
            labelCredits.Text = "This amazing and lifechanging euchre game was develepod by\r\nthe following intellectual titans of programming and game design.\r\n\r\nFathima Bukhari\r\nInguer Lara\r\nNathaniel Wesener";
            // 
            // FormCredits
            // 
            AcceptButton = buttonCreditsExit;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCreditsExit;
            ClientSize = new Size(484, 205);
            Controls.Add(labelCredits);
            Controls.Add(buttonCreditsExit);
            MaximumSize = new Size(502, 252);
            MinimumSize = new Size(502, 252);
            Name = "FormCredits";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game Credits";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCreditsExit;
        private Label labelCredits;
    }
}