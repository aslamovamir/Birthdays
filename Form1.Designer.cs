namespace WindowsFormsApp2
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
            this.Congratulate_BTN = new System.Windows.Forms.Button();
            this.Name1_TB = new System.Windows.Forms.TextBox();
            this.Name2_TB = new System.Windows.Forms.TextBox();
            this.Name3_TB = new System.Windows.Forms.TextBox();
            this.first_person_TB = new System.Windows.Forms.TextBox();
            this.second_person_TB = new System.Windows.Forms.TextBox();
            this.third_person_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BirthDate1_TP = new System.Windows.Forms.DateTimePicker();
            this.BirthDate2_TP = new System.Windows.Forms.DateTimePicker();
            this.BirthDate3_TP = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Congratulate_BTN
            // 
            this.Congratulate_BTN.Location = new System.Drawing.Point(353, 348);
            this.Congratulate_BTN.Name = "Congratulate_BTN";
            this.Congratulate_BTN.Size = new System.Drawing.Size(81, 47);
            this.Congratulate_BTN.TabIndex = 0;
            this.Congratulate_BTN.Text = "Congratulate!";
            this.Congratulate_BTN.UseVisualStyleBackColor = true;
            this.Congratulate_BTN.Click += new System.EventHandler(this.Congratulate_BTN_Click);
            // 
            // Name1_TB
            // 
            this.Name1_TB.Location = new System.Drawing.Point(168, 69);
            this.Name1_TB.Name = "Name1_TB";
            this.Name1_TB.Size = new System.Drawing.Size(100, 20);
            this.Name1_TB.TabIndex = 1;
            // 
            // Name2_TB
            // 
            this.Name2_TB.Location = new System.Drawing.Point(168, 157);
            this.Name2_TB.Name = "Name2_TB";
            this.Name2_TB.Size = new System.Drawing.Size(100, 20);
            this.Name2_TB.TabIndex = 2;
            // 
            // Name3_TB
            // 
            this.Name3_TB.Location = new System.Drawing.Point(168, 240);
            this.Name3_TB.Name = "Name3_TB";
            this.Name3_TB.Size = new System.Drawing.Size(100, 20);
            this.Name3_TB.TabIndex = 3;
            // 
            // first_person_TB
            // 
            this.first_person_TB.Location = new System.Drawing.Point(416, 91);
            this.first_person_TB.Name = "first_person_TB";
            this.first_person_TB.Size = new System.Drawing.Size(356, 20);
            this.first_person_TB.TabIndex = 4;
            // 
            // second_person_TB
            // 
            this.second_person_TB.Location = new System.Drawing.Point(416, 183);
            this.second_person_TB.Name = "second_person_TB";
            this.second_person_TB.Size = new System.Drawing.Size(356, 20);
            this.second_person_TB.TabIndex = 5;
            // 
            // third_person_TB
            // 
            this.third_person_TB.Location = new System.Drawing.Point(416, 266);
            this.third_person_TB.Name = "third_person_TB";
            this.third_person_TB.Size = new System.Drawing.Size(356, 20);
            this.third_person_TB.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name of 2nd Person:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name of 3rd Person:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name of 1st Person:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Birthday Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Birthday Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Birthday Date:";
            // 
            // BirthDate1_TP
            // 
            this.BirthDate1_TP.CustomFormat = "dd-MM-yyyy";
            this.BirthDate1_TP.Location = new System.Drawing.Point(168, 92);
            this.BirthDate1_TP.Name = "BirthDate1_TP";
            this.BirthDate1_TP.Size = new System.Drawing.Size(200, 20);
            this.BirthDate1_TP.TabIndex = 16;
            // 
            // BirthDate2_TP
            // 
            this.BirthDate2_TP.Location = new System.Drawing.Point(168, 183);
            this.BirthDate2_TP.Name = "BirthDate2_TP";
            this.BirthDate2_TP.Size = new System.Drawing.Size(200, 20);
            this.BirthDate2_TP.TabIndex = 17;
            // 
            // BirthDate3_TP
            // 
            this.BirthDate3_TP.Location = new System.Drawing.Point(168, 266);
            this.BirthDate3_TP.Name = "BirthDate3_TP";
            this.BirthDate3_TP.Size = new System.Drawing.Size(200, 20);
            this.BirthDate3_TP.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BirthDate3_TP);
            this.Controls.Add(this.BirthDate2_TP);
            this.Controls.Add(this.BirthDate1_TP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.third_person_TB);
            this.Controls.Add(this.second_person_TB);
            this.Controls.Add(this.first_person_TB);
            this.Controls.Add(this.Name3_TB);
            this.Controls.Add(this.Name2_TB);
            this.Controls.Add(this.Name1_TB);
            this.Controls.Add(this.Congratulate_BTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Congratulate_BTN;
        private System.Windows.Forms.TextBox Name1_TB;
        private System.Windows.Forms.TextBox Name2_TB;
        private System.Windows.Forms.TextBox Name3_TB;
        private System.Windows.Forms.TextBox first_person_TB;
        private System.Windows.Forms.TextBox second_person_TB;
        private System.Windows.Forms.TextBox third_person_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker BirthDate1_TP;
        private System.Windows.Forms.DateTimePicker BirthDate2_TP;
        private System.Windows.Forms.DateTimePicker BirthDate3_TP;
    }
}

