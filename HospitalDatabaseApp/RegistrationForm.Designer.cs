namespace HospitalDatabaseApp
{
    partial class RegistrationForm
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
            this.tab_reg = new System.Windows.Forms.TabControl();
            this.pat_reg = new System.Windows.Forms.TabPage();
            this.doc_reg = new System.Windows.Forms.TabPage();
            this.doc_spz = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.doc_pass2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.doc_pass1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.doc_uname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.doc_lnm = new System.Windows.Forms.TextBox();
            this.doc_fnm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pat_lnm = new System.Windows.Forms.TextBox();
            this.pat_fnm = new System.Windows.Forms.TextBox();
            this.pat_pass2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pat_pass1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pat_unam = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tab_reg.SuspendLayout();
            this.pat_reg.SuspendLayout();
            this.doc_reg.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_reg
            // 
            this.tab_reg.Controls.Add(this.pat_reg);
            this.tab_reg.Controls.Add(this.doc_reg);
            this.tab_reg.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab_reg.Location = new System.Drawing.Point(0, 0);
            this.tab_reg.Name = "tab_reg";
            this.tab_reg.SelectedIndex = 0;
            this.tab_reg.Size = new System.Drawing.Size(329, 318);
            this.tab_reg.TabIndex = 0;
            // 
            // pat_reg
            // 
            this.pat_reg.Controls.Add(this.label1);
            this.pat_reg.Controls.Add(this.label2);
            this.pat_reg.Controls.Add(this.pat_lnm);
            this.pat_reg.Controls.Add(this.pat_fnm);
            this.pat_reg.Controls.Add(this.pat_pass2);
            this.pat_reg.Controls.Add(this.label10);
            this.pat_reg.Controls.Add(this.pat_pass1);
            this.pat_reg.Controls.Add(this.label11);
            this.pat_reg.Controls.Add(this.pat_unam);
            this.pat_reg.Controls.Add(this.label12);
            this.pat_reg.Location = new System.Drawing.Point(4, 22);
            this.pat_reg.Name = "pat_reg";
            this.pat_reg.Padding = new System.Windows.Forms.Padding(3);
            this.pat_reg.Size = new System.Drawing.Size(321, 292);
            this.pat_reg.TabIndex = 0;
            this.pat_reg.Text = "Signup as Patient";
            this.pat_reg.UseVisualStyleBackColor = true;
            // 
            // doc_reg
            // 
            this.doc_reg.Controls.Add(this.label9);
            this.doc_reg.Controls.Add(this.label8);
            this.doc_reg.Controls.Add(this.doc_lnm);
            this.doc_reg.Controls.Add(this.doc_fnm);
            this.doc_reg.Controls.Add(this.doc_spz);
            this.doc_reg.Controls.Add(this.label7);
            this.doc_reg.Controls.Add(this.doc_pass2);
            this.doc_reg.Controls.Add(this.label4);
            this.doc_reg.Controls.Add(this.doc_pass1);
            this.doc_reg.Controls.Add(this.label5);
            this.doc_reg.Controls.Add(this.doc_uname);
            this.doc_reg.Controls.Add(this.label6);
            this.doc_reg.Location = new System.Drawing.Point(4, 22);
            this.doc_reg.Name = "doc_reg";
            this.doc_reg.Padding = new System.Windows.Forms.Padding(3);
            this.doc_reg.Size = new System.Drawing.Size(321, 292);
            this.doc_reg.TabIndex = 1;
            this.doc_reg.Text = "Signup as Doctor";
            this.doc_reg.UseVisualStyleBackColor = true;
            // 
            // doc_spz
            // 
            this.doc_spz.Location = new System.Drawing.Point(90, 80);
            this.doc_spz.Name = "doc_spz";
            this.doc_spz.Size = new System.Drawing.Size(220, 20);
            this.doc_spz.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Speclization:";
            // 
            // doc_pass2
            // 
            this.doc_pass2.Location = new System.Drawing.Point(90, 240);
            this.doc_pass2.Name = "doc_pass2";
            this.doc_pass2.PasswordChar = 'X';
            this.doc_pass2.Size = new System.Drawing.Size(220, 20);
            this.doc_pass2.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Re Password:";
            // 
            // doc_pass1
            // 
            this.doc_pass1.Location = new System.Drawing.Point(90, 200);
            this.doc_pass1.Name = "doc_pass1";
            this.doc_pass1.PasswordChar = 'X';
            this.doc_pass1.Size = new System.Drawing.Size(220, 20);
            this.doc_pass1.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password:";
            // 
            // doc_uname
            // 
            this.doc_uname.Location = new System.Drawing.Point(90, 40);
            this.doc_uname.Name = "doc_uname";
            this.doc_uname.Size = new System.Drawing.Size(220, 20);
            this.doc_uname.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Username:";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(329, 64);
            this.button1.TabIndex = 100;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // doc_lnm
            // 
            this.doc_lnm.Location = new System.Drawing.Point(90, 160);
            this.doc_lnm.Name = "doc_lnm";
            this.doc_lnm.Size = new System.Drawing.Size(220, 20);
            this.doc_lnm.TabIndex = 23;
            // 
            // doc_fnm
            // 
            this.doc_fnm.Location = new System.Drawing.Point(90, 120);
            this.doc_fnm.Name = "doc_fnm";
            this.doc_fnm.Size = new System.Drawing.Size(220, 20);
            this.doc_fnm.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Firstname:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Lastname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Lastname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Firstname:";
            // 
            // pat_lnm
            // 
            this.pat_lnm.Location = new System.Drawing.Point(90, 160);
            this.pat_lnm.Name = "pat_lnm";
            this.pat_lnm.Size = new System.Drawing.Size(220, 20);
            this.pat_lnm.TabIndex = 12;
            // 
            // pat_fnm
            // 
            this.pat_fnm.Location = new System.Drawing.Point(90, 120);
            this.pat_fnm.Name = "pat_fnm";
            this.pat_fnm.Size = new System.Drawing.Size(220, 20);
            this.pat_fnm.TabIndex = 11;
            // 
            // pat_pass2
            // 
            this.pat_pass2.Location = new System.Drawing.Point(90, 240);
            this.pat_pass2.Name = "pat_pass2";
            this.pat_pass2.PasswordChar = 'X';
            this.pat_pass2.Size = new System.Drawing.Size(220, 20);
            this.pat_pass2.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Re Password:";
            // 
            // pat_pass1
            // 
            this.pat_pass1.Location = new System.Drawing.Point(90, 200);
            this.pat_pass1.Name = "pat_pass1";
            this.pat_pass1.PasswordChar = 'X';
            this.pat_pass1.Size = new System.Drawing.Size(220, 20);
            this.pat_pass1.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Password:";
            // 
            // pat_unam
            // 
            this.pat_unam.Location = new System.Drawing.Point(90, 80);
            this.pat_unam.Name = "pat_unam";
            this.pat_unam.Size = new System.Drawing.Size(220, 20);
            this.pat_unam.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Username:";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 387);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tab_reg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.tab_reg.ResumeLayout(false);
            this.pat_reg.ResumeLayout(false);
            this.pat_reg.PerformLayout();
            this.doc_reg.ResumeLayout(false);
            this.doc_reg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_reg;
        private System.Windows.Forms.TabPage pat_reg;
        private System.Windows.Forms.TabPage doc_reg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox doc_spz;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox doc_pass2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox doc_pass1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox doc_uname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox doc_lnm;
        private System.Windows.Forms.TextBox doc_fnm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pat_lnm;
        private System.Windows.Forms.TextBox pat_fnm;
        private System.Windows.Forms.TextBox pat_pass2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox pat_pass1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox pat_unam;
        private System.Windows.Forms.Label label12;
    }
}