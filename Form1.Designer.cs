namespace Calculate_Quiz
{
    partial class QuizFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizFrm));
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pic1 = new System.Windows.Forms.PictureBox();
            this.AnsA = new System.Windows.Forms.Label();
            this.AnsB = new System.Windows.Forms.Label();
            this.AnsC = new System.Windows.Forms.Label();
            this.AnsD = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQuestion
            // 
            this.txtQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtQuestion.Enabled = false;
            this.txtQuestion.Font = new System.Drawing.Font("PMingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.ForeColor = System.Drawing.Color.DarkRed;
            this.txtQuestion.Location = new System.Drawing.Point(602, 43);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.Size = new System.Drawing.Size(277, 33);
            this.txtQuestion.TabIndex = 0;
            this.txtQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaShell;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(167, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 79);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaShell;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(682, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 79);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SeaShell;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(171, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 79);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SeaShell;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(682, 318);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(203, 79);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Pic1);
            this.panel1.Location = new System.Drawing.Point(8, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 179);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Pic1
            // 
            this.Pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pic1.Image = ((System.Drawing.Image)(resources.GetObject("Pic1.Image")));
            this.Pic1.Location = new System.Drawing.Point(3, 3);
            this.Pic1.Name = "Pic1";
            this.Pic1.Size = new System.Drawing.Size(527, 178);
            this.Pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic1.TabIndex = 0;
            this.Pic1.TabStop = false;
            // 
            // AnsA
            // 
            this.AnsA.AutoSize = true;
            this.AnsA.Font = new System.Drawing.Font("Engravers MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnsA.ForeColor = System.Drawing.Color.Gold;
            this.AnsA.Image = ((System.Drawing.Image)(resources.GetObject("AnsA.Image")));
            this.AnsA.Location = new System.Drawing.Point(122, 229);
            this.AnsA.Name = "AnsA";
            this.AnsA.Size = new System.Drawing.Size(39, 31);
            this.AnsA.TabIndex = 6;
            this.AnsA.Text = "A";
            this.AnsA.Click += new System.EventHandler(this.label1_Click);
            // 
            // AnsB
            // 
            this.AnsB.Cursor = System.Windows.Forms.Cursors.Default;
            this.AnsB.Font = new System.Drawing.Font("Engravers MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnsB.ForeColor = System.Drawing.Color.Gold;
            this.AnsB.Image = ((System.Drawing.Image)(resources.GetObject("AnsB.Image")));
            this.AnsB.Location = new System.Drawing.Point(122, 340);
            this.AnsB.Name = "AnsB";
            this.AnsB.Size = new System.Drawing.Size(39, 31);
            this.AnsB.TabIndex = 7;
            this.AnsB.Text = "B";
            // 
            // AnsC
            // 
            this.AnsC.AutoSize = true;
            this.AnsC.Font = new System.Drawing.Font("Engravers MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnsC.ForeColor = System.Drawing.Color.Gold;
            this.AnsC.Image = ((System.Drawing.Image)(resources.GetObject("AnsC.Image")));
            this.AnsC.Location = new System.Drawing.Point(637, 229);
            this.AnsC.Name = "AnsC";
            this.AnsC.Size = new System.Drawing.Size(38, 31);
            this.AnsC.TabIndex = 8;
            this.AnsC.Text = "C";
            // 
            // AnsD
            // 
            this.AnsD.AutoSize = true;
            this.AnsD.Font = new System.Drawing.Font("Engravers MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnsD.ForeColor = System.Drawing.Color.Gold;
            this.AnsD.Image = ((System.Drawing.Image)(resources.GetObject("AnsD.Image")));
            this.AnsD.Location = new System.Drawing.Point(637, 340);
            this.AnsD.Name = "AnsD";
            this.AnsD.Size = new System.Drawing.Size(42, 31);
            this.AnsD.TabIndex = 9;
            this.AnsD.Text = "D";
            // 
            // QuizFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(987, 422);
            this.Controls.Add(this.AnsD);
            this.Controls.Add(this.AnsC);
            this.Controls.Add(this.AnsB);
            this.Controls.Add(this.AnsA);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtQuestion);
            this.Name = "QuizFrm";
            this.Text = "Quiz Game";
            this.Load += new System.EventHandler(this.QuizFrm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Pic1;
        private System.Windows.Forms.Label AnsA;
        private System.Windows.Forms.Label AnsB;
        private System.Windows.Forms.Label AnsC;
        private System.Windows.Forms.Label AnsD;
    }
}

