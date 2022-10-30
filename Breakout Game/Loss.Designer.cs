namespace Breakout_Game
{
    partial class Loss
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
            this.lossExit = new System.Windows.Forms.Button();
            this.lossRetry = new System.Windows.Forms.Button();
            this.winLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lossScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lossExit
            // 
            this.lossExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lossExit.Font = new System.Drawing.Font("Snap ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lossExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lossExit.Location = new System.Drawing.Point(468, 180);
            this.lossExit.Name = "lossExit";
            this.lossExit.Size = new System.Drawing.Size(112, 53);
            this.lossExit.TabIndex = 0;
            this.lossExit.Text = "Exit";
            this.lossExit.UseVisualStyleBackColor = false;
            this.lossExit.Click += new System.EventHandler(this.lossExit_Click);
            // 
            // lossRetry
            // 
            this.lossRetry.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lossRetry.Font = new System.Drawing.Font("Snap ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lossRetry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lossRetry.Location = new System.Drawing.Point(139, 180);
            this.lossRetry.Name = "lossRetry";
            this.lossRetry.Size = new System.Drawing.Size(112, 53);
            this.lossRetry.TabIndex = 1;
            this.lossRetry.Text = "Retry";
            this.lossRetry.UseVisualStyleBackColor = false;
            this.lossRetry.Click += new System.EventHandler(this.lossRetry_Click);
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.BackColor = System.Drawing.Color.Transparent;
            this.winLabel.Font = new System.Drawing.Font("Yu Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.winLabel.Location = new System.Drawing.Point(147, 62);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(414, 48);
            this.winLabel.TabIndex = 5;
            this.winLabel.Text = "Oh Nooo！You Loss！";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(147, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Score:";
            // 
            // lossScore
            // 
            this.lossScore.AutoSize = true;
            this.lossScore.BackColor = System.Drawing.Color.Transparent;
            this.lossScore.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lossScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lossScore.Location = new System.Drawing.Point(357, 110);
            this.lossScore.Name = "lossScore";
            this.lossScore.Size = new System.Drawing.Size(108, 42);
            this.lossScore.TabIndex = 7;
            this.lossScore.Text = "Score";
            // 
            // Loss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Breakout_Game.Properties.Resources.lose;
            this.ClientSize = new System.Drawing.Size(721, 409);
            this.Controls.Add(this.lossScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.lossRetry);
            this.Controls.Add(this.lossExit);
            this.Name = "Loss";
            this.Text = "Lose";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lossExit;
        private System.Windows.Forms.Button lossRetry;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lossScore;
    }
}