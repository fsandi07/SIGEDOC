﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Menu.Master" AutoEventWireup="true" CodeBehind="CrearProyecto.aspx.cs" Inherits="SIGEDOC.Vistas.CrearProyecto" %>
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
                         <asp:TextBox class="req" ID="TextBox1" runat="server"></asp:TextBox>
                     </div>
                    <div class="contenedor-input">
                        <asp:Label ID="Label2" runat="server" Text="Numero de Licitacion"></asp:Label>
                         <asp:TextBox class="req" ID="TextBox2" runat="server"></asp:TextBox>
                     </div>  
                    
                    <div class="contenedor-input">
                        <asp:Label ID="Label3" runat="server" Text="Cliente"></asp:Label>
                         <asp:TextBox class="req" ID="TextBox4" runat="server"></asp:TextBox>
                     </div> 
                    <div class="contenedor-input">
                        <asp:Label ID="Label5" runat="server" Text="Centro de Costos:"></asp:Label>
                          <asp:TextBox class="req" ID="TextBox3" runat="server"></asp:TextBox>
                     </div> 

                    <div class="contenedor-input">
                        <asp:Label ID="Label6" runat="server" Text="Descripción del Proyecto:"></asp:Label><br />
                         <asp:TextBox class="form-control form-control-user" runat="server" TextMode="MultiLine" Rows="5" MaxLength="0" Columns="62" BorderColor="#CCB210"></asp:TextBox>
                     </div>
                    <div class="contenedor-input">
                        <asp:Label ID="Label7" runat="server" Text="Fecha del Proyecto:"></asp:Label>                                         
                     <input id="datepicker" width="514" />
                     <script type="text/javascript">
                        $('#datepicker').datepicker({
                            uiLibrary: 'bootstrap4'
                        });
                    </script>
                    </div>
                    <div class="contenedor-input">
                         <asp:Label ID="Label4" runat="server" Text="Ganado"></asp:Label>  <asp:Label ID="Label8" runat="server" Text="Perdido"></asp:Label> <asp:Label ID="Label9" runat="server" Text="En Proceso"></asp:Label>
                        <asp:RadioButton ID="RadioButton1" runat="server" BorderColor="Red" BackColor="Yellow" Checked="True" />
                     </div>
                     <asp:Button class="btn btn-primary btn-user btn-block"  ID="BtnCrear" runat="server" Text="Crear" BackColor="#CCB210" BorderColor="#CCB210" />
                </form>
            </div>
   <script src="js/jquery.js"></script>
   <script src="js/main.js"></script>

  <script src='https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js'></script><script  src="./dist/script.js"></script>

</asp:Content>
