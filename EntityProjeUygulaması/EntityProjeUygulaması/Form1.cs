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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void btnlistele_Click(object sender, EventArgs e)
        {
            var kategoriler = db.tbl_katagori.ToList();
            dataGridView1.DataSource = kategoriler;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            tbl_katagori t = new tbl_katagori();
            t.AD = textBox2.Text;
            db.tbl_katagori.Add(t);
            db.SaveChanges();
            MessageBox.Show("KATEGORİ EKLENDİ");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var ktgr = db.tbl_katagori.Find(x);
            db.tbl_katagori.Remove(ktgr);
            db.SaveChanges();
            MessageBox.Show("kategori Silindi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var ktgr = db.tbl_katagori.Find(x);
            ktgr.AD = textBox2.Text;
            db.SaveChanges();
            MessageBox.Show("guncelleme yapıldı");
        }
    }
}
