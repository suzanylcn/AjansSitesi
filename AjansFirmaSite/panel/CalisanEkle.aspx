<%@ Page Title="" Language="C#" MasterPageFile="~/panel/Panel.Master" AutoEventWireup="true" CodeBehind="CalisanEkle.aspx.cs" Inherits="AjansFirmaSite.panel.CalisanEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	
	<h4>Çalışan Ekle</h4>

	
	<div class="col-md-4">



		
		<div class="form-group">

			<asp:Label CssClass="control-label" Text="Ad" runat="server" />
			<asp:TextBox CssClass="form-control" ID="Txtad" runat="server"></asp:TextBox>
		</div>
		<div class="form-group">
			<asp:Label CssClass="control-label" Text="Soyad" runat="server" />
			<asp:TextBox CssClass="form-control" ID="txtSoyad" runat="server"></asp:TextBox>


		</div>
		<div class="form-group">	
			<asp:Label CssClass="control-label" Text="Unvan" runat="server" />
			<asp:TextBox CssClass="form-control" ID="txtunvan" runat="server"></asp:TextBox>
		</div>
		<%--
			--%>
		<div class="form-group">	
			<asp:Label CssClass="control-label" Text="Resim Ekle" runat="server" />
			<asp:FileUpload ID="FileResim" runat="server" />
		</div>
		<div class="form-group">	
			<asp:Label CssClass="control-label" Text="Facebook" runat="server" />
			<asp:TextBox CssClass="form-control" ID="txtface" runat="server"></asp:TextBox>
		</div>
		<div class="form-group">	
			<asp:Label CssClass="control-label" Text="Twitter" runat="server" />
			<asp:TextBox CssClass="form-control" ID="txtwit" runat="server"></asp:TextBox>
		</div>
		<div class="form-group">	
			<asp:Label CssClass="control-label" Text="Instagram" runat="server" />
			<asp:TextBox CssClass="form-control" ID="txtInst" runat="server"></asp:TextBox>
		</div>
		
		<asp:Button CssClass="btn  btn-warning" ID="btKaydet" runat="server" OnClick="btKaydet_Click" Text="Kaydet" />

	</div>
</asp:Content>
