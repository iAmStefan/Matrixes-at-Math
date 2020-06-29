namespace Atestat_Matematica
{
    partial class Start
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
            this.authentication = new System.Windows.Forms.Button();
            this.registration = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Label();
            this.projectName = new System.Windows.Forms.Label();
            this.student = new System.Windows.Forms.Label();
            this.highschool = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // authentication
            // 
            this.authentication.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authentication.Location = new System.Drawing.Point(218, 277);
            this.authentication.Name = "authentication";
            this.authentication.Size = new System.Drawing.Size(130, 43);
            this.authentication.TabIndex = 0;
            this.authentication.Text = "Autentificare";
            this.authentication.UseVisualStyleBackColor = true;
            this.authentication.Click += new System.EventHandler(this.authentication_Click);
            // 
            // registration
            // 
            this.registration.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registration.Location = new System.Drawing.Point(354, 277);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(130, 43);
            this.registration.TabIndex = 1;
            this.registration.Text = "Inregistrare";
            this.registration.UseVisualStyleBackColor = true;
            this.registration.Click += new System.EventHandler(this.registration_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(679, -2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(23, 23);
            this.close.TabIndex = 2;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // projectName
            // 
            this.projectName.AutoSize = true;
            this.projectName.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectName.ForeColor = System.Drawing.Color.Black;
            this.projectName.Location = new System.Drawing.Point(124, 17);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(430, 44);
            this.projectName.TabIndex = 3;
            this.projectName.Text = "Matrice la matematică";
            // 
            // student
            // 
            this.student.AutoSize = true;
            this.student.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student.ForeColor = System.Drawing.Color.Black;
            this.student.Location = new System.Drawing.Point(305, 65);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(395, 39);
            this.student.TabIndex = 4;
            this.student.Text = "de Taloi Marius- Ștefănel";
            // 
            // highschool
            // 
            this.highschool.AutoSize = true;
            this.highschool.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highschool.ForeColor = System.Drawing.Color.Black;
            this.highschool.Location = new System.Drawing.Point(118, 113);
            this.highschool.Name = "highschool";
            this.highschool.Size = new System.Drawing.Size(502, 33);
            this.highschool.TabIndex = 5;
            this.highschool.Text = "Colegiul National ,,Gheorghe Titeica\"";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.highschool);
            this.Controls.Add(this.student);
            this.Controls.Add(this.projectName);
            this.Controls.Add(this.close);
            this.Controls.Add(this.registration);
            this.Controls.Add(this.authentication);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Start";
            this.Text = "Matrice la matematica";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button authentication;
        private System.Windows.Forms.Button registration;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label projectName;
        private System.Windows.Forms.Label student;
        private System.Windows.Forms.Label highschool;
    }
}

