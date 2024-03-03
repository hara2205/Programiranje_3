using FIT.Data;
using FIT.Data.ispit;
using FIT.Infrastructure;
using FIT.Infrastructure.ispit;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.ispit
{
    public partial class frmPrisustvo : Form
    {
        DLWMSDbContext db = konekcija.db;
        List<dtoPrisustvo> listaPrisustva = new List<dtoPrisustvo>();
        private prostorija obj;
        public frmPrisustvo(prostorija pr)
        {
            InitializeComponent();
            obj = pr;
            dgvPrisustvo.AutoGenerateColumns = false;
            dgvPrisustvo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ucitajNastavu();
            ucitajStudenta();
            ucitajPodatke();
        }

        private void ucitajPodatke()
        {
            lblProstorija.Text = obj.ToString();
            dgvPrisustvo.DataSource = null;
            listaPrisustva.Clear();
            var lista = db.Prisustvo.Where(x => x.Nastava.Prostorija.Id == obj.Id).ToList();
            if (lista.Count != 0)
            {
                foreach (var item in lista)
                {
                    listaPrisustva.Add(new dtoPrisustvo { Prisustvo = item });
                }
                dgvPrisustvo.DataSource = listaPrisustva;
                lblKapacitet.Text = listaPrisustva.Count.ToString() + "/" + obj.Kapacitet.ToString();
                if (listaPrisustva.Count == obj.Kapacitet)
                {
                    btnDodaj.Enabled = false;
                    btnGenerisi.Enabled = false;
                }
            }
        }

        private void ucitajStudenta()
        {
            var lista = db.Studenti.ToList();
            cmbStudenti.ValueMember = "Id";
            cmbStudenti.DisplayMember = "Indeks" + "Ime" + "Prezime";
            cmbStudenti.DataSource = lista;
            cmbStudenti.SelectedIndex = -1;
        }

        private void ucitajNastavu()
        {
            var lista = db.Nastava.Where(p => p.Prostorija.Id == obj.Id).ToList();
            cmbNastava.ValueMember = "Id";
            cmbNastava.DisplayMember = "Oznaka";
            cmbNastava.DataSource = lista;
            cmbNastava.SelectedIndex = -1;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (cmbNastava.SelectedIndex == -1)
            {
                MessageBox.Show("Morate odabrati predmet", "Info", MessageBoxButtons.OK);
                return;
            }
            else if (cmbStudenti.SelectedIndex == -1)
            {
                MessageBox.Show("Morate odabrati studenta", "Info", MessageBoxButtons.OK);
                return;
            }
            var nastava = cmbNastava.SelectedItem as nastava;
            var student = cmbStudenti.SelectedItem as Student;
            var novo = new prisustvo()
            {
                Nastava = nastava,
                Student = student
            };
            db.Prisustvo.Add(novo);
            db.SaveChanges();
            MessageBox.Show("Uspjesno ste evidentirali novo prisustvo!", "Info", MessageBoxButtons.OK);
            ucitajPodatke();
        }

        private void btnGenerisi_Click(object sender, EventArgs e)
        {
            if(cmbStudenti.SelectedIndex == -1)
            {
                MessageBox.Show("Morate odabrati studenta", "Info", MessageBoxButtons.OK);
                return;
            }
            else if(cmbNastava.SelectedIndex == -1) {
                MessageBox.Show("Morate odabrati nastavu!", "Info", MessageBoxButtons.OK);
                return;
            }
            else if(string.IsNullOrEmpty(txtBroj.Text)) {
                MessageBox.Show("Morate odabrati broj zapisa!", "Info", MessageBoxButtons.OK);
                return;
            } 
            var nastava = cmbNastava.SelectedItem as nastava;
            var student = cmbStudenti.SelectedItem as Student;
            int brojZapisa=int.Parse(txtBroj.Text);
            if (brojZapisa + listaPrisustva.Count >= obj.Kapacitet)
            {
                MessageBox.Show("Nije moguce dodati toliko podataka!", "Info", MessageBoxButtons.OK);
                return;
            }
            var thread = new Thread(() => GenerisiThread(brojZapisa, nastava, student));
            txtInfo.ScrollBars = ScrollBars.Vertical;
            thread.Start();
        }

        private void GenerisiThread(int brojZapisa, nastava? nastava, Student? student)
        {
            for (int i = 0; i < brojZapisa; i++)
            {
                var novo = new prisustvo()
                {
                    Nastava = nastava,
                    Student=student
                };
                db.Prisustvo.Add(novo);
                db.SaveChanges();
                Action action = () =>
                {
                    txtInfo.Text += $"{DateTime.Now.ToString()} -> {student.ToString()}" +
                    $" za {nastava.ToString()}" +Environment.NewLine;
                };
                BeginInvoke(action);
                BeginInvoke(ucitajPodatke);
                Thread.Sleep(300);
            }
            MessageBox.Show("Uspjesno ste generisali podatke!", "Info", MessageBoxButtons.OK);
        }
    }
}
