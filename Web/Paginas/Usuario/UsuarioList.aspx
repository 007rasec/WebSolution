<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UsuarioList.aspx.cs" Inherits="Web.Paginas.Usuario.UsuarioList" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	
	<asp:UpdatePanel ID="UpdatePanel1" runat="server">

		<contenttemplate>	
			<asp:Button ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click"/>
				<div class="row">
					<div class="col-lg-6">
						Id Usuario:
					</div>
					<div class="col-lg-6">
					


						<asp:TextBox ID="txtIdUsuario" ReadOnly="true" runat="server"></asp:TextBox>
					</div>
				</div>
				<div class="row">
					<div class="col-lg-6">
						Usuario:
					</div>
					<div class="col-lg-6">
						<asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
					</div>
				</div>
				<div class="row">
					<div class="col-lg-6">
						Password:
					</div>
					<div class="col-lg-6">
						<asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
					</div>
				</div>
				<div class="row">
					<div class="col-lg-6">
						Perfil:
					</div>
					<div class="col-lg-6">
						<asp:TextBox ID="txtPerfil" runat="server"></asp:TextBox>
					</div>
				</div>
				<div class="row">
					<div class="col-lg-6">
						Estado:
					</div>
					<div class="col-lg-6">
						<asp:CheckBox ID="chbxEstado" runat="server" />
					</div>
				</div>
				<div class="row">
					<div class="col-lg-6">
						<asp:Button ID="btnGrabar" runat="server" OnClick="btnGrabar_Click" Text="Grabar" />
						<asp:Button ID="btnCargar" runat="server" OnClick="btnCargar_Click" Text="Cargar" />
					</div>
				</div>
			<div class="row">
				<div class="col-lg-12">
					<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" EmptyDataText="Sin datos" Width="100%" 
						OnRowCommand="GridView1_RowCommand"> 
				<Columns>
					<asp:TemplateField HeaderText="Id Usuario"> 
						<ItemTemplate>
							<asp:Label runat="server" ID="lblIdUsuario" Text='<%# Bind("IdUsuario") %>'></asp:Label>
						</ItemTemplate>
					</asp:TemplateField>
					<asp:BoundField DataField="Usuario" HeaderText="Usuario" />
					<asp:BoundField DataField="Password" HeaderText="Password" />
					<asp:BoundField DataField="Perfil" HeaderText="Perfil" />
					<asp:CheckBoxField DataField="Estado" HeaderText="Estado" />
					<asp:BoundField DataField="UsuarioIngresa" HeaderText="Usuario Ingresa" />
					<asp:BoundField DataField="FechaIngreso" HeaderText="FechaIngreso" />
					<asp:BoundField DataField="UsuarioModifica" HeaderText="Usuario Modifica" />
					<asp:BoundField DataField="FechaModificacion" HeaderText="Fecha Modificación" />
					
					<asp:TemplateField HeaderText="Modificar">
						<ItemTemplate>
							<asp:ImageButton ID="Modificar" runat="server" CommandName="Modificar" CommandArgument='<%# ((GridViewRow)Container).RowIndex %>'  ImageUrl="~/Imagenes/002-guardar.png" />
						</ItemTemplate>
					</asp:TemplateField>
					
					<asp:TemplateField HeaderText="Eliminar">
						<ItemTemplate>
							<asp:Button ID="Eliminar" runat="server" CommandName="Eliminar" CommandArgument="<%# ((GridViewRow)Container).RowIndex %>"/>
						</ItemTemplate>
					</asp:TemplateField>
				</Columns>
			</asp:GridView>
				</div>
			</div>
			
			<asp:HiddenField ID="HiddenField1" runat="server" />

        </contenttemplate>
	</asp:UpdatePanel>
	
</asp:Content>
