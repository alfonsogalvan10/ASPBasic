using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Inicio : System.Web.UI.Page
{
    //Variables
    WebService wb = new WebService();
    private TextBox focusedTextbox = null;
    decimal resultado;

    protected void Page_Load(object sender, EventArgs e)
    {
        labelIgual.Text = "=";
    }

    protected void SumarCick(object sender, EventArgs e)
    {
        labelOperacion.Text = "+";
        resultado = wb.SumarEvento(txtnumero1.Text, txtnumero2.Text);
        txtResultado.Text = resultado.ToString();
    }
    protected void RestarClick(object sender, EventArgs e)
    {
        labelOperacion.Text = "-";
        resultado = wb.RestarEvento(txtnumero1.Text, txtnumero2.Text);
        txtResultado.Text = resultado.ToString();
    }
    protected void MultiplicarClick(object sender, EventArgs e)
    {
        labelOperacion.Text = "X";
        resultado = wb.MultiplicarEvento(txtnumero1.Text, txtnumero2.Text);
        txtResultado.Text = resultado.ToString();
    }
    protected void DividirClick(object sender, EventArgs e)
    {
        labelOperacion.Text = "/";
        resultado = wb.DividirEvento(txtnumero1.Text, txtnumero2.Text);
        txtResultado.Text = resultado.ToString();
    }
    protected void Clear(object sender, EventArgs e)
    {
        txtnumero1.Text = "";
        txtnumero2.Text = "";
        txtResultado.Text = "";
        labelOperacion.Text = "";
    }
    protected void PonerNumerito(object sender, EventArgs e)
    {
        Button buttonPulsado = (Button)sender;
        if (focusedTextbox != null)
        {
            // put something in textbox
            focusedTextbox.Text += wb.PonerNumero(buttonPulsado.Text);
        }
    }
    protected void textBox_Enter(object sender, EventArgs e)
    {
        focusedTextbox = (TextBox)sender;
    }
}