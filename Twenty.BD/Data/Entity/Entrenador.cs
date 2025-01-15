using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twenty.BD.Data.Entity
{
    public class Entrenador : EntityBase
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Documento { get; set; }

        public int Edad {  get; set; }

        public string Email { get; set; }

        public int Telefono { get; set; }

        public int ActividadId { get; set; }
        public Actividad? Actividad { get; set; }
    }
}
