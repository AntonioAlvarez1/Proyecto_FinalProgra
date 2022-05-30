using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_FinalProgra
{
    public class Medicamentos
    {
        public int CodigoMedicamento { get; set; }
        public string IngedienteGenerico { get; set; }
        public string Laboratorio { get; set; }
        public List<Enfermedades> Enfermedad {get; set;}
    }
}