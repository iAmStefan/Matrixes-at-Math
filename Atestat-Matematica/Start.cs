using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Atestat_Matematica
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void authentication_Click(object sender, EventArgs e)
        {
            Autentificare_elev auth = new Autentificare_elev();
            auth.Show();
            this.Hide();
        }

        private void registration_Click(object sender, EventArgs e)
        {
            Inregistrare_elev register = new Inregistrare_elev();
            register.Show();
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            authentication.FlatStyle = FlatStyle.Flat;
            authentication.BackColor = ColorTranslator.FromHtml("#2B89D0");
            registration.FlatStyle = FlatStyle.Flat;
            registration.BackColor = ColorTranslator.FromHtml("#2B89D0");
            this.BackgroundImage = new Bitmap("matematicaStart.jpg");
            close.BackColor = Color.Transparent;
            close.ForeColor = Color.White;
            projectName.BackColor = Color.Transparent;
            student.BackColor = Color.Transparent;
            highschool.BackColor = Color.Transparent;
        }
    }

    public class MyData
    {
        public static string e_mail = string.Empty;
        public static OleDbConnection MyConnection = null;

        public static void openDB(ref OleDbConnection conn)
        {
            conn = null;
            try
            {
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MatematicaPlatforma.accdb";
                conn = new OleDbConnection(connectionString);
                conn.Open();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static short countApparitions(string Query)
        {
            short count = 0;
            openDB(ref MyConnection);
            try
            {
                OleDbCommand cmd = new OleDbCommand(Query, MyConnection);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) count++;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                MyConnection.Close();
            }
            return count;
        }

        public static void writeData(string TableName, string Query)
        {
            openDB(ref MyConnection);
            try
            {
                OleDbCommand cmd = new OleDbCommand(Query, MyConnection);
                cmd.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                MyConnection.Close();
            }
        }

        public static string selectData(string Data, string TableName, string emailPointer)
        {
            string returnedData = string.Empty;
            openDB(ref MyConnection);
            try
            {
                string Query = string.Format("SELECT {0} FROM {1} WHERE email='{2}';", Data, TableName, emailPointer);
                OleDbCommand cmd = new OleDbCommand(Query, MyConnection);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) returnedData = reader[Data].ToString();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                MyConnection.Close();
            }
            return returnedData;
        }
    }
}
