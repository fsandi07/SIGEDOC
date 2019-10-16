<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Administrador.Master" AutoEventWireup="true" CodeBehind="InicioAdmin.aspx.cs" Inherits="Sigemat.Vistas.InicioAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
           <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
      <ol class="carousel-indicators">
        <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
        <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
        <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
      </ol>

      <div class="carousel-inner">
        <div class="carousel-item active">
          <img class="d-block w-100" src="img/Anuncio3.jpg" alt="Screenshot 11">
        <div class="carousel-caption d-none d-md-block">
          <h3 class="h3 mb-0 text-gray-801" >Deseas Apoyar</h3>
           <a href="#" data-toggle="modal" data-target="#AvisoModal3" class="btn btn-primary">Mas informacion</a>
        </div>
        </div>
        <div class="carousel-item">
          <img class="d-block w-100" src="img/Anuncio1.jpg" alt="Screenshot 10">
        </div>
        <div class="carousel-item">
          <img class="d-block w-100" src="img/Anuncio2.png" alt="Screenshot 13">
        </div>
      </div>
      <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
        <span class="sr-only">Previous</span>
      </a>
      <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
        <span class="carousel-control-next-icon" aria-hidden="true"></span>
        <span class="sr-only">Next</span>
      </a>
    </div>
    

     <!-- Bootstrap core JavaScript-->
  <script src="vendor/jquery/jquery.min.js"></script>
  <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

  <!-- Core plugin JavaScript-->
  <script src="vendor/jquery-easing/jquery.easing.min.js"></script>

  <!-- Custom scripts for all pages-->
  <script src="js/sb-admin-2.min.js"></script>

     <!-- Aviso3 Modal-->
  <div class="modal fade" id="AvisoModal3" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
    <div class="modal-dialog" role="document">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title" id="exampleModalLabel">Desea Colaborar en esta Causa.</h5>
          <button class="close" type="button" data-dismiss="modal" aria-label="Cerrar">
            <span aria-hidden="true">×</span>
          </button>
        </div>
        <div class="modal-body">Si deseas Colaborar con esta obran favor buscar la encargado/a de Recoleccion de Utiles en la direccion
            de la escuela o envie un correo a recoleccionutiles@sigemat.com.
        </div>
        <div class="modal-footer">
          <button class="btn btn-secondary" type="button" data-dismiss="modal">Cerrar</button>
          <%--<a class="btn btn-primary" href="InicioEstudiante.aspx">Salir</a>--%>
        </div>
      </div>
    </div>
  </div>

</asp:Content>
