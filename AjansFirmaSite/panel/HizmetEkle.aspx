<%@ Page Title="" Language="C#" MasterPageFile="~/panel/Panel.Master" AutoEventWireup="true" CodeBehind="HizmetEkle.aspx.cs" Inherits="AjansFirmaSite.panel.HizmetEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



	<h4>Hizmet Ekle</h4>

	<div class="col-md-4">

		<div class="form-group">

			<asp:Label CssClass="control-label" Text="Başlık" runat="server" />
			<asp:TextBox CssClass="form-control" ID="Txtbaslik" runat="server"></asp:TextBox>
		</div>
		<div class="form-group">
			<asp:Label CssClass="control-label" Text="Açıklama" runat="server" />
			<asp:TextBox CssClass="form-control" ID="txtaciklama" runat="server"></asp:TextBox>

			<div class="form-group">	
			<asp:Label CssClass="control-label" Text="Resim Ekle" runat="server" />
			<asp:FileUpload ID="FileResim" runat="server" />
		</div>
		</div>


		<asp:Button CssClass="btn  btn-warning" ID="btKaydet" runat="server" OnClick="btKaydet_Click" Text="Kaydet" />

	</div>
</asp:Content>
