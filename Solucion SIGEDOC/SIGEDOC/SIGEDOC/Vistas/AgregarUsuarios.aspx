<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Menu.Master" AutoEventWireup="true" CodeBehind="AgregarUsuarios.aspx.cs" Inherits="SIGEDOC.Vistas.AgregarUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <!-- Google Fonts -->
    <link href="https://fonts.googleapis.com/css?family=Raleway|Ubuntu" rel="stylesheet">
    <link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css">
    <!-- Estilos -->
    <link rel="stylesheet" href="css/estilos.css">
    <link rel="stylesheet" href="./dist/style.css">
    <style>
        #scroll {
            /*border: /*1px solid;*/
            height: 500px;
            width: 860px;
            overflow-y: scroll;
            overflow-x: hidden;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Formularios -->
    <div class="contenedor-formularios">
        <!-- Links de los formularios -->
        <div id="scroll">
            <div id="iniciar-sesion">
                <span class="login100-form-title">
                    <i class="fas fa-user-plus"></i>Agregar Usuario
                </span>
            </div>
            <br />
            <br />
            <br />
            <!-- Contenido de los Formularios -->
            <div class="contenido-tab">
                <!-- Iniciar Sesion -->
                <form>
                    <div class="contenedor-input">
                        <asp:Label ID="Lblidentificacion" runat="server" Text="*Identificación"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                         <asp:TextBox class="req" ID="txtidentifiaccion" runat="server" TextMode="Number" Width="735px"></asp:TextBox><asp:Button ID="BtnValidaCed" runat="server" Text="Validar Cedula" Width="138px" OnClick="BtnValidaCed_Click" />
                    </div>
                    <div class="contenedor-input">
                        <asp:Label ID="lblnombre" runat="server" Text="*Nombre"></asp:Label>
                        &nbsp;
                        &nbsp;<asp:TextBox class="req" ID="txtnombre" runat="server" ReadOnly="True"></asp:TextBox>
                    </div>
                    <div class="contenedor-input">
                        <asp:Label ID="lblapellidos" runat="server" Text="Apellidos"></asp:Label>
                        &nbsp;
                         <asp:TextBox class="req" ID="txtapellido" runat="server" ReadOnly="True"></asp:TextBox>
                    </div>

                    <div class="contenedor-input">
                        <asp:Label ID="lblnickname" runat="server" Text="*Nombre de Usuario"></asp:Label>
                        &nbsp;<asp:TextBox class="req" ID="txtnickname" runat="server" ReadOnly="True"></asp:TextBox>
                    </div>
                    <div class="contenedor-input">
                        <asp:Label ID="Lblrol" runat="server" Text="*tipo de Rol"></asp:Label><br />
                        <asp:DropDownList ID="dptrol" runat="server" CssClass="alert-dark" DataSourceID="SqlDataRol" DataTextField="nombreRol" DataValueField="IdRol">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataRol" runat="server" ConnectionString="<%$ ConnectionStrings:sigedocConnectionString %>" SelectCommand="SELECT [IdRol], [nombreRol] FROM [TbRol]"></asp:SqlDataSource>
                    </div>
                    <div class="contenedor-input">
                        <asp:Label ID="Lblcorreo" runat="server" Text="*Correo Electronico"></asp:Label>
                        &nbsp;
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtcorreo" ErrorMessage="RegularExpressionValidator" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="#996600">*Formato invalido@</asp:RegularExpressionValidator>
                        <asp:TextBox class="req" ID="txtcorreo" runat="server" ReadOnly="True"></asp:TextBox>
                    </div>
                    <div class="contenedor-input">
                        <asp:Label ID="Lblcontacto" runat="server" Text="Contacto"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtcontacto" ErrorMessage="CompareValidator" Type="Double" ForeColor="#996600">*Valor Numerico unicamente</asp:CompareValidator>
                        <asp:TextBox class="req" ID="txtcontacto" runat="server" ReadOnly="True"></asp:TextBox>
                    </div>
                    *Datos son requeridos.
                    <%--<input type="submit" class="button button-block" value="Iniciar Sesión">--%>
                    <asp:Button class="btn btn-primary btn-user btn-block1" ID="BtnCrear" runat="server" Text="Crear" BackColor="#CCB210" BorderColor="#CCB210" OnClick="BtnCrear_Click" Enabled="False" />
                </form>
            </div>
        </div>
    </div>
    <script src="js/jquery.js"></script>
    <script src="js/main.js"></script>
    <script type="text/javascript">
        function mensajeEspera() {
            let timerInterval
            Swal.fire({
                title: '¡Acceso Denegado!, no cuenta con los permisos para Aceder a este Modulo, contacte al Administrador',

                timer: 4000,
                allowOutsideClick: false,
                onBeforeOpen: () => {

                    Swal.showLoading()

                    timerInterval = setInterval(() => {
                        Swal.getContent().querySelector('strong')
                            .textContent = (Swal.getTimerLeft() / 1000)
                                .toFixed(0)
                    }, 100)
                },
                onClose: () => {
                    clearInterval(timerInterval)
                }
            })
            window.setTimeout('location.href="Menu.aspx"', 4000)
        }
        // mensaje de error
        function mensajeError() {
            swal.fire({
                title: '¡Error!',
                text: "¡" + " Lo sentimos a ocurrido un Error, por favor intentelo de nuevo," +
                    "Si el problema persiste contacte al Administrador " + "!",
                type: 'error',
                showConfirmButton: false,
                allowOutsideClick: false,
                timer: 4000,

            })
        }
        function mensajeErrorValidaCedula() {
            swal.fire({
                title: '¡Error!',
                text: "¡" + " El usuario ya existe en la base de datos" + "!",
                type: 'error',
                showConfirmButton: false,
                allowOutsideClick: false,
                timer: 4000,

            })
        }
        function mensajeErrorDatosVacios() {
            swal.fire({
                title: '¡Error!',
                text: "¡" + "Espacios requeridos en blanco." + "!",
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
        function mensajeDeconfirmacion1() {
            swal.fire({
                title: "¡Confirmado!",
                text: "¡" + "El Usuario no esta registrado puede ingresar los datos." + "!",
                type: 'success',
                allowOutsideClick: false,
            })
        }
        function mensajeDeconfirmacion2() {
            swal.fire({
                title: "¡Confirmado!",
                text: "¡" + "El Usuario se ecuentra ya resgistrado." + "!",
                type: 'success',
                allowOutsideClick: false,
            })
        }
    </script>
    <script src='https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js'></script>
    <script src="./dist/script.js"></script>
</asp:Content>
