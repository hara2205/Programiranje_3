namespace FIT.WinForms.ispit
{
    partial class frmNovaProstorija
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            pbLogo = new PictureBox();
            label2 = new Label();
            txtNaziv = new TextBox();
            label3 = new Label();
            txtOznaka = new TextBox();
            label4 = new Label();
            txtKapacitet = new TextBox();
            btnSacuvaj = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Logo:";
            // 
            // pbLogo
            // 
            pbLogo.BackColor = SystemColors.ActiveCaption;
            pbLogo.Location = new Point(12, 32);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(216, 241);
            pbLogo.TabIndex = 1;
            pbLogo.TabStop = false;
            pbLogo.DoubleClick += pbLogo_DoubleClick;
            pbLogo.Validating += pbLogo_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 61);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(253, 84);
            txtNaziv.Multiline = true;
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(315, 47);
            txtNaziv.TabIndex = 3;
            txtNaziv.Validating += txtNaziv_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(253, 147);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 4;
            label3.Text = "Oznaka:";
            // 
            // txtOznaka
            // 
            txtOznaka.Location = new Point(253, 170);
            txtOznaka.Multiline = true;
            txtOznaka.Name = "txtOznaka";
            txtOznaka.Size = new Size(145, 47);
            txtOznaka.TabIndex = 5;
            txtOznaka.Validating += txtOznaka_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(423, 147);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 6;
            label4.Text = "kapacitet:";
            // 
            // txtKapacitet
            // 
            txtKapacitet.Location = new Point(423, 170);
            txtKapacitet.Multiline = true;
            txtKapacitet.Name = "txtKapacitet";
            txtKapacitet.Size = new Size(145, 47);
            txtKapacitet.TabIndex = 7;
            txtKapacitet.Validating += txtKapacitet_Validating;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(253, 223);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(315, 50);
            btnSacuvaj.TabIndex = 8;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmNovaProstorija
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 299);
            Controls.Add(btnSacuvaj);
            Controls.Add(txtKapacitet);
            Controls.Add(label4);
            Controls.Add(txtOznaka);
            Controls.Add(label3);
            Controls.Add(txtNaziv);
            Controls.Add(label2);
            Controls.Add(pbLogo);
            Controls.Add(label1);
            Name = "frmNovaProstorija";
            Text = "Podaci o prostoriji";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pbLogo;
        private Label label2;
        private TextBox txtNaziv;
        private Label label3;
        private TextBox txtOznaka;
        private Label label4;
        private TextBox txtKapacitet;
        private Button btnSacuvaj;
        private ErrorProvider errorProvider1;
    }
}