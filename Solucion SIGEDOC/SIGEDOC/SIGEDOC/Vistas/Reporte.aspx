﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Menu.Master" AutoEventWireup="true" CodeBehind="Reporte.aspx.cs" Inherits="SIGEDOC.Vistas.Reporte" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
          
                   
 <CR:CrystalReportViewer class="req" ID="RptProyectos" runat="server" AutoDataBind="true" ToolPanelWidth="100px" />

</asp:Content>
