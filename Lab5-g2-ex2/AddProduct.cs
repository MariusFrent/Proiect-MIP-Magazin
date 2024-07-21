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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (MagazinDbContext mdb = new MagazinDbContext())
            {
                Produs p = new Produs();

                p.Denumire = txtDenumire.Text;
                p.DescriereProdus = txtDescriere.Text;
                p.DataIntrare = dtpIntrare.Value;
                p.DataValabilitate = dtpValabilitate.Value;

                p.Cantitate = 1;

                mdb.Produse.Add(p);
                mdb.SaveChanges();
            }
            MessageBox.Show("Produs adaugat!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
