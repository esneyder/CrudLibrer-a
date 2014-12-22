using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrudLibrería
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.cedula = txtcedula.Text;
            persona.nombre = txtnombres.Text;
            persona.apellido = txtapellidos.Text;
            persona.genero = txtgenero.Text;
            persona.ciudad = txtciudad.Text;
            persona.direccion = txtdireccion.Text;
            persona.telefono = txttelefono.Text;

            if (persona.NuevaPresona(persona) ==1)               {
                msg.Text = persona.Mensaje;          
            }
            else { msg.Text = persona.Mensaje; }
        }

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            if ((persona = persona.getPersona(txtcedula.Text)) != null)
            {
                txtcedula.Text = persona.cedula;
                txtnombres.Text = persona.nombre;
                txtapellidos.Text = persona.apellido;
                txtgenero.Text = persona.genero;
                txtciudad.Text = persona.ciudad;
                txtdireccion.Text = persona.direccion;
                txttelefono.Text = persona.telefono;
                ClientScript.RegisterClientScriptBlock(this.GetType(),
                        "registro", "<script>alert('registro encontrado')</script>");
                msg.Text = persona.Mensaje;
            }
            else
            {
                msg.Text = persona.Mensaje;
                ClientScript.RegisterClientScriptBlock(this.GetType(),  
                            "registro", "<script>alert('registro no encontrado')</script>");

            }
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.cedula = txtcedula.Text;
            persona.nombre = txtnombres.Text;
            persona.apellido = txtapellidos.Text;
            persona.genero = txtgenero.Text;
            persona.ciudad = txtciudad.Text;
            persona.direccion = txtdireccion.Text;
            persona.telefono = txttelefono.Text;

            if (persona.NuevaPresona(persona) == 1)
            {
                msg.Text = persona.Mensaje;
            }
            else { msg.Text = persona.Mensaje; }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            if (persona.EliminarPesona(txtcedula.Text) ==1)
            {
                msg.Text = persona.Mensaje;
            }
            else { msg.Text = persona.Mensaje; }
        }
    }
}