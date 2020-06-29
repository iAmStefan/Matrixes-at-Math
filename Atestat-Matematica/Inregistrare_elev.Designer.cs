namespace Atestat_Matematica
{
    partial class Inregistrare_elev
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.reParola = new System.Windows.Forms.TextBox();
            this.prenume = new System.Windows.Forms.TextBox();
            this.parola = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.nume = new System.Windows.Forms.TextBox();
            this.register = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.seePassword = new System.Windows.Forms.CheckBox();
            this.back = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(321, -2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(23, 23);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prenume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Parola";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Repeta parola";
            // 
            // reParola
            // 
            this.reParola.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reParola.Location = new System.Drawing.Point(126, 325);
            this.reParola.Name = "reParola";
            this.reParola.PasswordChar = '•';
            this.reParola.Size = new System.Drawing.Size(110, 21);
            this.reParola.TabIndex = 7;
            this.reParola.Leave += new System.EventHandler(this.reParola_Leave);
            // 
            // prenume
            // 
            this.prenume.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenume.Location = new System.Drawing.Point(124, 125);
            this.prenume.Name = "prenume";
            this.prenume.Size = new System.Drawing.Size(110, 21);
            this.prenume.TabIndex = 8;
            // 
            // parola
            // 
            this.parola.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parola.Location = new System.Drawing.Point(126, 275);
            this.parola.Name = "parola";
            this.parola.PasswordChar = '•';
            this.parola.Size = new System.Drawing.Size(110, 21);
            this.parola.TabIndex = 9;
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(124, 175);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(110, 21);
            this.username.TabIndex = 10;
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(126, 225);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(110, 21);
            this.email.TabIndex = 11;
            // 
            // nume
            // 
            this.nume.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nume.Location = new System.Drawing.Point(124, 75);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(110, 21);
            this.nume.TabIndex = 12;
            // 
            // register
            // 
            this.register.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.Location = new System.Drawing.Point(104, 373);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(121, 40);
            this.register.TabIndex = 13;
            this.register.Text = "Creare cont";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(71, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 30);
            this.label7.TabIndex = 14;
            this.label7.Text = "Inregistrare elev";
            // 
            // seePassword
            // 
            this.seePassword.AutoSize = true;
            this.seePassword.Location = new System.Drawing.Point(242, 279);
            this.seePassword.Name = "seePassword";
            this.seePassword.Size = new System.Drawing.Size(15, 14);
            this.seePassword.TabIndex = 15;
            this.seePassword.UseVisualStyleBackColor = true;
            this.seePassword.CheckedChanged += new System.EventHandler(this.seePassword_CheckedChanged);
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(289, -3);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(34, 23);
            this.back.TabIndex = 16;
            this.back.Text = "<-";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Inregistrare_elev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(342, 425);
            this.Controls.Add(this.back);
            this.Controls.Add(this.seePassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.register);
            this.Controls.Add(this.nume);
            this.Controls.Add(this.email);
            this.Controls.Add(this.username);
            this.Controls.Add(this.parola);
            this.Controls.Add(this.prenume);
            this.Controls.Add(this.reParola);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inregistrare_elev";
            this.Text = "Matrice la matematica";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Inregistrare_elev_FormClosed);
            this.Load += new System.EventHandler(this.Inregistrare_elev_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox reParola;
        private System.Windows.Forms.TextBox prenume;
        private System.Windows.Forms.TextBox parola;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox nume;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox seePassword;
        private System.Windows.Forms.Label back;
    }
}