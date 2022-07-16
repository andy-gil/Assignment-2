namespace assign2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.resetButton = new System.Windows.Forms.Button();
            this.rollButton = new System.Windows.Forms.Button();
            this.lblGuessEnter = new System.Windows.Forms.Label();
            this.lblPlayed = new System.Windows.Forms.Label();
            this.lblWon = new System.Windows.Forms.Label();
            this.lblLoss = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.ResultsOfDice = new System.Windows.Forms.RichTextBox();
            this.numGuessed = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(248, 297);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(85, 33);
            this.resetButton.TabIndex = 0;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(248, 238);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(85, 30);
            this.rollButton.TabIndex = 1;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // lblGuessEnter
            // 
            this.lblGuessEnter.AutoSize = true;
            this.lblGuessEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessEnter.Location = new System.Drawing.Point(18, 166);
            this.lblGuessEnter.Name = "lblGuessEnter";
            this.lblGuessEnter.Size = new System.Drawing.Size(206, 24);
            this.lblGuessEnter.TabIndex = 3;
            this.lblGuessEnter.Text = "Enter your guess (1-6): ";
            // 
            // lblPlayed
            // 
            this.lblPlayed.AutoSize = true;
            this.lblPlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayed.Location = new System.Drawing.Point(18, 23);
            this.lblPlayed.Name = "lblPlayed";
            this.lblPlayed.Size = new System.Drawing.Size(228, 24);
            this.lblPlayed.TabIndex = 5;
            this.lblPlayed.Text = "Number of Times Played: ";
            // 
            // lblWon
            // 
            this.lblWon.AutoSize = true;
            this.lblWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWon.Location = new System.Drawing.Point(18, 63);
            this.lblWon.Name = "lblWon";
            this.lblWon.Size = new System.Drawing.Size(211, 24);
            this.lblWon.TabIndex = 6;
            this.lblWon.Text = "Number of Times Won: ";
            // 
            // lblLoss
            // 
            this.lblLoss.AutoSize = true;
            this.lblLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoss.Location = new System.Drawing.Point(18, 108);
            this.lblLoss.Name = "lblLoss";
            this.lblLoss.Size = new System.Drawing.Size(205, 24);
            this.lblLoss.TabIndex = 7;
            this.lblLoss.Text = "Number of Times Lost: ";
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbImage.BackgroundImage")));
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbImage.Location = new System.Drawing.Point(38, 213);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(154, 135);
            this.pbImage.TabIndex = 8;
            this.pbImage.TabStop = false;
            // 
            // ResultsOfDice
            // 
            this.ResultsOfDice.Location = new System.Drawing.Point(12, 383);
            this.ResultsOfDice.Name = "ResultsOfDice";
            this.ResultsOfDice.Size = new System.Drawing.Size(617, 167);
            this.ResultsOfDice.TabIndex = 9;
            this.ResultsOfDice.Text = "";
            // 
            // numGuessed
            // 
            this.numGuessed.Location = new System.Drawing.Point(248, 167);
            this.numGuessed.Name = "numGuessed";
            this.numGuessed.Size = new System.Drawing.Size(100, 22);
            this.numGuessed.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 562);
            this.Controls.Add(this.numGuessed);
            this.Controls.Add(this.ResultsOfDice);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.lblLoss);
            this.Controls.Add(this.lblWon);
            this.Controls.Add(this.lblPlayed);
            this.Controls.Add(this.lblGuessEnter);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.resetButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Label lblGuessEnter;
        private System.Windows.Forms.Label lblPlayed;
        private System.Windows.Forms.Label lblWon;
        private System.Windows.Forms.Label lblLoss;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.RichTextBox ResultsOfDice;
        private System.Windows.Forms.TextBox numGuessed;
    }
}

