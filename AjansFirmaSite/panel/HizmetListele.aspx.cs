using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AjansFirmaSite.panel
{
    public partial class HizmetListele : System.Web.UI.Page
    {
        public List<hizmet> hizmetlist = new List<hizmet>();
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
            
            if (islemcik == "sil")
            {
                int silincekId = Convert.ToInt32(Request.QueryString["id"]);
                SqlCommand komut1 = new SqlCommand("Delete from hizmetler where id=" + silincekId, baglan);

                komut1.ExecuteNonQuery();
            }
            SqlCommand komut = new SqlCommand("select*from hizmetler", baglan);
            SqlDataReader hizmetlerdengelenveri = komut.ExecuteReader();
            while (hizmetlerdengelenveri.Read())
            {
                hizmet hzmt = new hizmet();
                hzmt.id = Convert.ToInt32(hizmetlerdengelenveri["id"]);
                hzmt.baslik = hizmetlerdengelenveri["baslik"].ToString();
                hzmt.acıklama = hizmetlerdengelenveri["acıklama"].ToString();
                hzmt.resim = hizmetlerdengelenveri["resim"].ToString();
                hizmetlist.Add(hzmt);
            }
            baglan.Close();

            
        }
    }
}