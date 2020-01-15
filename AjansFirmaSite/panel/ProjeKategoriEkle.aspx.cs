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
    public partial class ProjeKategoriEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Server=DESKTOP-6GBHM2T\\SQLEXPRESS;Database=ajans;Integrated Security=true;");
            baglan.Open();

            SqlCommand komut = new SqlCommand("insert into projeKategori(ad) values(@adi)", baglan);
            komut.Parameters.Add("@adi", SqlDbType.Text).Value = txtad.Text;
            komut.ExecuteNonQuery();
            Response.Redirect("ProjeKategoriListele.aspx");
            Response.End();
        }
    }
}