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
    public partial class Müşteriler : Form
    {
        public Müşteriler()
        {
            InitializeComponent();
        }

        private void btnMüşteriEkle_Click(object sender, EventArgs e)
        {
            FormMusteri formMusteri = new FormMusteri()
            {
                Text = "Müşteri Ekle",
                Musteri = new Musteri() { ID = Guid.NewGuid() },
            };

            var sonuc = formMusteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MüşteriEkle(formMusteri.Musteri);

                if (b)
                {
                    DataSet ds = BLogic.MüşteriGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }

            }
        }

        private void btnMüşteriDüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            FormMusteri formMusteri = new FormMusteri()
            {
                Text = "Müşteri Güncelle",
                Güncelleme = true,
                Musteri = new Musteri()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Ad = row.Cells[1].Value.ToString(),
                    Soyad = row.Cells[2].Value.ToString(),
                    Telefon = row.Cells[3].Value.ToString(),
                    Mail = row.Cells[4].Value.ToString(),
                    Adres = row.Cells[5].Value.ToString(),
                },
            };

            var sonuc = formMusteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MüşteriGüncelle(formMusteri.Musteri);

                if (b)
                {
                    row.Cells[1].Value = formMusteri.Musteri.Ad;
                    row.Cells[2].Value = formMusteri.Musteri.Soyad;
                    row.Cells[3].Value = formMusteri.Musteri.Telefon;
                    row.Cells[4].Value = formMusteri.Musteri.Mail;
                    row.Cells[5].Value = formMusteri.Musteri.Adres;
                }

            }
        }

        private void btnMüşteriBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.MüşteriGetir(toolStripTextBox1.Text);
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];
        }



        private void btnMüşteriSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();



            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MüşteriSil(ID);

                if (b)
                {
                    DataSet ds = BLogic.MüşteriGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void Müşteriler_Load(object sender, EventArgs e)
        {
            DataSet ds = BLogic.MüşteriGetir("");
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];
        }

        public Musteri Musteri { get; set; }
        private void btnOK_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            Musteri = new Musteri()
            {
                ID = Guid.Parse(row.Cells[0].Value.ToString()),
                Ad = row.Cells[1].Value.ToString(),
                Soyad = row.Cells[2].Value.ToString(),
                Telefon = row.Cells[3].Value.ToString(),
                Mail = row.Cells[4].Value.ToString(),
                Adres = row.Cells[5].Value.ToString(),
            };

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
