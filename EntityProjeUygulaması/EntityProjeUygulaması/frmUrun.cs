using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProjeUygulaması
{
    public partial class frmUrun : Form
    {
        public frmUrun()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void BTNLISTELE_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.tbl_urunler select new { x.URUNID, x.URUNAD, x.MARKA, x.FİYAT, x.tbl_katagori.AD, x.DURUM }).ToList();

        }

        private void BTNEKLE_Click(object sender, EventArgs e)
        {
            tbl_urunler t = new tbl_urunler();
            t.URUNAD = TXTURUNAD.Text;
            t.MARKA = TXTMARKA.Text;
            t.STOK =short.Parse (TXTSTOK.Text);
            t.KATEGORİ = int.Parse(CMBKATEGORI.SelectedValue.ToString());
            t.FİYAT = decimal.Parse(TXTFIYAT.Text);
            t.DURUM = true;
            db.tbl_urunler.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Sistem Kaydedildi");
        }

        private void BTNSIL_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TXTID.Text);
            var urun = db.tbl_urunler.Find(x);
            db.tbl_urunler.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün Silindi");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TXTURUNAD.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TXTMARKA.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TXTSTOK.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TXTFIYAT.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            TXTDURUM.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            CMBKATEGORI.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void BTNGUNCELLE_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TXTID.Text);
            var urun = db.tbl_urunler.Find(x);
            urun.URUNAD = TXTURUNAD.Text;
            urun.STOK = short.Parse(TXTSTOK.Text);
            urun.MARKA = TXTMARKA.Text;
            db.SaveChanges();
            MessageBox.Show("Ürün Güncellendi");
        }

        private void frmUrun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.tbl_katagori select new { x.ID, x.AD }).ToList();
            CMBKATEGORI.ValueMember = "ID";
            CMBKATEGORI.DisplayMember = "AD";
            CMBKATEGORI.DataSource = kategoriler;
        }
    }
}
