<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Menu.Master" AutoEventWireup="true" CodeBehind="ConsultarDocumentos.aspx.cs" Inherits="SIGEDOC.Vistas.ConsultarDocumentos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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


    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="numtotaldocu" DataSourceID="SqlDataDocCreado" ForeColor="#333333" GridLines="None" OnRowDataBound="GridView1_RowDataBound" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="1051px">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField HeaderText="Editar " SelectText="&lt;i class='fas fa-edit'&gt;&lt;/i&gt;" ShowSelectButton="True" />
            <asp:BoundField DataField="numtotaldocu" HeaderText="Numero " InsertVisible="False" ReadOnly="True" SortExpression="numtotaldocu" />
            <asp:BoundField DataField="nombredCreado" HeaderText="Nombre" SortExpression="nombredCreado" />
            <asp:BoundField DataField="asuntodCreado" HeaderText="Asunto" SortExpression="asuntodCreado" />
            <asp:BoundField DataField="detalledCreadol" HeaderText="Detalle" SortExpression="detalledCreadol" />
            <asp:BoundField DataField="Usuario" HeaderText="Usuario" SortExpression="Usuario" />
            <asp:BoundField DataField="idProyecto" HeaderText="Proyecto" SortExpression="idProyecto" />
            <asp:BoundField DataField="numConsecu" HeaderText="Consecutivo" SortExpression="numConsecu" />
            <asp:BoundField DataField="estatus" HeaderText="Estatus" SortExpression="estatus" />
            <asp:BoundField DataField="fecha" HeaderText="Fecha" SortExpression="fecha" />
            <asp:BoundField DataField="idCliente" HeaderText="Cliente" SortExpression="idCliente" />
            <asp:BoundField DataField="periodo" HeaderText="Periodo" SortExpression="periodo" />
            <asp:BoundField DataField="numReferencia" HeaderText="Referencia" SortExpression="numReferencia" />
            <asp:BoundField DataField="habilitado" HeaderText="Habilitado" SortExpression="habilitado" />
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
    <asp:SqlDataSource ID="SqlDataDocCreado" runat="server" ConnectionString="<%$ ConnectionStrings:sigedocConnectionString %>" SelectCommand="SELECT * FROM [TbDocCreado]"></asp:SqlDataSource>
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
                    Nombre:<asp:TextBox class="req" ID="txtnombre" runat="server" ForeColor="Black"></asp:TextBox>
                    Encargado:<asp:TextBox ID="txtencargado" runat="server" ForeColor="Black"></asp:TextBox>
                    Telefono:<asp:TextBox ID="txttelefono" runat="server" ForeColor="Black"></asp:TextBox>
                    Correo:<asp:TextBox ID="txtcorreo" runat="server" ForeColor="Black"></asp:TextBox>
                    <br>
                    Detalle:<asp:TextBox ID="txtdetalle" runat="server" ForeColor="Black" TextMode="MultiLine"></asp:TextBox><br>
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
