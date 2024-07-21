using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lab5_g2_ex2
{
    public class Utilizator
    {
        public int Id { get; set; }

        [MaxLength(30, ErrorMessage = "Maxim 30 de caractere")]
        public string Nume { get; set; }

        [MaxLength(30, ErrorMessage = "Maxim 30 de caractere")]
        public string Prenume { get; set; }

        [MaxLength(15, ErrorMessage = "Maxim 15 de caractere")]
        public string Username { get; set; }

        [MaxLength(20, ErrorMessage = "Maxim 20 de caractere")]
        public string Password { get; set; }
    }

    public class UtilizatorDBContext : DbContext
    {
        public DbSet<Utilizator> Users { get; set; }
    }
}
