<%@ Page Title="" Language="C#" MasterPageFile="~/panel/Panel.Master" AutoEventWireup="true" CodeBehind="ProjeEkle.aspx.cs" Inherits="AjansFirmaSite.panel.ProjeEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<h4>Proje Ekle</h4>

	<div class="col-md-4">

		<div class="form-group">
			<asp:Label CssClass="control-label" Text="Kategori" runat="server" />
			<asp:DropDownList CssClass="form-control" ID="drpKategori" runat="server"></asp:DropDownList>
		</div>

		<div class="form-group">
			<asp:Label CssClass="control-label" Text="Ad" runat="server" />
			<asp:TextBox CssClass="form-control" ID="txtAd" runat="server"></asp:TextBox>
		</div>

		<div class="form-group">
			<asp:Label CssClass="control-label" Text="Açıklama" runat="server" />
			<asp:TextBox CssClass="form-control" ID="txtaciklama" runat="server"></asp:TextBox>
		</div>

		<div class="form-group">
			<asp:Label CssClass="control-label" Text="Resim Ekle" runat="server" />
			<asp:FileUpload ID="FileResim" runat="server" />
		</div>

		<div class="form-group">
			<asp:Label CssClass="control-label" Text="Tarih" runat="server" />
			<asp:TextBox CssClass="form-control" ID="txttarih" type="date" runat="server"></asp:TextBox>
		</div>

		<asp:Button CssClass="btn  btn-warning" ID="btKaydet" runat="server" OnClick="btKaydet_Click" Text="Kaydet" />
	</div>



</asp:Content>
