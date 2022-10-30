namespace Breakout_Game
{
    partial class Win
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
            this.winRetry = new System.Windows.Forms.Button();
            this.winExit = new System.Windows.Forms.Button();
            this.winLabel = new System.Windows.Forms.Label();
            this.winTotal = new System.Windows.Forms.Label();
            this.winScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // winRetry
            // 
            this.winRetry.BackColor = System.Drawing.Color.SandyBrown;
            this.winRetry.Font = new System.Drawing.Font("Snap ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winRetry.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.winRetry.Location = new System.Drawing.Point(259, 246);
            this.winRetry.Name = "winRetry";
            this.winRetry.Size = new System.Drawing.Size(112, 53);
            this.winRetry.TabIndex = 3;
            this.winRetry.Text = "Retry";
            this.winRetry.UseVisualStyleBackColor = false;
            this.winRetry.Click += new System.EventHandler(this.winRetry_Click);
            // 
            // winExit
            // 
            this.winExit.BackColor = System.Drawing.Color.SandyBrown;
            this.winExit.Font = new System.Drawing.Font("Snap ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.winExit.Location = new System.Drawing.Point(583, 246);
            this.winExit.Name = "winExit";
            this.winExit.Size = new System.Drawing.Size(112, 53);
            this.winExit.TabIndex = 2;
            this.winExit.Text = "Exit";
            this.winExit.UseVisualStyleBackColor = false;
            this.winExit.Click += new System.EventHandler(this.lossExit_Click);
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.BackColor = System.Drawing.Color.Transparent;
            this.winLabel.Font = new System.Drawing.Font("Yu Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.winLabel.Location = new System.Drawing.Point(209, 93);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(531, 48);
            this.winLabel.TabIndex = 4;
            this.winLabel.Text = "Congratulations！You Win！";
            // 
            // winTotal
            // 
            this.winTotal.AutoSize = true;
            this.winTotal.BackColor = System.Drawing.Color.Transparent;
            this.winTotal.Font = new System.Drawing.Font("Yu Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winTotal.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.winTotal.Location = new System.Drawing.Point(231, 167);
            this.winTotal.Name = "winTotal";
            this.winTotal.Size = new System.Drawing.Size(222, 45);
            this.winTotal.TabIndex = 5;
            this.winTotal.Text = "Total Score:";
            // 
            // winScore
            // 
            this.winScore.AutoSize = true;
            this.winScore.BackColor = System.Drawing.Color.Transparent;
            this.winScore.Font = new System.Drawing.Font("Yu Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winScore.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.winScore.Location = new System.Drawing.Point(459, 167);
            this.winScore.Name = "winScore";
            this.winScore.Size = new System.Drawing.Size(0, 45);
            this.winScore.TabIndex = 6;
            // 
            // Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Breakout_Game.Properties.Resources.Win;
            this.ClientSize = new System.Drawing.Size(948, 594);
            this.Controls.Add(this.winScore);
            this.Controls.Add(this.winTotal);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.winRetry);
            this.Controls.Add(this.winExit);
            this.Name = "Win";
            this.Text = "Win";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button winRetry;
        private System.Windows.Forms.Button winExit;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Label winTotal;
        private System.Windows.Forms.Label winScore;
    }
}