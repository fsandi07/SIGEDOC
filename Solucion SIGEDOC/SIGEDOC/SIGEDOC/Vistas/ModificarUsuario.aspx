<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Menu.Master" AutoEventWireup="true" CodeBehind="ModificarUsuario.aspx.cs" Inherits="SIGEDOC.Vistas.ModificarUsuario" %>

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



     <style type="text/css">
         .auto-style1 {
             color: #2f3037;
             background-color: #dedee1;
             border-color: #d1d1d5;
             margin-top: 0px;
         }
     </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="contenedor-Grid">
    <asp:GridView ID="GridUsuarios" runat="server" AutoGenerateColumns="False" CellPadding="5" DataKeyNames="cedulaUsu" DataSourceID="SqlDataUsuario" ForeColor="#333333" GridLines="Vertical" OnSelectedIndexChanged="GridUsuarios_SelectedIndexChanged" CssClass="auto-style1" Width="978px" BorderColor="#003300" BorderStyle="None" OnRowDataBound="GridUsuarios_RowDataBound">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField HeaderText="Editar" SelectText="&lt;i class='fas fa-edit'&gt;&lt;/i&gt;" ShowSelectButton="True" />
            <asp:BoundField DataField="cedulaUsu" HeaderText="Cedula" ReadOnly="True" SortExpression="cedulaUsu" />
            <asp:BoundField DataField="nombreUsu" HeaderText="Nombre" SortExpression="nombreUsu" />
            <asp:BoundField DataField="apellidosUsu" HeaderText="Apellido" SortExpression="apellidosUsu" />
            <asp:BoundField DataField="nicknameUsu" HeaderText="Nickname" SortExpression="nicknameUsu" />
            <asp:BoundField DataField="correoElectUsu" HeaderText="Correo" SortExpression="correoElectUsu" />
            <asp:BoundField DataField="nombreRol" HeaderText="Rol" SortExpression="nombreRol" />
            <asp:BoundField DataField="idRol" HeaderText="idRol" SortExpression="idRol" />
            <asp:BoundField DataField="estadoUsu" HeaderText="Estado" SortExpression="estadoUsu" />
            <asp:BoundField DataField="contactoUsu" HeaderText="Telefono" SortExpression="contactoUsu" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" BorderStyle="Solid" HorizontalAlign="Center" VerticalAlign="Middle" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataUsuario" runat="server" ConnectionString="<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString %>" SelectCommand="select  a.cedulaUsu, a.nombreUsu,a.apellidosUsu,a.nicknameUsu,a.correoElectUsu,b.nombreRol,a.idRol,a.estadoUsu,a.contactoUsu 
from TbUsuario a, TbRol b
where a.idRol = b.IdRol "></asp:SqlDataSource>

    <asp:SqlDataSource ID="SqlDataRol" runat="server" ConnectionString="<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString %>" SelectCommand="SELECT [nombreRol], [IdRol] FROM [TbRol]"></asp:SqlDataSource>
    
      </div>  
        
        <%-- inicio de modal--%>
    <div class="modal fade" id="ModalUsuario" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">¿Desea Actualizar este Usuario?</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    Nombre:<asp:TextBox  class="req" ID="txtnombre" runat="server" ForeColor="Black" required=""></asp:TextBox>
                    Apellido:<asp:TextBox  class="req" ID="txtapellido" runat="server" ForeColor="Black" required=""></asp:TextBox>
                    Cedula:<asp:TextBox ID="txtcedula" runat="server" ReadOnly="True" ForeColor="Black"></asp:TextBox>
                    Nickname:<asp:TextBox ID="txtnikcname" runat="server" ForeColor="Black" required=""></asp:TextBox>
                    Correo:<asp:TextBox ID="txtcorreo" runat="server" ForeColor="Black"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator" BackColor="#FFCC00" Text="Debe ingresar un correo electronico valido" ControlToValidate="txtcorreo"></asp:RegularExpressionValidator>
                    Contacto:<asp:TextBox ID="txtcontacto" runat="server" ForeColor="Black"></asp:TextBox><br>
                    Estado:
                      <asp:DropDownList ID="dptestado" runat="server" AutoPostBack="True" CssClass="alert-dark">
                          <asp:ListItem Value="1">Activo</asp:ListItem>
                          <asp:ListItem Value="2">Inactivo</asp:ListItem>
                      </asp:DropDownList>
                    <br>
                    Tipo de Rol:
                    <asp:DropDownList ID="dptrol" runat="server" DataSourceID="SqlDataRol" DataTextField="nombreRol" DataValueField="IdRol" CssClass="alert-dark">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataRol1" runat="server" ConnectionString="<%$ ConnectionStrings:sigedocConnectionString %>" SelectCommand="SELECT * FROM [TbRol]"></asp:SqlDataSource>
                    <br>
                    <div class="modal-footer">
                        <asp:Button ID="btningresar" runat="server" Text="Guardar Cambios" class="btn btn-primary" OnClick="btningresar_Click"/>
                        <%-- <button type="button" class="btn btn-primary" data-dismiss="modal">Comprar</button>--%>
                        <%--data-dismiss="modal"--%>
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                    </div>
                </div>
            </div>
        </div>
    </div>

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
           window.setTimeout('location.href="ModificarUsuario.aspx"',3000)
          
        }

    </script>    


</asp:Content>
