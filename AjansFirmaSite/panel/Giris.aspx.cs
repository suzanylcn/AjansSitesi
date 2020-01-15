using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AjansFirmaSite.panel
{
    public partial class Giris : System.Web.UI.Page
    {
        public string uyarı = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGiris_Click(object sender, EventArgs e)
        {
            string kAdi = txtkullaniciAdi.Text;
            string sifre = txtsifre.Text;

            SqlConnection baglan = new SqlConnection("Server=DESKTOP-6GBHM2T\\SQLEXPRESS;Database=ajans;Integrated Security=true;");
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select*from yoneticiler where kullaniciAdi='" + kAdi+"'and sifre ='" + sifre + "' ", baglan);
            SqlDataReader yoneticilerVeri = komut.ExecuteReader();
            if (yoneticilerVeri.Read())
            {
                Session["kullaniciAdi"] = yoneticilerVeri["kullaniciAdi"];
                Response.Redirect("anasayfa.aspx");
                Response.End();
            }
            else
            {
                uyarı= "Lütfen Kullanıcı Adı ve Şifrenizi Kontrol Edip Tekrar Deneyiniz.";
            }
        }
        
    }
}