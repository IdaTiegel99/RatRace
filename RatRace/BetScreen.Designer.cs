﻿
namespace RatRace
{
    partial class BetScreen
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
            this.BetRat1 = new System.Windows.Forms.Button();
            this.BetRat2 = new System.Windows.Forms.Button();
            this.BetRat3 = new System.Windows.Forms.Button();
            this.BetRat4 = new System.Windows.Forms.Button();
            this.BetRat5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BetRat1
            // 
            this.BetRat1.Location = new System.Drawing.Point(66, 178);
            this.BetRat1.Name = "BetRat1";
            this.BetRat1.Size = new System.Drawing.Size(136, 46);
            this.BetRat1.TabIndex = 0;
            this.BetRat1.Text = "Bet on Rat 1";
            this.BetRat1.UseVisualStyleBackColor = true;
            this.BetRat1.Click += new System.EventHandler(this.BetRat1_Click);
            // 
            // BetRat2
            // 
            this.BetRat2.Location = new System.Drawing.Point(339, 178);
            this.BetRat2.Name = "BetRat2";
            this.BetRat2.Size = new System.Drawing.Size(136, 46);
            this.BetRat2.TabIndex = 1;
            this.BetRat2.Text = "Bet on Rat 2";
            this.BetRat2.UseVisualStyleBackColor = true;
            this.BetRat2.Click += new System.EventHandler(this.BetRat2_Click);
            // 
            // BetRat3
            // 
            this.BetRat3.Location = new System.Drawing.Point(604, 178);
            this.BetRat3.Name = "BetRat3";
            this.BetRat3.Size = new System.Drawing.Size(136, 46);
            this.BetRat3.TabIndex = 2;
            this.BetRat3.Text = "Bet on Rat 3";
            this.BetRat3.UseVisualStyleBackColor = true;
            this.BetRat3.Click += new System.EventHandler(this.BetRat3_Click);
            // 
            // BetRat4
            // 
            this.BetRat4.Location = new System.Drawing.Point(193, 302);
            this.BetRat4.Name = "BetRat4";
            this.BetRat4.Size = new System.Drawing.Size(136, 46);
            this.BetRat4.TabIndex = 3;
            this.BetRat4.Text = "Bet on Rat 4";
            this.BetRat4.UseVisualStyleBackColor = true;
            this.BetRat4.Click += new System.EventHandler(this.BetRat4_Click);
            // 
            // BetRat5
            // 
            this.BetRat5.Location = new System.Drawing.Point(475, 302);
            this.BetRat5.Name = "BetRat5";
            this.BetRat5.Size = new System.Drawing.Size(136, 46);
            this.BetRat5.TabIndex = 4;
            this.BetRat5.Text = "Bet on Rat 5";
            this.BetRat5.UseVisualStyleBackColor = true;
            this.BetRat5.Click += new System.EventHandler(this.BetRat5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Player x Bets";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(310, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BetScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BetRat5);
            this.Controls.Add(this.BetRat4);
            this.Controls.Add(this.BetRat3);
            this.Controls.Add(this.BetRat2);
            this.Controls.Add(this.BetRat1);
            this.Name = "BetScreen";
            this.Text = "BetScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BetRat1;
        private System.Windows.Forms.Button BetRat2;
        private System.Windows.Forms.Button BetRat3;
        private System.Windows.Forms.Button BetRat4;
        private System.Windows.Forms.Button BetRat5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}