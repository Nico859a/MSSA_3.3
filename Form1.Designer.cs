namespace Assignment3._3_new_
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
            this.button1 = new System.Windows.Forms.Button();
            this.lab6 = new System.Windows.Forms.Label();
            this.lab5 = new System.Windows.Forms.Label();
            this.lab4 = new System.Windows.Forms.Label();
            this.lab3 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.tb_StudentID = new System.Windows.Forms.TextBox();
            this.tb_FirstName = new System.Windows.Forms.TextBox();
            this.tb_LastName = new System.Windows.Forms.TextBox();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cb_MonthOfAdmission = new System.Windows.Forms.ComboBox();
            this.lab1 = new System.Windows.Forms.Label();
            this.tb_GradeNeeded = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(134, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1Delete_Click);
            // 
            // lab6
            // 
            this.lab6.AutoSize = true;
            this.lab6.Location = new System.Drawing.Point(144, 58);
            this.lab6.Name = "lab6";
            this.lab6.Size = new System.Drawing.Size(58, 13);
            this.lab6.TabIndex = 1;
            this.lab6.Text = "Student ID";
            // 
            // lab5
            // 
            this.lab5.AutoSize = true;
            this.lab5.Location = new System.Drawing.Point(144, 102);
            this.lab5.Name = "lab5";
            this.lab5.Size = new System.Drawing.Size(57, 13);
            this.lab5.TabIndex = 2;
            this.lab5.Text = "First Name";
            // 
            // lab4
            // 
            this.lab4.AutoSize = true;
            this.lab4.Location = new System.Drawing.Point(143, 154);
            this.lab4.Name = "lab4";
            this.lab4.Size = new System.Drawing.Size(58, 13);
            this.lab4.TabIndex = 3;
            this.lab4.Text = "Last Name";
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.lab3.Location = new System.Drawing.Point(155, 208);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(45, 13);
            this.lab3.TabIndex = 4;
            this.lab3.Text = "Address";
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Location = new System.Drawing.Point(102, 267);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(99, 13);
            this.lab2.TabIndex = 5;
            this.lab2.Text = "Month of Admission";
            // 
            // tb_StudentID
            // 
            this.tb_StudentID.Location = new System.Drawing.Point(208, 51);
            this.tb_StudentID.Name = "tb_StudentID";
            this.tb_StudentID.Size = new System.Drawing.Size(118, 20);
            this.tb_StudentID.TabIndex = 6;
            // 
            // tb_FirstName
            // 
            this.tb_FirstName.Location = new System.Drawing.Point(206, 95);
            this.tb_FirstName.Name = "tb_FirstName";
            this.tb_FirstName.Size = new System.Drawing.Size(120, 20);
            this.tb_FirstName.TabIndex = 7;
            // 
            // tb_LastName
            // 
            this.tb_LastName.Location = new System.Drawing.Point(206, 147);
            this.tb_LastName.Name = "tb_LastName";
            this.tb_LastName.Size = new System.Drawing.Size(120, 20);
            this.tb_LastName.TabIndex = 8;
            // 
            // tb_Address
            // 
            this.tb_Address.Location = new System.Drawing.Point(206, 201);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(120, 20);
            this.tb_Address.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.Location = new System.Drawing.Point(251, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(369, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(419, 241);
            this.dataGridView1.TabIndex = 12;
            // 
            // cb_MonthOfAdmission
            // 
            this.cb_MonthOfAdmission.FormattingEnabled = true;
            this.cb_MonthOfAdmission.Location = new System.Drawing.Point(205, 259);
            this.cb_MonthOfAdmission.Name = "cb_MonthOfAdmission";
            this.cb_MonthOfAdmission.Size = new System.Drawing.Size(121, 21);
            this.cb_MonthOfAdmission.TabIndex = 13;
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(122, 309);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(77, 13);
            this.lab1.TabIndex = 14;
            this.lab1.Text = "Grade Needed";
            this.lab1.UseWaitCursor = true;
            // 
            // tb_GradeNeeded
            // 
            this.tb_GradeNeeded.Location = new System.Drawing.Point(205, 302);
            this.tb_GradeNeeded.Name = "tb_GradeNeeded";
            this.tb_GradeNeeded.Size = new System.Drawing.Size(121, 20);
            this.tb_GradeNeeded.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_GradeNeeded);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.cb_MonthOfAdmission);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tb_Address);
            this.Controls.Add(this.tb_LastName);
            this.Controls.Add(this.tb_FirstName);
            this.Controls.Add(this.tb_StudentID);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.lab3);
            this.Controls.Add(this.lab4);
            this.Controls.Add(this.lab5);
            this.Controls.Add(this.lab6);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lab6;
        private System.Windows.Forms.Label lab5;
        private System.Windows.Forms.Label lab4;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.TextBox tb_StudentID;
        private System.Windows.Forms.TextBox tb_FirstName;
        private System.Windows.Forms.TextBox tb_LastName;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_MonthOfAdmission;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.TextBox tb_GradeNeeded;
    }
}

