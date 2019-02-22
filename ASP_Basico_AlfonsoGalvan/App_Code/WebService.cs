using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Descripción breve de WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{
    decimal numero1;
    decimal numero2;
    decimal resultado;
    bool comprueba;

    public WebService()
    {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    [WebMethod]
    public decimal SumarEvento(string txtnumero1, string txtnumero2)
    {
        comprueba = decimal.TryParse(txtnumero1, out numero1);
        comprueba = decimal.TryParse(txtnumero2, out numero2);
        resultado = numero1 + numero2;

        return resultado;
    }
    [WebMethod]
    public decimal RestarEvento(string txtnumero1, string txtnumero2)
    {
        comprueba = decimal.TryParse(txtnumero1, out numero1);
        comprueba = decimal.TryParse(txtnumero2, out numero2);
        resultado = numero1 - numero2;

        return resultado;
    }
    [WebMethod]
    public decimal MultiplicarEvento(string txtnumero1, string txtnumero2)
    {
        comprueba = decimal.TryParse(txtnumero1, out numero1);
        comprueba = decimal.TryParse(txtnumero2, out numero2);
        resultado = numero1 * numero2;

        return resultado;
    }
    [WebMethod]
    public decimal DividirEvento(string txtnumero1, string txtnumero2)
    {
        comprueba = decimal.TryParse(txtnumero1, out numero1);
        comprueba = decimal.TryParse(txtnumero2, out numero2);
        resultado = numero1 / numero2;

        return resultado;
    }

    [WebMethod]
    public string PonerNumero(string numero)
    {
        return numero;
    }

}
