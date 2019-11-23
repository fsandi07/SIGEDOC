<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Menu.Master" AutoEventWireup="true" CodeBehind="ConsultarProyecto.aspx.cs" Inherits="SIGEDOC.Vistas.ConsultarProyecto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

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
</asp:Content>




<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="centroCostos" DataSourceID="SqlDataProyec" CellPadding="4" ForeColor="#333333" GridLines="None" Width="1113px">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="centroCostos" HeaderText="centro Costos" InsertVisible="False" ReadOnly="True" SortExpression="centroCostos" />
            <asp:BoundField DataField="NombreProy" HeaderText=" Proyecto " SortExpression="NombreProy" />
            <asp:BoundField DataField="NumLicita" HeaderText="N Licitacion " SortExpression="NumLicita" />
            <asp:BoundField DataField="detalleProyec" HeaderText="Detalle" SortExpression="detalleProyec" />
            <asp:BoundField DataField="idCliente" HeaderText="Cliente" SortExpression="idCliente" />
            <asp:BoundField DataField="idUsuario" HeaderText="Usuario" SortExpression="idUsuario" />
            <asp:BoundField DataField="estadoProyec" HeaderText="Estado" SortExpression="estadoProyec" />
            <asp:BoundField DataField="fechaProy" HeaderText="Fecha" SortExpression="fechaProy" />
            <asp:BoundField DataField="statusProyec" HeaderText="Status" SortExpression="statusProyec" />

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
    <asp:SqlDataSource ID="SqlDataProyec" runat="server" ConnectionString="<%$ ConnectionStrings:sigedocConnectionString %>" SelectCommand="SELECT * FROM [TbProyecto]"></asp:SqlDataSource>
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

</asp:Content>
