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

        public int DificultadId { get; set; }
        public Dificultad? Dificultad {  get; set; }

        public string Duracion { get; set; } 

        public string Horario { get; set; }

        public int TipoEntrenamientoId { get; set; }
        public TipoEntrenamiento? TipoDeEntrenamiento { get; set; }

        public int Precio {  get; set; }

    }
}
