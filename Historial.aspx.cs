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
        static List<HistorialPacient> historialPacientestemp = new List<HistorialPacient>();
        HistorialPacient historialtemp = new HistorialPacient();
        

        private void leerJason()
        {
           
            string archivo = Server.MapPath("sintomas.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            sintomastemp = JsonConvert.DeserializeObject<List<Sintomas>>(json);
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                leerJason();
                DropSint.DataValueField = "SintomaDesc";
                DropSint.DataSource = sintomastemp;
                DropSint.DataBind();
            }
        }

        protected void ButtonSIntomas_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(TextBoxNit.Text) || String.IsNullOrEmpty(TextBoxID.Text) || String.IsNullOrEmpty(TextBoxFecha .Text) || String.IsNullOrEmpty(TextBoxTemperatura.Text) || String.IsNullOrEmpty(TextBoxPresion.Text)||String.IsNullOrEmpty(TextBoxTratamiento.Text)|| String.IsNullOrEmpty(TextBoxReceta.Text))
            {
                Response.Write("<script>alert('Agregar todos los campos')</script>");
            }
            else
            {
                
                historialtemp.IdConsulta = Convert.ToInt16(TextBoxID.Text);
                historialtemp.nitpaciente = Convert.ToInt16(TextBoxNit.Text);
                historialtemp.FechaHoraConsulta = Convert.ToDateTime(TextBoxFecha.Text);
                historialtemp.Temperatura = Convert.ToInt16(TextBoxTemperatura.Text);
                historialtemp.Presion = TextBoxPresion.Text;
                historialtemp.Sintomas = sintomastemp.ToArray().ToList();
                historialtemp.diagnostic = TextBoxDiagnostico.Text;
                historialtemp.Tratamiento = TextBoxTratamiento.Text;
                
               
              
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

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
    }
}