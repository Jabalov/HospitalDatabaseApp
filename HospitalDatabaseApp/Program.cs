using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalDatabaseApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static SqlConnection myConnection = new SqlConnection(
                            "user id=SA;"               +
                            "password=MrMax369S;"       +
                            "server=35.233.21.199;"     +
                            "Trusted_Connection=no;"    +
                            "database=hospital; "       +
                            "connection timeout=30");

        public static SqlCommand commandExcuter;
        public static SqlDataReader reader;

        public static string username = "";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }

        public static void UpdateExcuterCommand(string queryString)
        {
            if (myConnection.State == ConnectionState.Closed)
                myConnection.Open();

            if (commandExcuter == null)
                commandExcuter = new SqlCommand(queryString, myConnection);
            else
                commandExcuter.CommandText = queryString;

            commandExcuter.Parameters.Clear();
        }

        public static void Excute()
        {
            if (reader != null)
                reader.Close();

            commandExcuter.ExecuteNonQuery();
        }

        public static void StartReader()
        {
            if (reader != null)
                reader.Close();

            reader = commandExcuter.ExecuteReader();
        }
    }
}
