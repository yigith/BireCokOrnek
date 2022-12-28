using BireCokOrnek.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BireCokOrnek
{
    public partial class CalisanForm : Form
    {
        private readonly UygulamaDbContext _db;
        private readonly Calisan _calisan;

        public CalisanForm(UygulamaDbContext db, Calisan calisan = null)
        {
            _db = db;
            _calisan = calisan;
            InitializeComponent();
            cboDepartman.DataSource = _db.Departmanlar.ToList();

            if (_calisan != null)
            {
                txtAd.Text = _calisan.Ad;
                txtSoyad.Text = _calisan.Soyad;
                cboDepartman.SelectedItem = _calisan.Departman;
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            Departman dep = (Departman)cboDepartman.SelectedItem;

            if (ad == "" || dep == null)
            {
                MessageBox.Show("Ad alanı ve departman seçimi zorunludur.");
                return;
            }

            if (_calisan == null)
            {
                _db.Add(new Calisan()
                {
                    Ad = ad,
                    Soyad = soyad,
                    Departman = dep
                });
            }
            else
            {
                _calisan.Ad = ad;
                _calisan.Soyad = soyad;
                _calisan.Departman = dep;
            }
            _db.SaveChanges();
            DialogResult = DialogResult.OK;
        }
    }
}
