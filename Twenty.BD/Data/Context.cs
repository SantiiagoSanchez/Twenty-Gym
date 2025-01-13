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

        public DbSet<Actividad> Actividades {  get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Dificultad> Dificultades { get; set; }
        public DbSet<Entrenador> Entrenadores { get; set; }
        public DbSet<TipoEntrenamiento> TipoEntrenamientos { get; set; }
        public Context(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var cascadeFKs = modelBuilder.Model.G­etEntityTypes()
                                          .SelectMany(t => t.GetForeignKeys())
                                          .Where(fk => !fk.IsOwnership
                                                       && fk.DeleteBehavior == DeleteBehavior.Casca­de);
            foreach (var fk in cascadeFKs)
            {
                fk.DeleteBehavior = DeleteBehavior.Restr­ict;
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
