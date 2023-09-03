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
    public partial class frmIstatisik : Form
    {
        public frmIstatisik()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void frmIstatisik_Load(object sender, EventArgs e)
        {
            lblkategori.Text = db.tbl_katagori.Count().ToString();
            lbltoplamurun.Text = db.tbl_urunler.Count().ToString();
            lblaktifmusteri.Text = db.tbl_musteri.Count(x => x.DURUM == true).ToString();
            lblpasifmusteri.Text = db.tbl_musteri.Count(x => x.DURUM == false).ToString();
            lbltoplamstok.Text = db.tbl_urunler.Sum(x => x.STOK).ToString();
            lbltutar.Text = db.tbl_satis.Sum(x => x.FIYAT).ToString()+ " TL";
            lblenyuksekfiyat.Text = (from x in db.tbl_urunler orderby x.FİYAT descending select x.URUNAD).FirstOrDefault();
            lblendusukfiyat.Text = (from x in db.tbl_urunler orderby x.FİYAT ascending select x.URUNAD).FirstOrDefault();
            lblbeyazesya.Text = db.tbl_urunler.Count(x=> x.KATEGORİ == 1).ToString();
            lbltoplambuzdolabı.Text = (from x in db.tbl_urunler orderby x.STOK descending select x.URUNAD).FirstOrDefault();
            lblsehirsayisi.Text = (from x in db.tbl_musteri select x.SEHIR).Distinct().Count().ToString();
            lblenfazlamarka.Text = db.MARKAGETIR().FirstOrDefault();
        }
    }
}
