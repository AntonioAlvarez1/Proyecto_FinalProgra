using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_FinalProgra
{
    public partial class Agenda1 : System.Web.UI.Page
    {
        static List<Agenda> agendatemp = new List<Agenda>();
        static List<Pacientes> pacientestemp = new List<Pacientes>();

        protected void Page_Load(object sender, EventArgs e)
        {
            string archivo = Server.MapPath("pacientes.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            pacientestemp = JsonConvert.DeserializeObject<List<Pacientes>>(json);
            
        }

        private void GuardarJason()
        {
            string json = JsonConvert.SerializeObject(agendatemp);
            string archivo = Server.MapPath("agenda.json");
            System.IO.File.WriteAllText(archivo, json);

        }
        protected void ButtonAgregacita_Click(object sender, EventArgs e)
        {
            Agenda agendatemporal = new Agenda();
            int id = 0;
            id = Convert.ToInt32(TextBoxNit.Text);
            foreach (var u in pacientestemp )
            {
                if (u.NitPaciente == id)
                {
                    Response.Write("<script>alert('Id agregado anteriormente')</script>");
                }
                else 
                {
                    agendatemporal.NitPaciente = Convert.ToInt32(TextBoxNit.Text);
                    agendatemporal.Fecha = Convert.ToDateTime(TextBoxFecha.Text);
                    
                  
                }
            }
            GuardarJason();
        }
    }
}