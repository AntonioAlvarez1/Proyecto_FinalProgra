using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Newtonsoft.Json;

namespace Proyecto_FinalProgra
{
    public partial class UpdatePacientes : System.Web.UI.Page
    {
        int id =0;
        static List<Pacientes> pacienteupdate = new List<Pacientes>();
        protected void Page_Load(object sender, EventArgs e)
        {
            string archivo = Server.MapPath("pacientes.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            pacienteupdate = JsonConvert.DeserializeObject<List<Pacientes>>(json);
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            id=Convert.ToInt32(TextBoxID.Text);
            bool encontrado = false;
            foreach (var u in pacienteupdate)
            {
                if (u.NitPaciente == id)
                {
                    encontrado = true;
                   
                    TextBoxNombre.Text = u.Nombre;
                    TextBoxApellido.Text = u.Apellido;
                    TextBoxDireccion.Text = u.Direccion;
                    TextBoxTelefono.Text = u.Telefono.ToString();
                }
                
                if (!encontrado)
                {
                    
                    TextBoxNombre.Text = "";
                    TextBoxApellido.Text = "";
                    TextBoxDireccion.Text = "";
                    TextBoxTelefono.Text = "";
                }
            }
        }

        private void GuardarJason()
        {
            string json = JsonConvert.SerializeObject(pacienteupdate);
            string archivo = Server.MapPath("pacientes.json");
            System.IO.File.WriteAllText(archivo, json);
            
        }
        protected void ButtonModificar_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(TextBoxID.Text);
            foreach (var u in pacienteupdate)
            {
                if (u.NitPaciente == id)
                {
                    u.Nombre = TextBoxNombre.Text;
                    u.Apellido = TextBoxApellido.Text;
                    u.Direccion = TextBoxDireccion.Text;
                    u.Telefono = Convert.ToInt32(TextBoxTelefono.Text);
                }
                GuardarJason();
                GridView1.DataBind();
            }
            
        }
    }
}