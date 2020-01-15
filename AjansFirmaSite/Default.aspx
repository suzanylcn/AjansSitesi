<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AjansFirmaSite._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


	<!-- Header -->
	<header class="masthead" style="position:relative;">
		<div style="position:absolute; width:100%; height:100%; background:black;background: #00000066;">

		</div>
		<div class="container">
			<div class="intro-text" style="text-shadow: 2px 2px 2px black;">
				<div class="intro-heading text-uppercase">WEB TASARIM</div>
				<div class="intro-lead-in">Tüm Tarayıcılar ile Uyumlu Esnek, Yönetilebilir, Yeni Trend Web siteleri</div>
			</div>
		</div>
	</header>

	<!-- Services -->
	<section class="page-section" id="services">
		<div class="container">
			<div class="row">
				<div class="col-lg-12 text-center">
					<h2 class="section-heading text-uppercase">Hizmetlerimiz</h2>
					<h3 class="section-subheading text-muted">...</h3>
				</div>
			</div>
			<div class="row text-center">


				<%
					foreach (var item in siteList)
					{ %>

				<div class="col-md-4">
					<span class="fa-stack fa-4x">

						<img src="resimler/hizmetler/<%:item.resim %>" style="width: 135px; height: 135px; border-radius: 50%;" />
					</span>
					<h4 class="service-heading">
						<%:yaziKisalt(item.baslik,30)%>
					</h4>
					<p class="text-muted">
						<%:item.acıklama%>
					</p>
				</div>

				<%	} %>


			</div>
		</div>
	</section>



	<section class="bg-light page-section" id="portfolio">
		<div class="container">
			<div class="row">
				<div class="col-lg-12 text-center">
					<h2 class="section-heading text-uppercase">Projeler</h2>
					<h3 class="section-subheading text-muted">Yapmış olduğumuz projelerin bir kaçı.</h3>
				</div>
			</div>
			<div class="row">


				<%foreach (var item in projeList)
					{%>


				<div class="col-md-4 col-sm-6 portfolio-item">
					
					<a class="portfolio-link" data-toggle="modal" href="#modal<%:item.id %>">
						<div class="portfolio-hover">
							<div class="portfolio-hover-content">
								<i class="fas fa-plus fa-3x"></i>
							</div>
						</div>
						<img class="img-fluid" src="resimler/proje/<%:item.resim %>" style="width: 100%; height: 200px; object-fit: cover; **">
					</a>
					<div class="portfolio-caption">
						<h4><%:item.ad %></h4>
						<p class="text-muted"><%:yaziKisalt(item.aciklama,110)%></p>
					</div>
				</div>





				<%}   %>
			</div>
		</div>
	</section>

	<!-- About -->
	

	<!-- Team -->
	<section class="bg-light page-section" id="team">
		<div class="container">
			<div class="row">
				<div class="col-lg-12 text-center">
					<h2 class="section-heading text-uppercase">Çalışanlarımız</h2>
					<h3 class="section-subheading text-muted">Lorem ipsum dolor sit amet consectetur.</h3>
				</div>
			</div>


			<div class="row">

				<%foreach (var item in calısanList)
					{ %>
				<div class="col-sm-4">
					<div class="team-member">
						<img class="mx-auto rounded-circle" src="resimler/calisan/<%:item.resim %>" alt="">
						<h4><%:item.ad %></h4>
						<h4><%:item.soyad %></h4>
						<p class="text-muted"><%:item.unvan %></p>
						<ul class="list-inline social-buttons">
							<li class="list-inline-item">
								<%--  --%>
								<a href="<%:item.twitterLink %>">
									<i class="fab fa-twitter"></i>
								</a>
							</li>
							<li class="list-inline-item">
								<a href="<%:item.facebookLink %>">
									<i class="fab fa-facebook-f"></i>
								</a>
							</li>

							<li class="list-inline-item">
								<a href="<%:item.instagramLink %>">
									<i class="fab fa-instagram"></i>
								</a>
							</li>
						</ul>
					</div>
				</div>



				<%} %>
			</div>


			
		</div>
	</section>

	<!-- Clients -->
	

	<!-- Contact -->
	<section class="page-section" id="contact">
		<div class="container">
			<div class="row">
				<div class="col-lg-12 text-center">
					<h2 class="section-heading text-uppercase">Contact Us</h2>
					<h3 class="section-subheading text-muted">Lorem ipsum dolor sit amet consectetur.</h3>
				</div>
			</div>
			<div class="row">
				<div class="col-lg-12">

					<form id="contactForm" name="sentMessage" novalidate="novalidate">
						<div class="row">
							<div class="col-md-6">
								<div class="form-group">
									<input class="form-control" id="name" type="text" placeholder="Your Name *" required="required" data-validation-required-message="Please enter your name.">
									<p class="help-block text-danger"></p>
								</div>
								<div class="form-group">
									<input class="form-control" id="email" type="email" placeholder="Your Email *" required="required" data-validation-required-message="Please enter your email address.">
									<p class="help-block text-danger"></p>
								</div>
								<div class="form-group">
									<input class="form-control" id="phone" type="tel" placeholder="Your Phone *" required="required" data-validation-required-message="Please enter your phone number.">
									<p class="help-block text-danger"></p>
								</div>
							</div>
							<div class="col-md-6">
								<div class="form-group">
									<textarea class="form-control" id="message" placeholder="Your Message *" required="required" data-validation-required-message="Please enter a message."></textarea>
									<p class="help-block text-danger"></p>
								</div>
							</div>
							<div class="clearfix"></div>
							<div class="col-lg-12 text-center">
								<div id="success"></div>
								<button id="sendMessageButton" class="btn btn-primary btn-xl text-uppercase" type="submit">Send Message</button>
							</div>
						</div>
					</form>
				</div>
			</div>
		</div>
	</section>


	<!-- Portfolio Modals -->
	<%
		foreach (var projecik in projeList)
		{
	%>
	<div class="portfolio-modal modal fade" id="modal<%:projecik.id %>" tabindex="-1" role="dialog" aria-hidden="true">
		<div class="modal-dialog">
			<div class="modal-content">
				<div class="close-modal" data-dismiss="modal">
					<div class="lr">
						<div class="rl"></div>
					</div>
				</div>
				<div class="container">
					<div class="row">
						<div class="col-lg-8 mx-auto">
							<div class="modal-body">
								<!-- Project Details Go Here -->
								<h2 class="text-uppercase"><%:projecik.ad %></h2>
								<img class="img-fluid d-block mx-auto" src="resimler/proje/<%:projecik.resim %>" alt="">
								<p>
									<%:projecik.aciklama %>
								</p>
								<ul class="list-inline">
									<li>Tarih: <%:projecik.tarih.ToString("dd/MM/yyy") %></li>
									<li>Kategori: <%:projecik.kategori %></li>
								</ul>
								<button class="btn btn-primary" data-dismiss="modal" type="button">
									<i class="fas fa-times"></i>
									Pencereyi Kapat
								</button>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
	</div>

	<% } %>
</asp:Content>
