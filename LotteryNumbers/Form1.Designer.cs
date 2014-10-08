namespace LotteryNumbers
{
    partial class Lottery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lottery));
            this.button1 = new System.Windows.Forms.Button();
            this.txtDisplay1 = new System.Windows.Forms.TextBox();
            this.txtDisplay2 = new System.Windows.Forms.TextBox();
            this.txtDisplay3 = new System.Windows.Forms.TextBox();
            this.txtDisplay4 = new System.Windows.Forms.TextBox();
            this.txtDisplay5 = new System.Windows.Forms.TextBox();
            this.txtDisplay6 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtGoodLuck = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(109, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDisplay1
            // 
            this.txtDisplay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay1.Location = new System.Drawing.Point(30, 256);
            this.txtDisplay1.Name = "txtDisplay1";
            this.txtDisplay1.Size = new System.Drawing.Size(40, 26);
            this.txtDisplay1.TabIndex = 1;
            // 
            // txtDisplay2
            // 
            this.txtDisplay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay2.Location = new System.Drawing.Point(76, 256);
            this.txtDisplay2.Name = "txtDisplay2";
            this.txtDisplay2.Size = new System.Drawing.Size(40, 26);
            this.txtDisplay2.TabIndex = 2;
            // 
            // txtDisplay3
            // 
            this.txtDisplay3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay3.Location = new System.Drawing.Point(123, 256);
            this.txtDisplay3.Name = "txtDisplay3";
            this.txtDisplay3.Size = new System.Drawing.Size(40, 26);
            this.txtDisplay3.TabIndex = 3;
            // 
            // txtDisplay4
            // 
            this.txtDisplay4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay4.Location = new System.Drawing.Point(169, 256);
            this.txtDisplay4.Name = "txtDisplay4";
            this.txtDisplay4.Size = new System.Drawing.Size(40, 26);
            this.txtDisplay4.TabIndex = 4;
            // 
            // txtDisplay5
            // 
            this.txtDisplay5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay5.Location = new System.Drawing.Point(215, 256);
            this.txtDisplay5.Name = "txtDisplay5";
            this.txtDisplay5.Size = new System.Drawing.Size(40, 26);
            this.txtDisplay5.TabIndex = 5;
            // 
            // txtDisplay6
            // 
            this.txtDisplay6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay6.Location = new System.Drawing.Point(261, 256);
            this.txtDisplay6.Name = "txtDisplay6";
            this.txtDisplay6.Size = new System.Drawing.Size(40, 26);
            this.txtDisplay6.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 220);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txtGoodLuck
            // 
            this.txtGoodLuck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtGoodLuck.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGoodLuck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoodLuck.Location = new System.Drawing.Point(96, 288);
            this.txtGoodLuck.Name = "txtGoodLuck";
            this.txtGoodLuck.Size = new System.Drawing.Size(130, 24);
            this.txtGoodLuck.TabIndex = 8;
            this.txtGoodLuck.Text = "Good Luck!";
            this.txtGoodLuck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGoodLuck.Visible = false;
            // 
            // Lottery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(327, 351);
            this.Controls.Add(this.txtGoodLuck);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtDisplay6);
            this.Controls.Add(this.txtDisplay5);
            this.Controls.Add(this.txtDisplay4);
            this.Controls.Add(this.txtDisplay3);
            this.Controls.Add(this.txtDisplay2);
            this.Controls.Add(this.txtDisplay1);
            this.Controls.Add(this.button1);
            this.Name = "Lottery";
            this.Text = "Lottery Numbers Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDisplay1;
        private System.Windows.Forms.TextBox txtDisplay2;
        private System.Windows.Forms.TextBox txtDisplay3;
        private System.Windows.Forms.TextBox txtDisplay4;
        private System.Windows.Forms.TextBox txtDisplay5;
        private System.Windows.Forms.TextBox txtDisplay6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtGoodLuck;
    }
}

