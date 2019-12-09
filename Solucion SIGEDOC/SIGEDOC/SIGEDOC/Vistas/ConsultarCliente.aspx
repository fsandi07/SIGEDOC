<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Menu.Master" AutoEventWireup="true" CodeBehind="ConsultarCliente.aspx.cs" Inherits="SIGEDOC.Vistas.ConsultarCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">   
    <!-- Estilos -->
    <link rel="stylesheet" href="css/estilos.css">
    <link rel="stylesheet" href="dist/style.css">
     <style>
        #scroll {
            /*border: /*1px solid;*/
            height: 500px;
            width: 855px;
            overflow-y: scroll;
            overflow-x: hidden;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="contenedor-formularios">
        <div id="scroll">
            <div id="iniciar-sesion">
                <span class="login100-form-title">
                    <i class="fas fa-users"></i>&nbsp Consultar Clientes
                </span>
            </div>
            <br />
            <br />
            <br />
            *Lista con datos de los clientes en General.
    <div class="card shadow mb-4">
        <div class="card-body">
            <a href="#collapseCardExample" class="d-block card-header py-3" data-toggle="collapse" role="button" aria-expanded="False" aria-controls="collapseCardExample">
                <asp:Label ID="Lblhead" runat="server" Text="Label" ForeColor="#993300" Font-Bold="True">Ver Clientes</asp:Label>
            </a>
            <div class="collapse show" id="collapseCardExample">
                <asp:GridView ID="GridCliente" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="idCliente" DataSourceID="SqlDataCliente" ForeColor="Black" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="778px" OnRowDataBound="GridCliente_RowDataBound" BackColor="#999999" BorderColor="#333333" BorderStyle="Solid" BorderWidth="3px" CellSpacing="2">
                    <Columns>
                        <asp:CommandField HeaderText="Editar" SelectText="&lt;i class='fas fa-edit'&gt;&lt;/i&gt;" ShowSelectButton="True" />
                        <asp:BoundField DataField="idCliente" HeaderText="idCliente" InsertVisible="False" ReadOnly="True" SortExpression="idCliente" />
                        <asp:BoundField DataField="nombreCliente" HeaderText="Nombre" SortExpression="nombreCliente" />
                        <asp:BoundField DataField="nombreContacto" HeaderText="Encargado" SortExpression="nombreContacto" />
                        <asp:BoundField DataField="telefonoContacto" HeaderText="Telefono" SortExpression="telefonoContacto" />
                        <asp:BoundField DataField="correoElect" HeaderText="Correo" SortExpression="correoElect" />
                        <asp:BoundField DataField="detalleCliente" HeaderText="Detalle" SortExpression="detalleCliente" />
                        <asp:BoundField DataField="estadoCliente" HeaderText="Estado" SortExpression="estadoCliente" />
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="#996600" HorizontalAlign="Center" VerticalAlign="Middle" />
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
            <asp:SqlDataSource ID="SqlDataCliente" runat="server" ConnectionString="<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString %>" SelectCommand="SELECT * FROM [TbCliente]"></asp:SqlDataSource>
            <%-- Grid para buscar clientes --%>
      *Lista con datos de clientes filrados.
    <div class="card shadow mb-4">
        <div class="card-body">
            <a href="#collapseCardExample1" class="d-block card-header py-3" data-toggle="collapse" role="button" aria-expanded="False" aria-controls="collapseCardExample">
                <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="#993300" Font-Bold="True">Buscar Cliente</asp:Label>
            </a>
            <div class="collapse show" id="collapseCardExample1">
                <asp:Label ID="lbBuscarCliente" runat="server" Text="Buscar por Nombre "></asp:Label>
                <asp:DropDownList ID="DptbuscarCliente" runat="server" DataSourceID="SqlDataCliente1" DataTextField="nombreCliente" DataValueField="nombreCliente" OnSelectedIndexChanged="DptbuscarCliente_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataCliente1" runat="server" ConnectionString="<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString %>" SelectCommand="SELECT [nombreCliente] FROM [TbCliente]"></asp:SqlDataSource>
                <asp:GridView ID="GridBuscarCliente" runat="server" BackColor="#999999" BorderColor="#333333" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" ForeColor="#996600" CellSpacing="2">
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="#996600" HorizontalAlign="Center" VerticalAlign="Middle" />
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
    </div>
    <%-- Fin del grid  --%>
    <script type="text/javascript">
        function mensajeEspera() {
            let timerInterval
            Swal.fire({
                title: '¡Acceso Denegado!, no cuenta con los permisos para Aceder a este Modulo,contacte al Administrador',

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
            window.setTimeout('location.href="ConsultarCliente.aspx"', 4000)
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
            window.setTimeout('location.href="ConsultarCliente.aspx"', 3000)
        }
    </script>
    <%--Modal para cargar los datos que se van a actualizar --%>
    <div class="modal fade" id="ModalCliente" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">¿Desea Actualizar este Usuario?</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <img src="img/PQS.png" /><br /><br />
                    Nombre:<asp:TextBox class="req" ID="txtnombre" runat="server" ForeColor="Black" required=""></asp:TextBox>
                    Encargado:<asp:TextBox ID="txtencargado" runat="server" ForeColor="Black" required=""></asp:TextBox>
                    Telefono:<asp:TextBox ID="txttelefono" runat="server" ForeColor="Black" required=""></asp:TextBox>
                    Correo:<asp:TextBox ID="txtcorreo" runat="server" ForeColor="Black" required=""></asp:TextBox>
                    <br>
                    Detalle:<br>
                    <asp:TextBox ID="txtdetalle" runat="server" ForeColor="Black" TextMode="MultiLine" required=""></asp:TextBox><br>
                    <br>
                    Estado:
                      <asp:DropDownList ID="dptestado" runat="server" CssClass="alert-dark">
                          <asp:ListItem Value="1">Activo</asp:ListItem>
                          <asp:ListItem Value="2">Inactivo</asp:ListItem>
                      </asp:DropDownList>
                    <div class="modal-footer">
                        <asp:Button ID="btnActualizar" runat="server" Text="Guardar Cambios" class="btn btn-primary" OnClick="btnActualizar_Click" />
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

