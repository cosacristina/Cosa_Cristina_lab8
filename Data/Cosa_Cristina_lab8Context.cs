using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cosa_Cristina_lab8.Models;

namespace Cosa_Cristina_lab8.Data
{
    public class Cosa_Cristina_lab8Context : DbContext
    {
        public Cosa_Cristina_lab8Context (DbContextOptions<Cosa_Cristina_lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Cosa_Cristina_lab8.Models.Book> Book { get; set; }

        public DbSet<Cosa_Cristina_lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Cosa_Cristina_lab8.Models.Category> Category { get; set; }
    }
}
