using BireCokOrnek.Data;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.Arm;

namespace BireCokOrnek
{
    public partial class Form1 : Form
    {
        UygulamaDbContext db = new UygulamaDbContext();

        public Form1()
        {
            InitializeComponent();
            DepartmanlariListele();
        }

        private void DepartmanlariListele()
        {
            lstDepartmanlar.DataSource = db.Departmanlar.Include(x => x.Calisanlar).ToList();
        }

        private void lstDepartmanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalisanlariListele();
        }

        private void CalisanlariListele()
        {
            if (lstDepartmanlar.SelectedIndex < 0) return;
            Departman dep = (Departman)lstDepartmanlar.SelectedItem;
            dgvCalisanlar.DataSource = null;
            dgvCalisanlar.DataSource = dep.Calisanlar;
            dgvCalisanlar.Columns[3].Visible = false;
        }

        private void btnYeniDepartman_Click(object sender, EventArgs e)
        {
            var frm = new DepartmanForm(db);
            DialogResult dr = frm.ShowDialog();

            if (dr == DialogResult.OK)
            {
                DepartmanlariListele();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstDepartmanlar.SelectedIndex < 0)
                return;
            Departman dep = (Departman)lstDepartmanlar.SelectedItem;
            db.Remove(dep);
            db.SaveChanges();
            DepartmanlariListele();

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (lstDepartmanlar.SelectedIndex < 0)
                return;
            Departman dep = (Departman)lstDepartmanlar.SelectedItem;

            var frm = new DepartmanForm(db, dep);
            DialogResult dr = frm.ShowDialog();

            if (dr == DialogResult.OK)
            {
                DepartmanlariListele();
                lstDepartmanlar.SelectedItem = dep;
            }
        }

        private void btnCalisaniDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvCalisanlar.SelectedRows.Count < 0)
            {
                MessageBox.Show("Düzenlemek istediğiniz çalışanı seçiniz.");
                return;
            }

            Calisan calisan = (Calisan)dgvCalisanlar.SelectedRows[0].DataBoundItem;
            var frm = new CalisanForm(db, calisan);
            DialogResult dr = frm.ShowDialog();

            if (dr == DialogResult.OK)
            {
                CalisanlariListele();
                foreach (DataGridViewRow satir in dgvCalisanlar.Rows)
                {
                    satir.Selected = satir.DataBoundItem == calisan;
                }
            }
        }

        private void btnYeniCalisan_Click(object sender, EventArgs e)
        {
            var frm = new CalisanForm(db);
            DialogResult dr = frm.ShowDialog();

            if (dr == DialogResult.OK)
            {
                CalisanlariListele();
            }
        }

        private void btnCalisaniSil_Click(object sender, EventArgs e)
        {
            if (dgvCalisanlar.SelectedRows.Count < 0)
            {
                MessageBox.Show("Silmek istediğiniz çalışanı seçiniz.");
                return;
            }

            Calisan calisan = (Calisan)dgvCalisanlar.SelectedRows[0].DataBoundItem;
            db.Remove(calisan);
            db.SaveChanges();
            CalisanlariListele();
        }
    }
}