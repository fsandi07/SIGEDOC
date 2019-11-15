<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Menu.Master" AutoEventWireup="true" CodeBehind="AgregarCliente.aspx.cs" Inherits="SIGEDOC.Vistas.AgregarCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

     <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">

    <!-- Google Fonts -->
    <link href="https://fonts.googleapis.com/css?family=Raleway|Ubuntu" rel="stylesheet">
     <link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css">
    <!-- Estilos -->
    <link rel="stylesheet" href="css/estilos.css">

  <link rel="stylesheet" href="./dist/style.css">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <!-- Formularios -->
    <div class="contenedor-formularios">
        <!-- Links de los formularios -->
               <div id="iniciar-sesion">
           <span class="login100-form-title">
					<i class="far fa-address-card"></i>	Agregar Cliente Nuevo
					</span>
                   <br /><br /><br />
        <!-- Contenido de los Formularios -->
        <div class="contenido-tab">
            <!-- Iniciar Sesion -->
            
                
                <form>
                    <div class="contenedor-input">
                        <asp:Label ID="Label1" runat="server" Text="Nombre Del Cliente"></asp:Label>
                         <asp:TextBox class="req" ID="TextBox1" runat="server"></asp:TextBox>
                     </div>
                    <div class="contenedor-input">
                        <asp:Label ID="Label2" runat="server" Text="Nombre de la Persona de Contacto"></asp:Label>
                         <asp:TextBox class="req" ID="TextBox2" runat="server"></asp:TextBox>
                     </div>  
                    
                    <div class="contenedor-input">
                        <asp:Label ID="Label3" runat="server" Text="Número De Teléfono"></asp:Label>
                        <asp:TextBox ID="txttelefono" runat="server" TextMode="Number"></asp:TextBox>
                     </div> 
                    <div class="contenedor-input">
                        <asp:Label ID="Label5" runat="server" Text="Correo Electronico"></asp:Label>
                          <asp:TextBox class="req" ID="txtcorreo" runat="server"></asp:TextBox>
                     </div> 

                    <div class="contenedor-input">
                        <asp:Label ID="Label6" runat="server" Text="Observaciones"></asp:Label><br />
                         <asp:TextBox class="form-control form-control-user" runat="server" TextMode="MultiLine" Rows="5" MaxLength="0" Columns="62" BorderColor="#CCB210" CssClass="alert-dark" Width="775px"></asp:TextBox>
                     </div>
                    <%--<input type="submit" class="button button-block" value="Iniciar Sesión">--%>
                     <asp:Button class="btn btn-primary btn-user btn-block"  ID="BtnCrear" runat="server" Text="Crear" BackColor="#CCB210" BorderColor="#CCB210" />
                </form>
            </div>

           

   <script src="js/jquery.js"></script>
   <script src="js/main.js"></script>


  <script src='https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js'></script><script  src="./dist/script.js"></script>


</asp:Content>
