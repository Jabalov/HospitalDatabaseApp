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
    public partial class DoctorForm : Form
    {
        List<string> unames, complainments;

        public DoctorForm()
        {
            InitializeComponent();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            Program.UpdateExcuterCommand("SELECT firstName, lastName  FROM  Users WHERE username = @uname");
            Program.commandExcuter.Parameters.AddWithValue("@uname", Program.username);
            Program.StartReader();

            if (Program.reader.HasRows)
            {
                Program.reader.Read();
                this.Text = string.Format("Hello Dr {0} {1}.", Program.reader["firstName"], Program.reader["lastName"]);
            }


            Program.UpdateExcuterCommand("select patientUsername, complainment, firstName, lastName from MedicalAppointments, Users where MedicalAppointments.doctorUsername = @uname and Users.username=patientUsername");
            Program.commandExcuter.Parameters.AddWithValue("@uname", Program.username);
            Program.StartReader();

            if (Program.reader.HasRows)
            {
                unames = new List<string>(); complainments = new List<string>();

                while (Program.reader.Read())
                {
                    unames.Add(Program.reader["patientUsername"].ToString());
                    complainments.Add(Program.reader["complainment"].ToString());
                    listBox1.Items.Add(string.Format("Mr/s: {0} {1}", Program.reader["firstName"], Program.reader["lastName"]));
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                return;

            mainLabel.Text = string.Format("Patient is complaining from: {0}", complainments[listBox1.SelectedIndex]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                return;

            Program.UpdateExcuterCommand("INSERT INTO MedicalRecords (doctorUsername, patientUsername, diagnostic, treatment)	VALUES	(@duname, @puname, @diagn, @treat); " +
                "DELETE FROM MedicalAppointments WHERE MedicalAppointments.doctorUsername = @duname and MedicalAppointments.patientUsername = @puname ;");

            Program.commandExcuter.Parameters.AddWithValue("@duname", Program.username);
            Program.commandExcuter.Parameters.AddWithValue("@puname", unames[listBox1.SelectedIndex]);
            Program.commandExcuter.Parameters.AddWithValue("@diagn", richTextBox1.Text);
            Program.commandExcuter.Parameters.AddWithValue("@treat", richTextBox2.Text);

            try
            {
                Program.Excute();
                unames.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);

                MessageBox.Show("Patient updated successfully");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong! Please try again");
            }

        }
    }
}
