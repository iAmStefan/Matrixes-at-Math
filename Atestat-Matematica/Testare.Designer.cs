namespace Atestat_Matematica
{
    partial class Testare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.close = new System.Windows.Forms.Label();
            this.nrIntrebare = new System.Windows.Forms.Label();
            this.puncte = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.Button();
            this.setAnswer = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Label();
            this.ceas = new System.Windows.Forms.Timer(this.components);
            this.nextQuestion = new System.Windows.Forms.Button();
            this.workSpace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(969, -2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(23, 23);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // nrIntrebare
            // 
            this.nrIntrebare.AutoSize = true;
            this.nrIntrebare.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrIntrebare.Location = new System.Drawing.Point(10, 120);
            this.nrIntrebare.Name = "nrIntrebare";
            this.nrIntrebare.Size = new System.Drawing.Size(103, 21);
            this.nrIntrebare.TabIndex = 1;
            this.nrIntrebare.Text = "Nr intrebare";
            // 
            // puncte
            // 
            this.puncte.AutoSize = true;
            this.puncte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puncte.Location = new System.Drawing.Point(880, 30);
            this.puncte.Name = "puncte";
            this.puncte.Size = new System.Drawing.Size(74, 21);
            this.puncte.TabIndex = 2;
            this.puncte.Text = "Puncte: ";
            // 
            // answer
            // 
            this.answer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer.Location = new System.Drawing.Point(290, 410);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(130, 55);
            this.answer.TabIndex = 9;
            this.answer.Text = "Raspunde la intrebare";
            this.answer.UseVisualStyleBackColor = true;
            this.answer.Click += new System.EventHandler(this.answer_Click);
            // 
            // setAnswer
            // 
            this.setAnswer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setAnswer.Location = new System.Drawing.Point(570, 410);
            this.setAnswer.Name = "setAnswer";
            this.setAnswer.Size = new System.Drawing.Size(130, 55);
            this.setAnswer.TabIndex = 10;
            this.setAnswer.Text = "Blocheaza raspunsul";
            this.setAnswer.UseVisualStyleBackColor = true;
            this.setAnswer.Click += new System.EventHandler(this.setAnswer_Click);
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(936, -3);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(34, 23);
            this.back.TabIndex = 14;
            this.back.Text = "<-";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // ceas
            // 
            this.ceas.Enabled = true;
            this.ceas.Interval = 1000;
            this.ceas.Tick += new System.EventHandler(this.ceas_Tick);
            // 
            // nextQuestion
            // 
            this.nextQuestion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextQuestion.ForeColor = System.Drawing.Color.Black;
            this.nextQuestion.Location = new System.Drawing.Point(850, 410);
            this.nextQuestion.Name = "nextQuestion";
            this.nextQuestion.Size = new System.Drawing.Size(130, 55);
            this.nextQuestion.TabIndex = 15;
            this.nextQuestion.Text = "Urmatoare intrebare";
            this.nextQuestion.UseVisualStyleBackColor = true;
            this.nextQuestion.Click += new System.EventHandler(this.nextQuestion_Click);
            // 
            // workSpace
            // 
            this.workSpace.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workSpace.Location = new System.Drawing.Point(10, 410);
            this.workSpace.Name = "workSpace";
            this.workSpace.Size = new System.Drawing.Size(130, 55);
            this.workSpace.TabIndex = 16;
            this.workSpace.Text = "Deschide spatiul de lucru";
            this.workSpace.UseVisualStyleBackColor = true;
            this.workSpace.Click += new System.EventHandler(this.workSpace_Click);
            // 
            // Testare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(990, 475);
            this.Controls.Add(this.workSpace);
            this.Controls.Add(this.nextQuestion);
            this.Controls.Add(this.back);
            this.Controls.Add(this.setAnswer);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.puncte);
            this.Controls.Add(this.nrIntrebare);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Testare";
            this.Text = "Matrice la matematica";
            this.Load += new System.EventHandler(this.Testare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label nrIntrebare;
        private System.Windows.Forms.Label puncte;
        private System.Windows.Forms.Button answer;
        private System.Windows.Forms.Button setAnswer;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Timer ceas;
        private System.Windows.Forms.Button nextQuestion;
        private System.Windows.Forms.Button workSpace;
    }
}