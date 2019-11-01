<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Menu.Master" AutoEventWireup="true" CodeBehind="Reporte.aspx.cs" Inherits="SIGEDOC.Vistas.Reporte" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <!-- Formularios -->
    <div class="contenedor-formularios">
        <!-- Links de los formularios -->
             <%--  <div id="iniciar-sesion"></div>
           <span class="login100-form-title">
					<i class="far fa-address-card"></i>	Agregar Cliente Nuevo
					</span>--%>
               
        <!-- Contenido de los Formularios -->
        <div class="contenido-tab">
            <!-- Iniciar Sesion -->
            
                
                <form>
                    <div class="contenedor-input">
                     
                   
                    <CR:CrystalReportViewer class="req" ID="CrystalReportViewer1" runat="server" AutoDataBind="true" Height="50px" ToolPanelWidth="100px" Width="350px" />
                    
                     </div>
                   

                    <%--<input type="submit" class="button button-block" value="Iniciar Sesión">--%>
                   
                </form>
            </div>

          </div>

</asp:Content>
