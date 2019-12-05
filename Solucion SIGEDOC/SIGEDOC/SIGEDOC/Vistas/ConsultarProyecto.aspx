<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Menu.Master" AutoEventWireup="true" CodeBehind="ConsultarProyecto.aspx.cs" Inherits="SIGEDOC.Vistas.ConsultarProyecto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <!-- Google Fonts -->
    <link href="https://fonts.googleapis.com/css?family=Raleway|Ubuntu" rel="stylesheet">
    <link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css">
    <!-- Estilos -->
    <link rel="stylesheet" href="css/estilos.css">
    <link rel="stylesheet" href="dist/style.css">
    <%-- <button type="button" class="btn btn-primary" data-dismiss="modal">Comprar</button>--%>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <script src="https://code.jquery.com/jquery-3.3.1.min.js"></script>
    <script src="https://unpkg.com/gijgo@1.9.13/js/gijgo.min.js" type="text/javascript"></script>
    <link href="https://unpkg.com/gijgo@1.9.13/css/gijgo.min.css" rel="stylesheet" type="text/css" />
</asp:Content>




<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <asp:Label ID="lbcencostos" runat="server" Text="Buscar por Centro de Costos"></asp:Label> 
    <br>
    <asp:DropDownList ID="Dptcentrocostos" runat="server" DataSourceID="SqlDataCotsos" DataTextField="centroCostos" DataValueField="centroCostos" AutoPostBack="True" OnSelectedIndexChanged="Dptcentrocostos_SelectedIndexChanged"></asp:DropDownList>
   
    <asp:SqlDataSource ID="SqlDataCotsos" runat="server" ConnectionString="<%$ ConnectionStrings:sigedocConnectionString %>" SelectCommand="SELECT [centroCostos] FROM [TbProyecto]"></asp:SqlDataSource>
     <%-- inicio del grid view --%>
    <asp:GridView ID="GridProyectos" runat="server" AutoGenerateColumns="False" DataKeyNames="centroCostos" DataSourceID="SqlDataProyec" CellPadding="4" ForeColor="#333333" GridLines="None" Width="998px" OnSelectedIndexChanged="GridProyectos_SelectedIndexChanged" OnRowDataBound="GridProyectos_RowDataBound">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField HeaderText="Editar" SelectText="&lt;i class='fas fa-edit'&gt;&lt;/i&gt;" ShowSelectButton="True" />
            <asp:BoundField DataField="centroCostos" HeaderText="C.Costos" InsertVisible="False" ReadOnly="True" SortExpression="centroCostos" />
            <asp:BoundField DataField="NombreProy" HeaderText="Nombre" SortExpression="NombreProy" />
            <asp:BoundField DataField="NumLicita" HeaderText="Licitacion" SortExpression="NumLicita" />
            <asp:BoundField DataField="detalleProyec" HeaderText="Detalle" SortExpression="detalleProyec" />
            <asp:BoundField DataField="idCliente" HeaderText="id" SortExpression="idCliente" />
            <asp:BoundField DataField="nombrecliente" HeaderText="Cliente" SortExpression="nombrecliente" />
            <asp:BoundField DataField="estadoProyec" HeaderText="Estado" SortExpression="estadoProyec" />
            <asp:BoundField DataField="fechaProy" HeaderText="Fecha" SortExpression="fechaProy" />
            <asp:BoundField DataField="nombreUsu" HeaderText="Usuario" SortExpression="nombreUsu" />

        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataProyec" runat="server" ConnectionString="<%$ ConnectionStrings:sigedocConnectionString %>" SelectCommand="
select a.centroCostos,a.NombreProy,a.NumLicita,a.detalleProyec,a.idCliente,c.nombrecliente,a.estadoProyec,a.fechaProy,b.nombreUsu
from TbProyecto a, TbUsuario b,TbCliente c where a.idUsuario = b.cedulaUsu and a.idCliente=c.idCliente
"></asp:SqlDataSource>
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
                    Nombre del Pyoyecto:<asp:TextBox class="req" ID="txtnombreProyecto" runat="server" ForeColor="Black"></asp:TextBox>
                    <br>
                    Numero de Licitacion:<asp:TextBox class="req" ID="txtlicitacion" runat="server" ForeColor="Black"></asp:TextBox>
                    <br>
                    Detalle<asp:TextBox ID="txtdetalleproyecto" runat="server" ForeColor="Black"></asp:TextBox>
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
