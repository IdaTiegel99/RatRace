
namespace RatRace
{
    partial class Main
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
        //hej
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnPlayer2 = new System.Windows.Forms.Button();
            this.BtnPlayer3 = new System.Windows.Forms.Button();
            this.BtnPlayer4 = new System.Windows.Forms.Button();
            this.BtnPlayer5 = new System.Windows.Forms.Button();
            this.BtnMove = new System.Windows.Forms.Button();
            this.BtnPlayer1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPlayer2
            // 
            this.BtnPlayer2.Location = new System.Drawing.Point(174, 296);
            this.BtnPlayer2.Name = "BtnPlayer2";
            this.BtnPlayer2.Size = new System.Drawing.Size(112, 35);
            this.BtnPlayer2.TabIndex = 1;
            this.BtnPlayer2.Text = "Player 2 Bet";
            this.BtnPlayer2.UseVisualStyleBackColor = true;
            this.BtnPlayer2.Click += new System.EventHandler(this.BtnPlayer2_Click);
            // 
            // BtnPlayer3
            // 
            this.BtnPlayer3.Location = new System.Drawing.Point(348, 296);
            this.BtnPlayer3.Name = "BtnPlayer3";
            this.BtnPlayer3.Size = new System.Drawing.Size(110, 35);
            this.BtnPlayer3.TabIndex = 2;
            this.BtnPlayer3.Text = "Player 3 Bet";
            this.BtnPlayer3.UseVisualStyleBackColor = true;
            this.BtnPlayer3.Click += new System.EventHandler(this.BtnPlayer3_Click);
            // 
            // BtnPlayer4
            // 
            this.BtnPlayer4.Location = new System.Drawing.Point(511, 296);
            this.BtnPlayer4.Name = "BtnPlayer4";
            this.BtnPlayer4.Size = new System.Drawing.Size(106, 35);
            this.BtnPlayer4.TabIndex = 3;
            this.BtnPlayer4.Text = "Player 4 Bet";
            this.BtnPlayer4.UseVisualStyleBackColor = true;
            this.BtnPlayer4.Click += new System.EventHandler(this.BtnPlayer4_Click);
            // 
            // BtnPlayer5
            // 
            this.BtnPlayer5.Location = new System.Drawing.Point(680, 296);
            this.BtnPlayer5.Name = "BtnPlayer5";
            this.BtnPlayer5.Size = new System.Drawing.Size(108, 35);
            this.BtnPlayer5.TabIndex = 4;
            this.BtnPlayer5.Text = "Player 5 Bet";
            this.BtnPlayer5.UseVisualStyleBackColor = true;
            this.BtnPlayer5.Click += new System.EventHandler(this.BtnPlayer5_Click);
            // 
            // BtnMove
            // 
            this.BtnMove.Location = new System.Drawing.Point(556, 356);
            this.BtnMove.Name = "BtnMove";
            this.BtnMove.Size = new System.Drawing.Size(232, 82);
            this.BtnMove.TabIndex = 5;
            this.BtnMove.Text = "Move";
            this.BtnMove.UseVisualStyleBackColor = true;
            this.BtnMove.Click += new System.EventHandler(this.BtnMove_Click);
            // 
            // BtnPlayer1
            // 
            this.BtnPlayer1.Location = new System.Drawing.Point(12, 296);
            this.BtnPlayer1.Name = "BtnPlayer1";
            this.BtnPlayer1.Size = new System.Drawing.Size(111, 35);
            this.BtnPlayer1.TabIndex = 6;
            this.BtnPlayer1.Text = "Player 1 Bet";
            this.BtnPlayer1.UseVisualStyleBackColor = true;
            this.BtnPlayer1.Click += new System.EventHandler(this.BtnPlayer1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnPlayer1);
            this.Controls.Add(this.BtnMove);
            this.Controls.Add(this.BtnPlayer5);
            this.Controls.Add(this.BtnPlayer4);
            this.Controls.Add(this.BtnPlayer3);
            this.Controls.Add(this.BtnPlayer2);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnPlayer2;
        private System.Windows.Forms.Button BtnPlayer3;
        private System.Windows.Forms.Button BtnPlayer4;
        private System.Windows.Forms.Button BtnPlayer5;
        private System.Windows.Forms.Button BtnMove;
        private System.Windows.Forms.Button BtnPlayer1;
        private System.Windows.Forms.Button button1;
    }
}

