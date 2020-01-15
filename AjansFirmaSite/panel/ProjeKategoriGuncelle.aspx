<%@ Page Title="" Language="C#" MasterPageFile="~/panel/Panel.Master" AutoEventWireup="true" CodeBehind="ProjeKategoriGuncelle.aspx.cs" Inherits="AjansFirmaSite.panel.ProjeKategoriGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<h4>Proje Kategorisi Güncelle</h4>

	
	<div class="col-md-4">
		
		<div class="form-group">

			<asp:Label CssClass="control-label" Text="Kategori Adı" runat="server" />
			<asp:TextBox CssClass="form-control" ID="txtad" runat="server"></asp:TextBox>
		</div>
		
		<asp:Button CssClass="btn  btn-warning" ID="btKaydet" runat="server" OnClick="btKaydet_Click" Text="Kaydet" />

	</div>

</asp:Content>
