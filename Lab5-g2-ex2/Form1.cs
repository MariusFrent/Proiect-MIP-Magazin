using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_g2_ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adaugareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AddProduct ap = new AddProduct();
            //ap.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            using (MagazinDbContext db = new MagazinDbContext())
            {
                var res = from s in db.Produse
                          select new
                          {
                              s.Id,
                              s.Denumire,
                              s.Cantitate
                          };
                dataGridView1.DataSource = res.ToList();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;

            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString());

            SellProduct sp = new SellProduct(id);
            sp.ShowDialog();

            /*using (MagazinDbContext mdb =  new MagazinDbContext())
            {
                var res = mdb.Produse.SingleOrDefault(x => x.Id == id);

                if (res != null)
                {
                    res.Cantitate--;
                    mdb.SaveChanges();
                }

            }*/
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string src = txtSearch.Text;

            using (MagazinDbContext db = new MagazinDbContext())
            {
                var res = from s in db.Produse
                          where s.Denumire.Contains(src)
                          select new
                          {
                              s.Id,
                              s.Denumire,
                              s.Cantitate
                          };
                dataGridView1.DataSource = res.ToList();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void produseNoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct ap = new AddProduct();
            ap.ShowDialog();
        }

        private void produseExistenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddExistingProduct ap = new AddExistingProduct();
            ap.ShowDialog();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser au = new AddUser();
            au.ShowDialog();
        }

        private void btnLogare_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string pass = txtPassword.Text;

            using (UtilizatorDBContext udb = new UtilizatorDBContext())
            {
                var resU = udb.Users.SingleOrDefault(x => x.Username == user);
                if (resU != null)
                {
                    var resP = udb.Users.SingleOrDefault(x => x.Password == pass);
                    if (resP != null )
                    {
                        MessageBox.Show("Logare reusita!");
                        UserInfo userInfo = new UserInfo();
                        userInfo.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Parola incorecta!");
                        txtPassword.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Utilizatorul nu a fost gasit!");
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
            }
        }
    }
}
