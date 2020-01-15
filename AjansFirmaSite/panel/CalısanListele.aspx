<%@ Page Title="" Language="C#" MasterPageFile="~/panel/Panel.Master" AutoEventWireup="true" CodeBehind="CalısanListele.aspx.cs" Inherits="AjansFirmaSite.panel.CalısanListele" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<h4>Çalışanlar Listesi</h4>

	<%-- 
		
	--%>

	<table class="table table-bordered">
		<thead>
			<tr>
				<th>#</th>
				<th>Ad</th>
				<th>Soyad</th>
				<th>Unvan</th>

				<th style="width: 200px;">İşlem</th>
			</tr>
		</thead>
		<tbody>

			<%foreach (var item in calisanlist)
				{%>

			<tr>
				<td><%:item.id %></td>
				<td><%:item.ad %></td>
				<td><%:item.soyad %></td>
				<td><%:item.unvan %></td>

				<td>
					
					<a class="btn btn-danger btn-xs" href="CalısanListele.aspx?id=<%:item.id %>&islem=sil">
						<i class="fa fa-trash"></i>
						Sil
					</a>

	
					<a class="btn btn-info btn-xs " href="CalisanGuncelle.aspx?id=<%:item.id %>">
						<i class="fa fa-edit"></i>

						Düzenle

					</a>
				</td>
			</tr>

			<%} %>
		</tbody>

	</table>


</asp:Content>
