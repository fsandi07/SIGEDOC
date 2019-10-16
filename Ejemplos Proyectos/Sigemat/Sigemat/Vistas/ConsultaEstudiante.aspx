<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Estudiante.Master" AutoEventWireup="true" CodeBehind="ConsultaEstudiante.aspx.cs" Inherits="Sigemat.Vistas.ConsultaEstudiante" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p> Realizar las consultas Necesarias</p>


   <div class="card shadow mb-4">
                <!-- Card Header - Accordion -->
                <a href="#collapseCardExample" class="d-block card-header py-3" data-toggle="collapse" role="button" aria-expanded="true" aria-controls="collapseCardExample">
                  <h6 class="m-0 font-weight-bold text-primary">Informacion Importante</h6>
                </a>
                <!-- Card Content - Collapse -->
                <div class="collapse show" id="collapseCardExample">
                  <div class="card-body">
                    Este es un ejemplo de un Contenedor de informacion.
                      <strong>Click Sobre el titulo</strong> 
                      Para ver como el contenedor se expande!
                      la informacion aqui suministrada es de gran importancia para el alumno.
                  </div>
                </div>
              </div>
</asp:Content>
