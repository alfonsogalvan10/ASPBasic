using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Inicio : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void redireccionar(object sender, EventArgs e)
    {
        Button buttonPulsado = (Button)sender;
        if (buttonPulsado.Text == "Números")
        {
            Response.Redirect("Numeros.aspx");
        }
        else
        {
            Response.Redirect("Cadenas.aspx");
        }
    }
}