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
    public partial class Platforma : Form
    {
        public Platforma()
        {
            InitializeComponent();
        }

        string testNota1 = MyData.selectData("NotaTest1", "Elevi", MyData.e_mail);
        string testNota2 = MyData.selectData("NotaTest2", "Elevi", MyData.e_mail);
        string testNota3 = MyData.selectData("NotaTest3", "Elevi", MyData.e_mail);

        private void invataMatrici_Click(object sender, EventArgs e)
        {
            Lectii lessons = new Lectii();
            lessons.Show();
            this.Hide();
        }

        private void incepeTest_Click(object sender, EventArgs e)
        {
            Testare test = new Testare();
            test.Show();
            this.Hide();
        }

        private void Platforma_Load(object sender, EventArgs e)
        {
            if (testNota1 == string.Empty) noteTest.Text = "Nu ai dat inca teste";
            else if (testNota1 != string.Empty) noteTest.Text = "Note: " + testNota1;
            if (testNota1 != string.Empty && testNota2 != string.Empty) noteTest.Text = "Note: " + testNota1 + " si " + testNota2;
            if (testNota1 != string.Empty && testNota2 != string.Empty && testNota3 != string.Empty) noteTest.Text = "Note: " + testNota1 + ", " + testNota2 + " si " + testNota3;
            invataMatrici.FlatStyle = FlatStyle.Flat;
            invataMatrici.BackColor = ColorTranslator.FromHtml("#2B89D0");
            incepeTest.FlatStyle = FlatStyle.Flat;
            incepeTest.BackColor = ColorTranslator.FromHtml("#2B89D0");
            string numePrenume = MyData.selectData("Nume", "Elevi", MyData.e_mail) + " " + MyData.selectData("Prenume", "Elevi", MyData.e_mail);
            elev.Text = "Elev: " + numePrenume;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Platforma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Autentificare_elev auth = new Autentificare_elev();
            auth.Show();
            this.Hide();
        }
    }
}
