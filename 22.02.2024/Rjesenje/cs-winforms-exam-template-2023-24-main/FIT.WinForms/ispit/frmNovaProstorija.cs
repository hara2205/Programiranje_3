using FIT.Data.ispit;
using FIT.Infrastructure;
using FIT.Infrastructure.ispit;
using FIT.WinForms.Helpers;
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
    public partial class frmNovaProstorija : Form
    {
        DLWMSDbContext db = konekcija.db;
        private prostorija? prost = null;
        public frmNovaProstorija()
        {
            InitializeComponent();
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public frmNovaProstorija(prostorija obj)
        {
            InitializeComponent();
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            prost = obj;
            ucitajFormu();
        }

        private void ucitajFormu()
        {
            pbLogo.Image = prost.Logo.ToImage();
            txtNaziv.Text = prost.Naziv;
            txtOznaka.Text = prost.Oznaka;
            txtKapacitet.Text=prost.Kapacitet.ToString();

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.None))
            {
                if (prost == null)
                {
                    var naziv = txtNaziv.Text;
                    var oznaka = txtOznaka.Text;
                    int kapacitet = int.Parse(txtKapacitet.Text);
                    var logo = pbLogo.Image.ToByteArray();
                    prostorija nova = new prostorija()
                    {
                        Naziv = naziv,
                        Oznaka = oznaka,
                        Kapacitet = kapacitet,
                        Logo = logo,
                    };
                    db.Prostorije.Add(nova);
                    db.SaveChanges();
                    MessageBox.Show("Uspjesno ste dodali novu prostoriju!", "Info", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    prost.Naziv = txtNaziv.Text;
                    prost.Kapacitet=int.Parse(txtKapacitet.Text);
                    prost.Oznaka = txtOznaka.Text;
                    prost.Logo=pbLogo.Image.ToByteArray();
                    db.SaveChanges();
                    MessageBox.Show("Uspjesno ste izvrsili modifikaciju podataja!", "Info", MessageBoxButtons.OK);
                    this.Close();
                }
            }
        }

        private void pbLogo_DoubleClick(object sender, EventArgs e)
        {
            var rd = new OpenFileDialog();
            if (rd.ShowDialog() == DialogResult.OK)
            {
                pbLogo.Image = Image.FromFile(rd.FileName);
            }
        }

        private void pbLogo_Validating(object sender, CancelEventArgs e)
        {
            if (pbLogo.Image == null)
            {
                e.Cancel = true;
                errorProvider1.SetError(pbLogo, "Morate odabrati logo!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(pbLogo, null);
            }
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNaziv.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNaziv, "Morate unijeti naziv prostorije!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNaziv, null);
            }
        }

        private void lblOznaka_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtOznaka_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtOznaka.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtOznaka, "Morate unijeti oznaku!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtOznaka, null);
            }
        }

        private void txtKapacitet_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtKapacitet.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtKapacitet, "Morate unijeti kapacitet prostorije!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtKapacitet, null);
            }
        }
    }
}
