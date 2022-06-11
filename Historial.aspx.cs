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
    public partial class Historial : System.Web.UI.Page
    {
        static List<Sintomas> sintomastemp = new List<Sintomas>();
        static List<Sintomas> sintomastemp2 = new List<Sintomas>();
        static List<Medicamentos> medicamentostemp = new List<Medicamentos>();
        static List<Medicamentos> medicamentostemp2 = new List<Medicamentos>();
        
        static List<HistorialPacient> historialPacientestemp = new List<HistorialPacient>();
        HistorialPacient historialtemp = new HistorialPacient();
        
        private void guardarHistorial()
        {
           
                string json = JsonConvert.SerializeObject(historialPacientestemp);
                string archivo = Server.MapPath("historialpacientes.json");
                System.IO.File.WriteAllText(archivo, json);
            
        }
        private void leerJason()
        {
           
            string archivo = Server.MapPath("sintomas.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            sintomastemp = JsonConvert.DeserializeObject<List<Sintomas>>(json);
        }

        private void cargahistorial()
        {
            string archivo = Server.MapPath("historialpacientes.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            historialPacientestemp = JsonConvert.DeserializeObject<List<HistorialPacient>>(json);
            GridViewHistorial.DataSource = historialPacientestemp;
            GridViewHistorial.DataBind();
        }
        private void leerrecetas()
        {
            string archivo = Server.MapPath("medicamentos.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            medicamentostemp = JsonConvert.DeserializeObject<List<Medicamentos>>(json);
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            cargahistorial();
            if (!IsPostBack)
            {
                leerJason();
                DropSint.DataValueField = "SintomaDesc";
                DropSint.DataSource = sintomastemp;
                DropSint.DataBind();
                leerrecetas();
                DropDownListReceta.DataValueField = "CodigoMedicamento";
                DropDownListReceta.DataSource = medicamentostemp;
                DropDownListReceta.DataBind();

                DropDownList1.DataBind();
                Calendar1.DataBind();
                

            }
        }

        protected void ButtonSIntomas_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(TextBoxNit.Text) || String.IsNullOrEmpty(TextBoxID.Text) || String.IsNullOrEmpty(TextBoxFecha .Text) || String.IsNullOrEmpty(TextBoxTemperatura.Text) || String.IsNullOrEmpty(TextBoxPresion.Text)||String.IsNullOrEmpty(TextBoxTratamiento.Text))
            {
                Response.Write("<script>alert('Agregar todos los campos')</script>");
            }
            else
            {
                               
                historialtemp.Sintomas = sintomastemp.ToArray().ToList();
            
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            historialtemp.IdConsulta = Convert.ToInt16(TextBoxID.Text);
            historialtemp.nitpaciente = Convert.ToInt16(TextBoxNit.Text);
            historialtemp.FechaHoraConsulta = Convert.ToDateTime(TextBoxFecha.Text);
            historialtemp.Temperatura = Convert.ToInt16(TextBoxTemperatura.Text);
            historialtemp.Presion = TextBoxPresion.Text;
            historialtemp.diagnostic = TextBoxDiagnostico.Text;
            historialtemp.Tratamiento = TextBoxTratamiento.Text;
            historialtemp.Receta = medicamentostemp2;
            historialtemp.ProximaVisita = Calendar1.SelectedDate;
            historialtemp.Costoconsulta = DropDownList1.SelectedItem.Text;
            historialPacientestemp.Add(historialtemp);

            GridViewHistorial.DataSource = historialPacientestemp;
            GridViewHistorial.DataBind();
            guardarHistorial();
            medicamentostemp2.Clear();
            sintomastemp2.Clear();
           
        }

        protected void ButtonAgregarSintoma_Click(object sender, EventArgs e)
        {
            Sintomas sintoma = new Sintomas();
            sintoma.CodigoS = DropSint.SelectedIndex;
            sintoma.SintomaDesc = DropSint.SelectedItem.Text;

            sintomastemp2.Add(sintoma);
            
            GridView1.DataSource = sintomastemp2;
            GridView1.DataBind();

        }

        protected void ButtonAgregaReceta_Click(object sender, EventArgs e)
        {
            Medicamentos m = new Medicamentos();
            m.CodigoMedicamento=DropDownListReceta.SelectedIndex;
            m.IngedienteGenerico = DropDownListReceta.SelectedItem.Text;
            m.Laboratorio = DropDownListReceta.SelectedItem.Text;
            medicamentostemp2.Add(m);
           
            
        }
    }
}