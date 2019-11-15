<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Menu.Master" AutoEventWireup="true" CodeBehind="CrearProyecto.aspx.cs" Inherits="SIGEDOC.Vistas.CrearProyecto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

     <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">

    <!-- Google Fonts -->
    <link href="https://fonts.googleapis.com/css?family=Raleway|Ubuntu" rel="stylesheet">
     <link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css">
    <!-- Estilos -->
    <link rel="stylesheet" href="css/estilos.css">
    <link rel="stylesheet" href="dist/style.css">
    <%-- para el calendario con javascript --%>
     <meta name="viewport" content="width=device-width, initial-scale=1">
       <script src="https://code.jquery.com/jquery-3.3.1.min.js"></script>
    <script src="https://unpkg.com/gijgo@1.9.13/js/gijgo.min.js" type="text/javascript"></script>
    <link href="https://unpkg.com/gijgo@1.9.13/css/gijgo.min.css" rel="stylesheet" type="text/css" />

     <style type="text/css">
         .auto-style1 {
             width: 90%
         }
     </style>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <!-- Formularios -->
    <div class="contenedor-formularios">
        <!-- Links de los formularios -->
               <div id="iniciar-sesion">
           <span class="login100-form-title">
					<i class="fas fa-fw fa-folder"></i>	Crear Proyecto Nuevo
					</span>
                   <br /><br /><br />
        <!-- Contenido de los Formularios -->
        <div class="contenido-tab">
            <!-- Iniciar Sesion -->
            
                
                <form>
                    <div class="contenedor-input">
                        <asp:Label ID="Label1" runat="server" Text="Nombre Proyecto"></asp:Label>
                         <asp:TextBox class="req" ID="txtNombreProye" runat="server"></asp:TextBox>
                     </div>
                    <div class="contenedor-input">
                        <asp:Label ID="Label2" runat="server" Text="Numero de Licitacion"></asp:Label>
                         <asp:TextBox class="req" ID="txtLicitacion" runat="server"></asp:TextBox>
                     </div>  
                    
                   <div class="contenedor-input">
                         Cliente:  &nbsp <asp:DropDownList ID="DptCliente" runat="server" CssClass="alert-dark" Width="774px" Height="26px" DataSourceID="SqlDataCliente" DataTextField="nombreCliente" DataValueField="idCliente">
                             </asp:DropDownList>
                         <asp:SqlDataSource ID="SqlDataCliente" runat="server" ConnectionString="<%$ ConnectionStrings:sigedocConnectionString %>" SelectCommand="SELECT [idCliente], [nombreCliente] FROM [TbCliente]"></asp:SqlDataSource>
                   </div>
                    <div class="contenedor-input">
                        <asp:Label ID="Label5" runat="server" Text="Centro de Costos:"></asp:Label>
                          <asp:TextBox class="req" ID="txtCentroCostos" runat="server" ReadOnly="True"></asp:TextBox>
                     </div> 

                    <div class="contenedor-input">
                        <asp:Label ID="Label6" runat="server" Text="Descripción del Proyecto:"></asp:Label><br />
                         <asp:TextBox class="form-control form-control-user" runat="server" TextMode="MultiLine" Rows="5" MaxLength="0" Columns="62" BorderColor="#CCB210" CssClass="alert-dark" Width="775px" ID="txtDescripcion"></asp:TextBox>
                     </div>
                    <div class="contenedor-input">
                        <asp:Label ID="Label7" runat="server" Text="Fecha del Proyecto:"></asp:Label>                                         
                     <input id="dataproyec" class="auto-style1" />
                     <script type="text/javascript">
                        $('#datepicker').datepicker({
                            uiLibrary: 'bootstrap4'
                        });
                    </script>
                    </div>
                    <div class="contenedor-input">
                         Estado del Proyecto:  &nbsp <asp:DropDownList ID="Dpl_estado" runat="server" CssClass="alert-dark" Width="776px" Height="31px">
                             <asp:ListItem Value="1">En Proceso</asp:ListItem>
                             <asp:ListItem Value="2">Ganado</asp:ListItem>
                             <asp:ListItem Value="3">Perdido</asp:ListItem>
                         </asp:DropDownList>
                     </div>
                     <asp:Button class="btn btn-primary btn-user btn-block"
                         ID="BtnCrear" runat="server" Text="Crear" BackColor="#CCB210"
                         BorderColor="#CCB210" Width="775px" />
                </form>
            </div>
   <script src="js/jquery.js"></script>
   <script src="js/main.js"></script>

  <script src='https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js'></script><script  src="./dist/script.js"></script>

</asp:Content>
