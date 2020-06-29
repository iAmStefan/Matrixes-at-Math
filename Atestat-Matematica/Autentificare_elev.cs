using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat_Matematica
{
    public partial class Autentificare_elev : Form
    {
        public Autentificare_elev()
        {
            InitializeComponent();
        }

        private void Autentificare_elev_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Autentificare_elev_Load(object sender, EventArgs e)
        {
            login.FlatStyle = FlatStyle.Flat;
            login.BackColor = ColorTranslator.FromHtml("#2B89D0");
            if (Properties.Settings.Default.memorat == true)
            {
                email.Text = Properties.Settings.Default.email;
                parola.Text = Properties.Settings.Default.parola;
                rememberMe.Checked = true;
            }
        }   

        private void login_Click(object sender, EventArgs e)
        {
            short exist = 0;
            string query = string.Format("SELECT Email,Parola FROM Elevi WHERE Email='{0}' AND Parola='{1}';", email.Text, parola.Text);
            exist = MyData.countApparitions(query);
            if (email.Text == string.Empty || parola.Text == string.Empty)
                MessageBox.Show("Te rog sa completezi toate campurile.", "Matrice la matematica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (exist == 0)
            {
                MessageBox.Show("Acest e-mail nu exista. Introdu te rog unul valid.", "Matrice la matematica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                rememberMe.Checked = false;
                seePassword.Checked = false;
                email.Text = "";
                parola.Text = "";
                Properties.Settings.Default.email = email.Text;
                Properties.Settings.Default.parola = parola.Text;
                Properties.Settings.Default.memorat = false;
                Properties.Settings.Default.Save();
            }
            else
            {
                string numePrenume = MyData.selectData("Nume", "Elevi", email.Text) + " " + MyData.selectData("Prenume", "Elevi", email.Text);
                MessageBox.Show("Bine ai venit, " + numePrenume + "!", "Matrice la matematica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MyData.e_mail = email.Text;
                Platforma platform = new Platforma();
                platform.Show();
                this.Hide();
            }
        }

        private void rememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (email.Text == string.Empty || parola.Text == string.Empty)
                MessageBox.Show("Pentru a memora datele, campurile trebuie sa fie completate", "Matrice la matematica", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Properties.Settings.Default.email = email.Text;
                Properties.Settings.Default.parola = parola.Text;
                Properties.Settings.Default.memorat = true;
                Properties.Settings.Default.Save();
            }
        }

        private void seePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (seePassword.Checked == true) parola.PasswordChar = '\0';
            else parola.PasswordChar = '•';
        }

        private void back_Click(object sender, EventArgs e)
        {
            Start inceput = new Start();
            inceput.Show();
            this.Hide();
        }
    }
}
