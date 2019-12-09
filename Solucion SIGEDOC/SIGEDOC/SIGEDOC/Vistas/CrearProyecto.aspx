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
    <style>
        #scroll {
            /*border: /*1px solid;*/
            height: 550px;
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
                    <i class="fas fa-fw fa-folder"></i>Crear Proyecto Nuevo
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
                        <asp:Label ID="Lblnombreproyecto" runat="server" Text="*Nombre Proyecto"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        &nbsp;<asp:TextBox class="req" ID="txtnombreproye" runat="server"></asp:TextBox>
                    </div>
                    <div class="contenedor-input">
                        <asp:Label ID="Lbllicitacion" runat="server" Text="*Numero de Licitacion"></asp:Label>
                        &nbsp;<asp:TextBox class="req" ID="txtLicitacion" runat="server"></asp:TextBox>
                    </div>
                    <div class="contenedor-input">
                        *Cliente:  &nbsp
                        <asp:DropDownList ID="DptCliente" runat="server" CssClass="alert-dark" Width="819px" Height="26px" DataSourceID="SqlDataCliente" DataTextField="nombreCliente" DataValueField="idCliente">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataCliente" runat="server" ConnectionString="<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString %>" SelectCommand="SELECT [idCliente], [nombreCliente] FROM [TbCliente]"></asp:SqlDataSource>
                    </div>
                    <%--    <div class="contenedor-input">
                        <asp:Label ID="Lblcentrodecostos" runat="server" Text="Centro de Costos:"></asp:Label>
                          <asp:TextBox class="req" ID="txtcentrocostos" runat="server" ReadOnly="True"></asp:TextBox>
                     </div> --%>

                    <div class="contenedor-input">
                        <asp:Label ID="Label6" runat="server" Text="Descripción del Proyecto:"></asp:Label>&nbsp;<br />
                        <asp:TextBox class="form-control form-control-user" runat="server" TextMode="MultiLine" Rows="5" MaxLength="0" Columns="62" BorderColor="#CCB210" CssClass="alert-dark" Width="820px" ID="txtDescripcion"></asp:TextBox>
                    </div>
                    <div class="contenedor-input">
                        <asp:Label ID="Label7" runat="server" Text="*Fecha del Proyecto:"></asp:Label>
                        &nbsp; 
                        &nbsp;<asp:TextBox ID="txtfecha" runat="server" TextMode="Date"></asp:TextBox>
                    </div>
                    <div class="contenedor-input">
                        *Estado del Proyecto:  &nbsp
                        <asp:DropDownList ID="dptestado" runat="server" CssClass="alert-dark" Width="820px" Height="34px">
                            <asp:ListItem Value="En Proceso">En Proceso</asp:ListItem>
                            <asp:ListItem Value="Ganado">Ganado</asp:ListItem>
                            <asp:ListItem Value="Perdido">Perdido</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    *Datos Requeridos
                    <asp:Button class="btn btn-primary btn-user btn-block"
                        ID="BtnCrear" runat="server" Text="Crear" BackColor="#CCB210"
                        BorderColor="#CCB210" Width="820px" OnClick="BtnCrear_Click" />
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
