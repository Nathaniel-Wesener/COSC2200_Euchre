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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHowToPlay));
            buttonHowToPlayExit = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonHowToPlayExit
            // 
            buttonHowToPlayExit.Location = new Point(1735, 982);
            buttonHowToPlayExit.Margin = new Padding(8, 7, 8, 7);
            buttonHowToPlayExit.Name = "buttonHowToPlayExit";
            buttonHowToPlayExit.Size = new Size(235, 70);
            buttonHowToPlayExit.TabIndex = 0;
            buttonHowToPlayExit.Text = "E&xit";
            buttonHowToPlayExit.UseVisualStyleBackColor = true;
            buttonHowToPlayExit.Click += buttonHowToPlayExit_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 83);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1947, 873);
            textBox1.TabIndex = 1;
            textBox1.Text = resources.GetString("textBox1.Text");
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 19);
            label1.Name = "label1";
            label1.Size = new Size(221, 48);
            label1.TabIndex = 2;
            label1.Text = "How To Play:";
            label1.Click += label1_Click_1;
            // 
            // FormHowToPlay
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2000, 1080);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(buttonHowToPlayExit);
            Margin = new Padding(8, 7, 8, 7);
            Name = "FormHowToPlay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "How to Play 2 Person Euchre";
            Load += FormHowToPlay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonHowToPlayExit;
        private TextBox textBox1;
        private Label label1;
    }
}