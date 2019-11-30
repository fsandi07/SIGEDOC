<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Menu.Master" AutoEventWireup="true" CodeBehind="ConsultarDocumentos.aspx.cs" Inherits="SIGEDOC.Vistas.ConsultarDocumentos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" href="css/estilos.css">
    <link rel="stylesheet" href="dist/style.css">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    

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

    </script>


    <asp:GridView ID="GridDocumento" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataDocCreado" ForeColor="#333333" GridLines="None" OnRowDataBound="GridDocumento_RowDataBound" OnSelectedIndexChanged="GridDocumento_SelectedIndexChanged" Width="1051px" HorizontalAlign="Center">
        <AlternatingRowStyle BackColor="White" />
        <Columns>

            <asp:CommandField HeaderText="Editar" SelectText="&lt;i class='fas fa-edit'&gt;&lt;/i&gt;" ShowSelectButton="True" />
            <asp:BoundField DataField="nombredcreado" HeaderText="Nombre" SortExpression="nombredcreado" />
            <asp:BoundField DataField="asuntodcreado" HeaderText="Asunto" SortExpression="asuntodcreado" />
            <asp:BoundField DataField="detalledCreadol" HeaderText="Detalle" SortExpression="detalledCreadol" />
            <asp:TemplateField HeaderText="PDF">
                <ItemTemplate>
                   
 <%--                    <asp:Image ID="pdf" runat="server" Width="50px" Height="50px"  NavigateUrl='<%#"data:varbinary(MAX)/pdf;base64,"+Convert.ToBase64String ((byte [])Eval("documentoPDF")) %>' />--%>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Word">
                <ItemTemplate>
                    <%-- este campo es para los word --%>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="estatus" HeaderText="Estatus" SortExpression="estatus" />
            <asp:BoundField DataField="fecha" HeaderText="Fecha" SortExpression="fecha" />
            <asp:BoundField DataField="nombrecliente" HeaderText="Cliente" SortExpression="nombrecliente" />
            <asp:BoundField DataField="idProyecto" HeaderText="Centro Costos " SortExpression="idProyecto" />
            <asp:BoundField DataField="nombreusu" HeaderText="Usuario" SortExpression="nombreusu" />
            <asp:BoundField DataField="numReferencia" HeaderText="Referencia" SortExpression="numReferencia" />
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
    <asp:SqlDataSource ID="SqlDataDocCreado" runat="server" ConnectionString="<%$ ConnectionStrings:sigedocConnectionString %>" SelectCommand="select a.nombredcreado,a.asuntodcreado,a.detalledCreadol,a.documentoPDF,a.documentoWord,a.estatus,a.fecha,c.nombrecliente,a.idProyecto,b.nombreusu,a.numReferencia

from TbDocCreado a, TbUsuario b,TbCliente c where a.Usuario = b.cedulaUsu and a.idCliente=c.idCliente"></asp:SqlDataSource>
    <%--Modal para cargar los datos que se van a actualizar --%>
    <div class="modal fade" id="ModalDocumentos" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">¿Desea Actualizar este Usuario?</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    Nombre Del docuemnto<asp:TextBox class="req" ID="txtnombre" runat="server" ForeColor="Black"></asp:TextBox>
                    Asunto<asp:TextBox ID="txtasunto" runat="server" ForeColor="Black"></asp:TextBox>
                    Detalle<asp:TextBox ID="txtdetalle" runat="server" ForeColor="Black"></asp:TextBox>
                    Usuario<asp:TextBox ID="txtusuario" runat="server" ForeColor="Black" ReadOnly="True"></asp:TextBox>
                    <br>
                    centro de Costos:<asp:TextBox ID="txtcentrocostos" runat="server" ForeColor="Black" ReadOnly="True"></asp:TextBox><br>
                    Estado
                        <asp:DropDownList ID="dptestado" runat="server" CssClass="alert-dark">
                            <asp:ListItem Value="En Proceso">En Proceso</asp:ListItem>
                            <asp:ListItem Value="Ganado">Ganado</asp:ListItem>
                            <asp:ListItem Value="Perdido">Perdido</asp:ListItem>
                        </asp:DropDownList>
                    <br>
                    Cliente
                    <asp:DropDownList ID="dptcliente" runat="server" CssClass="alert-dark" DataSourceID="SqlDataCliente" DataTextField="nombreCliente" DataValueField="idCliente"></asp:DropDownList>
                    <br>
                    <asp:SqlDataSource ID="SqlDataCliente" runat="server" ConnectionString="<%$ ConnectionStrings:sigedocConnectionString %>" SelectCommand="SELECT [idCliente], [nombreCliente] FROM [TbCliente]"></asp:SqlDataSource>
                    <br>
                    Fecha:<asp:TextBox ID="txtfecha" runat="server" ForeColor="Black" ReadOnly="True"></asp:TextBox><br>
                    Cargar documento 
                    <asp:FileUpload class="btn btn-primary btn-user btn-block" ID="FileSubirWord" runat="server" />
                    <asp:RegularExpressionValidator
                        ID="RegularExpressionValidator1" runat="server"
                        ValidationExpression=".*(\.doc|\.DOCX|\.docx)$"
                        ControlToValidate="FileSubirWord">El formato del Archivo no es Word</asp:RegularExpressionValidator>
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
