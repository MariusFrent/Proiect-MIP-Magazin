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
    public partial class AddExistingProduct : Form
    {
        public AddExistingProduct()
        {
            InitializeComponent();
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            using (MagazinDbContext mdb = new MagazinDbContext())
            {
                int id = int.Parse(txtID.Text);
                var res = mdb.Produse.SingleOrDefault(x => x.Id == id);

                if (res != null)
                {
                    res.Cantitate += int.Parse(txtCantitate.Text);
                    mdb.SaveChanges();
                }
            }
            MessageBox.Show("Cantitate crescuta!");
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
