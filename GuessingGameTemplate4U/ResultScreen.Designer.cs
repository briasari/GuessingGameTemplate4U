namespace GuessingGameTemplate4U
{
    partial class ResultScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.guessesLabel = new System.Windows.Forms.Label();
            this.guessNumLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(40, 37);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(46, 16);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "results";
            // 
            // guessesLabel
            // 
            this.guessesLabel.AutoSize = true;
            this.guessesLabel.Location = new System.Drawing.Point(40, 112);
            this.guessesLabel.Name = "guessesLabel";
            this.guessesLabel.Size = new System.Drawing.Size(88, 16);
            this.guessesLabel.TabIndex = 1;
            this.guessesLabel.Text = "you guessed:";
            // 
            // guessNumLabel
            // 
            this.guessNumLabel.AutoSize = true;
            this.guessNumLabel.Location = new System.Drawing.Point(40, 197);
            this.guessNumLabel.Name = "guessNumLabel";
            this.guessNumLabel.Size = new System.Drawing.Size(95, 16);
            this.guessNumLabel.TabIndex = 2;
            this.guessNumLabel.Text = "you took x tries";
            // 
            // ResultScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.Controls.Add(this.guessNumLabel);
            this.Controls.Add(this.guessesLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "ResultScreen";
            this.Size = new System.Drawing.Size(341, 316);
            this.Load += new System.EventHandler(this.ResultScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label guessesLabel;
        private System.Windows.Forms.Label guessNumLabel;
    }
}
