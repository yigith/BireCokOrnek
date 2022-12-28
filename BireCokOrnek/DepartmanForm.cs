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
    public partial class DepartmanForm : Form
    {
        private readonly UygulamaDbContext _db;
        private readonly Departman _departman;

        public DepartmanForm(UygulamaDbContext db, Departman departman = null)
        {
            _db = db;
            _departman = departman;

            InitializeComponent();

            if (_departman != null)
            {
                txtAd.Text = departman.Ad;
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();

            if (ad == "")
            {
                MessageBox.Show("Ad girmediniz.");
                return;
            }

            if (_departman == null)
            {
                _db.Add(new Departman() { Ad = ad });
            }
            else
            {
                _departman.Ad = ad;
            }
            _db.SaveChanges();
            DialogResult = DialogResult.OK;
        }
    }
}
