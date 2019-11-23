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


</asp:Content>
