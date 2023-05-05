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
            this.AnsA = new System.Windows.Forms.Label();
            this.AnsB = new System.Windows.Forms.Label();
            this.AnsC = new System.Windows.Forms.Label();
            this.AnsD = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtQuestion
            // 
            this.txtQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtQuestion.Enabled = false;
            this.txtQuestion.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.ForeColor = System.Drawing.Color.DarkRed;
            this.txtQuestion.Location = new System.Drawing.Point(352, 78);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.Size = new System.Drawing.Size(270, 35);
            this.txtQuestion.TabIndex = 0;
            this.txtQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(166, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 58);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(677, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 58);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Location = new System.Drawing.Point(166, 333);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 58);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.Location = new System.Drawing.Point(677, 333);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(203, 58);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AnsA
            // 
            this.AnsA.AutoSize = true;
            this.AnsA.BackColor = System.Drawing.Color.Transparent;
            this.AnsA.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnsA.ForeColor = System.Drawing.Color.DarkGreen;
            this.AnsA.Location = new System.Drawing.Point(122, 229);
            this.AnsA.Name = "AnsA";
            this.AnsA.Size = new System.Drawing.Size(36, 37);
            this.AnsA.TabIndex = 6;
            this.AnsA.Text = "A";
            // 
            // AnsB
            // 
            this.AnsB.BackColor = System.Drawing.Color.Transparent;
            this.AnsB.Cursor = System.Windows.Forms.Cursors.Default;
            this.AnsB.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnsB.ForeColor = System.Drawing.Color.DarkGreen;
            this.AnsB.Location = new System.Drawing.Point(122, 340);
            this.AnsB.Name = "AnsB";
            this.AnsB.Size = new System.Drawing.Size(39, 31);
            this.AnsB.TabIndex = 7;
            this.AnsB.Text = "B";
            // 
            // AnsC
            // 
            this.AnsC.AutoSize = true;
            this.AnsC.BackColor = System.Drawing.Color.Transparent;
            this.AnsC.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnsC.ForeColor = System.Drawing.Color.DarkGreen;
            this.AnsC.Location = new System.Drawing.Point(637, 229);
            this.AnsC.Name = "AnsC";
            this.AnsC.Size = new System.Drawing.Size(34, 37);
            this.AnsC.TabIndex = 8;
            this.AnsC.Text = "C";
            // 
            // AnsD
            // 
            this.AnsD.AutoSize = true;
            this.AnsD.BackColor = System.Drawing.Color.Transparent;
            this.AnsD.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnsD.ForeColor = System.Drawing.Color.DarkGreen;
            this.AnsD.Location = new System.Drawing.Point(637, 340);
            this.AnsD.Name = "AnsD";
            this.AnsD.Size = new System.Drawing.Size(37, 37);
            this.AnsD.TabIndex = 9;
            this.AnsD.Text = "D";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Who is smarter than 5th grade student";
            // 
            // QuizFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(987, 422);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnsD);
            this.Controls.Add(this.AnsC);
            this.Controls.Add(this.AnsB);
            this.Controls.Add(this.AnsA);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtQuestion);
            this.Name = "QuizFrm";
            this.Text = "Quiz Game";
            this.Load += new System.EventHandler(this.QuizFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label AnsA;
        private System.Windows.Forms.Label AnsB;
        private System.Windows.Forms.Label AnsC;
        private System.Windows.Forms.Label AnsD;
        private System.Windows.Forms.Label label1;
    }
}

