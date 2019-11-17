<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Menu.Master" AutoEventWireup="true" CodeBehind="Rol.aspx.cs" Inherits="SIGEDOC.Vistas.Rol" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">

    <!-- Google Fonts -->
    <link href="https://fonts.googleapis.com/css?family=Raleway|Ubuntu" rel="stylesheet">
    <link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css">
    <!-- Estilos -->
    <link rel="stylesheet" href="css/estilos.css">

    <link rel="stylesheet" href="./dist/style.css">
    <%-- links Para las Alertas  --%>
    <script type="text/javascript" src="jquery.min.js"></script>
    <link rel="stylesheet" type="text/css" href="sweetalert/sweetalert2.min.css">
    <script type="text/javascript" src="sweetalert/sweetalert2.min.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Formularios -->
    <div class="contenedor-formularios">
        <!-- Links de los formularios -->
        <div id="iniciar-sesion">
            <span class="login100-form-title">
                <i class="fas fa-fw fa-cog">&nbsp</i>Crear Roles para Usuarios
            </span>
        </div>
        <br />
        <br />
        <!-- Contenido de los Formularios -->
        <%--  <div class="contenido-tab">--%>
        <div class="contenedor-input">
            <asp:Label ID="lblNombreRol" runat="server" Text="Nombre del Rol"></asp:Label>
            <asp:TextBox class="req" ID="txtNombreRol" runat="server"></asp:TextBox>
        </div>
        <div class="contenedor-input">
            <asp:Label ID="lblDetalleRol" runat="server" Text="Detalle del Rol"></asp:Label>
            <asp:TextBox class="req" ID="txtDetalleRol" runat="server"></asp:TextBox>
        </div>   
        <br/>
         <div class="contenedor-input">
            <asp:Label ID="lblPermisos" runat="server" Text="Otorgar Permisos"></asp:Label> 
             
        </div>  
        <asp:CheckBoxList ID="cbPermisos" runat="server" Height="50px" Width="619px"  CellPadding="-1" CellSpacing="-1">
            <asp:ListItem Value="1">Crear Cliente</asp:ListItem>
            <asp:ListItem Value="1">Consultar Cliente</asp:ListItem>
            <asp:ListItem Value="1">Crear Documento</asp:ListItem>
            <asp:ListItem Value="1">Subir Documento</asp:ListItem>
            <asp:ListItem Value="1">Consultar Documento</asp:ListItem>
            <asp:ListItem Value="1">Usuarios</asp:ListItem>
            <asp:ListItem Value="1">Roles</asp:ListItem>
            <asp:ListItem Value="1">Bitacora</asp:ListItem>
            <asp:ListItem Value="1">Reportes Auditoria</asp:ListItem>
            <asp:ListItem Value="1">Reportes de Movimientos</asp:ListItem>
            <asp:ListItem Value="1">Reportes de Proyectos</asp:ListItem>
        </asp:CheckBoxList>
           <br/>  <br/>
        <hr class="sidebar-divider my-0">
        <asp:Button class="btn btn-primary btn-user btn-block" ID="BtnGuardar" runat="server" Text="Guardar"
            BackColor="#CCB210" BorderColor="#CCB210" OnClick="BtnGuardar_Click" />
       
    </div>

    <script src="js/jquery.js"></script>
    <script src="js/main.js"></script>


    <script src='https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js'></script>
    <script src="./dist/script.js"></script>

    <script type="text/javascript">
        // mensaje de espera 
       

        // mensaje de error
        function mensajeError() {
            swal.fire({
                title: '¡Error!',
                text: "¡" + "No se Pudo Realizar el registro del Documento" + "!",
                type: 'error',
                showConfirmButton: false,
                allowOutsideClick: false,
                timer: 4000,

            })
        }

        //mensaje de conrfimacion
        function mensajeDeconfirmacion() {
            swal.fire({
                title: "¡EXITO!",
                text: "¡" + "Los Datos se Guardaron Con Exito" + "!",
                type: 'success',
                allowOutsideClick: false,
            })

        }

        //mensaje de validacion del word
        function mensajeDeValidacionDoc() {
            swal.fire({
                title: '¡Atencion!',
                text: "¡" + "Debe cargar el documento word" + "!",
                type: 'error',
                showConfirmButton: false,
                allowOutsideClick: false,
                timer: 3000,

            })
        }
        

    </script>



</asp:Content>
