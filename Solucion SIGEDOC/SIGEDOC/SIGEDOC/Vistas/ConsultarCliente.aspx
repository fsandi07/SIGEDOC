<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Menu.Master" AutoEventWireup="true" CodeBehind="ConsultarCliente.aspx.cs" Inherits="SIGEDOC.Vistas.ConsultarCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%--      <!-- Google Fonts -->
    <link href="https://fonts.googleapis.com/css?family=Raleway|Ubuntu" rel="stylesheet">
     <link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css">--%>
    <!-- Estilos -->
    <link rel="stylesheet" href="css/estilos.css">
    <link rel="stylesheet" href="dist/style.css">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridCliente" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="idCliente" DataSourceID="SqlDataCliente" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="944px" OnRowDataBound="GridCliente_RowDataBound">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField HeaderText="Modificar" SelectText="&lt;i class='fas fa-edit'&gt;&lt;/i&gt;" ShowSelectButton="True" />
            <asp:BoundField DataField="idCliente" HeaderText="idCliente" InsertVisible="False" ReadOnly="True" SortExpression="idCliente" />
            <asp:BoundField DataField="nombreCliente" HeaderText="Nombre" SortExpression="nombreCliente" />
            <asp:BoundField DataField="nombreContacto" HeaderText="Encargado" SortExpression="nombreContacto" />
            <asp:BoundField DataField="telefonoContacto" HeaderText="Telefono" SortExpression="telefonoContacto" />
            <asp:BoundField DataField="correoElect" HeaderText="Correo" SortExpression="correoElect" />
            <asp:BoundField DataField="detalleCliente" HeaderText="Detalle" SortExpression="detalleCliente" />
            <asp:BoundField DataField="estadoCliente" HeaderText="Estado" SortExpression="estadoCliente" />
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
    <asp:SqlDataSource ID="SqlDataCliente" runat="server" ConnectionString="<%$ ConnectionStrings:sigedocConnectionString %>" SelectCommand="SELECT * FROM [TbCliente]"></asp:SqlDataSource>
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
           window.setTimeout('location.href="ConsultarCliente.aspx"',3000)
          
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
                    Nombre:<asp:TextBox  class="req" ID="txtnombre" runat="server" ForeColor="Black"></asp:TextBox>
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
                        <asp:Button ID="btnActualizar" runat="server" Text="Guardar Cambios" class="btn btn-primary" OnClick="btnActualizar_Click"/>
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

