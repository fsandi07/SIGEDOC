<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OlvidoClave.aspx.cs" Inherits="SIGEDOC.Vistas.OlvidoClave" %>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta http-equiv="X-UA-Compatible" content="IE=edge"/>
<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
<meta name="description" content=""/>
<meta name="author" content=""/> 
<meta http-equiv="Content-Type", content="text/html"/>
<title>PQS-Olvido Clave</title>
    <!-- Custom fonts for this template-->
  <link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css"/>
  <link href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i" rel="stylesheet"/>
    <!-- Custom styles for this template-->
  <link href="css/sb-admin-2.min.css" rel="stylesheet"/>   
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
              <div class="col-lg-6 d-none d-lg-block bg-register-image" ></div>
              <div class="col-lg-6">
                <div class="p-5 " opacity:0 >
                  <div class="text-center">
                    <h1 class="h4 text-gray-801 mb-4">Ingrese Sus datos</h1>
                      <p> Su Contraseña será enviada a su Correo Eletrónico Asociado a su pérfil</p>
                       <hr>
                  </div>
                    <form id="form2">
                      <div class="form-group">
                          <asp:Label ID="LblIndentificacion" runat="server" Text="Identificación:"></asp:Label>
                          <br />
                          <div class="form-group">
                          <asp:TextBox class="form-control form-control-user" ID="TxtIdenti" runat="server"></asp:TextBox>
                          </div>  
                          <asp:Label  ID="LblEmail" runat="server" Text="Correo Eléctronico:"></asp:Label>
                           <br />
                          <div class="form-group">                                                       
                          <asp:TextBox class="form-control form-control-user" ID="TxtEmail" runat="server" TextMode="Email"></asp:TextBox>
                          </div>  
                    </div>
                       <asp:Button class="btn btn-primary btn-user btn-block"  ID="BtnEnvio" runat="server" Text="Enviar" BackColor="#CCB210" BorderColor="#CCB210"  />
                    </form>
                  <hr>
                  <div class="text-center">
                    <a class="small" href="Login.aspx">Regresar al Loging</a>
                  </div>
                 </div>
              </div>
            </div>
          </div>
        </div>

      </div>

    </div>

  </div>

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
