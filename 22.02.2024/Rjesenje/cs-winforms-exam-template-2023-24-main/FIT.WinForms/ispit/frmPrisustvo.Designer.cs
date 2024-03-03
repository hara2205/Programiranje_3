namespace FIT.WinForms.ispit
{
    partial class frmPrisustvo
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
            label1 = new Label();
            cmbNastava = new ComboBox();
            label2 = new Label();
            cmbStudenti = new ComboBox();
            btnDodaj = new Button();
            dgvPrisustvo = new DataGridView();
            Oznaka = new DataGridViewTextBoxColumn();
            Student = new DataGridViewTextBoxColumn();
            gbGenerator = new GroupBox();
            txtInfo = new TextBox();
            label4 = new Label();
            btnGenerisi = new Button();
            txtBroj = new TextBox();
            label3 = new Label();
            lblProstorija = new Label();
            lblKapacitet = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPrisustvo).BeginInit();
            gbGenerator.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 62);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "Nastava:";
            // 
            // cmbNastava
            // 
            cmbNastava.FormattingEnabled = true;
            cmbNastava.Location = new Point(12, 85);
            cmbNastava.Name = "cmbNastava";
            cmbNastava.Size = new Size(330, 28);
            cmbNastava.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(348, 59);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 2;
            label2.Text = "Student:";
            // 
            // cmbStudenti
            // 
            cmbStudenti.FormattingEnabled = true;
            cmbStudenti.Location = new Point(348, 85);
            cmbStudenti.Name = "cmbStudenti";
            cmbStudenti.Size = new Size(340, 28);
            cmbStudenti.TabIndex = 3;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(694, 84);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(94, 29);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "DODAJ";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvPrisustvo
            // 
            dgvPrisustvo.AllowUserToAddRows = false;
            dgvPrisustvo.AllowUserToDeleteRows = false;
            dgvPrisustvo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrisustvo.Columns.AddRange(new DataGridViewColumn[] { Oznaka, Student });
            dgvPrisustvo.Location = new Point(12, 119);
            dgvPrisustvo.Name = "dgvPrisustvo";
            dgvPrisustvo.ReadOnly = true;
            dgvPrisustvo.RowHeadersWidth = 51;
            dgvPrisustvo.RowTemplate.Height = 29;
            dgvPrisustvo.Size = new Size(776, 188);
            dgvPrisustvo.TabIndex = 5;
            // 
            // Oznaka
            // 
            Oznaka.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Oznaka.DataPropertyName = "Oznaka";
            Oznaka.HeaderText = "Predmet, prostorija, vrijeme";
            Oznaka.MinimumWidth = 6;
            Oznaka.Name = "Oznaka";
            Oznaka.ReadOnly = true;
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "Student";
            Student.HeaderText = "Student";
            Student.MinimumWidth = 6;
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // gbGenerator
            // 
            gbGenerator.Controls.Add(txtInfo);
            gbGenerator.Controls.Add(label4);
            gbGenerator.Controls.Add(btnGenerisi);
            gbGenerator.Controls.Add(txtBroj);
            gbGenerator.Controls.Add(label3);
            gbGenerator.Location = new Point(12, 313);
            gbGenerator.Name = "gbGenerator";
            gbGenerator.Size = new Size(776, 225);
            gbGenerator.TabIndex = 6;
            gbGenerator.TabStop = false;
            gbGenerator.Text = "Generator";
            // 
            // txtInfo
            // 
            txtInfo.BackColor = SystemColors.Info;
            txtInfo.Location = new Point(6, 99);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(764, 112);
            txtInfo.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 76);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 9;
            label4.Text = "Info:";
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(236, 32);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(94, 29);
            btnGenerisi.TabIndex = 7;
            btnGenerisi.Text = "GENERIŠI";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // txtBroj
            // 
            txtBroj.Location = new Point(97, 32);
            txtBroj.Name = "txtBroj";
            txtBroj.Size = new Size(125, 27);
            txtBroj.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 35);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 7;
            label3.Text = "Broj zapisa:";
            // 
            // lblProstorija
            // 
            lblProstorija.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProstorija.Location = new Point(12, 3);
            lblProstorija.Name = "lblProstorija";
            lblProstorija.Size = new Size(377, 59);
            lblProstorija.TabIndex = 11;
            lblProstorija.Text = "Naziv prostorije - oznaka";
            lblProstorija.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblKapacitet
            // 
            lblKapacitet.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKapacitet.Location = new Point(417, 3);
            lblKapacitet.Name = "lblKapacitet";
            lblKapacitet.Size = new Size(377, 59);
            lblKapacitet.TabIndex = 12;
            lblKapacitet.Text = "kapacitet";
            lblKapacitet.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frmPrisustvo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 550);
            Controls.Add(lblKapacitet);
            Controls.Add(lblProstorija);
            Controls.Add(gbGenerator);
            Controls.Add(dgvPrisustvo);
            Controls.Add(btnDodaj);
            Controls.Add(cmbStudenti);
            Controls.Add(label2);
            Controls.Add(cmbNastava);
            Controls.Add(label1);
            Name = "frmPrisustvo";
            Text = "Evidencija nastave";
            ((System.ComponentModel.ISupportInitialize)dgvPrisustvo).EndInit();
            gbGenerator.ResumeLayout(false);
            gbGenerator.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbNastava;
        private Label label2;
        private ComboBox cmbStudenti;
        private Button btnDodaj;
        private DataGridView dgvPrisustvo;
        private GroupBox gbGenerator;
        private TextBox txtInfo;
        private Label label4;
        private Button btnGenerisi;
        private TextBox txtBroj;
        private Label label3;
        private Label lblProstorija;
        private Label lblKapacitet;
        private DataGridViewTextBoxColumn Oznaka;
        private DataGridViewTextBoxColumn Student;
    }
}