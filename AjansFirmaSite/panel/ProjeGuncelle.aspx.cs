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
    public partial class ProjeGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection baglan = new SqlConnection("Server=DESKTOP-6GBHM2T\\SQLEXPRESS;Database=ajans;Integrated Security=true;");
                baglan.Open();

                List<projeKategori> projeKategoriList = new List<projeKategori>();
                SqlCommand Komut1 = new SqlCommand("Select * From projeKategori", baglan);
                SqlDataReader kategoridendengelenveri = Komut1.ExecuteReader();
                while (kategoridendengelenveri.Read())
                {
                    projeKategori projeKategoricik = new projeKategori();
                    projeKategoricik.id = Convert.ToInt32(kategoridendengelenveri["id"]);
                    projeKategoricik.ad = kategoridendengelenveri["ad"].ToString();
                    projeKategoriList.Add(projeKategoricik);
                }
                kategoridendengelenveri.Close();

                drpKategori.DataSource = projeKategoriList;
                drpKategori.DataValueField = "id";
                drpKategori.DataTextField = "ad";
                drpKategori.DataBind();

                int duzenlencekId = Convert.ToInt32(Request.QueryString["id"]);
                SqlCommand Komut = new SqlCommand("Select * From projeler where id=" + duzenlencekId, baglan);
                SqlDataReader projedengelenveri = Komut.ExecuteReader();
                
                while (projedengelenveri.Read())
                {
                    txtad.Text = projedengelenveri["ad"].ToString();
                    txtaciklama.Text = projedengelenveri["aciklama"].ToString();
                    txttarih.Text = Convert.ToDateTime(projedengelenveri["tarih"]).ToString("yyyy-MM-dd");



                    drpKategori.SelectedValue = projedengelenveri["kategoriId"].ToString();

                }

               

                baglan.Close();

            }
        }

        protected void btKaydet_Click1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            SqlConnection baglan = new SqlConnection("Server=DESKTOP-6GBHM2T\\SQLEXPRESS;Database=ajans;Integrated Security=true;");
            baglan.Open();
            string filename = "";
            if (FileResim.HasFile)
            {
                filename = DateTime.Now.ToString("dd/MM/yyyy hh/mm/ss") + Path.GetFileName(FileResim.FileName);
                FileResim.SaveAs(Server.MapPath("~/resimler/proje/") + filename);
                SqlCommand komut = new SqlCommand("update projeler set ad=@ad,aciklama=@acıklama,resim=@resimi,tarih=@tarihi,kategoriId=@kategorisi where id=" + id, baglan);
                komut.Parameters.Add("@ad", SqlDbType.Text).Value = txtad.Text;
                komut.Parameters.Add("@acıklama", SqlDbType.Text).Value = txtaciklama.Text;
                komut.Parameters.Add("@resimi", SqlDbType.Text).Value = filename;
                komut.Parameters.Add("@kategorisi", SqlDbType.Int).Value = drpKategori.SelectedValue;
                komut.Parameters.Add("@tarihi", SqlDbType.Date).Value = txttarih.Text;
                komut.ExecuteNonQuery();
            }
            else
            {
                SqlCommand komut = new SqlCommand("update projeler set ad=@ad,aciklama=@acıklama,tarih=@tarihi,kategoriId=@kategorisi where id=" + id, baglan);
                komut.Parameters.Add("@ad", SqlDbType.Text).Value = txtad.Text;
                komut.Parameters.Add("@acıklama", SqlDbType.Text).Value = txtaciklama.Text;
                komut.Parameters.Add("@kategorisi", SqlDbType.Int).Value = drpKategori.SelectedValue;
                komut.Parameters.Add("@tarihi", SqlDbType.Date).Value = txttarih.Text;
                komut.ExecuteNonQuery();

            }

            baglan.Close();

            Response.Redirect("ProjeListele.aspx");
            Response.End();
        }
    }
}