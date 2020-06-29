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
    public partial class Lectii : Form
    {
        public Lectii()
        {
            InitializeComponent();
        }

        private void Lectii_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Lectii_Load(object sender, EventArgs e)
        {
            
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Platforma platforma = new Platforma();
            platforma.Show();
            this.Hide();
        }

        private void intro_Click(object sender, EventArgs e)
        {
            informatii.LoadFile(@"Lectii/Matrice.pdf");
        }

        private void equality_Click(object sender, EventArgs e)
        {
            informatii.LoadFile(@"Lectii/Egalitatea matricelor.pdf");
        }

        private void operations_Click(object sender, EventArgs e)
        {
            informatii.LoadFile(@"Lectii/Operatii cu matrice.pdf");
        }

        private void properties_Click(object sender, EventArgs e)
        {
            informatii.LoadFile(@"Lectii/Proprietati ale matricelor.pdf");
        }

        private void mainDiagonal_Click(object sender, EventArgs e)
        {
            informatii.LoadFile(@"Lectii/Urma unei matrice.pdf");
        }

        private void transposed_Click(object sender, EventArgs e)
        {
            informatii.LoadFile(@"Lectii/Transpusa unei matrice.pdf");
        }

        private void determinants_Click(object sender, EventArgs e)
        {
            informatii.LoadFile(@"Lectii/Determinanti.pdf");
        }
    }
}
