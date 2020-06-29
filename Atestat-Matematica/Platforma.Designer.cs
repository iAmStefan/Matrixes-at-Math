namespace Atestat_Matematica
{
    partial class Platforma
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
            this.close = new System.Windows.Forms.Label();
            this.invataMatrici = new System.Windows.Forms.Button();
            this.incepeTest = new System.Windows.Forms.Button();
            this.elev = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Label();
            this.noteTest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(779, -2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(23, 23);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // invataMatrici
            // 
            this.invataMatrici.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invataMatrici.Location = new System.Drawing.Point(227, 175);
            this.invataMatrici.Name = "invataMatrici";
            this.invataMatrici.Size = new System.Drawing.Size(143, 51);
            this.invataMatrici.TabIndex = 1;
            this.invataMatrici.Text = "Invata matricele\n";
            this.invataMatrici.UseVisualStyleBackColor = true;
            this.invataMatrici.Click += new System.EventHandler(this.invataMatrici_Click);
            // 
            // incepeTest
            // 
            this.incepeTest.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incepeTest.Location = new System.Drawing.Point(414, 175);
            this.incepeTest.Name = "incepeTest";
            this.incepeTest.Size = new System.Drawing.Size(143, 51);
            this.incepeTest.TabIndex = 2;
            this.incepeTest.Text = "Incepe testul";
            this.incepeTest.UseVisualStyleBackColor = true;
            this.incepeTest.Click += new System.EventHandler(this.incepeTest_Click);
            // 
            // elev
            // 
            this.elev.AutoSize = true;
            this.elev.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elev.Location = new System.Drawing.Point(2, 2);
            this.elev.Name = "elev";
            this.elev.Size = new System.Drawing.Size(40, 20);
            this.elev.TabIndex = 3;
            this.elev.Text = "Elev";
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(746, -2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(34, 23);
            this.back.TabIndex = 4;
            this.back.Text = "<-";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // noteTest
            // 
            this.noteTest.AutoSize = true;
            this.noteTest.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteTest.Location = new System.Drawing.Point(2, 31);
            this.noteTest.Name = "noteTest";
            this.noteTest.Size = new System.Drawing.Size(45, 20);
            this.noteTest.TabIndex = 5;
            this.noteTest.Text = "Note";
            // 
            // Platforma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.noteTest);
            this.Controls.Add(this.back);
            this.Controls.Add(this.elev);
            this.Controls.Add(this.incepeTest);
            this.Controls.Add(this.invataMatrici);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Platforma";
            this.Text = "Matrice la matematica";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Platforma_FormClosed);
            this.Load += new System.EventHandler(this.Platforma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Button invataMatrici;
        private System.Windows.Forms.Button incepeTest;
        private System.Windows.Forms.Label elev;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Label noteTest;
    }
}