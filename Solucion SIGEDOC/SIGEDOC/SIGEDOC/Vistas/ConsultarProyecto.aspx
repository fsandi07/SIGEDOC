﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Menu.Master" AutoEventWireup="true" CodeBehind="ConsultarProyecto.aspx.cs" Inherits="SIGEDOC.Vistas.ConsultarProyecto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Google Fonts -->
    <link href="https://fonts.googleapis.com/css?family=Raleway|Ubuntu" rel="stylesheet">
    <link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css">
    <!-- Estilos -->
    <link rel="stylesheet" href="css/estilos.css">
    <link rel="stylesheet" href="dist/style.css">
    <%-- fin del grid --%>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <script src="https://code.jquery.com/jquery-3.3.1.min.js"></script>
    <script src="https://unpkg.com/gijgo@1.9.13/js/gijgo.min.js" type="text/javascript"></script>
    <link href="https://unpkg.com/gijgo@1.9.13/css/gijgo.min.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- inicio del grid view --%>
    <div class="contenedor-formularios">
        <div id="iniciar-sesion">
            <span class="login100-form-title">
                <i class="fas fa-fw fa-folder"></i>Consulta de Proyecto
            </span>
        </div>
        <br />
        <br />
        <br />
        *Cuadro de información de todos los proyectos creados.
        <div class="card shadow mb-4">
            <div class="card-body">
                <a href="#collapseCardExample" class="d-block card-header py-3" data-toggle="collapse" role="button" aria-expanded="False" aria-controls="collapseCardExample">
                    <asp:Label ID="Lblhead" runat="server" Text="Label" ForeColor="#993300" Font-Bold="True">Ver Proyectos</asp:Label>
                </a>
                <div class="collapse show" id="collapseCardExample">
                    <asp:GridView ID="GridProyectos" runat="server" AutoGenerateColumns="False" DataKeyNames="centroCostos" DataSourceID="SqlDataProyec" CellPadding="3" ForeColor="Black" Width="776px" OnSelectedIndexChanged="GridProyectos_SelectedIndexChanged" OnRowDataBound="GridProyectos_RowDataBound" BackColor="#999999" BorderColor="#333333" BorderStyle="Solid" BorderWidth="1px" GridLines="Vertical">
                        <AlternatingRowStyle BackColor="#CCCCCC" />
                        <Columns>
                            <asp:CommandField HeaderText="Editar" SelectText="&lt;i class='fas fa-edit'&gt;&lt;/i&gt;" ShowSelectButton="True" />
                            <asp:BoundField DataField="centroCostos" HeaderText="C.costos" InsertVisible="False" ReadOnly="True" SortExpression="centroCostos" />
                            <asp:BoundField DataField="NombreProy" HeaderText="Nombre" SortExpression="NombreProy" />
                            <asp:BoundField DataField="NumLicita" HeaderText="Licitacion" SortExpression="NumLicita" />
                            <asp:BoundField DataField="detalleProyec" HeaderText="Detalle" SortExpression="detalleProyec" />
                            <asp:BoundField DataField="idCliente" HeaderText="Id " SortExpression="idCliente" />
                            <asp:BoundField DataField="nombrecliente" HeaderText="Cliente" SortExpression="nombrecliente" />
                            <asp:BoundField DataField="estadoProyec" HeaderText="Estado" SortExpression="estadoProyec" />
                            <asp:BoundField DataField="fechaProy" HeaderText="Fecha" SortExpression="fechaProy" />
                            <asp:BoundField DataField="nombreUsu" HeaderText="Usuario" SortExpression="nombreUsu" />
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="#CC9900" HorizontalAlign="Center" VerticalAlign="Middle" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#808080" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#383838" />
                    </asp:GridView>
                </div>
            </div>
        </div>
        <%-- fin del grid --%>
        <asp:SqlDataSource ID="SqlDataProyec" runat="server" ConnectionString="<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString %>" SelectCommand="
