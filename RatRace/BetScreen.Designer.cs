
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
        public void InitializeComponent()
        {
            this.BetRat1 = new System.Windows.Forms.Button();
            this.BetRat2 = new System.Windows.Forms.Button();
            this.BetRat3 = new System.Windows.Forms.Button();
            this.BetRat4 = new System.Windows.Forms.Button();
            this.BetRat5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BetDone = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AmountPicker = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.AmountPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // BetRat1
            // 
            this.BetRat1.Location = new System.Drawing.Point(12, 218);
            this.BetRat1.Name = "BetRat1";
            this.BetRat1.Size = new System.Drawing.Size(136, 46);
            this.BetRat1.TabIndex = 0;
            this.BetRat1.Text = "Bet on Rat 1";
            this.BetRat1.UseVisualStyleBackColor = true;
            this.BetRat1.Click += new System.EventHandler(this.BetRat1_Click);
            // 
            // BetRat2
            // 
            this.BetRat2.Location = new System.Drawing.Point(170, 218);
            this.BetRat2.Name = "BetRat2";
            this.BetRat2.Size = new System.Drawing.Size(136, 46);
            this.BetRat2.TabIndex = 1;
            this.BetRat2.Text = "Bet on Rat 2";
            this.BetRat2.UseVisualStyleBackColor = true;
            this.BetRat2.Click += new System.EventHandler(this.BetRat2_Click);
            // 
            // BetRat3
            // 
            this.BetRat3.Location = new System.Drawing.Point(323, 218);
            this.BetRat3.Name = "BetRat3";
            this.BetRat3.Size = new System.Drawing.Size(136, 46);
            this.BetRat3.TabIndex = 2;
            this.BetRat3.Text = "Bet on Rat 3";
            this.BetRat3.UseVisualStyleBackColor = true;
            this.BetRat3.Click += new System.EventHandler(this.BetRat3_Click);
            // 
            // BetRat4
            // 
            this.BetRat4.Location = new System.Drawing.Point(486, 218);
            this.BetRat4.Name = "BetRat4";
            this.BetRat4.Size = new System.Drawing.Size(136, 46);
            this.BetRat4.TabIndex = 3;
            this.BetRat4.Text = "Bet on Rat 4";
            this.BetRat4.UseVisualStyleBackColor = true;
            this.BetRat4.Click += new System.EventHandler(this.BetRat4_Click);
            // 
            // BetRat5
            // 
            this.BetRat5.Location = new System.Drawing.Point(639, 218);
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
            this.label1.Location = new System.Drawing.Point(333, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // BetDone
            // 
            this.BetDone.Location = new System.Drawing.Point(339, 392);
            this.BetDone.Name = "BetDone";
            this.BetDone.Size = new System.Drawing.Size(136, 46);
            this.BetDone.TabIndex = 7;
            this.BetDone.Text = "Submit";
            this.BetDone.UseVisualStyleBackColor = true;
            this.BetDone.Click += new System.EventHandler(this.BetDone_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 32);
            this.label2.TabIndex = 8;
            this.label2.Tag = "MoneyLabel";
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // AmountPicker
            // 
            this.AmountPicker.Location = new System.Drawing.Point(339, 75);
            this.AmountPicker.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.AmountPicker.Name = "AmountPicker";
            this.AmountPicker.Size = new System.Drawing.Size(120, 20);
            this.AmountPicker.TabIndex = 9;
            // 
            // BetScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AmountPicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BetDone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BetRat5);
            this.Controls.Add(this.BetRat4);
            this.Controls.Add(this.BetRat3);
            this.Controls.Add(this.BetRat2);
            this.Controls.Add(this.BetRat1);
            this.Name = "BetScreen";
            this.Text = "BetScreen";
            ((System.ComponentModel.ISupportInitialize)(this.AmountPicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BetRat1;
        private System.Windows.Forms.Button BetRat2;
        private System.Windows.Forms.Button BetRat3;
        private System.Windows.Forms.Button BetRat4;
        private System.Windows.Forms.Button BetRat5;
        private System.Windows.Forms.Button BetDone;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown AmountPicker;
    }
}