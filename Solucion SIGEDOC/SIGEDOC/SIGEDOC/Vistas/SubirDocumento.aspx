﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Menu.Master" AutoEventWireup="true" CodeBehind="SubirDocumento.aspx.cs" Inherits="SIGEDOC.Vistas.SubirDocumento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">

    <!-- Google Fonts -->
    <link href="https://fonts.googleapis.com/css?family=Raleway|Ubuntu" rel="stylesheet">
    <link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css">
    <!-- Estilos -->
    <link rel="stylesheet" href="css/estilos.css">

    <link rel="stylesheet" href="./dist/style.css">
    <%--     </div>--%>
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
                <i class="fas fa-file-alt">&nbsp</i>Subir Documento
            </span>
        </div>
        <br />
        <br />
        <div class="contenedor-input">   
        </div>
        <!-- Contenido de los Formularios -->
        <%--  <div class="contenido-tab">--%>
        <div class="contenedor-input">
            <asp:Label ID="lblNombreDoc" runat="server" Text="Nombre del Documento"></asp:Label>
            <asp:TextBox class="req" ID="txtNombreDoc" runat="server"></asp:TextBox>
        </div>     

        <div class="contenedor-input">
            <asp:Label ID="lblDescrip" runat="server" Text="Descripcion"></asp:Label><br />
            <asp:TextBox class="form-control form-control-user" runat="server" TextMode="MultiLine" Rows="5" MaxLength="0" Columns="62" BorderColor="#CCB210" CssClass="alert-dark" Width="772px" ID="txtDescripcion"></asp:TextBox>
        </div>
        <div class="contenedor-input">
         <asp:Label ID="lblPeriodo" runat="server" Text="Periodo"></asp:Label><br />        
        <asp:DropDownList ID="dptPeriodo" runat="server"  CssClass="alert-dark" Height="28px" Width="771px" AutoPostBack="False">
            <asp:ListItem>Seleccionar</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="contenedor-input">
            <asp:Label ID="lblProyec" runat="server" Text="Asociar Proyecto"></asp:Label><br />
            <asp:DropDownList ID="dptProyecto" runat="server" CssClass="alert-dark" DataSourceID="SqlDataProyecto" DataTextField="NombreProy" DataValueField="centroCostos" Height="35px" Width="775px" AutoPostBack="True" OnSelectedIndexChanged="dptProyecto_SelectedIndexChanged">
                <asp:ListItem Selected="True">Seleccionar</asp:ListItem>
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataProyecto" runat="server" ConnectionString="<%$ ConnectionStrings:sigedocConnectionString %>" SelectCommand="SELECT [NombreProy], [centroCostos] FROM [TbProyecto]"></asp:SqlDataSource>
        </div>      
        <div class="contenedor-input">
            <asp:Label ID="lblCenCos" runat="server" Text=" Centro de Costos" ></asp:Label>
            <asp:TextBox class="req" ID="txtCenCos" runat="server" ReadOnly="True"></asp:TextBox>
        </div>
        <div class="contenedor-input">
            <asp:Label ID="lblReferen" runat="server" Text="Referencia"></asp:Label>
            <asp:TextBox class="req" ID="txtReferencia" runat="server" ></asp:TextBox>
        </div>       
        <hr class="sidebar-divider my-0">
        <asp:Label ID="lblFileWord" runat="server" Text="">Cargar documento Word</asp:Label><br />       

        <asp:FileUpload class="btn btn-primary btn-user btn-block" ID="FileSubirWordsub" runat="server" />
        <asp:Label ID="lblFilePdf" runat="server" Text="Cargar documento Pdf"></asp:Label><br />   

        <asp:FileUpload class="btn btn-primary btn-user btn-block" ID="FileSubirPdfsub" runat="server"
            BackColor="Red" BorderColor="Red" /><br />
        <hr class="sidebar-divider my-0">
        <asp:Button class="btn btn-primary btn-user btn-block" ID="BtnGuardar" runat="server" Text="Guardar"
            BackColor="#CCB210" BorderColor="#CCB210" OnClick="BtnGuardar_Click" /><br />
        <asp:Button class="btn btn-primary btn-user btn-block" ID="BtnCancelar" runat="server" Text="Cancelar"
            BackColor="Gray" BorderColor="#990000"   />

        <%--     </div>--%>
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
        // mensaje error Docmuento

        function mensajeErrorDocumento() {
            swal.fire({
                title: '¡Error!',
                text: "¡" + " Debe cargar un Documento" + "!",
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

    </script>    



</asp:Content>