using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HospitalDatabaseApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox2.Text != "")
            {
                Program.UpdateExcuterCommand("SELECT passwd, userType  FROM  [dbo].[Users] WHERE username = @pra1");
                Program.commandExcuter.Parameters.AddWithValue("@pra1", textBox1.Text);
                Program.StartReader();

                try
                {
                    Program.reader.Read();

                    if (Program.reader["passwd"].ToString() == textBox2.Text)
                    {
                        // To use the username later on when pulling quriez for everything else
                        Program.username = textBox1.Text;

                        // TODO: logged in sucessfully, go to login forms
                        switch (Program.reader["userType"].ToString())
                        {
                            case "Doctor":
                                this.Hide();
                                new DoctorForm().ShowDialog();
                                this.Close();
                                break;

                            case "Patient":
                                this.Hide();
                                new PatientFrom().ShowDialog();
                                this.Close();
                                break;

                            default:
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invaild Password, Please try again.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Username doesnt exist! Please try another username");
                    return;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new RegistrationForm().ShowDialog();
            this.Show();
        }
    }
}
