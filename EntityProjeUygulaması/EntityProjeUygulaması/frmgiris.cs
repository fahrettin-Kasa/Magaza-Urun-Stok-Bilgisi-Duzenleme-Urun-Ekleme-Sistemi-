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
    public partial class frmgiris : Form
    {
        public frmgiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbEntityUrunEntities db = new DbEntityUrunEntities();
            var sorgu = from x in db.tbl_admin where x.KULLANICI == textBox1.Text && x.SIFRE == textBox2.Text select x ;
            if (sorgu.Any())
            {
                AnaForm fr = new AnaForm();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("HATALI GİRİŞ");
            }
        }
    }
}
