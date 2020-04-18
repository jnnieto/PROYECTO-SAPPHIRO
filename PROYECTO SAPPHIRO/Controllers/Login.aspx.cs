using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnIngresar_Click(object sender, EventArgs e)
    {
        EUsuario user = new EUsuario
        {

            Nombre_usuario = textUsuario.Text,
            Contraseña = textContraseña.Text
        };
        user = new DAOUser().Login(user);

        if (user == null)
        {
            Response.Redirect("CuentaErronea.aspx");
        }
        else
        {
            Response.Redirect("CuentaValida.aspx");
        }
    }
}