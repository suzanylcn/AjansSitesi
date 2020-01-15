using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AjansFirmaSite
{
    public partial class _Default : Page
    {
        public List<hizmet> siteList = new List<hizmet>();
        public List<Calısan> calısanList = new List<Calısan>();
        public List<proje> projeList = new List<proje>();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Server=DESKTOP-6GBHM2T\\SQLEXPRESS;Database=ajans;Integrated Security=true;");
            baglan.Open();
            SqlCommand komut = new SqlCommand("select*from hizmetler", baglan);
            SqlDataReader dabasedengelenveri = komut.ExecuteReader();
            while (dabasedengelenveri.Read())
            {
                hizmet sitecik = new hizmet();
                sitecik.id = Convert.ToInt32(dabasedengelenveri["id"]);
                sitecik.baslik = dabasedengelenveri["baslik"].ToString();
                sitecik.acıklama = dabasedengelenveri["acıklama"].ToString();
                sitecik.resim = dabasedengelenveri["resim"].ToString();
                siteList.Add(sitecik);
            }
            baglan.Close();

            SqlConnection baglan1 = new SqlConnection("Server=DESKTOP-6GBHM2T\\SQLEXPRESS;Database=ajans;Integrated Security=true;");
            baglan1.Open();
            SqlCommand komut1 = new SqlCommand("select*from calısanlar", baglan1);
            SqlDataReader dabasedengelenveri1 = komut1.ExecuteReader();
            while (dabasedengelenveri1.Read())
            {
                Calısan calis = new Calısan();
                calis.id = Convert.ToInt32(dabasedengelenveri1["id"]);
                calis.ad = dabasedengelenveri1["ad"].ToString();
                calis.soyad = dabasedengelenveri1["soyad"].ToString();
                calis.unvan = dabasedengelenveri1["unvan"].ToString();
                calis.resim = dabasedengelenveri1["resim"].ToString();
                calis.facebookLink = dabasedengelenveri1["facebookLink"].ToString();
                calis.twitterLink = dabasedengelenveri1["twitterLink"].ToString();
                calis.instagramLink = dabasedengelenveri1["instagramLink"].ToString();
                calısanList.Add(calis);
            }
            baglan1.Close();

            SqlConnection baglan2 = new SqlConnection("Server=DESKTOP-6GBHM2T\\SQLEXPRESS;Database=ajans;Integrated Security=true;");
            baglan2.Open();
            SqlCommand komut2 = new SqlCommand("select projeler.*, projeKategori.ad as kategori from projeler inner join projeKategori on projeler.kategoriId=projeKategori.id", baglan2);
            SqlDataReader projedengelenveri = komut2.ExecuteReader();

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
            baglan2.Close();

        }
        public string yaziKisalt(string yazi, int sayi)
        {


            string sonyazi = "";
            if (yazi.Length > sayi)
            {
                sonyazi = yazi.Substring(0, sayi);
            }
            else
            {
                sonyazi = yazi;
            }
            return sonyazi;

        }


    }
}