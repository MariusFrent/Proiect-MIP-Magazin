using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_g2_ex2
{
    public class IstoricVanzari
    {
        public int Id { get; set; }
        public int Id_user { get; set; }

        [MaxLength(30, ErrorMessage = "Maxim 30 de caractere")]
        public string NumeProdus { get; set; }
        public int Cantitate { get; set; }

    }

    public class IstoricDBContext : DbContext
    {
        public DbSet<IstoricVanzari> Vanzari { get; set;}
    }
}
