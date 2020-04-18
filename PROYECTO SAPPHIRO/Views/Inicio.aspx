<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Index.master" AutoEventWireup="true" CodeFile="~/Controllers/Inicio.aspx.cs" Inherits="Views_Inicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <link href="Styles/Estilos.css" rel="stylesheet" />
<br>
<div class="recuadro">
    <h1 class="titulo">S A P P H I R O</h1>
    <table>
        <tr>
            <td>
                <center>
                <p class="infoIni">Lorem ipsum dolor sit amet, consecteur adipiscing elit. Nullam consequat, lectus et eleifend tristique, maruris augue sagittis libero, vel, vehicula nisi leo ullamcoper eros.</p>
                 <button class="btn-contactanos">
                   <a class="texto-btnContacto" href="Contactanos.aspx">CONTÁCTANOS</a>
                 </button>

                </center>
            </td>
            <td>
                <img src="Images/LOGO-SAPPHIRO.png" height=350px style="margin-left: 0px" />
            </td>
        </tr>
    </table>
</div>
        <div class="pie"> 
           <footer>
     <p><br />&copy; @DateTime.Now.Year - SAPPHIRO SOFTWARE CONTABLE</p>
    </footer>
    </div>
</asp:Content>

