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
        static List<Agenda> agendatemp2 = new List<Agenda>();
        static List<Pacientes> pacientestemp = new List<Pacientes>();

        Agenda agendatemporal = new Agenda();

        private void cargarJson()
        {
            string archivo = Server.MapPath("pacientes.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            pacientestemp = JsonConvert.DeserializeObject<List<Pacientes>>(json);
        }
        private void CargaAgenda()
        {
            string archivo = Server.MapPath("agenda.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            agendatemp2 = JsonConvert.DeserializeObject<List<Agenda>>(json);
            GridView1.DataSource = agendatemp2;
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarJson();
            CargaAgenda();

        }

        private void GuardarJason()
        {
            string json = JsonConvert.SerializeObject(agendatemp);
            string archivo = Server.MapPath("agenda.json");
            System.IO.File.WriteAllText(archivo, json);

        }
        protected void ButtonAgregacita_Click(object sender, EventArgs e)
        {
            
           if(String.IsNullOrEmpty(TextBoxNit.Text)|| String.IsNullOrEmpty(TextBoxHF.Text)||String.IsNullOrEmpty(TextBoxHI.Text))
            {

                Response.Write("<script>alert('Agregar todos los campos')</script>");
            }
            else
            {
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
}