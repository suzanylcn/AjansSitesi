using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AjansFirmaSite.panel
{
    public partial class ProjeListele : System.Web.UI.Page
    {
        public List<proje> projeList = new List<proje>();
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
                SqlCommand komut1 = new SqlCommand("Delete from projeler where id=" + silincekId, baglan);

                komut1.ExecuteNonQuery();
            }
            SqlCommand komut = new SqlCommand("select projeler.*, projeKategori.ad as kategori from projeler inner join projeKategori on projeler.kategoriId = projeKategori.id", baglan);
            SqlDataReader projedengelenveri = komut.ExecuteReader();

            while (projedengelenveri.Read())
            {
                proje projecik = new proje();
                projecik.id = Convert.ToInt32(projedengelenveri["id"]);
                projecik.ad = projedengelenveri["ad"].ToString();
                projecik.aciklama = projedengelenveri["aciklama"].ToString();
                projecik.resim = projedengelenveri["resim"].ToString();
                projecik.kategori = projedengelenveri["kategori"].ToString();
                projecik.tarih = Convert.ToDateTime(projedengelenveri["tarih"]);
                projeList.Add(projecik);
            }
            baglan.Close();
        }
    }
}