using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalDatabaseApp
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uname = "", fname = "", lname = "", spz = "", pass = "", type = "";

            if (tab_reg.SelectedIndex == 0)
            {
                if (pat_pass1.Text != pat_pass2.Text)
                {
                    MessageBox.Show("Error! Passwords doesnt match");
                    return;
                }

                uname = pat_unam.Text; fname = pat_fnm.Text; lname = pat_lnm.Text; pass = pat_pass1.Text; type = "Patient";
            }
            else
            {
                if (doc_pass1.Text != doc_pass2.Text)
                {
                    MessageBox.Show("Error! Passwords doesnt match");
                    return;
                }

                uname = doc_uname.Text; pass = doc_pass1.Text; fname = doc_fnm.Text; lname = doc_lnm.Text; spz = doc_spz.Text; type = "Doctor";
            }


            Program.UpdateExcuterCommand("INSERT INTO Users (username, passwd, userType, specialization, FirstName, LastName) VALUES (@pra1, @pra2, @pra3, @pra4, @pra5, @pra6)");
            Program.commandExcuter.Parameters.AddWithValue("@pra1", uname);
            Program.commandExcuter.Parameters.AddWithValue("@pra2", pass);
            Program.commandExcuter.Parameters.AddWithValue("@pra3", type);
            Program.commandExcuter.Parameters.AddWithValue("@pra4", spz);
            Program.commandExcuter.Parameters.AddWithValue("@pra5", fname);
            Program.commandExcuter.Parameters.AddWithValue("@pra6", lname);

            try
            {
                Program.Excute();
                MessageBox.Show("Done Succeccfully!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Somthing went wrong! Please try again using another username");
            }
        }
    }
}
