<%@ Page Title="" Language="C#" MasterPageFile="~/panel/Panel.Master" AutoEventWireup="true" CodeBehind="HizmetListele.aspx.cs" Inherits="AjansFirmaSite.panel.HizmetListele" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	
	<h4>Hizmet Listesi</h4>

	<%-- 
		
		--%>

	<table class="table table-bordered">
		<thead>
			<tr>
				<th>#</th>
				<th>Başlık</th>
				<th>Açıklama</th>
				<th>Resim</th>
				<th style="width:200px;">İşlem</th>
			</tr>
		</thead>
		<tbody>

			<%foreach (var item in hizmetlist)
				{%>

			<tr>
				<td><%:item.id %></td>
				<td><%:item.baslik %></td>
				<td><%:item.acıklama %></td>
				<td><%:item.resim %></td>
				
				<td>
					<a class="btn btn-primary btn-xs" href="HizmetListele.aspx?id=<%:item.id %>&islem=sil ">
						<i class="fa fa-trash"></i>
						Sil
					</a>


					<a class="btn btn-info btn-xs " href="HizmetDüzenle.aspx?id=<%:item.id %>&islem=duzenle">
						
					
						<i class="fa fa-edit"></i>

						Düzenle

					</a>
				</td>
			</tr>


			<%} %>
		</tbody>
	</table>


</asp:Content>
