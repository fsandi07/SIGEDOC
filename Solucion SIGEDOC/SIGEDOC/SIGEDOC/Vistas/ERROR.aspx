<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ERROR.aspx.cs" Inherits="SIGEDOC.Vistas.ERROR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>     
    <!-- Custom fonts for this template-->
  <link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css"/>
  <link href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i" rel="stylesheet"/>
   <!-- Custom styles for this template-->
  <link href="css/sb-admin-2.min.css" rel="stylesheet"/>
    <title>Pagina de Error</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="text-center">
            <i class="fas fa-exclamation-circle"></i>
            <div class="error mx-auto" data-text="404">404</div>
            <p class="lead text-gray-800 mb-5">Page Not Found</p>
            <p class="text-gray-500 mb-0">Error Esta Intentando acceder sin Credenciales</p>
            <a href="Login.aspx">&larr; Volver al Login</a>
          </div>

        <div>
        </div>
    </form>
</body>
</html>
