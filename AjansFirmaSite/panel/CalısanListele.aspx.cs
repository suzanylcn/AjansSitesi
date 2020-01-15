using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AjansFirmaSite.panel
{
    public partial class CalısanListele : System.Web.UI.Page
    {
        public List<Calısan> calisanlist = new List<Calısan>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["kullaniciAdi"] == null)
            {
                Response.Redirect("Login.aspx");
                Response.End();
            }
            SqlConnection baglan = new SqlConnection("Server=DESKTOP-6GBHM2T\\SQLEXPRESS;Database=ajans;Integrated Security=true;");
            baglan.Open();


            string islemcik = Request.QueryString["islem"];
           
            if (islemcik=="sil")
            {
                int silinecekid = Convert.ToInt32( Request.QueryString["id"]);
                SqlCommand komut1 = new SqlCommand("Delete from calısanlar where id=" + silinecekid, baglan);
                komut1.ExecuteNonQuery();
            }










            SqlCommand komut = new SqlCommand("select*from calısanlar", baglan);

            SqlDataReader calisanlardangelenveri = komut.ExecuteReader();

            while (calisanlardangelenveri.Read())
            {
                Calısan calis = new Calısan();
                calis.id = Convert.ToInt32(calisanlardangelenveri["id"]);
                calis.ad = calisanlardangelenveri["ad"].ToString();
                calis.soyad = calisanlardangelenveri["soyad"].ToString();
                calis.unvan = calisanlardangelenveri["unvan"].ToString();
                calis.resim = calisanlardangelenveri["resim"].ToString();
                calis.facebookLink= calisanlardangelenveri["facebookLink"].ToString();
                calis.twitterLink = calisanlardangelenveri["twitterLink"].ToString();
                calis.instagramLink = calisanlardangelenveri["instagramLink"].ToString();
                calisanlist.Add(calis);
            }
            baglan.Close();
        }
    }
}