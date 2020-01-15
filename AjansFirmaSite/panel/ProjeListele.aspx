<%@ Page Title="" Language="C#" MasterPageFile="~/panel/Panel.Master" AutoEventWireup="true" CodeBehind="ProjeListele.aspx.cs" Inherits="AjansFirmaSite.panel.ProjeListele" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h4>Hizmet Listesi</h4>

	<%-- 
		--%>

	<table class="table table-bordered">
		<thead>
			<tr>
				<th>#</th>
				<th>Başlık</th>
				<th>Kategori</th>
				<th>Resim</th>
				<th>Tarih</th>
				<th style="width:200px;">İşlem</th>
			</tr>
		</thead>
		<tbody>
			<%foreach (var item in projeList)
				{%>

			<tr>
				<td><%:item.id %></td>
				<td><%:item.ad %></td>
				<td><%:item.kategori %></td> 
				<td>
					
					<a href="../resimler/proje/<%:item.resim %>" class="btn btn-warning btn-sm" target="_blank">Resmi gör</a>

				</td>
				<td><%:item.tarih.ToString("dd/MM/yyyy") %></td>
				
				<td>
					<a class="btn btn-success btn-sm" href="ProjeListele.aspx?id=<%:item.id %>&islem=sil ">
						<i class="fa fa-trash"></i>
						Sil
					</a>

					<a class="btn btn-warning btn-sm " href="ProjeGuncelle.aspx?id=<%:item.id %>&islem=duzenle">
						<i class="fa fa-edit"></i>
						Düzenle
					</a>
				</td>
			</tr>


			<%} %>
		</tbody>
	</table>



</asp:Content>
