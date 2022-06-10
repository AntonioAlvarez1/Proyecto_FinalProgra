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

        private void cargarJson()
        {
            string archivo = Server.MapPath("pacientes.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            pacientestemp = JsonConvert.DeserializeObject<List<Pacientes>>(json);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarJson();
            
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
            int id = Convert.ToInt32( TextBoxNit.Text);
                agendatemporal.NitPaciente = Convert.ToInt32(TextBoxNit.Text);
                agendatemporal.Fecha = Calendar1.SelectedDate;
                agendatemporal.Inicio = TextBoxHI.Text;
                agendatemporal.Fin = TextBoxHF.Text;
                agendatemp.Add(agendatemporal);
                GridView1.DataSource = agendatemp;
                GridView1.DataBind();
                GuardarJason();
            



        }
    }
}