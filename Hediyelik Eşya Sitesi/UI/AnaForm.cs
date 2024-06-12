using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hediyelik_Eşya_Sitesi.BL;
using Hediyelik_Eşya_Sitesi.UI;

namespace Hediyelik_Eşya_Sitesi
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            DataSet ds = BLogic.SatisDetay();
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];

            DataSet ds2 = BLogic.OdemeDetay();
            if (ds2 != null)
                dataGridView2.DataSource = ds2.Tables[0];
        }

        Müşteriler mf = new Müşteriler();
        Ürünler uf = new Ürünler();

        private void btnMüşteriler_Click(object sender, EventArgs e)
        {
            mf.ShowDialog();
        }

        private void btnÜrünler_Click(object sender, EventArgs e)
        {
            uf.ShowDialog();
        }

        private void btnSatışYap_Click(object sender, EventArgs e)
        {
            FormSatis form = new FormSatis()
            {
                Text = "Satış Yap",
                Satis = new Satis()
                {
                    ID = Guid.NewGuid(),
                }
            };

                var sonuc = form.ShowDialog();
                if (sonuc == DialogResult.OK)
                {
                    bool b = BLogic.SatisEkle(form.Satis);

                    if (b)
                    {
                    DataSet ds = BLogic.SatisDetay();
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }

                }
        }

        private void btnSatışDüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            FormSatis form = new FormSatis()
            {
                Text = "Satış Güncelle",
                Güncelleme = true,
                Satis = new Satis()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    MusteriID = Guid.Parse(row.Cells[1].Value.ToString()),
                    UrunID = Guid.Parse(row.Cells[2].Value.ToString()),
                    Fiyat = double.Parse(row.Cells[7].Value.ToString()),
                    Tarih = DateTime.Parse(row.Cells[8].Value.ToString()),
                },
            };

            var sonuc = form.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SatisGüncelle(form.Satis);

                if (b)
                {
                    row.Cells[1].Value = form.Satis.MusteriID;
                    row.Cells[2].Value = form.Satis.UrunID;
                    row.Cells[7].Value = form.Satis.Fiyat;
                    row.Cells[8].Value = form.Satis.Tarih;
                }

            }
        }

        private void btnSatışSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();



            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SatisSil(ID);

                if (b)
                {
                    DataSet ds = BLogic.SatisDetay();
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnSatışBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.SatışBul(toolStripTextBox1.Text);
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnÖdemeYap_Click(object sender, EventArgs e)
        {
            FormOdeme form = new FormOdeme()
            {
                Text = "Ödeme Yap",
                Odeme = new Odeme()
                {
                    ID = Guid.NewGuid(),
                }
            };

            var sonuc = form.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OdemeEkle(form.Odeme);

                if (b)
                {
                    DataSet ds = BLogic.OdemeDetay();
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }

            }
        }

        private void btnÖdemeDüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];

            FormOdeme form = new FormOdeme()
            {
                Text = "Ödeme Güncelle",
                Güncelleme = true,
                Odeme = new Odeme()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    MusteriID = Guid.Parse(row.Cells[1].Value.ToString()),
                    Tarih = DateTime.Parse(row.Cells[3].Value.ToString()),
                    Tutar = double.Parse(row.Cells[4].Value.ToString()),
                    Tur = row.Cells[5].Value.ToString(),
                    Aciklama = row.Cells[6].Value.ToString(),
                },
            };

            var sonuc = form.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OdemeGüncelle(form.Odeme);

                if (b)
                {
                    row.Cells[1].Value = form.Odeme.MusteriID;
                    row.Cells[3].Value = form.Odeme.Tarih;
                    row.Cells[4].Value = form.Odeme.Tutar;
                    row.Cells[5].Value = form.Odeme.Tur;
                    row.Cells[6].Value = form.Odeme.Aciklama;
                }

            }
        }

        private void btnÖdemeSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();



            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OdemeSil(ID);

                if (b)
                {
                    DataSet ds = BLogic.OdemeDetay();
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnÖdemeBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.ÖdemeBul(toolStripTextBox2.Text);
            if (ds != null)
                dataGridView2.DataSource = ds.Tables[0];
        }
    }
}
