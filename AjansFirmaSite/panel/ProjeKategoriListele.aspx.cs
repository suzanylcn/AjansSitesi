using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AjansFirmaSite.panel
{
    public partial class ProjeKategoriListele : System.Web.UI.Page
    {
        public List<projeKategori> kategorilist = new List<projeKategori>();
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
                int silinecekid = Convert.ToInt32(Request.QueryString["id"]);
                SqlCommand komut1 = new SqlCommand("Delete from projeKategori where id=" + silinecekid, baglan);
                komut1.ExecuteNonQuery();
            }

            SqlCommand komut = new SqlCommand("select*from projeKategori", baglan);

            SqlDataReader calisanlardangelenveri = komut.ExecuteReader();

            while (calisanlardangelenveri.Read())
            {
                projeKategori kategori = new projeKategori();
                kategori.id = Convert.ToInt32(calisanlardangelenveri["id"]);
                kategori.ad = calisanlardangelenveri["ad"].ToString();
                kategorilist.Add(kategori);
            }
            baglan.Close();
        }
    }
}