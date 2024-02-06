namespace COSC2200_Euchre
{
    partial class FormAbout
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
            labelAbout = new Label();
            buttonAboutExit = new Button();
            SuspendLayout();
            // 
            // labelAbout
            // 
            labelAbout.AutoSize = true;
            labelAbout.Location = new Point(12, 9);
            labelAbout.Name = "labelAbout";
            labelAbout.Size = new Size(361, 40);
            labelAbout.TabIndex = 0;
            labelAbout.Text = "This app is a 2 player Euchre game developed for the\r\nCOSC 2200 Group project.";
            // 
            // buttonAboutExit
            // 
            buttonAboutExit.Location = new Point(336, 89);
            buttonAboutExit.Name = "buttonAboutExit";
            buttonAboutExit.Size = new Size(94, 29);
            buttonAboutExit.TabIndex = 1;
            buttonAboutExit.Text = "E&xit";
            buttonAboutExit.UseVisualStyleBackColor = true;
            buttonAboutExit.Click += buttonAboutExit_Click;
            // 
            // FormAbout
            // 
            AcceptButton = buttonAboutExit;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonAboutExit;
            ClientSize = new Size(442, 130);
            Controls.Add(buttonAboutExit);
            Controls.Add(labelAbout);
            MaximumSize = new Size(460, 177);
            MinimumSize = new Size(460, 177);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About This Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAbout;
        private Button buttonAboutExit;
    }
}