namespace Atestat_Matematica
{
    partial class Lectii
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lectii));
            this.informatii = new AxAcroPDFLib.AxAcroPDF();
            this.close = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Label();
            this.intro = new System.Windows.Forms.Button();
            this.equality = new System.Windows.Forms.Button();
            this.operations = new System.Windows.Forms.Button();
            this.mainDiagonal = new System.Windows.Forms.Button();
            this.transposed = new System.Windows.Forms.Button();
            this.properties = new System.Windows.Forms.Button();
            this.determinants = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.informatii)).BeginInit();
            this.SuspendLayout();
            // 
            // informatii
            // 
            this.informatii.Enabled = true;
            this.informatii.Location = new System.Drawing.Point(159, 25);
            this.informatii.Name = "informatii";
            this.informatii.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("informatii.OcxState")));
            this.informatii.Size = new System.Drawing.Size(731, 495);
            this.informatii.TabIndex = 1;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(877, -2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(23, 23);
            this.close.TabIndex = 2;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(838, -3);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(34, 23);
            this.back.TabIndex = 3;
            this.back.Text = "<-";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // intro
            // 
            this.intro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intro.Location = new System.Drawing.Point(5, 25);
            this.intro.Name = "intro";
            this.intro.Size = new System.Drawing.Size(150, 45);
            this.intro.TabIndex = 4;
            this.intro.Text = "Introducere";
            this.intro.UseVisualStyleBackColor = true;
            this.intro.Click += new System.EventHandler(this.intro_Click);
            // 
            // equality
            // 
            this.equality.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equality.Location = new System.Drawing.Point(5, 100);
            this.equality.Name = "equality";
            this.equality.Size = new System.Drawing.Size(150, 45);
            this.equality.TabIndex = 5;
            this.equality.Text = "Egalitatea matricelor";
            this.equality.UseVisualStyleBackColor = true;
            this.equality.Click += new System.EventHandler(this.equality_Click);
            // 
            // operations
            // 
            this.operations.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operations.Location = new System.Drawing.Point(5, 175);
            this.operations.Name = "operations";
            this.operations.Size = new System.Drawing.Size(150, 45);
            this.operations.TabIndex = 6;
            this.operations.Text = "Operatii cu matrice";
            this.operations.UseVisualStyleBackColor = true;
            this.operations.Click += new System.EventHandler(this.operations_Click);
            // 
            // mainDiagonal
            // 
            this.mainDiagonal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainDiagonal.Location = new System.Drawing.Point(5, 325);
            this.mainDiagonal.Name = "mainDiagonal";
            this.mainDiagonal.Size = new System.Drawing.Size(150, 45);
            this.mainDiagonal.TabIndex = 7;
            this.mainDiagonal.Text = "Urma matricei";
            this.mainDiagonal.UseVisualStyleBackColor = true;
            this.mainDiagonal.Click += new System.EventHandler(this.mainDiagonal_Click);
            // 
            // transposed
            // 
            this.transposed.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transposed.Location = new System.Drawing.Point(5, 400);
            this.transposed.Name = "transposed";
            this.transposed.Size = new System.Drawing.Size(150, 45);
            this.transposed.TabIndex = 8;
            this.transposed.Text = "Transpusa matricei";
            this.transposed.UseVisualStyleBackColor = true;
            this.transposed.Click += new System.EventHandler(this.transposed_Click);
            // 
            // properties
            // 
            this.properties.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.properties.Location = new System.Drawing.Point(5, 250);
            this.properties.Name = "properties";
            this.properties.Size = new System.Drawing.Size(150, 45);
            this.properties.TabIndex = 9;
            this.properties.Text = "Proprietatile matricelor";
            this.properties.UseVisualStyleBackColor = true;
            this.properties.Click += new System.EventHandler(this.properties_Click);
            // 
            // determinants
            // 
            this.determinants.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.determinants.Location = new System.Drawing.Point(5, 475);
            this.determinants.Name = "determinants";
            this.determinants.Size = new System.Drawing.Size(150, 45);
            this.determinants.TabIndex = 10;
            this.determinants.Text = "Determinanti";
            this.determinants.UseVisualStyleBackColor = true;
            this.determinants.Click += new System.EventHandler(this.determinants_Click);
            // 
            // Lectii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(900, 537);
            this.Controls.Add(this.determinants);
            this.Controls.Add(this.properties);
            this.Controls.Add(this.transposed);
            this.Controls.Add(this.mainDiagonal);
            this.Controls.Add(this.operations);
            this.Controls.Add(this.equality);
            this.Controls.Add(this.intro);
            this.Controls.Add(this.back);
            this.Controls.Add(this.close);
            this.Controls.Add(this.informatii);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lectii";
            this.Text = "Matrice la matematica";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Lectii_FormClosed);
            this.Load += new System.EventHandler(this.Lectii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.informatii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF informatii;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Button intro;
        private System.Windows.Forms.Button equality;
        private System.Windows.Forms.Button operations;
        private System.Windows.Forms.Button mainDiagonal;
        private System.Windows.Forms.Button transposed;
        private System.Windows.Forms.Button properties;
        private System.Windows.Forms.Button determinants;
    }
}