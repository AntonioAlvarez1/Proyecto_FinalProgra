﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_FinalProgra
{
    public class HistorialPaciente:Pacientesh
    {
        public int IdConsulta { get; set; }
        public DateTime FechaHoraConsulta { get; set; }
        public int Temperatura { get; set; }
        public string Presion { get; set; }

       public List<Sintomas> Sintomas { get; set; }
        public string Tratamiento { get; set; }
        public List<Receta> Receta { get; set; }
        public DateTime ProximaVisita { get; set; }
        public int Costoconsulta { get; set; }
        
    }
}