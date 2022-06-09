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
    public partial class Sintomas1 : System.Web.UI.Page
    {
        static List<Sintomas> sintomastemp = new List<Sintomas>();
        Sintomas sintoma = new Sintomas();
        protected void Page_Load(object sender, EventArgs e)
        {
            string archivo = Server.MapPath("sintomas.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            sintomastemp = JsonConvert.DeserializeObject<List<Sintomas>>(json);
            GridViewSintomas.DataSource = sintomastemp;
            GridViewSintomas.DataBind();


        }
        private void GuardarJason()
        {
            string json = JsonConvert.SerializeObject(sintomastemp);
            string archivo = Server.MapPath("sintomas.json");
            System.IO.File.WriteAllText(archivo, json);
        
        }

        protected void ButtonAgrega_Click(object sender, EventArgs e)
        {
            
            int id = 0;
            id = Convert.ToInt32(TextCodigoSintoma.Text);
            bool encontrado = false;
                    sintoma.CodigoS = Convert.ToInt16(TextCodigoSintoma.Text);
                    sintoma.SintomaDesc = TextBoxsDescrip.Text;
                    sintomastemp.Add(sintoma);
                    GridViewSintomas.DataSource = sintomastemp;
                    GridViewSintomas.DataBind();
            GuardarJason();
                 
        }
    }
}


