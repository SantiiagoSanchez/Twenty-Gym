using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twenty.BD.Data.Entity
{
    public class Cliente : EntityBase
    {
        public string FotoPerfil { get; set; } //Aca se pone la ruta de la imagen que va a utilizar

        public string Nombre { get; set; }

        public string Documento { get; set; }

        public string Direccion {  get; set; }

        public int Telefono { get; set; }

        public string Sexo {  get; set; }

        public int Edad { get; set; }     

        public DateTime FechaInscripcion {  get; set; }

        public int Cuota { get; set; }

        public bool Membresia { get; set; }

        public string Email {  get; set; }

        public bool Alergias { get; set; }

        public int TelefonoEmergencia { get; set; }

        public int EntrenadorId {  get; set; }
        public Entrenador? Entrenador {  get; set; } 

        public int ActividadId { get; set; }
        public Actividad? Actividad {  get; set; } 

    }
}
