namespace Atestat_Matematica
{
    partial class Autentificare_elev
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
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.TextBox();
            this.parola = new System.Windows.Forms.TextBox();
            this.rememberMe = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.seePassword = new System.Windows.Forms.CheckBox();
            this.back = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(352, -1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(23, 23);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Parola";
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(115, 273);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(114, 43);
            this.login.TabIndex = 7;
            this.login.Text = "Autentificare";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(69, 87);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(121, 24);
            this.email.TabIndex = 8;
            // 
            // parola
            // 
            this.parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parola.Location = new System.Drawing.Point(69, 163);
            this.parola.Name = "parola";
            this.parola.PasswordChar = '•';
            this.parola.Size = new System.Drawing.Size(121, 24);
            this.parola.TabIndex = 9;
            // 
            // rememberMe
            // 
            this.rememberMe.AutoSize = true;
            this.rememberMe.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rememberMe.Location = new System.Drawing.Point(11, 222);
            this.rememberMe.Name = "rememberMe";
            this.rememberMe.Size = new System.Drawing.Size(127, 24);
            this.rememberMe.TabIndex = 10;
            this.rememberMe.Text = "Tine-ma minte";
            this.rememberMe.UseVisualStyleBackColor = true;
            this.rememberMe.CheckedChanged += new System.EventHandler(this.rememberMe_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Autentificare elev";
            // 
            // seePassword
            // 
            this.seePassword.AutoSize = true;
            this.seePassword.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seePassword.Location = new System.Drawing.Point(197, 170);
            this.seePassword.Name = "seePassword";
            this.seePassword.Size = new System.Drawing.Size(15, 14);
            this.seePassword.TabIndex = 12;
            this.seePassword.UseVisualStyleBackColor = true;
            this.seePassword.CheckedChanged += new System.EventHandler(this.seePassword_CheckedChanged);
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(319, -2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(34, 23);
            this.back.TabIndex = 13;
            this.back.Text = "<-";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Autentificare_elev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(374, 328);
            this.Controls.Add(this.back);
            this.Controls.Add(this.seePassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rememberMe);
            this.Controls.Add(this.parola);
            this.Controls.Add(this.email);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Autentificare_elev";
            this.Text = "Matrice la matematica";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Autentificare_elev_FormClosed);
            this.Load += new System.EventHandler(this.Autentificare_elev_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox parola;
        private System.Windows.Forms.CheckBox rememberMe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox seePassword;
        private System.Windows.Forms.Label back;
    }
}