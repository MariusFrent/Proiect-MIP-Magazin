using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Lab5_g2_ex2
{
    internal class Produs
    {

        public int Id {  get; set; }

        [MaxLength(30,ErrorMessage="Maxim 30 de caractere")]
        public string Denumire { get; set; }

        [MaxLength(200, ErrorMessage = "Maxim 200 de caractere")]

        public string DescriereProdus { get; set; }

        public DateTime DataIntrare { get; set; }
        public DateTime DataValabilitate { get; set; }

        public int Cantitate {  get; set; }
    }

    class MagazinDbContext : DbContext
    {
        public DbSet<Produs> Produse { get; set; }
    }
}
