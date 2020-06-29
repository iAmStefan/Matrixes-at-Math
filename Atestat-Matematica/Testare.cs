using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Atestat_Matematica
{
    public partial class Testare : Form
    {
        public Testare()
        {
            InitializeComponent();
        }

        #region Declarari
        string testNota1 = MyData.selectData("NotaTest1", "Elevi", MyData.e_mail);
        string testNota2 = MyData.selectData("NotaTest2", "Elevi", MyData.e_mail);
        string testNota3 = MyData.selectData("NotaTest3", "Elevi", MyData.e_mail);
        RichTextBox spatiu = new RichTextBox();
        Label testEnding = new Label();
        Label timp = new Label();
        Label and = new Label();
        Label Comma = new Label();
        Label Completion = new Label();
        Label question = new Label();
        Label[] raspunsuri = new Label[22] { R1paranteza1, R1paranteza2, RC, RG1paranteza1, RG1paranteza2, RG1, RG2paranteza1, RG2paranteza2, RG2, RG3paranteza1, RG3paranteza2, RG3, var1, var2, var3, var4, M1paranteza1, M1paranteza2, M2paranteza1, M2paranteza2, M3paranteza1, M3paranteza2 };
        Label[] solutions = new Label[4] { RC, RG1, RG2, RG3 };
        Label[] choices = new Label[4] { var1, var2, var3, var4 };
        Label[] Matrixes = new Label[12] { Matrix1, Matrix2, Matrix3, MatrixA, MatrixB, MatrixC, M1paranteza1, M1paranteza2, M2paranteza1, M2paranteza2, M3paranteza1, M3paranteza2 };
        static Label MatrixA = new Label();
        static Label MatrixB = new Label();
        static Label MatrixC = new Label();
        static Label Matrix1 = new Label();
        static Label Matrix2 = new Label();
        static Label Matrix3 = new Label();
        static Label M1paranteza1 = new Label();
        static Label M1paranteza2 = new Label();
        static Label M2paranteza1 = new Label();
        static Label M2paranteza2 = new Label();
        static Label M3paranteza1 = new Label();
        static Label M3paranteza2 = new Label();
        static Label var1 = new Label();
        static Label var2 = new Label();
        static Label var3 = new Label();
        static Label var4 = new Label();
        static Label RC = new Label();
        static Label RG1 = new Label();
        static Label RG2 = new Label();
        static Label RG3 = new Label();
        static Label R1paranteza1 = new Label();
        static Label R1paranteza2 = new Label();
        static Label RG1paranteza1 = new Label();
        static Label RG1paranteza2 = new Label();
        static Label RG2paranteza1 = new Label();
        static Label RG2paranteza2 = new Label();
        static Label RG3paranteza1 = new Label();
        static Label RG3paranteza2 = new Label();
        int questionNumber = 1, time = 1800;
        int[] locatieX = new int[4] { 55, 335, 615, 895 };
        int[] locatieY = new int[4] { 300, 300, 300, 300 };
        string[] questionList = new string[6] { "Sa se calculeze A + B", "Sa se calculeze A·B - C", "Calculeaza determinantul matricei de mai sus", "Calculati (-3)·A", "Sa se calculeze determinantul matricei 4·A", "Aflati a, b, c din egalitatea matricelor de mai sus" };
        List<string> intrebari = new List<string>();
        List<string> questionGraveyard = new List<string>();
        List<Point> locationPoints = new List<Point>();
        double points = 1;

        #region Exercitiul1
        int[,] e1m1 = new int[3, 3] { { -3, 7, -1 }, { 8, 5, -4 }, { 2, -9, 3 } };
        int[,] e1m2 = new int[3, 3] { { 2, -4, 8 }, { 3, -1, 7 }, { 6, -5, -4 } };
        int[,] e1RaspunsCorect = new int[3, 3] { { -1, 3, 7 }, { 11, 4, 3 }, { 8, -14, -1 } };
        int[,] e1RaspunsGresit1 = new int[3, 3] { { -2, 3, 6 }, { 12, -6, 3 }, { 7, -14, -2 } };
        int[,] e1RaspunsGresit2 = new int[3, 3] { { -1, 4, 7}, { 11, 5, -3}, { 6, -4, 1} };
        int[,] e1RaspunsGresit3 = new int[3, 3] { { -1, -3, 7}, { 5, 4, -3 }, {8, -13, -1 } };
        #endregion Exercitiul1

        #region Exercitiul2
        int[,] e2m1 = new int[3, 1] { { -1 }, { 2 }, { 1 } };
        int[,] e2m2 = new int[1, 3] { { 3, -1, -2} };
        int[,] e2m3 = new int[3, 3] { { -2, 1, 3 }, { 4, -5, -6}, { 3, 1, -1 } }; 
        int[,] e2RaspunsCorect = new int[3, 3] { { -1, 0, -1}, { 2, 3, 2}, { 0, -2, -1 } };
        int[,] e2RaspunsGresit1 = new int[3, 3] { { -1, 0, 1}, { 2, 3, 2}, { 0, -2, -1 } };
        int[,] e2RaspunsGresit2 = new int[3, 3] { { 1, 0, 1}, { 2, -7, 2 }, { 0, 2, 1} };
        int[,] e2RaspunsGresit3 = new int[3, 3] { { 1, 0, -1}, { 2, 3, 2 }, { 0, -2, -1} };
        #endregion Exercitiul2

        #region Exercitiul3
        int[,] e3m = new int[3, 3] { { -5, 0, 1}, { 0, 3, -1 }, { 4, 1, 0 } };
        static int e3RaspunsCorect = 17;
        static int e3RaspunsGresit1 = 16;
        static int e3RaspunsGresit2 = 18;
        static int e3RaspunsGresit3 = 15;
        int[] e3Answers = new int[4] { e3RaspunsCorect, e3RaspunsGresit1, e3RaspunsGresit2, e3RaspunsGresit3 };
        #endregion Exercitiul3

        #region Exercitiul4
        int[,] e4m = new int[2, 2] { { -1, 3 }, { 7, -2 } };
        int[,] e4RaspunsCorect = new int[2, 2] { { 3, -9 }, { -21, 6 } };
        int[,] e4RaspunsGresit1 = new int[2, 2] { { 3, 9 }, { 21, 6 } };
        int[,] e4RaspunsGresit2 = new int[2, 2] { { -3, 9 }, { -21, 6 } };
        int[,] e4RaspunsGresit3 = new int[2, 2] { { -3, 9 }, { 21, -6 } };
        #endregion Exercitiul4

        #region Exercitiul5
        int[,] e5m = new int[2, 2] { {3, -7 }, { -1, 8 } };
        static int e5RaspunsCorect = 68;
        static int e5RaspunsGresit1 = 57;
        static int e5RaspunsGresit2 = -68;
        static int e5RaspunsGresit3 = 69;
        int[] e5Answers = new int[4] { e5RaspunsCorect, e5RaspunsGresit1, e5RaspunsGresit2, e5RaspunsGresit3 };
        #endregion Exercitiul5

        #region Exercitiul6
        string[,] e6m1 = new string[3, 3] { { "3", "a", "-2" }, { "-1", "6", "b" }, { "4", "7", "-c" } };
        int[,] e6m2 = new int[3, 3] { { 3, 5, -2 }, { -1, 6, -8 }, { 4, 7, -9 } };
        static string e6RaspunsCorect = "a = 5, b = -8, c = 9";
        static string e6RaspunsGresit1 = "a = -5, b= -8, c = -9";
        static string e6RaspunsGresit2 = "a = -5, b = 8, c = -9";
        static string e6RaspunsGresit3 = "a = 5, b = 8, c = 9";
        string[] e6Answers = new string[4] { e6RaspunsCorect, e6RaspunsGresit1, e6RaspunsGresit2, e6RaspunsGresit3 };
        #endregion Exercitiul6

        #endregion Declarari

        void PlasareControale()
        {
            answer.FlatStyle = FlatStyle.Flat;
            answer.BackColor = ColorTranslator.FromHtml("#2B89D0");

            setAnswer.FlatStyle = FlatStyle.Flat;
            setAnswer.BackColor = ColorTranslator.FromHtml("#2B89D0");

            nextQuestion.FlatStyle = FlatStyle.Flat;
            nextQuestion.BackColor = ColorTranslator.FromHtml("#2B89D0");

            workSpace.FlatStyle = FlatStyle.Flat;
            workSpace.BackColor = ColorTranslator.FromHtml("#2B89D0");

            testEnding.Location = new Point(130, 150);
            testEnding.Size = new Size(480, 33);
            testEnding.Font = new Font("Century Gothic", 23);

            spatiu.Size = new Size(930, 63);
            spatiu.Location = new Point(30, 215);

            this.Controls.Add(timp);
            timp.Size = new Size(300, 20);
            timp.Text = time.ToString();
            timp.Location = new Point(10, 30);
            timp.Font = new Font("Century Gothic", 12);

            for (int i = 0; i < choices.Length; i++)
            {
                choices[i].Size = new Size(30, 25);
                choices[0].Location = new Point(10, 320);
                if (i > 0) choices[i].Location = new Point(choices[i-1].Location.X + 280, 320);
                this.Controls.Add(choices[i]);
            }

            var1.Text = "a)";
            var1.Click += Var1_Click;
            var1.Font = new Font("Century Gothic", 12);

            var2.Text = "b)";
            var2.Click += Var2_Click;
            var2.Font = new Font("Century Gothic", 12);

            var3.Text = "c)";
            var3.Click += Var3_Click;
            var3.Font = new Font("Century Gothic", 12);

            var4.Text = "d)";
            var4.Click += Var4_Click;
            var4.Font = new Font("Century Gothic", 12);

            Comma.Text = ",";
            Comma.Font = new Font("Tahoma", 12);
            Comma.Size = new Size(10, 20);

            this.Controls.Add(Completion);
            Completion.Size = new Size(150, 20);
            Completion.Location = new Point(30, 120);
            Completion.Font = new Font("Century Gothic", 12);

            MatrixA.Text = "A =";
            MatrixA.Location = new Point(180, 120);
            MatrixA.Size = new Size(45, 25);
            MatrixA.Font = new Font("Century Gothic", 12);

            MatrixB.Text = "B =";
            MatrixB.Location = new Point(335, 120);
            MatrixB.Size = new Size(45, 25);
            MatrixB.Font = new Font("Century Gothic", 12);

            MatrixC.Text = "C =";
            MatrixC.Location = new Point(440, 120);
            MatrixC.Size = new Size(45, 25);
            MatrixC.Font = new Font("Century Gothic", 12);

            question.Size = new Size(400, 20);
            question.Location = new Point(30, 180);
            question.Font = new Font("Century Gothic", 12);

            addControl(M1paranteza1, M1paranteza2, Matrix1, RC, RG1, RG2, RG3);
            addControl(MatrixA, MatrixB, M2paranteza1, M2paranteza2, Matrix2, R1paranteza1, R1paranteza2);
            addControl(RG1paranteza1, RG1paranteza2, RG2paranteza1, RG2paranteza2, RG3paranteza1, RG3paranteza2, question);
        }

        void PlasareMatrice()
        {
            Matrix1.Location = new Point(230, 98);
            Matrix1.Font = new Font("Century Gothic", 12);
            Matrix1.Size = new Size(63, 60);
            Matrix1.BringToFront();

            M1paranteza1.Location = new Point(210, 88);
            M1paranteza1.Size = new Size(31, 73);
            M1paranteza1.Text = "(";
            M1paranteza1.TextAlign = ContentAlignment.TopCenter;

            M1paranteza2.Location = new Point(290, 88);
            M1paranteza2.Size = new Size(31, 73);
            M1paranteza2.Text = ")";
            M1paranteza2.TextAlign = ContentAlignment.TopCenter;
            M1paranteza2.BringToFront();

            this.Controls.Add(and);
            and.Text = "si";
            and.Size = new Size(25, 20);
            and.Location = new Point(315, 120);
            and.Font = new Font("Century Gothic", 12);
            and.BringToFront();

            M2paranteza1.Location = new Point(360, 88);
            M2paranteza1.Size = new Size(31, 73);
            M2paranteza1.TextAlign = ContentAlignment.TopCenter;
            M2paranteza1.Text = "(";
            M2paranteza1.BringToFront();

            M2paranteza2.Location = new Point(430, 88);
            M2paranteza2.Size = new Size(31, 73);
            M2paranteza1.TextAlign = ContentAlignment.TopCenter;
            M2paranteza2.Text = ")";
            M2paranteza2.BringToFront();

            Matrix2.Location = new Point(380, 98);
            Matrix2.Font = new Font("Century Gothic", 12);
            Matrix2.Size = new Size(63, 60);
            Matrix2.BringToFront();

            Matrix3.Size = new Size(63, 60);
            Matrix3.Font = new Font("Century Gothic", 12);

            M3paranteza1.Location = new Point(470, 88);
            M3paranteza1.Size = new Size(31, 73);
            M3paranteza1.TextAlign = ContentAlignment.TopCenter;
            M3paranteza1.Text = "(";

            M3paranteza2.Location = new Point(547, 88);
            M3paranteza2.Size = new Size(31, 73);
            M3paranteza2.TextAlign = ContentAlignment.TopCenter;
            M3paranteza2.Text = ")";

            for (int i = 0; i < solutions.Length; i++)
            {
                solutions[i].Size = new Size(73, 65);
                solutions[i].Font = new Font("Century Gothic", 12);
            }

            R1paranteza1.Location = new Point(25, 290);
            R1paranteza1.Size = new Size(31, 73);
            R1paranteza1.Text = "(";

            R1paranteza2.Location = new Point(115, 290);
            R1paranteza2.Size = new Size(31, 73);
            R1paranteza2.Text = ")";

            RG1paranteza1.Location = new Point(305, 290);
            RG1paranteza1.Size = new Size(31, 73);
            RG1paranteza1.Text = "(";

            RG1paranteza2.Location = new Point(395, 290);
            RG1paranteza2.Size = new Size(31, 73);
            RG1paranteza2.Text = ")";

            RG2paranteza1.Location = new Point(585, 290);
            RG2paranteza1.Size = new Size(31, 73);
            RG2paranteza1.Text = "(";

            RG2paranteza2.Location = new Point(675, 290);
            RG2paranteza2.Size = new Size(31, 73);
            RG2paranteza2.Text = ")";

            RG3paranteza1.Location = new Point(865, 290);
            RG3paranteza1.Size = new Size(31, 73);
            RG3paranteza1.Text = "(";

            RG3paranteza2.Location = new Point(955, 290);
            RG3paranteza2.Size = new Size(31, 73);
            RG3paranteza2.Text = ")";
        }

        int getDistance(Point label1, Point label2)
        {
            double distanta = Math.Sqrt((label1.X - label2.X) * (label1.X - label2.X) + (label1.Y - label2.Y) * (label1.Y - label2.Y));
            return Convert.ToInt32(distanta);
        }

        private void Var4_Click(object sender, EventArgs e)
        {
            if (setAnswer.Enabled == true)
            {
                for (int i = 0; i < raspunsuri.Length; i++)
                {
                    if (i == 0 || i == 1 || i == 3 || i == 4 || i == 6 || i == 7 || i == 14 || i == 13 || i == 12) raspunsuri[i].ForeColor = Color.Black;
                    else if (i == 9 || i == 10 || i == 15) raspunsuri[i].ForeColor = Color.DodgerBlue;

                    if (getDistance(RG3paranteza1.Location, RC.Location) < 40)
                    {
                        if (i == 5 || i == 8 || i == 11) raspunsuri[i].ForeColor = Color.Black;
                        else if (i == 2) raspunsuri[i].ForeColor = Color.DodgerBlue;
                    }
                    else if (getDistance(RG3paranteza1.Location, RG1.Location) < 40)
                    {
                        if (i == 2 || i == 8 || i == 11) raspunsuri[i].ForeColor = Color.Black;
                        else if (i == 5) raspunsuri[i].ForeColor = Color.DodgerBlue;
                    }
                    else if (getDistance(RG3paranteza1.Location, RG2.Location) < 40)
                    {
                        if (i == 2 || i == 5 || i == 11) raspunsuri[i].ForeColor = Color.Black;
                        else if (i == 8) raspunsuri[i].ForeColor = Color.DodgerBlue;
                    }
                    else if (getDistance(RG3paranteza1.Location, RG3.Location) < 40)
                    {
                        if (i == 2 || i == 5 || i == 8) raspunsuri[i].ForeColor = Color.Black;
                        else if (i == 11) raspunsuri[i].ForeColor = Color.DodgerBlue;
                    }
                }
            }
        }

        private void Var3_Click(object sender, EventArgs e)
        {
            if (setAnswer.Enabled == true)
            {
                for (int i = 0; i < raspunsuri.Length; i++)
                {
                    if (i == 0 || i == 1 || i == 3 || i == 4 || i == 9 || i == 10 || i == 15 || i == 13 || i == 12) raspunsuri[i].ForeColor = Color.Black;
                    else if (i == 14 || i == 6 || i == 7) raspunsuri[i].ForeColor = Color.DodgerBlue;

                    if (getDistance(RG2paranteza1.Location, RC.Location) < 40)
                    {
                        if (i == 5 || i == 8 || i == 11) raspunsuri[i].ForeColor = Color.Black;
                        else if (i == 2) raspunsuri[i].ForeColor = Color.DodgerBlue;
                    }
                    else if (getDistance(RG2paranteza1.Location, RG1.Location) < 40)
                    {
                        if (i == 2 || i == 8 || i == 11) raspunsuri[i].ForeColor = Color.Black;
                        else if (i == 5) raspunsuri[i].ForeColor = Color.DodgerBlue;
                    }
                    else if (getDistance(RG2paranteza1.Location, RG2.Location) < 40)
                    {
                        if (i == 2 || i == 5 || i == 11) raspunsuri[i].ForeColor = Color.Black;
                        else if (i == 8) raspunsuri[i].ForeColor = Color.DodgerBlue;
                    }
                    else if (getDistance(RG2paranteza1.Location, RG3.Location) < 40)
                    {
                        if (i == 2 || i == 5 || i == 8) raspunsuri[i].ForeColor = Color.Black;
                        else if (i == 11) raspunsuri[i].ForeColor = Color.DodgerBlue;
                    }
                }
            }
        }

        private void Var2_Click(object sender, EventArgs e)
        {
            if (setAnswer.Enabled == true)
            {
                for (int i = 0; i < raspunsuri.Length; i++)
                {
                    if (i == 6 || i == 7 || i == 9 || i == 10 || i == 0 || i == 1 || i == 14 || i == 15 || i == 12) raspunsuri[i].ForeColor = Color.Black;
                    else if (i == 3 || i == 4 || i == 13) raspunsuri[i].ForeColor = Color.DodgerBlue;

                    if (getDistance(RG1paranteza1.Location, RC.Location) < 40)
                    {
                        if (i == 5 || i == 8 || i == 11) raspunsuri[i].ForeColor = Color.Black;
                        else if (i == 2) raspunsuri[i].ForeColor = Color.DodgerBlue;
                    }
                    else if (getDistance(RG1paranteza1.Location, RG1.Location) < 40)
                    {
                        if (i == 2 || i == 8 || i == 11) raspunsuri[i].ForeColor = Color.Black;
                        else if (i == 5) raspunsuri[i].ForeColor = Color.DodgerBlue;
                    }
                    else if (getDistance(RG1paranteza1.Location, RG2.Location) < 40)
                    {
                        if (i == 2 || i == 5 || i == 11) raspunsuri[i].ForeColor = Color.Black;
                        else if (i == 8) raspunsuri[i].ForeColor = Color.DodgerBlue;
                    }
                    else if (getDistance(RG1paranteza1.Location, RG3.Location) < 40)
                    {
                        if (i == 2 || i == 5 || i == 8) raspunsuri[i].ForeColor = Color.Black;
                        else if (i == 11) raspunsuri[i].ForeColor = Color.DodgerBlue;
                    }
                }
            }
        }

        private void Var1_Click(object sender, EventArgs e)
        {
            if (setAnswer.Enabled == true)
            {
                for (int i = 0; i < raspunsuri.Length; i++)
                {
                    if (i == 3 || i == 4 || i == 6 || i == 7 || i == 9 || i == 10 || i == 13 || i == 14 || i == 15) raspunsuri[i].ForeColor = Color.Black;
                    else if (i == 0 || i == 1 || i == 12) raspunsuri[i].ForeColor = Color.DodgerBlue;

                    if (getDistance(R1paranteza1.Location, RC.Location) < 40)
                    {
                        if (i == 5 || i == 8 || i == 11) raspunsuri[i].ForeColor = Color.Black;
                        else if (i == 2) raspunsuri[i].ForeColor = Color.DodgerBlue;
                    }
                    else if (getDistance(R1paranteza1.Location, RG1.Location) < 40)
                    {
                        if (i == 2 || i == 8 || i == 11) raspunsuri[i].ForeColor = Color.Black;
                        else if (i == 5) raspunsuri[i].ForeColor = Color.DodgerBlue;
                    }
                    else if (getDistance(R1paranteza1.Location, RG2.Location) < 40)
                    {
                        if (i == 2 || i == 5 || i == 11) raspunsuri[i].ForeColor = Color.Black;
                        else if (i == 8) raspunsuri[i].ForeColor = Color.DodgerBlue;
                    }
                    else if (getDistance(R1paranteza1.Location, RG3.Location) < 40)
                    {
                        if (i == 2 || i == 5 || i == 8) raspunsuri[i].ForeColor = Color.Black;
                        else if (i == 11) raspunsuri[i].ForeColor = Color.DodgerBlue;
                    }
                }
            }
        }

        void addControl(Control control1, Control control2, Control control3, Control control4, Control control5, Control control6, Control control7)
        {
            this.Controls.Add(control1);
            this.Controls.Add(control2);
            this.Controls.Add(control3);
            this.Controls.Add(control4);
            this.Controls.Add(control5);
            this.Controls.Add(control6);
            this.Controls.Add(control7);
        }

        void removeControl(Control control1, Control control2, Control control3, Control control4, Control control5, Control control6, Control control7)
        {
            this.Controls.Remove(control1);
            this.Controls.Remove(control2);
            this.Controls.Remove(control3);
            this.Controls.Remove(control4);
            this.Controls.Remove(control5);
            this.Controls.Remove(control6);
            this.Controls.Remove(control7);
        }

        private void Testare_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < questionList.Length; i++) intrebari.Add(questionList[i]);
            Randomizer();
            PlasareControale();
            PlasareMatrice();
            nrIntrebare.Text = questionNumber.ToString() + ".";
            puncte.Text = "Puncte: " + points.ToString();
            timp.Text = "Timp ramas: ";
            setAnswer.Enabled = true;
            nextQuestion.Enabled = false;
            for (int i = 0; i < 22; i++)
            {
                if (i == 0 || i == 1 || i == 3 || i == 4 || i == 6 || i == 7 || i == 9 || i == 10 || i == 16 || i == 17 || i == 18 || i == 19 || i == 20 || i == 21)
                    raspunsuri[i].Font = new Font("Century Gothic", 43);
            }
            question.Text = intrebari[0];
            Completion.Text = "Se dau matricele: ";
            Matrix1.Text = e1m1[0, 0] + "  " + e1m1[0, 1] + "  " + e1m1[0, 2] + Environment.NewLine + " " + e1m1[1, 0] + "  " + e1m1[1, 1] + "  " + e1m1[1, 2] + Environment.NewLine + " " + e1m1[2, 0] + "  " + e1m1[2, 1] + "  " + e1m1[2, 2];
            Matrix2.Text = e1m2[0, 0] + "  " + e1m2[0, 1] + "   " + e1m2[0, 2] + Environment.NewLine + e1m2[1, 0] + "  " + e1m2[1, 1] + "   " + e1m2[1, 2] + Environment.NewLine + e1m2[2, 0] + "  " + e1m2[2, 1] + "  " + e1m2[2, 2];
            RC.Text = " " + e1RaspunsCorect[0, 0] + "    " + e1RaspunsCorect[0, 1] + "  " + e1RaspunsCorect[0, 2] + Environment.NewLine + e1RaspunsCorect[1, 0] + "    " + e1RaspunsCorect[1, 1] + "  " + e1RaspunsCorect[1, 2] + Environment.NewLine + " " + " " + e1RaspunsCorect[2, 0] + " " + e1RaspunsCorect[2, 1] + " " + e1RaspunsCorect[2, 2];
            RG1.Text = " " + e1RaspunsGresit1[0, 0] + "    " + e1RaspunsGresit1[0, 1] + "  " + e1RaspunsGresit1[0, 2] + Environment.NewLine + e1RaspunsGresit1[1, 0] + "   " + e1RaspunsGresit1[1, 1] + "  " + e1RaspunsGresit1[1, 2] + Environment.NewLine + "  " + e1RaspunsGresit1[2, 0] + " " + e1RaspunsGresit1[2, 1] + " " + e1RaspunsGresit1[2, 2];
            RG2.Text = " " + e1RaspunsGresit2[0, 0] + "   " + e1RaspunsGresit2[0, 1] + "   " + e1RaspunsGresit2[0, 2] + Environment.NewLine + e1RaspunsGresit2[1, 0] + "   " + e1RaspunsGresit2[1, 1] + "  " + e1RaspunsGresit2[1, 2] + Environment.NewLine + "  " + e1RaspunsGresit2[2, 0] + "  " + e1RaspunsGresit2[2, 1] + "   " + e1RaspunsGresit2[2, 2];
            RG3.Text = e1RaspunsGresit3[0, 0] + "   " + e1RaspunsGresit3[0, 1] + "   " + e1RaspunsGresit3[0, 2] + Environment.NewLine + " " + e1RaspunsGresit3[1, 0] + "    " + e1RaspunsGresit3[1, 1] + "  " + e1RaspunsGresit3[1, 2] + Environment.NewLine + " " + e1RaspunsGresit3[2, 0] + " " + e1RaspunsGresit3[2, 1] + "  " + e1RaspunsGresit3[2, 2];
            questionGraveyard.Add(intrebari[0]);
        }

        void Randomizer()
        {
            for (int i = 0; i < 4; i++)
            {
                Point punct = new Point();
                punct.X = locatieX[i];
                punct.Y = locatieY[i];
                locationPoints.Add(punct);
            }

            for (int i = 0; i < 4; i++)
            {
                Random random = new Random();
                int aleatoriu = random.Next(locationPoints.Count);
                Point punct = new Point();
                punct = locationPoints[aleatoriu];
                solutions[i].Location = punct;
                locationPoints.Remove(punct);
            }
        }

        private void setAnswer_Click(object sender, EventArgs e)
        {            
            if (var1.ForeColor == Color.DodgerBlue || var2.ForeColor == Color.DodgerBlue || var3.ForeColor == Color.DodgerBlue || var4.ForeColor == Color.DodgerBlue)
                setAnswer.Enabled = false;
        }

        private async void answer_Click(object sender, EventArgs e)
        {
            if (setAnswer.Enabled == false)
            {
                nextQuestion.Enabled = true;
                if ((raspunsuri[2].Location == new Point(55, 300) && var1.ForeColor == Color.DodgerBlue) || (raspunsuri[2].Location == new Point(335, 300) && var2.ForeColor == Color.DodgerBlue) || (raspunsuri[2].Location == new Point(615, 300) && var3.ForeColor == Color.DodgerBlue) || (raspunsuri[2].Location == new Point(895, 300) && var4.ForeColor == Color.DodgerBlue))
                {
                    raspunsuri[2].ForeColor = Color.Green;
                    points += 1.5;
                    puncte.Text = "Puncte: " + points.ToString();
                    for (int i = 0; i < raspunsuri.Length; i++)
                    {
                        if (getDistance(R1paranteza1.Location, raspunsuri[2].Location) < 40)
                        {
                            if (i == 12 || i == 0 || i == 1) raspunsuri[i].ForeColor = Color.Green;
                        }
                        else if (getDistance(RG1paranteza1.Location, raspunsuri[2].Location) < 40)
                        {
                            if (i == 13 || i == 3 || i == 4) raspunsuri[i].ForeColor = Color.Green;
                        }
                        else if (getDistance(RG2paranteza1.Location, raspunsuri[2].Location) < 40)
                        {
                            if (i == 14 || i == 6 || i == 7) raspunsuri[i].ForeColor = Color.Green;
                        }
                        else if (getDistance(RG3paranteza1.Location, raspunsuri[2].Location) < 40)
                        {
                            if (i == 15 || i == 9 || i == 10) raspunsuri[i].ForeColor = Color.Green;
                        }
                    }
                }
                else if ((raspunsuri[2].Location != new Point(55, 300) && var1.ForeColor == Color.DodgerBlue) || (raspunsuri[2].Location != new Point(335, 300) && var2.ForeColor == Color.DodgerBlue) || (raspunsuri[2].Location != new Point(615, 300) && var3.ForeColor == Color.DodgerBlue) || (raspunsuri[2].Location != new Point(895, 300) && var4.ForeColor == Color.DodgerBlue))
                {
                    raspunsuri[2].ForeColor = Color.Green;
                    for (int i = 0; i < raspunsuri.Length; i++)
                    {
                        if (var1.ForeColor == Color.DodgerBlue)
                        {
                            if (i == 12 || i == 0 || i == 1) raspunsuri[i].ForeColor = Color.Red;
                            if (getDistance(R1paranteza1.Location, RG1.Location) < 40) RG1.ForeColor = Color.Red;
                            else if (getDistance(R1paranteza1.Location, RG2.Location) < 40) RG2.ForeColor = Color.Red;
                            else if (getDistance(R1paranteza1.Location, RG3.Location) < 40) RG3.ForeColor = Color.Red;
                        }
                        else if (var2.ForeColor == Color.DodgerBlue)
                        {
                            if (i == 13 || i == 3 || i == 4) raspunsuri[i].ForeColor = Color.Red;
                            if (getDistance(RG1paranteza1.Location, RG1.Location) < 40) RG1.ForeColor = Color.Red;
                            else if (getDistance(RG1paranteza1.Location, RG2.Location) < 40) RG2.ForeColor = Color.Red;
                            else if (getDistance(RG1paranteza1.Location, RG3.Location) < 40) RG3.ForeColor = Color.Red;
                        }
                        else if (var3.ForeColor == Color.DodgerBlue)
                        {
                            if (i == 14 || i == 6 || i == 7) raspunsuri[i].ForeColor = Color.Red;
                            if (getDistance(RG2paranteza1.Location, RG1.Location) < 40) RG1.ForeColor = Color.Red;
                            else if (getDistance(RG2paranteza1.Location, RG2.Location) < 40) RG2.ForeColor = Color.Red;
                            else if (getDistance(RG2paranteza1.Location, RG3.Location) < 40) RG3.ForeColor = Color.Red;
                        }
                        else if (var4.ForeColor == Color.DodgerBlue)
                        {
                            if (i == 15 || i == 9 || i == 10) raspunsuri[i].ForeColor = Color.Red;
                            if (getDistance(RG3paranteza1.Location, RG1.Location) < 40) RG1.ForeColor = Color.Red;
                            else if (getDistance(RG3paranteza1.Location, RG2.Location) < 40) RG2.ForeColor = Color.Red;
                            else if (getDistance(RG3paranteza1.Location, RG3.Location) < 40) RG3.ForeColor = Color.Red;
                        }

                        if (getDistance(R1paranteza1.Location, raspunsuri[2].Location) < 40)
                        {
                            if (i == 12 || i == 0 || i == 1) raspunsuri[i].ForeColor = Color.Green;
                        }
                        else if (getDistance(RG1paranteza1.Location, raspunsuri[2].Location) < 40)
                        {
                            if (i == 13 || i == 3 || i == 4) raspunsuri[i].ForeColor = Color.Green;
                        }
                        else if (getDistance(RG2paranteza1.Location, raspunsuri[2].Location) < 40)
                        {
                            if (i == 14 || i == 6 || i == 7) raspunsuri[i].ForeColor = Color.Green;
                        }
                        else if (getDistance(RG3paranteza1.Location, raspunsuri[2].Location) < 40)
                        {
                            if (i == 15 || i == 9 || i == 10) raspunsuri[i].ForeColor = Color.Green;
                        }
                    }
                }
                if (questionNumber == 6)
                {
                    var taskDelay = Task.Delay(2000);
                    await taskDelay;
                    removeControl(workSpace, setAnswer, answer, Matrix1, Matrix2, Matrix3, M1paranteza1);
                    removeControl(M1paranteza2, M2paranteza1, M2paranteza2, M3paranteza1, M3paranteza2, and, Comma);
                    removeControl(nrIntrebare, Completion, question, MatrixA, MatrixB, MatrixC, puncte);
                    for (int i = 0; i < raspunsuri.Length; i++) this.Controls.Remove(raspunsuri[i]);
                    this.Controls.Add(testEnding);
                    testEnding.Text = "Testul s-a terminat. Ai luat: " + points.ToString() +  " puncte";
                    Console.WriteLine(testNota3);
                    if (testNota1 == string.Empty)
                    {
                        string Query = string.Format("UPDATE Elevi SET NotaTest1='{0}' WHERE Email='{1}';", points.ToString(), MyData.e_mail);
                        MyData.writeData("Elevi", Query);
                    }
                    else if (testNota1 != string.Empty && testNota2 == string.Empty)
                    {
                        string Query = string.Format("UPDATE Elevi SET NotaTest2='{0}' WHERE Email='{1}';", points.ToString(), MyData.e_mail);
                        MyData.writeData("Elevi", Query);
                    }
                    else if (testNota1 != string.Empty && testNota2 != string.Empty && testNota3 == string.Empty)
                    {
                        string Query = string.Format("UPDATE Elevi SET NotaTest3='{0}' WHERE Email='{1}';", points.ToString(), MyData.e_mail);
                        MyData.writeData("Elevi", Query);
                    }
                    ceas.Enabled = false;
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Platforma platform = new Platforma();
            platform.Show();
            this.Hide();
        }

        private void ceas_Tick(object sender, EventArgs e)
        {
            time--;
            timp.Text = "Timp ramas: " + time / 60  + " minute si " + time % 60 + " secunde";
            if (time == 0)
            {
                timp.Text = "Timp ramas: " + time % 60 + " secunde";
                removeControl(workSpace, setAnswer, answer, Matrix1, Matrix2, Matrix3, M1paranteza1);
                removeControl(M1paranteza2, M2paranteza1, M2paranteza2, M3paranteza1, M3paranteza2, and, Comma);
                removeControl(nrIntrebare, Completion, question, MatrixA, MatrixB, MatrixC, puncte);
                for (int i = 0; i < raspunsuri.Length; i++) this.Controls.Remove(raspunsuri[i]);
                this.Controls.Add(testEnding);
                testEnding.Text = "Timpul a expirat. Ai luat: " + points.ToString() + " puncte";
                ceas.Enabled = false;
            }
            else if (time < 60)
            {
                timp.Text = "Timp ramas: " + time % 60 + " secunde";
            }
        }

        private void nextQuestion_Click(object sender, EventArgs e)
        {
            Randomizer();
            if (questionNumber < 6) questionNumber++;
            nrIntrebare.Text = questionNumber.ToString() + ".";
            //this.Controls.Add(setAnswer);
            nextQuestion.Enabled = false;
            setAnswer.Enabled = true;
            for (int i = 0; i < raspunsuri.Length; i++) raspunsuri[i].ForeColor = Color.Black;
            if (question.Text == intrebari[0])
            {
                question.Text = intrebari[1];
                addControl(R1paranteza2, RG1paranteza1, RG1paranteza2, RG2paranteza1, RG2paranteza2, RG3paranteza1, RG3paranteza2);
                Completion.Text = "Se dau matricele: ";
                this.Controls.Add(MatrixC);
                and.Location = new Point(420, 120);
                this.Controls.Add(M1paranteza1);
                M1paranteza1.Location = new Point(210, 88);
                M1paranteza1.BringToFront();
                M1paranteza1.Size = new Size(31, 73);
                Matrix1.Location = new Point(230, 100);
                Matrix1.Size = new Size(25, 60);
                Matrix2.Size = new Size(75, 60);
                Matrix1.BringToFront();
                M1paranteza2.Location = new Point(250, 88);
                RC.Size = new Size(75, 65);
                RG1.Size = new Size(75, 65);
                RG2.Size = new Size(75, 65);
                RG3.Size = new Size(75, 65);
                R1paranteza1.Location = new Point(25, 290);
                R1paranteza1.Size = new Size(31, 73);
                R1paranteza1.Text = "(";

                R1paranteza2.Location = new Point(115, 290);
                R1paranteza2.Size = new Size(31, 73);
                R1paranteza2.Text = ")";

                RG1paranteza1.Location = new Point(305, 290);
                RG1paranteza1.Size = new Size(31, 73);
                RG1paranteza1.Text = "(";

                RG1paranteza2.Location = new Point(395, 290);
                RG1paranteza2.Size = new Size(31, 73);
                RG1paranteza2.Text = ")";

                RG2paranteza1.Location = new Point(585, 290);
                RG2paranteza1.Size = new Size(31, 73);
                RG2paranteza1.Text = "(";

                RG2paranteza2.Location = new Point(675, 290);
                RG2paranteza2.Size = new Size(31, 73);
                RG2paranteza2.Text = ")";

                RG3paranteza1.Location = new Point(865, 290);
                RG3paranteza1.Size = new Size(31, 73);
                RG3paranteza1.Text = "(";

                RG3paranteza2.Location = new Point(955, 290);
                RG3paranteza2.Size = new Size(31, 73);
                RG3paranteza2.Text = ")";
                Matrix2.Location = new Point(325, 120);
                Matrix2.BringToFront();
                M2paranteza1.Location = new Point(305, 100);
                M2paranteza2.Location = new Point(390, 100);
                MatrixB.Location = new Point(280, 120);
                this.Controls.Add(Matrix3);
                this.Controls.Add(Comma);
                this.Controls.Add(M3paranteza1);
                this.Controls.Add(M3paranteza2);
                Matrix3.Location = new Point(490, 100);
                Comma.BringToFront();
                Comma.Location = new Point(270, 120);
                M2paranteza1.Font = new Font("Tahoma", 30);
                M2paranteza2.Font = new Font("Tahoma", 30);
                M3paranteza1.BringToFront();
                Matrix3.BringToFront();
                for (int i = 0; i < raspunsuri.Length; i++)
                {
                    if (i == 0 || i == 1 || i == 3 || i == 4 || i == 6 || i == 7 || i == 9 || i == 10) raspunsuri[i].Font = new Font("Century Gothic", 43);
                }
                Matrix1.Text = e2m1[0, 0] + Environment.NewLine + " " + e2m1[1, 0] + Environment.NewLine + " " + e2m1[2, 0];
                Matrix2.Text = e2m2[0, 0] + "   " + e2m2[0, 1] + "   " + e2m2[0, 2];
                Matrix3.Text = e2m3[0, 0] + "  " + e2m3[0, 1] + "  " + e2m3[0, 2] + Environment.NewLine + " " + e2m3[1, 0] + " " + e2m3[1, 1] + " " + e2m3[1, 2] + Environment.NewLine + " " + e2m3[2, 0] + "  " + e2m3[2, 1] + " " + e2m3[2, 2];
                RC.Text = e2RaspunsCorect[0, 0] + "   " + e2RaspunsCorect[0, 1] + "  " + e2RaspunsCorect[0, 2] + Environment.NewLine + " " + e2RaspunsCorect[1, 0] + "   " + e2RaspunsCorect[1, 1] + "   " + e2RaspunsCorect[1, 2] + Environment.NewLine + " " + e2RaspunsCorect[2, 0] + "  " + e2RaspunsCorect[2, 1] + "  " + e2RaspunsCorect[2, 2];
                RG1.Text = e2RaspunsGresit1[0, 0] + "   " + e2RaspunsGresit1[0, 1] + "   " + e2RaspunsGresit1[0, 2] + Environment.NewLine + " " + e2RaspunsGresit1[1, 0] + "   " + e2RaspunsGresit1[1, 1] + "   " + e2RaspunsGresit1[1, 2] + Environment.NewLine + " " + e2RaspunsGresit1[2, 0] + "  " + e2RaspunsGresit1[2, 1] + "  " + e2RaspunsGresit1[2, 2];
                RG2.Text = " " + e2RaspunsGresit2[0, 0] + "    " + e2RaspunsGresit2[0, 1] + "   " + e2RaspunsGresit2[0, 2] + Environment.NewLine + " " + e2RaspunsGresit2[1, 0] + "   " + e2RaspunsGresit2[1, 1] + "   " + e2RaspunsGresit2[1, 2] + Environment.NewLine + " " + e2RaspunsGresit2[2, 0] + "    " + e2RaspunsGresit2[2, 1] + "   " + e2RaspunsGresit2[2, 2];
                RG3.Text = " " + e2RaspunsGresit3[0, 0] + "    " + e2RaspunsGresit3[0, 1] + "  " + e2RaspunsGresit3[0, 2] + Environment.NewLine + " " + e2RaspunsGresit3[1, 0] + "    " + e2RaspunsGresit3[1, 1] + "   " + e2RaspunsGresit3[1, 2] + Environment.NewLine + " " + e2RaspunsGresit3[2, 0] + "   " + e2RaspunsGresit3[2, 1] + "  " + e2RaspunsGresit3[2, 2];
                questionGraveyard.Add(intrebari[0]);
                workSpace.Location = new Point(10, 410);
                answer.Location = new Point(290, 410);
                setAnswer.Location = new Point(570, 410);
                nextQuestion.Location = new Point(850, 410);
                for (int i = 1; i < choices.Length; i++)
                {
                    choices[0].Location = new Point(10, 320);
                    choices[i].Location = new Point(choices[i - 1].Location.X + 280, 320);
                }
                this.Height = 475;
            }
            else if (question.Text == intrebari[1])
            {
                question.Text = intrebari[2];
                Completion.Text = "Se da matricea: ";
                Completion.Size = new Size(140, 20);
                Matrix1.Location = new Point(220, 100);
                M1paranteza1.Location = new Point(200, 88);
                M1paranteza2.Location = new Point(270, 88);
                MatrixA.Location = new Point(170, 120);
                RG3.Size = new Size(60, 40);
                removeControl(MatrixB, M2paranteza1, M2paranteza2, MatrixC, M3paranteza1, M3paranteza2, Comma);
                removeControl(Matrix2, Matrix3, R1paranteza1, R1paranteza2, RG1paranteza1, RG1paranteza2, RG2paranteza1);
                removeControl(RG2paranteza2, RG3paranteza1, RG3paranteza2, and, null, null, null);
                for (int i = 0; i < raspunsuri.Length; i++)
                {
                    if (i == 0 || i == 1 || i == 3 || i == 4 || i == 6 || i == 7 || i == 9 || i == 10) raspunsuri[i].Font = new Font("Century Gothic", 43);
                }
                Comma.BringToFront();
                Comma.Location = new Point(198, 85);
                Matrix1.Text = e3m[0, 0] + " " + e3m[0, 1] + "  " + e3m[0, 2] + Environment.NewLine + " " + e3m[1, 0] + " " + e3m[1, 1] + " " + e3m[1, 2] + Environment.NewLine + " " + e3m[2, 0] + " " + e3m[2, 1] + "  " + e3m[2, 2];
                RC.Text = e3RaspunsCorect.ToString();
                RG1.Text = e3RaspunsGresit1.ToString();
                RG2.Text = e3RaspunsGresit2.ToString();
                RG3.Text = e3RaspunsGresit3.ToString();
                questionGraveyard.Add(intrebari[1]);
                workSpace.Location = new Point(10, 370);
                answer.Location = new Point(290, 370);
                setAnswer.Location = new Point(570, 370);
                nextQuestion.Location = new Point(850, 370);
                Matrix1.Size = new Size(56, 60);
                this.Height = 435;
                for (int i = 1; i < choices.Length; i++)
                {
                    choices[0].Location = new Point(10, 300);
                    choices[i].Location = new Point(choices[i - 1].Location.X + 280, 300);
                }
            }
            else if (question.Text == intrebari[2])
            {
                question.Text = intrebari[3];
                Completion.Text = "Se da matricea: ";
                removeControl(MatrixB, M2paranteza1, M2paranteza2, MatrixC, M3paranteza1, M3paranteza2, Comma);
                removeControl(Matrix2, Matrix3, R1paranteza1, R1paranteza2, RG1paranteza1, RG1paranteza2, RG2paranteza1);
                removeControl(RG2paranteza2, RG3paranteza1, RG3paranteza2, and, null, null, null);
                addControl(R1paranteza1, R1paranteza2, RG1paranteza1, RG1paranteza2, RG2paranteza1, RG2paranteza2, RG3paranteza1);
                addControl(RG3paranteza2, MatrixA, null, null, null, null, null);
                Matrix1.Size = new Size(38, 60);
                Matrix1.Location = new Point(220, 110);
                M1paranteza1.Location = new Point(200, 100);
                M1paranteza2.Location = new Point(250, 100);
                M1paranteza1.Font = new Font("Century Gothic", 30);
                M1paranteza2.Font = new Font("Century Gothic", 30);
                RC.Size = new Size(50, 60);
                RG1.Size = new Size(50, 60);
                RG2.Size = new Size(50, 60);
                RG3.Size = new Size(50, 60);
                R1paranteza1.Location = new Point(33, 290);
                R1paranteza2.Location = new Point(100, 290);
                RG1paranteza1.Location = new Point(310, 290);
                RG1paranteza2.Location = new Point(380, 290);
                RG2paranteza1.Location = new Point(590, 290);
                RG2paranteza2.Location = new Point(670, 290);
                RG3paranteza1.Location = new Point(870, 290);
                RG3paranteza2.Location = new Point(945, 290);
                for (int i = 0; i < raspunsuri.Length; i++)
                {
                    if (i == 0 || i == 1 || i == 3 || i == 4 || i == 6 || i == 7 || i == 9 || i == 10) raspunsuri[i].Font = new Font("Century Gothic", 30);
                }
                Matrix1.Text = e4m[0, 0] + " " + e4m[0, 1] + Environment.NewLine + e4m[1, 0] + " " + e4m[1, 1];
                for (int i = 0; i < solutions.Length; i++) solutions[i].Text = e3Answers[i].ToString();
                workSpace.Location = new Point(10, 410);
                answer.Location = new Point(290, 410);
                setAnswer.Location = new Point(570, 410);
                nextQuestion.Location = new Point(850, 410);
                RC.Text = "   " + e4RaspunsCorect[0, 0] + " " + e4RaspunsCorect[0, 1] + Environment.NewLine + e4RaspunsCorect[1, 0] + "  " + e4RaspunsCorect[1, 1];
                RG1.Text = "   " + e4RaspunsGresit1[0, 0] + "  " + e4RaspunsGresit1[0, 1] + Environment.NewLine + " " + e4RaspunsGresit1[1, 0] + "  " + e4RaspunsGresit1[1, 1];
                RG2.Text = "  " + e4RaspunsGresit2[0, 0] + "  " + e4RaspunsGresit2[0, 1] + Environment.NewLine + e4RaspunsGresit2[1, 0] + "  " + e4RaspunsGresit2[1, 1];
                RG3.Text = "  " + e4RaspunsGresit3[0, 0] + "  " + e4RaspunsGresit3[0, 1] + Environment.NewLine + " " + e4RaspunsGresit3[1, 0] + " " + e4RaspunsGresit3[1, 1];
                for (int i = 1; i < choices.Length; i++)
                {
                    choices[0].Location = new Point(10, 305);
                    choices[i].Location = new Point(choices[i - 1].Location.X + 280, 305);
                }
                this.Height = 475;
                questionGraveyard.Add(intrebari[2]);
                for (int i = 0; i < raspunsuri.Length; i++)
                { 
                    if (i == 0 || i == 1 || i == 3 || i == 4 || i == 6 || i == 7 || i == 9 || i == 10) raspunsuri[i].Font = new Font("Tahoma", 30);
                }
            }
            else if (question.Text == intrebari[3])
            {
                question.Text = intrebari[4];
                Completion.Text = "Se da matricea: ";
                Matrix1.Location = new Point(220, 110);
                M1paranteza1.Location = new Point(200, 100);
                M1paranteza2.Location = new Point(250, 100);
                M1paranteza1.Font = new Font("Century Gothic", 30);
                M1paranteza2.Font = new Font("Century Gothic", 30);
                Matrix1.Text = e5m[0, 0] + " " + e5m[0, 1] + Environment.NewLine + e5m[1, 0] + " " + e5m[1, 1];
                RC.Text = e5RaspunsCorect.ToString();
                RG1.Text = e5RaspunsGresit1.ToString();
                RG2.Text = e5RaspunsGresit2.ToString();
                RG3.Text = e5RaspunsGresit3.ToString();
                removeControl(Matrix2, M2paranteza1, M2paranteza2, Matrix3, M3paranteza1, M3paranteza2, R1paranteza1);
                removeControl(R1paranteza2, RG1paranteza1, RG1paranteza2, RG2paranteza1, RG2paranteza2, RG3paranteza1, RG3paranteza2);
                removeControl(Comma, MatrixC, MatrixB, and, Matrix2, MatrixB, null);
                addControl(null, MatrixA, null, null, null, null, null);
                removeControl(M3paranteza1, M3paranteza2, Matrix3, M2paranteza1, M2paranteza2, MatrixC, and);
                for (int i = 0; i < raspunsuri.Length; i++)
                {
                    if (i == 0 || i == 1 || i == 3 || i == 4 || i == 6 || i == 7 || i == 9 || i == 10) raspunsuri[i].Font = new Font("Tahoma", 20);
                }
                this.Height = 435;
                for (int i = 1; i < choices.Length; i++)
                {
                    choices[0].Location = new Point(15, 300);
                    choices[i].Location = new Point(choices[i - 1].Location.X + 285, 300);
                }
                for (int i = 0; i < solutions.Length; i++) solutions[i].Size = new Size(40, 40);
                questionGraveyard.Add(intrebari[3]);
                workSpace.Location = new Point(10, 370);
                answer.Location = new Point(290, 370);
                setAnswer.Location = new Point(570, 370);
                nextQuestion.Location = new Point(850, 370);
            }
            else if (question.Text == intrebari[4])
            {
                question.Text = intrebari[5];
                Completion.Size = new Size(150, 20);
                Completion.Text = "Se dau matricele: ";
                for (int i = 0; i < solutions.Length; i++) solutions[i].Text = e5Answers[i].ToString();
                M1paranteza1.Font = new Font("Century Gothic", 43);
                M1paranteza2.Font = new Font("Century Gothic", 43);
                M2paranteza1.Font = new Font("Century Gothic", 43);
                M2paranteza2.Font = new Font("Century Gothic", 43);
                M1paranteza1.Location = new Point(210, 88);
                M1paranteza2.Location = new Point(285, 88);
                M2paranteza1.Location = new Point(360, 88);
                M2paranteza2.Location = new Point(430, 88);
                M1paranteza2.BringToFront();
                Matrix1.Location = new Point(230, 98);
                Matrix2.Location = new Point(380, 98);
                RC.Size = new Size(150, 30);
                RG1.Size = new Size(150, 30);
                RG2.Size = new Size(150, 30);
                RG3.Size = new Size(150, 30);
                Matrix1.Text = " " + e6m1[0, 0] + " " + e6m1[0, 1] + " " + e6m1[0, 2] + Environment.NewLine + e6m1[1, 0] + " " + e6m1[1, 1] + "  " + e6m1[1, 2] + Environment.NewLine + " " + e6m1[2, 0] + " " + e6m1[2, 1] + " " + e6m1[2, 2];
                Matrix2.Text = " " + e6m2[0, 0] + " " + e6m2[0, 1] + " " + e6m2[0, 2] + Environment.NewLine + e6m2[1, 0] + " " + e6m2[1, 1] + " " + e6m2[1, 2] + Environment.NewLine + " " + e6m2[2, 0] + " " + e6m2[2, 1] + " " + e6m2[2, 2];
                RC.Text = e6RaspunsCorect;
                RG1.Text = e6RaspunsGresit1;
                RG2.Text = e6RaspunsGresit2;
                RG3.Text = e6RaspunsGresit3;
                addControl(MatrixA, MatrixB, and, Matrix2, M2paranteza1, M2paranteza2, null);
                removeControl(Matrix3, M3paranteza1, M3paranteza2, R1paranteza1, null, null, null);
                removeControl(R1paranteza2, RG1paranteza1, RG1paranteza2, RG2paranteza1, RG2paranteza2, RG3paranteza1, RG3paranteza2);
                removeControl(Comma, MatrixC, null, null, null, null, null);
                for (int i = 1; i < choices.Length; i++)
                {
                    choices[0].Location = new Point(10, 300);
                    choices[i].Location = new Point(choices[i - 1].Location.X + 280, 300);
                }
                questionGraveyard.Add(intrebari[4]);
                workSpace.Location = new Point(10, 370);
                answer.Location = new Point(290, 370);
                setAnswer.Location = new Point(570, 370);
                nextQuestion.Location = new Point(850, 370);
                this.Width = 1050;
                close.Location = new Point(1030, -2);
                back.Location = new Point(1000, -3);
                Matrix1.Size = new Size(63, 60);
                MatrixA.Location = new Point(180, 120);
                and.Location = new Point(305, 120);
                and.BringToFront();
                MatrixB.Location = new Point(335, 120);
                M2paranteza1.BringToFront();
                Matrix2.BringToFront();
                M2paranteza2.BringToFront();
            }
            if (questionNumber == 6)
            {
                this.Controls.Remove(nextQuestion);
                setAnswer.Location = new Point(850, 370);
                answer.Location = new Point(450, 370);
            }
        }

        private void workSpace_Click(object sender, EventArgs e)
        {
            if (workSpace.Text == "Deschide spatiul de lucru")
            {
                this.Controls.Add(spatiu);
                workSpace.Text = "Inchide spatiul de lucru";
            }
            else
            {
                this.Controls.Remove(spatiu);
                workSpace.Text = "Deschide spatiul de lucru";
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}