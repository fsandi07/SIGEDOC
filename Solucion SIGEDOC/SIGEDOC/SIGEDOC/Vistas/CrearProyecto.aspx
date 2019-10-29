<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Menu.Master" AutoEventWireup="true" CodeBehind="CrearProyecto.aspx.cs" Inherits="SIGEDOC.Vistas.CrearProyecto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <meta charset="utf-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
  <meta name="description" content="">
  <meta name="author" content="">

   
  <!-- Custom fonts for this template-->
  <link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css">
  <link href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i" rel="stylesheet">

  <!-- Custom styles for this template-->
  <link href="css/sb-admin-2.min.css" rel="stylesheet">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 
  <div class="p-5">
              <div class="text-center">
                <h1 class="h4 text-gray-900 mb-4">Crear Proyecto Nuevo</h1>
              </div>
              <form class="user">
                <div class="form-group row">
                  <div class="col-sm-6 mb-3 mb-sm-0">
                    <%--<input type="text" class="form-control form-control-user" id="exampleFirstName" placeholder="Nombre del Proyecto">--%>
                          <asp:TextBox ID="txt_nombre_proyecto" runat="server" class="form-control form-control-user" placeholder="Nombre del Proyecto" ></asp:TextBox>
                  </div>
               </div>
                  <div class="form-group row">
                  <div class="col-sm-6 mb-3 mb-sm-0">
                    <asp:TextBox ID="txt_numero_licitacio_proyrcto" runat="server" class="form-control form-control-user" placeholder="Número de licitación" ></asp:TextBox>
                  </div>
               </div>
                <div class="form-group row">
                  <div class="col-sm-6 mb-3 mb-sm-0">
                     <asp:TextBox ID="txt_cliente_proyecto" runat="server" class="form-control form-control-user" placeholder="Cliente" ></asp:TextBox>
                  </div>                  
                </div>
                  <div class="form-group row">
                  <div class="col-sm-6 mb-3 mb-sm-0">
                   <asp:TextBox ID="txtDescripcion_p"  class="form-control form-control-user" runat="server" TextMode="MultiLine" Width="354px" placeholder="Descripción del Proyecto"></asp:TextBox>
                  </div>
               </div>
                    <div class="form-group row">
                  <div class="col-sm-6 mb-3 mb-sm-0">
               <asp:Calendar ID="date_Proyecto" runat="server" BackColor="#CCB210" BorderColor="#CCB210"></asp:Calendar>
                     
                  </div>
               </div>

                     <div class="form-group row">
                  <div class="col-sm-6 mb-3 mb-sm-0">
                 <asp:TextBox ID="txt_centro_costos_proyecto" runat="server" class="form-control form-control-user" placeholder=" Centro de Costos" TextMode="Number"></asp:TextBox>
                  </div>
               </div>

                <hr>
                  <i class="btn btn-facebook btn-user btn-auto" >                 
                <asp:Button ID="Button1" runat="server" Text="Crear Proyecto" BackColor="#CCB210" class="btn btn-facebook btn-user btn-auto"/>
               <a class="fas fa-check-square">
                      </a>
                  </i>
                   <i class="btn btn-google btn-user btn-auto">
                  <asp:Button ID="BtnCancelarP" runat="server" Text="Cancelar" class="btn btn-google btn-user btn-auto" BorderColor="#CC0000"/>
                   <a class="fas fa-window-close">
                   </a>  
                   </i>
              </form>
              <hr>
             <%-- <div class="text-center">
                <a class="small" href="forgot-password.html">Forgot Password?</a>
              </div>
              <div class="text-center">
                <a class="small" href="login.html">Already have an account? Login!</a>
              </div>--%>
            </div>

<%--  <!-- Bootstrap core JavaScript-->
  <script src="vendor/jquery/jquery.min.js"></script>
  <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

  <!-- Core plugin JavaScript-->
  <script src="vendor/jquery-easing/jquery.easing.min.js"></script>

  <!-- Custom scripts for all pages-->
  <script src="js/sb-admin-2.min.js"></script>--%>


</asp:Content>
