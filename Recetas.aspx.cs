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
    public partial class Recetas : System.Web.UI.Page
    {
        static List<Sintomas> sintomastemp = new List<Sintomas>();
        static List<Sintomas> sintomastemp2 = new List<Sintomas>();

        static List<Medicamentos> medicamentostemp = new List<Medicamentos>();
        Medicamentos Medicamentos = new Medicamentos();
        Sintomas sintoma = new Sintomas();
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
                DropDownList1.DataValueField = "SintomaDesc";
                DropDownList1.DataSource = sintomastemp;
                DropDownList1.DataBind();
            }
        }
        private void GuardarJason()
        {
            string json = JsonConvert.SerializeObject(medicamentostemp);
            string archivo = Server.MapPath("medicamentos.json");
            System.IO.File.WriteAllText(archivo, json);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            sintoma.CodigoS = DropDownList1.SelectedIndex;
            sintoma.SintomaDesc = DropDownList1.SelectedItem.Text;
            sintomastemp2.Add(sintoma);
            GridView1.DataSource = sintomastemp2;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            {
                Medicamentos.CodigoMedicamento = Convert.ToInt32(TextBoxCodigo.Text);
                Medicamentos.IngedienteGenerico = TextBoxIngrediente.Text;
                Medicamentos.Laboratorio = TextBoxLaboratorio.Text;
                Medicamentos.s = sintomastemp2.ToArray().ToList();
                medicamentostemp.Add(Medicamentos);
                GuardarJason();
                sintomastemp2.Clear();


            }
        }
    }
}