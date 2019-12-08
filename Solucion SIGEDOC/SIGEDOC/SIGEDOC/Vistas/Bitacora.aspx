<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Menu.Master" AutoEventWireup="true" CodeBehind="Bitacora.aspx.cs" Inherits="SIGEDOC.Vistas.Bitacora" %>
<%@ Register assembly="CrystalDecisions.Web, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <CR:CrystalReportViewer ID="BitacoraRPT" runat="server" AutoDataBind="true" Height="100px" ToolPanelWidth="100px"/>


</asp:Content>
