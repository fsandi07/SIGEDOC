<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Profesor.Master" AutoEventWireup="true" CodeBehind="InicioProfesor.aspx.cs" Inherits="Sigemat.Vistas.InicioProfesor1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="card shadow mb-4">
                <!-- Card Header - Accordion -->
                <a href="#collapseCardExample" class="d-block card-header py-3" data-toggle="collapse" role="button" aria-expanded="true" aria-controls="collapseCardExample">
                  <h6 class="m-0 font-weight-bold text-primary">Gracias por Formar parte de nuestra institucion.</h6>
                </a>
                <!-- Card Content - Collapse -->
                <div class="collapse show" id="collapseCardExample">
                  <div class="card-body">
                      <strong>Felicidades</strong> 
                      Para la nuestro centro educativo es un placer que sea Profesor activo,
                      por tal motivo le deseamos el mejor de los exitos en su enseñanza, 
                      es un placer poder brindarle toda la ayuda necesearia.
                  </div>
                </div>
              </div>
     <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
      <ol class="carousel-indicators">
        <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
        <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
        <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
      </ol>

      <div class="carousel-inner">
        <div class="carousel-item active">
          <img class="d-block w-100" src="img/profeanun1.png" alt="Screenshot 11">
        <div class="carousel-caption d-none d-md-block">
          <h3 class="h3 mb-0 text-gray-801" >Deseas Conocer Info Motivacional</h3>
           <a href="#" data-toggle="modal" data-target="#AvisoModal2" class="btn btn-primary">Mas informacion</a>
        </div>
        </div>
        <div class="carousel-item">
          <img class="d-block w-100" src="img/profeanun2.jpg" alt="Screenshot 10">
        </div>
        <div class="carousel-item">
          <img class="d-block w-100" src="img/profeanun3.jpg" alt="Screenshot 13">
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
     <!-- Aviso2 Modal-->
  <div class="modal fade" id="AvisoModal2" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
    <div class="modal-dialog" role="document">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title" id="exampleModalLabel">Deseas Obtener mayores Conocimientos.</h5>
          <button class="close" type="button" data-dismiss="modal" aria-label="Cerrar">
            <span aria-hidden="true">×</span>
          </button>
        </div>
        <div class="modal-body">Si desea recibir capacitaciones sobre  el manejo de la parte motivacional del alumno, favor
            contactar en el area administrativa el departamento de obras Sociales, o al correo Obrassociales@sigemat.com
        </div>
        <div class="modal-footer">
          <button class="btn btn-secondary" type="button" data-dismiss="modal">Cerrar</button>
          <%--<a class="btn btn-primary" href="InicioEstudiante.aspx">Salir</a>--%>
        </div>
      </div>
    </div>
  </div>
</asp:Content>
