using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_FinalProgra
{
    public class Agenda:Pacientesh
    {
        
        public DateTime Fecha { get; set; }
        public TimeSpan Inicio { get; set; }
        public TimeSpan Fin { get; set;}

    }
}