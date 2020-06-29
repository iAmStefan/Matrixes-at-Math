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
    public partial class Inregistrare_elev : Form
    {
        public Inregistrare_elev()
        {
            InitializeComponent();
        }

        private void Inregistrare_elev_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_Click(object sender, EventArgs e)
        {
            short exist = 0;
            string query = string.Format("SELECT Email,Parola FROM Elevi WHERE Email='{0}' AND Parola='{1}';", email.Text, parola.Text);
            exist = MyData.countApparitions(query);
            if (nume.Text == string.Empty || prenume.Text == string.Empty || username.Text == string.Empty || email.Text == string.Empty || parola.Text == string.Empty || reParola.Text == string.Empty)
                MessageBox.Show("Te rog sa completezi toate campurile", "Matrice la matematica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (exist >= 1)
                MessageBox.Show("E-mailul introdus exista deja. Alege altul", "Matrice la matematica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                string elevi = string.Format("INSERT INTO Elevi (Nume,Prenume,Username,Email,Parola)VALUES('{0}','{1}','{2}','{3}','{4}');", nume.Text, prenume.Text, username.Text, email.Text, parola.Text);
                MyData.writeData("Elevi", elevi);
                MessageBox.Show("Contul a fost creat cu succes", "Matrice la matematica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Autentificare_elev auth = new Autentificare_elev();
                auth.Show();
                this.Hide();
            }
        }

        private void reParola_Leave(object sender, EventArgs e)
        {
            if (parola.Text != reParola.Text)
                MessageBox.Show("Parolele nu coincid. Te rog sa introduci aceleasi parole", "Matrice la matematica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void seePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (seePassword.Checked == true)
            {
                parola.PasswordChar = '\0';
                reParola.PasswordChar = '\0';
            }
            else
            {
                parola.PasswordChar = '•';
                reParola.PasswordChar = '•';
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Start inceput = new Start();
            inceput.Show();
            this.Hide();
        }

        private void Inregistrare_elev_Load(object sender, EventArgs e)
        {
            register.FlatStyle = FlatStyle.Flat;
            register.BackColor = ColorTranslator.FromHtml("#2B89D0");
        }
    }
}
