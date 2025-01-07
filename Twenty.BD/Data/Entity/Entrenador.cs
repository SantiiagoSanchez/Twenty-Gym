using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twenty.BD.Data.Entity
{
    public class Entrenador
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int Edad {  get; set; }

        public string Email { get; set; }

        public int Telefono { get; set; }

        public string Actividad { get; set; } //Actividad que dicta (Musculacion, Zumba, Strong, Etc.). Necesita una tabla Aparte
    }
}
