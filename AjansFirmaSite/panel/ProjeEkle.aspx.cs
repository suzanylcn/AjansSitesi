using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AjansFirmaSite.panel
{
    public partial class ProjeEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            SqlConnection baglan = new SqlConnection("Server=DESKTOP-6GBHM2T\\SQLEXPRESS;Database=ajans;Integrated Security=true;");
            baglan.Open();

            SqlCommand komut = new SqlCommand("select*from projeKategori", baglan);
            SqlDataReader projeKategoriVeri = komut.ExecuteReader();

            List<projeKategori> projeKategoriList = new List<projeKategori>();

            while (projeKategoriVeri.Read())
            {
                projeKategori projeKategoricik = new projeKategori();

                projeKategoricik.ad = projeKategoriVeri["ad"].ToString();
                projeKategoricik.id = Convert.ToInt32(projeKategoriVeri["id"]);

                projeKategoriList.Add(projeKategoricik);
            }

            drpKategori.DataSource = projeKategoriList;
            drpKategori.DataValueField = "id";
            drpKategori.DataTextField = "ad";
            drpKategori.DataBind();

        }

        protected void btKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Server=DESKTOP-6GBHM2T\\SQLEXPRESS;Database=ajans;Integrated Security=true;");
            baglan.Open();
            string filename = "";

            if (FileResim.HasFile)
            {
                filename = DateTime.Now.ToString("dd/MM/yyyy hh/mm/ss") + Path.GetFileName(FileResim.FileName);
                FileResim.SaveAs(Server.MapPath("~/resimler/proje/") + filename);
            }
            SqlCommand komut = new SqlCommand("insert into projeler(ad,aciklama,resim,tarih,kategoriId)values(@ad,@acıklama,@resimi,@tarihi,@kategorisi)", baglan);
            komut.Parameters.Add("@ad", SqlDbType.Text).Value = txtAd.Text;
            komut.Parameters.Add("@acıklama", SqlDbType.Text).Value = txtaciklama.Text;
            komut.Parameters.Add("@resimi", SqlDbType.Text).Value = filename;
            komut.Parameters.Add("@kategorisi", SqlDbType.Int).Value = drpKategori.SelectedValue;
            komut.Parameters.Add("@tarihi", SqlDbType.Date).Value = txttarih.Text;
            komut.ExecuteNonQuery();
            Response.Redirect("ProjeListele.aspx");
            Response.End();
        }
        
    }
}