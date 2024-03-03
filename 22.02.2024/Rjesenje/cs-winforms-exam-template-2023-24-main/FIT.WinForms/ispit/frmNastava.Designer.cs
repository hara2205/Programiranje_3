namespace FIT.WinForms.ispit
{
    partial class frmNastava
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
            lblProstorija = new Label();
            label2 = new Label();
            cmbPredmet = new ComboBox();
            label3 = new Label();
            cmbDan = new ComboBox();
            label4 = new Label();
            cmbVrijeme = new ComboBox();
            btnDodaj = new Button();
            dgvNastava = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            Dan = new DataGridViewTextBoxColumn();
            Vrijeme = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvNastava).BeginInit();
            SuspendLayout();
            // 
            // lblProstorija
            // 
            lblProstorija.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProstorija.Location = new Point(12, 9);
            lblProstorija.Name = "lblProstorija";
            lblProstorija.Size = new Size(776, 59);
            lblProstorija.TabIndex = 0;
            lblProstorija.Text = "Naziv prostorije - oznaka";
            lblProstorija.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "Predmet:";
            // 
            // cmbPredmet
            // 
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(12, 91);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(233, 28);
            cmbPredmet.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 68);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 3;
            label3.Text = "Dan:";
            // 
            // cmbDan
            // 
            cmbDan.FormattingEnabled = true;
            cmbDan.Location = new Point(268, 91);
            cmbDan.Name = "cmbDan";
            cmbDan.Size = new Size(174, 28);
            cmbDan.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(464, 68);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 5;
            label4.Text = "Vrijeme:";
            // 
            // cmbVrijeme
            // 
            cmbVrijeme.FormattingEnabled = true;
            cmbVrijeme.Location = new Point(464, 91);
            cmbVrijeme.Name = "cmbVrijeme";
            cmbVrijeme.Size = new Size(174, 28);
            cmbVrijeme.TabIndex = 6;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(644, 90);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(144, 29);
            btnDodaj.TabIndex = 7;
            btnDodaj.Text = "DODAJ";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvNastava
            // 
            dgvNastava.AllowUserToAddRows = false;
            dgvNastava.AllowUserToDeleteRows = false;
            dgvNastava.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNastava.Columns.AddRange(new DataGridViewColumn[] { Predmet, Dan, Vrijeme });
            dgvNastava.Location = new Point(12, 134);
            dgvNastava.Name = "dgvNastava";
            dgvNastava.ReadOnly = true;
            dgvNastava.RowHeadersWidth = 51;
            dgvNastava.RowTemplate.Height = 29;
            dgvNastava.Size = new Size(776, 304);
            dgvNastava.TabIndex = 8;
            // 
            // Predmet
            // 
            Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Predmet.DataPropertyName = "Predmet";
            Predmet.HeaderText = "Predmet";
            Predmet.MinimumWidth = 6;
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
            // 
            // Dan
            // 
            Dan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dan.DataPropertyName = "Dan";
            Dan.HeaderText = "Dan";
            Dan.MinimumWidth = 6;
            Dan.Name = "Dan";
            Dan.ReadOnly = true;
            // 
            // Vrijeme
            // 
            Vrijeme.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Vrijeme.DataPropertyName = "Vrijeme";
            Vrijeme.HeaderText = "Vrijeme";
            Vrijeme.MinimumWidth = 6;
            Vrijeme.Name = "Vrijeme";
            Vrijeme.ReadOnly = true;
            // 
            // frmNastava
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvNastava);
            Controls.Add(btnDodaj);
            Controls.Add(cmbVrijeme);
            Controls.Add(label4);
            Controls.Add(cmbDan);
            Controls.Add(label3);
            Controls.Add(cmbPredmet);
            Controls.Add(label2);
            Controls.Add(lblProstorija);
            Name = "frmNastava";
            Text = "Nastava";
            ((System.ComponentModel.ISupportInitialize)dgvNastava).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProstorija;
        private Label label2;
        private ComboBox cmbPredmet;
        private Label label3;
        private ComboBox cmbDan;
        private Label label4;
        private ComboBox cmbVrijeme;
        private Button btnDodaj;
        private DataGridView dgvNastava;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Dan;
        private DataGridViewTextBoxColumn Vrijeme;
    }
}