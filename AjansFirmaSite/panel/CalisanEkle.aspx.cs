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
    public partial class CalisanEkle : System.Web.UI.Page
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
                FileResim.SaveAs(Server.MapPath("~/resimler/calisan/") + filename);
            }


            SqlCommand komut = new SqlCommand("insert into calısanlar(ad,soyad,unvan,resim,facebookLink,twitterLink,instagramLink)values(@adi,@soyadi,@unvani,@resimi,@facebookLinki,@twitterLinki,@instagramLinki)", baglan);
            komut.Parameters.Add("@adi", SqlDbType.Text).Value = Txtad.Text;
            komut.Parameters.Add("@soyadi", SqlDbType.Text).Value = txtSoyad.Text;
            komut.Parameters.Add("@unvani", SqlDbType.Text).Value = txtunvan.Text;
            komut.Parameters.Add("@resimi", SqlDbType.Text).Value = filename;
            komut.Parameters.Add("@facebookLinki", SqlDbType.Text).Value = txtface.Text;
            komut.Parameters.Add("@twitterLinki", SqlDbType.Text).Value = txtwit.Text;
            komut.Parameters.Add("@instagramLinki", SqlDbType.Text).Value = txtInst.Text;
            komut.ExecuteNonQuery();
            Response.Redirect("CalısanListele.aspx");
            Response.End();
        }
    }
}