using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace Proyecto_FinalProgra
{

    public partial class _Default : Page
    {
        static List<Pacientes> Pacientestemp = new List<Pacientes>();


        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void GuardarJason()
        {
            string json = JsonConvert.SerializeObject(Pacientestemp);
            string archivo = Server.MapPath("pacientes.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            GuardarJason();
            Pacientestemp.Clear();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Pacientes pacientes = new Pacientes();

            if (String.IsNullOrEmpty(TextboxNitPaciente.Text) || String.IsNullOrEmpty(TextboxNombre.Text) || String.IsNullOrEmpty(TextBoxApellido.Text) || String.IsNullOrEmpty(TextBoxFecha.Text) || String.IsNullOrEmpty(TextBoxTelefono.Text))
            {
                Response.Write("<script>alert('Agregar todos los campos')</script>");
            }


            else
            {
                pacientes.NitPaciente = Convert.ToInt16(TextboxNitPaciente.Text);
                pacientes.Nombre = TextboxNombre.Text;
                pacientes.Apellido = TextBoxApellido.Text;
                pacientes.Direccion = TextBoxDIrereccion.Text;
                pacientes.Telefono = Convert.ToInt32(TextBoxTelefono.Text);
                pacientes.Fechanacimiento = Convert.ToDateTime(TextBoxFecha.Text);
                Pacientestemp.Add(pacientes);
                GridView1.DataSource = Pacientestemp;
                GridView1.DataBind();
            }

        }

        protected void TextboxNitPaciente_TextChanged(object sender, EventArgs e)
        {

            {
                if (System.Text.RegularExpressions.Regex.IsMatch(TextboxNitPaciente.Text, "  ^ [0-9]"))
                {
                    TextboxNitPaciente.Text = "";
                }
            }
        }
    }
}