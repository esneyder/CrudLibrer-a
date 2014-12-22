using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrudLibrería
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            gdPersonas.DataSource = persona.ListadoPersonas();
            gdPersonas.DataBind();
        }
    }
}