using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hediyelik_Eşya_Sitesi.UI
{
    public partial class FormSatis : Form
    {
        public FormSatis()
        {
            InitializeComponent();
        }

        public Satis Satis { get; set; }
        public bool Güncelleme {  get; set; } = false;

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(nmFiyat.Value == 0)
            {
                errorProvider1.SetError(nmFiyat, "Lütfen fiyat giriniz!");
                nmFiyat.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(nmFiyat, "");
            }

            Satis.Tarih = dtTarih.Value;
            Satis.Fiyat = (double)nmFiyat.Value;
            Satis.UrunID = Guid.Parse(txtUrun.Text);
            Satis.MusteriID = Guid.Parse(txtMusteri.Text);

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }

        private void btnMüşteriSeç_Click(object sender, EventArgs e)
        {
            Müşteriler form = new Müşteriler();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtMusteri.Text = form.Musteri.ID.ToString();
            }
        }

        private void btnÜrünSeç_Click(object sender, EventArgs e)
        {
            Ürünler form = new Ürünler();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUrun.Text = form.Urun.ID.ToString();
            }
        }

        private void FormSatis_Load(object sender, EventArgs e)
        {
            txtID.Text = Satis.ID.ToString();
            if (Güncelleme)
            {
                txtMusteri.Text = Satis.MusteriID.ToString();
                txtUrun.Text = Satis.UrunID.ToString();
                nmFiyat.Value = (decimal)Satis.Fiyat;
                dtTarih.Value = Satis.Tarih;
            }
        }
    }
}
