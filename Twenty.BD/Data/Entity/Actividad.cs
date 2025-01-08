using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twenty.BD.Data.Entity
{
    public class Actividad : EntityBase
    {
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string Dificultad {  get; set; } //Principiante, Intermedio, Avanzado - Necesita Tabla

        public string Duracion { get; set; } 

        public string Horario { get; set; }

        public string TipoDeEntrenamiento { get; set; } //Flexibilidad, Musculacion, Fuerza, Cardio, etc. - Necesita Tabla

        public int Precio {  get; set; } //Precio de la actividad

    }
}
