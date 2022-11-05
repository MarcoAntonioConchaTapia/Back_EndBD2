using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Back_EndBD.Models
{
    public class Maestro
    {
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public int Edad { get; set; }
        public int Sueldo { get; set; }

    }
}