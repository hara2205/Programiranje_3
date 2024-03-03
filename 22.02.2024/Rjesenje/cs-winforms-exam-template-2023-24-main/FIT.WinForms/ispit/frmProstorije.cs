using FIT.Infrastructure;
using FIT.Infrastructure.ispit;
using FIT.WinForms.Izvjestaji;
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
    public partial class frmProstorije : Form
    {
        DLWMSDbContext db = konekcija.db;
        List<dtoProstorije> listaProstorija = new List<dtoProstorije>();
        public frmProstorije()
        {
            InitializeComponent();
            dgvProstorije.AutoGenerateColumns = false;
            dgvProstorije.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ucitajPodatke();
        }

        private void ucitajPodatke()
        {
            dgvProstorije.DataSource = null;
            listaProstorija.Clear();
            var lista = db.Prostorije.ToList();
            if (lista.Count != 0)
            {
                foreach (var item in lista)
                    listaProstorija.Add(new dtoProstorije() { Prostorija = item });
                dgvProstorije.DataSource = listaProstorija;
            }
        }

        private void btnNova_Click(object sender, EventArgs e)
        {
            var frm = new frmNovaProstorija();
            frm.ShowDialog();
            ucitajPodatke();
        }

        private void dgvProstorije_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var obj = dgvProstorije.SelectedRows[0].DataBoundItem as dtoProstorije;
            var frm = new frmNovaProstorija(obj.Prostorija);
            frm.ShowDialog();
            ucitajPodatke();
        }

        private void dgvProstorije_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var obj = dgvProstorije.SelectedRows[0].DataBoundItem as dtoProstorije;
                var frm = new frmNastava(obj.Prostorija);
                frm.ShowDialog();
                ucitajPodatke();
            }
            else if (e.ColumnIndex == 6)
            {
                var obj = dgvProstorije.SelectedRows[0].DataBoundItem as dtoProstorije;
                var frm = new frmPrisustvo(obj.Prostorija);
                frm.ShowDialog();
                ucitajPodatke();
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var frm = new frmIzvjestaji();
            frm.ShowDialog();
        }
    }
}
