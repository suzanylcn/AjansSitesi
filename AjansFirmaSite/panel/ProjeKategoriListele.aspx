<%@ Page Title="" Language="C#" MasterPageFile="~/panel/Panel.Master" AutoEventWireup="true" CodeBehind="ProjeKategoriListele.aspx.cs" Inherits="AjansFirmaSite.panel.ProjeKategoriListele" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


	<h4>Proje Kategori Listesi</h4>


	<table class="table table-bordered">
		<thead>
			<tr>
				<th>#</th>
				<th>Ad</th>

				<th style="width: 200px;">İşlem</th>
			</tr>
		</thead>
		<tbody>

			<%foreach (var item in kategorilist)
				{
			%>
			<tr>
				<td><%:item.id %></td>
				<td><%:item.ad %></td>

				<td>
					<a class="btn btn-danger btn-xs" href="ProjeKategoriListele.aspx?id=<%:item.id %>&islem=sil">
						<i class="fa fa-trash"></i>
						Sil
					</a>
					<a class="btn btn-info btn-xs " href="ProjeKategoriGuncelle.aspx?id=<%:item.id %>">
						<i class="fa fa-edit"></i>
						Düzenle
					</a>
				</td>
			</tr>

			<%} %>
		</tbody>

	</table>

</asp:Content>
