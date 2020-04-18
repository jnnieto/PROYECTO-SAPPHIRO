<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controllers/Login.aspx.cs" Inherits="Views_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Styles/Login.css" rel="stylesheet" />
    <style type="text/css">
        
        .auto-style4 {
            background-color: #E4E4E4;
            font: bold 60px Liquid Amber DEMO;
            height: 241px;
        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <center>
        <div class="hola">
            <img src="Images/LOGO-SAPPHIRO.png" height="190px" />
        </div>
        <div>
            <h1 class="active">BIENVENIDO A SAPPHIRO</h1>
        </div>
        </center>
        <div class="auto-style4">
            <table>
                <tr>
                    <td class="label">
                        <p>USUARIO:</p>
                        <p>CONTRASEÑA:</p>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="textUsuario" runat="server" Height="33px" Width="352px"></asp:TextBox><br /><br />
                        <asp:TextBox ID="textContraseña" TextMode="Password" runat="server" Height="33px" Width="349px" ></asp:TextBox>
                    </td>
                </tr>
            </table>
            <center>
                <a class="link" href="#">OLVIDÉ MI CONTRASEÑA</a>

            </center>
        </div>
        <br />
        <br />
        <br />
        <br />
        <center>
            <asp:Button ID="btnIngresar" runat="server" Text="INICIAR SESION" CssClass="btn-ingresar" OnClick="btnIngresar_Click" />
        </center>
        
    </form>
</body>
</html>
</html>
