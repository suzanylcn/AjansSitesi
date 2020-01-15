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
    public partial class HizmetEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Server=DESKTOP-6GBHM2T\\SQLEXPRESS;Database=ajans;Integrated Security=true;");
            baglan.Open();
            string filename = "";

            if (FileResim.HasFile)
            {
                filename = DateTime.Now.ToString("dd/MM/yyyy hh/mm/ss") + Path.GetFileName(FileResim.FileName);
                FileResim.SaveAs(Server.MapPath("~/resimler/hizmetler/") + filename);
            }

            SqlCommand komut=new SqlCommand("insert into hizmetler(baslik,acıklama,resim)values(@baslık,@acıklama,@resimi)",baglan);
            komut.Parameters.Add("@baslık", SqlDbType.Text).Value = Txtbaslik.Text;
            komut.Parameters.Add("@acıklama", SqlDbType.Text).Value = txtaciklama.Text;
            komut.Parameters.Add("@resimi", SqlDbType.Text).Value = filename;
            komut.ExecuteNonQuery();
            Response.Redirect("HizmetListele.aspx");
            Response.End();
        }
    }
}