<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SIGEDOC.Vistas.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta http-equiv="X-UA-Compatible" content="IE=edge"/>
<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
<meta name="description" content=""/>
<meta name="author" content=""/> 
<meta http-equiv="Content-Type", content="text/html"/>
<title>PQS-Login</title>
    <!-- Custom fonts for this template-->
  <link href="vendor/fontawesome-free/css2/all.min.css" rel="stylesheet" type="text/css"/>
  <link href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i" rel="stylesheet"/>
    <!-- Custom styles for this template-->
  <link href="css/sb-admin-2.min.css" rel="stylesheet"/>   
    <%-- links para las alertas --%>
     <script type="text/javascript" src="jquery.min.js"></script>
    <link rel="stylesheet" type="text/css" href="sweetalert/sweetalert2.min.css"/>
    <script type="text/javascript" src="sweetalert/sweetalert2.min.js" ></script>

</head>
<body class="bg-gradient-primary" >
    <form id="form1" runat="server">
        <div>

             <div class="container">

    <!-- Outer Row -->
    <div class="row justify-content-center">

      <div class="col-xl-10 col-lg-12 col-md-5">

        <div class="card o-hidden border-0 shadow-lg my-5" >
          <div class="card-body p-0" >
            <!-- Nested Row within Card Body -->
            <div class="row"  >
              <div class="col-lg-6 d-none d-lg-block bg-login-image" ></div>
              <div class="col-lg-6">
                <div class="p-5 " opacity:0 >
                  <div class="text-center">
                    <h1 class="h4 text-gray-800 mb-4">PQS DICAL Project Management & Consultants.</h1>
                  </div>
                    <form id="form2">
                      <div class="form-group">
                          <asp:Label ID="LblIndentificacion" runat="server" Text="Nickname:"></asp:Label>
                          <br />
                          <div class="form-group">
                          <asp:TextBox class="form-control form-control-user" ID="TxtIdenti" runat="server"></asp:TextBox>
                          </div>  
                          <asp:Label  ID="LblContraseña" runat="server" Text="Contraseña:"></asp:Label>
                           <br />
                          <div class="form-group">                                                       
                          <asp:TextBox class="form-control form-control-user" ID="TxtClave" runat="server" TextMode="Password"></asp:TextBox>
                          </div>  
                    </div>
                       <asp:Button class="btn btn-primary btn-user btn-block"  ID="BtnIngreso" runat="server" Text="Ingresar" BackColor="#CCB210" BorderColor="#CCB210" OnClick="BtnIngreso_Click"  />
                    </form>
                  <hr>
                  <div class="text-center">
                    <a class="small" href="OlvidoClave.aspx">Olvidó su Contraseña?</a>
                  </div>
                 </div>
              </div>
            </div>
          </div>
        </div>

      </div>

    </div>

  </div>
            <script language="JavaScript">

            var msg="¡El botón derecho está desactivado para este sitio !";

            function disableIE() {if (document.all) {alert(msg);return false;}

            }
            function disableNS(e) {

            if (document.layers||(document.getElementById&&!document.all)) {

            if (e.which==2||e.which==3) {return false;}

            }

            }

            if (document.layers) {

            document.captureEvents(Event.MOUSEDOWN);document.onmousedown=disableNS;

            } else {

            document.onmouseup=disableNS;document.oncontextmenu=disableIE;

            }
            document.oncontextmenu=new Function("return false")

            </script>

                  <%-- alerta de error --%>
             <script type="text/javascript">

                 function mensajeError() {
                     swal.fire({
                         title: '¡Error!',
                         text: "¡El Nickname o la Contraseña son Incorrectos por favor Verifique!",
                         type: 'error',
                         showConfirmButton: false,
                         allowOutsideClick: false,
                         timer: 4000,
                     })
                                         
                 }
                 </script>
  <!-- Bootstrap core JavaScript-->
  <script src="vendor/jquery/jquery.min.js"></script>
  <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

  <!-- Core plugin JavaScript-->
  <script src="vendor/jquery-easing/jquery.easing.min.js"></script>

  <!-- Custom scripts for all pages-->
  <script src="js/sb-admin-2.min.js"></script>  
        </div>
    </form>
</body>
</html>
