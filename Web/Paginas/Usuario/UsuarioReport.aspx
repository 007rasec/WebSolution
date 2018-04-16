<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UsuarioReport.aspx.cs" Inherits="Web.Paginas.Usuario.UsuarioReport" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=14.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

	<asp:UpdatePanel ID="UpdatePanel1" runat="server">
		<ContentTemplate>
			
        
			<a href="http://localhost/ReportServer/Pages/ReportViewer.aspx?%2fWeb.Report%2fReporteUsuario&rs:Command=Render">Reporte</a>
		</ContentTemplate>
	</asp:UpdatePanel>

</asp:Content>
