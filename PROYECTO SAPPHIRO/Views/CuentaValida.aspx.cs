using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_CuentaValida : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        EUsuario user = new EUsuario();
        textoRespuesta.Text = "BIENVENIDO " + user.Primer_nombre + " A SAPPHIRO SOFTWARE CONTABLE WEB";
    }
}