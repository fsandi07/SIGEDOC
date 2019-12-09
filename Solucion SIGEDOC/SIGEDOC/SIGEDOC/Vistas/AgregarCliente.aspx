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
    <script type="text/javascript" src="jquery.min.js"></script>
    <link rel="stylesheet" type="text/css" href="sweetalert/sweetalert2.min.css">
    <script type="text/javascript" src="sweetalert/sweetalert2.min.js"></script>
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
                    <i class="far fa-address-card"></i>Agregar Cliente Nuevo
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
                        <asp:Label ID="LblCliente" runat="server" Text="*Nombre Del Cliente"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        &nbsp;<asp:TextBox class="req" ID="txtnombrecliente" runat="server"></asp:TextBox>
                    </div>
                    <div class="contenedor-input">
                        <asp:Label ID="LblContacto" runat="server" Text="*Nombre de la Persona de Contacto"></asp:Label>
                        &nbsp;&nbsp;&nbsp;
                        &nbsp;&nbsp;&nbsp;
                         <asp:TextBox class="req" ID="txtnombrecontacto" runat="server"></asp:TextBox>
                    </div>

                    <div class="contenedor-input">
                        <asp:Label ID="LblTelefono" runat="server" Text="Número De Teléfono"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        &nbsp;&nbsp;
                        &nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txttelefono" ErrorMessage="CompareValidator" Type="Double" ForeColor="#996600"> *Valor Numerico Unicamente</asp:CompareValidator>
                        <asp:TextBox ID="txttelefono" runat="server" ></asp:TextBox>
                    </div>
                    <div class="contenedor-input">
                        <asp:Label ID="LblCorreo" runat="server" Text="*Correo Electronico"></asp:Label>
                        &nbsp;&nbsp;
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtcorreo" ErrorMessage="RegularExpressionValidator" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="#996600">Fromato invalido@ </asp:RegularExpressionValidator>
                        &nbsp;<asp:TextBox class="req" ID="txtcorreo" runat="server"></asp:TextBox>
                    </div>

                    <div class="contenedor-input">
                        <asp:Label ID="LblDetalle" runat="server" Text="Observaciones"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        <asp:TextBox ID="txtobservaciones" class="form-control form-control-user" runat="server" TextMode="MultiLine" Rows="5" MaxLength="0" Columns="62" BorderColor="#CCB210" CssClass="alert-dark" Width="775px"></asp:TextBox>
                    </div>
                    *Datos Requeridos.
                    <asp:Button class="btn btn-primary btn-user btn-block" ID="BtnCrear" runat="server" Text="Crear" BackColor="#CCB210" BorderColor="#CCB210" OnClick="BtnCrear_Click" />
                </form>
            </div>
        </div>
    </div>
    <script src="js/jquery.js"></script>
    <script src="js/main.js"></script>
    <script src='https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js'></script>
    <script src="./dist/script.js"></script>
    <script type="text/javascript">
        function mensajeEspera() {
            let timerInterval
            Swal.fire({
                title: '¡Acceso Denegado! no cuenta con los permisos para Aceder a este Modulo, contacte al Administrador',

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
        // mensaje espera2
        function mensajeEspera2() {
            let timerInterval
            Swal.fire({
                title: '¡Acceso Interrumpido!, Actualmente no existe conexion Internet',
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
            window.setTimeout('location.href="ErrorInternet.aspx"', 4000)
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
        //mensaje de conrfimacion
        function mensajeDeconfirmacion() {
            swal.fire({
                title: "¡EXITO!",
                text: "¡" + "Los Datos se Guardaron Con Exito" + "!",
                type: 'success',
                allowOutsideClick: false,
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
    </script>
</asp:Content>
