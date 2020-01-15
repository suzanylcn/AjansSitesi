using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AjansFirmaSite.panel
{
    public partial class ProjeKategoriGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection baglan = new SqlConnection("Server=DESKTOP-6GBHM2T\\SQLEXPRESS;Database=ajans;Integrated Security=true;");
                baglan.Open();


                string islemcik = Request.QueryString["islem"];

                int duzenlencekId = Convert.ToInt32(Request.QueryString["id"]);
                SqlCommand Komut = new SqlCommand("Select * From projeKategori where id=" + duzenlencekId, baglan);
                SqlDataReader projekategoridengelenveri = Komut.ExecuteReader();
                while (projekategoridengelenveri.Read())
                {
                    txtad.Text = projekategoridengelenveri["ad"].ToString();
                }

                baglan.Close();
            }
        }
        protected void btKaydet_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            SqlConnection baglan = new SqlConnection("Server=DESKTOP-6GBHM2T\\SQLEXPRESS;Database=ajans;Integrated Security=true;");
            baglan.Open();
            SqlCommand komut1 = new SqlCommand("update projeKategori Set ad=@adi where id=" + id, baglan);
            komut1.Parameters.Add("@adi", SqlDbType.Text).Value = txtad.Text;
            komut1.ExecuteNonQuery();
            Response.Redirect("ProjeKategoriListele.aspx");
            Response.End();
        }
    }
}