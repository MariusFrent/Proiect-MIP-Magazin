using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_g2_ex2
{
    public partial class SellProduct : Form
    {
        int id;
        public SellProduct(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnVanzare_Click(object sender, EventArgs e)
        {
            using (MagazinDbContext mdb = new MagazinDbContext())
            {
                var res = mdb.Produse.SingleOrDefault(x => x.Id == id);

                if (res != null)
                {
                    res.Cantitate -= int.Parse(textBox.Text);

                    if (res.Cantitate == 0)
                    {
                        mdb.Produse.Remove(res);
                    }
                    mdb.SaveChanges();
                }
            }
            MessageBox.Show("Produsul a fost vandut!");
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
