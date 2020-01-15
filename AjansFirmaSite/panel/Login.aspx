﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AjansFirmaSite.panel.Login1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<title></title>

	<!-- Custom fonts for this template-->
	<link href="assets/vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css" />
	<link href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i" rel="stylesheet" />

	<!-- Custom styles for this template-->
	<link href="assets/css/sb-admin-2.min.css" rel="stylesheet" />
</head>
<body class="bg-gradient-primary">
	<form id="form1" runat="server">
		<div>

			


			<div class="container">

				<!-- Outer Row -->
				<div class="row justify-content-center">

					<div class="col-xl-10 col-lg-12 col-md-9">

						<div class="card o-hidden border-0 shadow-lg my-5">
							<div class="card-body p-0">
								<!-- Nested Row within Card Body -->
								<div class="row">
									<div class="col-lg-6 d-none d-lg-block bg-login-image"></div>
									<div class="col-lg-6" style="height: 450px;">
										<div class="p-5">
											<div class="text-center">
												<h1 class="h4 text-gray-900 mb-4">Welcome Back!</h1>
											</div>

											<%-- 
											
											--%>

											<div class="user">
												<div class="form-group">
													<asp:TextBox class="form-control form-control-user" ID="txtkullaniciAdi" AutoCompleteType="Disabled" placeholder="Kullanıcı Adı Giriniz..." runat="server"></asp:TextBox>
												</div>
												<div class="form-group">
													<asp:TextBox class="form-control form-control-user" ID="txtsifre"   type="password" placeholder="Şifre Giriniz..." runat="server"></asp:TextBox>
												</div>
												<asp:Button ID="btnGiris" class="btn btn-primary btn-user btn-block" OnClick="btnGiris_Click" runat="server" Text="Giriş Yap" />
												
												
												<strong>
													<%:uyarı %>
												</strong>
											</div>

										</div>
									</div>
								</div>
							</div>
						</div>

					</div>

				</div>

			</div>

			<!-- Bootstrap core JavaScript-->
			<script src="assets/vendor/jquery/jquery.min.js"></script>
			<script src="assets/vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

			<!-- Core plugin JavaScript-->
			<script src="assets/vendor/jquery-easing/jquery.easing.min.js"></script>

			<!-- Custom scripts for all pages-->
			<script src="assets/js/sb-admin-2.min.js"></script>



		</div>
	</form>
</body>
</html>
