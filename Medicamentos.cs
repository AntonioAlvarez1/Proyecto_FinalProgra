using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_FinalProgra
{
    public class Medicamentos:Sintomas
    {
        public int CodigoMedicamento { get; set; }
        public string IngedienteGenerico { get; set; }
        public string Laboratorio { get; set; }
        public List<Sintomas> s { get; set; }
    }
}