select a.centroCostos,a.NombreProy,a.NumLicita,a.detalleProyec,a.idCliente,c.nombrecliente,a.estadoProyec,a.fechaProy,b.nombreUsu
from TbProyecto1 a, TbUsuario b,TbCliente c where a.idUsuario = b.cedulaUsu and a.idCliente=c.idCliente
"></asp:SqlDataSource>
        <%-- inicio del grid para las busquedas --%>
        * Cuadro por busquedas de los proyectos creados.
        <div class="card shadow mb-4">
            <div class="card-body">
                <a href="#collapseCardExample2" class="d-block card-header py-3" data-toggle="collapse" role="button" aria-expanded="False" aria-controls="collapseCardExample">
                    <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="#993300" Font-Bold="True">Buscar Proyectos</asp:Label>
                </a>
                <div class="collapse show" id="collapseCardExample2">
                    <asp:Label ID="lblcentrocostos" runat="server" Text="buscar por centro de costos "></asp:Label>
                    <asp:DropDownList ID="Dptcentrocostos" runat="server" AutoPostBack="True" DataSourceID="SqlDataCentrocostos" DataTextField="centroCostos" DataValueField="centroCostos" OnSelectedIndexChanged="Dptcentrocostos_SelectedIndexChanged1">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataCentrocostos" runat="server" ConnectionString="<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString %>" SelectCommand="SELECT [centroCostos] FROM [TbProyecto1]"></asp:SqlDataSource>
                    <asp:Label ID="lbnombreProyecto" runat="server" Text="buscar por Nombre de proyecto "></asp:Label>
                    <asp:DropDownList ID="DptnombreProtyecto" runat="server" DataSourceID="SqlDatanombreproyecto" DataTextField="NombreProy" DataValueField="NombreProy" OnSelectedIndexChanged="DptnombreProtyecto_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDatanombreproyecto" runat="server" ConnectionString="<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString %>" SelectCommand="SELECT [NombreProy] FROM [TbProyecto1]"></asp:SqlDataSource>
                    <asp:GridView ID="gridPbusquedas" runat="server" BackColor="#999999" BorderColor="#333333" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" ForeColor="Black" CellSpacing="2">
                        <FooterStyle BackColor="#CCCCCC" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="#CC9900" HorizontalAlign="Center" VerticalAlign="Middle" />
                        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                        <RowStyle BackColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#808080" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#383838" />
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
    <%-- Fin del grid para las busquedas  --%>
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
            window.setTimeout('location.href="ConsultarProyecto.aspx"', 3000)
        }
    </script>
    <%--Modal para cargar los datos --%>
    <div class="modal fade" id="ModalProyectos" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel2">¿Desea Actualizar Este Proyecto?</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    centro de Costos:<asp:TextBox ID="txtcentro_costos" runat="server" ForeColor="Black" ReadOnly="True"></asp:TextBox>
                    <br>
                    Nombre del Pyoyecto:<asp:TextBox class="req" ID="txtnombreProyecto" runat="server" ForeColor="Black" required=""></asp:TextBox>
                    <br>
                    Numero de Licitacion:<asp:TextBox class="req" ID="txtlicitacion" runat="server" ForeColor="Black" required=""></asp:TextBox>
                    <br>
                    Detalle<asp:TextBox ID="txtdetalleproyecto" runat="server" ForeColor="Black" required=""></asp:TextBox>
                    <br>
                    Ciente:
                      <asp:DropDownList ID="DptCliente" runat="server" CssClass="alert-dark" DataSourceID="SqlDataCliente" DataTextField="nombreCliente" DataValueField="idCliente">
                      </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataCliente" runat="server" ConnectionString="<%$ ConnectionStrings:sigedocConnectionString %>" SelectCommand="SELECT [idCliente], [nombreCliente] FROM [TbCliente]"></asp:SqlDataSource>
                    <br>
                    <br>
                    Estado del Proyecto:
                        <asp:DropDownList ID="dptestado" runat="server" CssClass="alert-dark">
                            <asp:ListItem Value="En Proceso">En Proceso</asp:ListItem>
                            <asp:ListItem Value="Ganado">Ganado</asp:ListItem>
                            <asp:ListItem Value="Perdido">Perdido</asp:ListItem>
                        </asp:DropDownList>
                    <br>
                    <br>
                    Usuario que creo el Proyecto:<asp:TextBox ID="txtusuario" runat="server" ForeColor="Black" ReadOnly="True"></asp:TextBox>
                    <br>
                    <br>
                    <div class="modal-footer">
                        <asp:Button ID="btnActalizar" runat="server" Text="Guardar Cambios" class="btn btn-primary" OnClick="btnActalizar_Click" />
                        <%-- <button type="button" class="btn btn-primary" data-dismiss="modal">Comprar</button>--%>
                        <%--data-dismiss="modal"--%>
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <%-- finla de la modal  --%>
</asp:Content>
