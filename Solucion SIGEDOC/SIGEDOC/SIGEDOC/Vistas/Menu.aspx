﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Menu.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="SIGEDOC.Vistas.Menu1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="card shadow mb-4">
                <!-- Card Header - Accordion -->
                <a href="#collapseCardExample" class="d-block card-header py-3" data-toggle="collapse" role="button" aria-expanded="true" aria-controls="collapseCardExample">
                  <h6 class="m-0 font-weight-bold text-primary">Somos una gran Compañia.</h6>
                </a>
                <!-- Card Content - Collapse -->
                <div class="collapse show" id="collapseCardExample">
                  <div class="card-body">
                      <strong>PREMIUM QUALITY SERVICES DICAL S.A (PQS DICAL)</strong> 
                       es una empresa fundada en Costa Rica en el año 2004 que cataliza mediante la modalidad de asociación la experiencia
                      y trayectoria de un grupo de profesionales en el desarrollo, construcción y administración de proyectos de ingeniería pesada, con validada experiencia internacional,
                      relaciones empresariales e interinstitucionales a nivel local e internacional, y persuadidos de su vocación por formar
                      parte de las soluciones a los proyectos que desarrollan e integran la región Centroamericana y del Caribe.
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
          <img class="d-block w-100" src="img/Expe1.jpg" alt="Screenshot 11">
        <div class="carousel-caption d-none d-md-block">
          <h3 class="h3 mb-0 text-gray-900" ><strong>Desea Conocer Más?</strong></h3>
           <a href="#" data-toggle="modal" data-target="#AvisoModal2" class="btn btn-primary">Ver información</a>
        </div>
        </div>
        <div class="carousel-item">
          <img class="d-block w-100" src="img/ExpeEolico.jpg" alt="Screenshot 10">
        </div>
        <div class="carousel-item">
          <img class="d-block w-100" src="img/ExpeJamaica.jpg" alt="Screenshot 13">
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
          <h5 class="modal-title" id="exampleModalLabel">Proyecto de Administración Obras en autopista 27.</h5>
          <button class="close" type="button" data-dismiss="modal" aria-label="Cerrar">
            <span aria-hidden="true">×</span>
          </button>
        </div>
        <div class="modal-body">
(San José – Caldera).
(Costa Rica, junio de 2017).
Cliente: MOPT – CNC.
Contrato: Administracción de las Obras Conexas de Obra Pública en la Carretera No. 27 San Jose – Caldera.
        </div>
        <div class="modal-footer">
          <button class="btn btn-secondary" type="button" data-dismiss="modal">Cerrar</button>
          <%--<a class="btn btn-primary" href="InicioEstudiante.aspx">Salir</a>--%>
        </div>
      </div>
    </div>
  </div>

</asp:Content>