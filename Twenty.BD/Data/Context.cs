using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twenty.BD.Data.Entity;

namespace Twenty.BD.Data
{
    public class Context : DbContext
    {

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Entrenador> Entrenadores { get; set; }
        public Context(DbContextOptions options) : base(options)
        {
        }
    }
}
