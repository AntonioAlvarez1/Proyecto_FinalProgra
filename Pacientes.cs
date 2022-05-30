using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_FinalProgra
{
    public class Pacientes:Pacientesh
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public DateTime Fechanacimiento { get; set; }
        public int Telefono { get; set; }


    }
}