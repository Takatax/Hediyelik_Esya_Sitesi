using Hediyelik_Eşya_Sitesi.BL;
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
    public partial class Ürünler : Form
    {
        public Ürünler()
        {
            InitializeComponent();
        }

        private void btnÜrünEkle_Click(object sender, EventArgs e)
        {
            FormUrun form = new FormUrun()
            {
                Text = "Ürün Ekle",
                Urun = new Urun() { ID = Guid.NewGuid() },
            };

            var sonuc = form.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.UrunEkle(form.Urun);

                if (b)
                {
                    DataSet ds = BLogic.UrunGetir("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }

            }
        }

        private void btnÜrünBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.UrunGetir(toolStripTextBox2.Text);
            if (ds != null)
                dataGridView2.DataSource = ds.Tables[0];
        }

        private void btnÜrünDüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];

            FormUrun form = new FormUrun()
            {
                Text = "Ürün Güncelle",
                Güncelleme = true,
                Urun = new Urun()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Ad = row.Cells[1].Value.ToString(),
                    Kategori = row.Cells[2].Value.ToString(),
                    Fiyat = double.Parse(row.Cells[3].Value.ToString()),
                    Stok = double.Parse(row.Cells[4].Value.ToString()),
                    Birim = row.Cells[5].Value.ToString(),
                    Detay = row.Cells[6].Value.ToString(),
                },
            };

            var sonuc = form.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.ÜrünGüncelle(form.Urun);

                if (b)
                {
                    row.Cells[1].Value = form.Urun.Ad;
                    row.Cells[2].Value = form.Urun.Kategori;
                    row.Cells[3].Value = form.Urun.Fiyat;
                    row.Cells[4].Value = form.Urun.Stok;
                    row.Cells[5].Value = form.Urun.Birim;
                    row.Cells[6].Value = form.Urun.Detay;
                }

            }
        }

        private void btnÜrünSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();



            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.UrunSil(ID);

                if (b)
                {
                    DataSet ds = BLogic.UrunGetir("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }
            }
        }

        private void Ürünler_Load(object sender, EventArgs e)
        {
            DataSet ds2 = BLogic.UrunGetir("");
            if (ds2 != null)
                dataGridView2.DataSource = ds2.Tables[0];
        }

        public Urun Urun { get; set; }
        private void btnOK_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];

            Urun = new Urun()
            {
                ID = Guid.Parse(row.Cells[0].Value.ToString()),
                Ad = row.Cells[1].Value.ToString(),
                Kategori = row.Cells[2].Value.ToString(),
                Fiyat = double.Parse(row.Cells[3].Value.ToString()),
                Stok = double.Parse(row.Cells[4].Value.ToString()),
                Birim = row.Cells[5].Value.ToString(),
                Detay = row.Cells[6].Value.ToString(),
            };

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
