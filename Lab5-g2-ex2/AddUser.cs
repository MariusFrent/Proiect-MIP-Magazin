using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_g2_ex2
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void btnInreg_Click(object sender, EventArgs e)
        {
            using (UtilizatorDBContext udb = new UtilizatorDBContext()) 
            {
                Utilizator u= new Utilizator();
                u.Nume = txtNume.Text;
                u.Prenume = txtPrenume.Text;
                u.Username = txtUsrNm.Text;
                u.Password = txtParola.Text;

                udb.Users.Add(u);
                udb.SaveChanges();
            }
            MessageBox.Show("Utilizator adaugat!");
            return;
        }

        private void btnIesi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
