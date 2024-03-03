using FIT.Data.ispit;
using FIT.Infrastructure;
using FIT.Infrastructure.ispit;
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
    public partial class frmNastava : Form
    {
        DLWMSDbContext db = konekcija.db;
        List<dtoNastava>listaNastave=new List<dtoNastava>();
        private prostorija obj;
        public frmNastava(prostorija pr)
        {
            InitializeComponent();
            dgvNastava.AutoGenerateColumns = false;
            dgvNastava.SelectionMode= DataGridViewSelectionMode.FullRowSelect;
            ucitajDane();
            ucitajVrijeme();
            ucitajPredmete();
            obj = pr;
            ucitajPodatke();
        }

        private void ucitajPodatke()
        {
            listaNastave.Clear();
            dgvNastava.DataSource = null;
            lblProstorija.Text=obj.ToString();
            var lista=db.Nastava.Where(p=>p.Prostorija.Id==obj.Id).ToList();
            if (lista.Count != 0)
            {
                foreach(var item in lista)
                {
                    listaNastave.Add(new dtoNastava() { Nastava = item });
                }
                dgvNastava.DataSource= listaNastave;
            }
        }

        private void ucitajPredmete()
        {
            var lista = db.Predmeti.ToList();
            cmbPredmet.ValueMember = "Id";
            cmbPredmet.DisplayMember = "Naziv";
            cmbPredmet.DataSource = lista;
            cmbPredmet.SelectedIndex = -1;
        }

        private void ucitajVrijeme()
        {
            List<string> lista = new List<string>();
            lista.Add("8 - 10");
            lista.Add("10 - 12");
            lista.Add("12 - 14");
            cmbVrijeme.DataSource= lista;
            cmbVrijeme.SelectedIndex = -1;
        }

        private void ucitajDane()
        {
            List<string> lista = new List<string>();
            lista.Add("Ponedjeljak");
            lista.Add("Utorak");
            lista.Add("Srijeda");
            lista.Add("Cetvrtak");
            lista.Add("Petak");
            lista.Add("Subota");
            cmbDan.DataSource = lista;
            cmbDan.SelectedIndex = -1;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (cmbDan.SelectedIndex == -1)
            {
                MessageBox.Show("Morate odabrati dan!", "Info", MessageBoxButtons.OK);
                return;
            }
            else if (cmbPredmet.SelectedIndex == -1)
            {
                MessageBox.Show("Morate odabrati predmet!", "Info", MessageBoxButtons.OK);
                return;
            }
            else if (cmbVrijeme.SelectedIndex == -1)
            {
                MessageBox.Show("Morate odabrati vrijeme!", "Info", MessageBoxButtons.OK);
                return;
            }
            var dan = cmbDan.SelectedItem.ToString();
            var vrijeme=cmbVrijeme.SelectedItem.ToString();
            var predmet = cmbPredmet.SelectedItem as predmet;
            var lista = db.Nastava.Where(p => p.Prostorija.Id == obj.Id);
            foreach (var item in lista) { 
            if(item.Dan==dan && item.Vrijeme ==vrijeme)
                {
                    MessageBox.Show($"U prostoriji {obj.Naziv} u {dan} u {vrijeme} vec ima nastava!", "Info", MessageBoxButtons.OK);
                    return;
                }
            }
            nastava nova = new nastava()
            {
                Prostorija = obj,
                Predmet = predmet,
                Dan = dan,
                Vrijeme = vrijeme,
                Oznaka = predmet.ToString() + " :: " + dan + " :: " + vrijeme
            };
            db.Nastava.Add(nova);
            db.SaveChanges();
            MessageBox.Show("Uspjesno ste dodali novu nastavu!", "Info", MessageBoxButtons.OK);
            ucitajPodatke();
        }
    }
}
