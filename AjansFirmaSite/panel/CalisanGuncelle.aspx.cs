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
    public partial class CalisanGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack == false)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                SqlConnection baglan = new SqlConnection("Server=DESKTOP-6GBHM2T\\SQLEXPRESS;Database=ajans;Integrated Security=true;");
                baglan.Open();






                SqlCommand komut = new SqlCommand("Select*from calısanlar where id =" + id, baglan);
                SqlDataReader calisandangelenveri = komut.ExecuteReader();
                while (calisandangelenveri.Read())
                {

                    Txtad.Text = calisandangelenveri["ad"].ToString();
                    txtSoyad.Text = calisandangelenveri["soyad"].ToString();
                    txtunvan.Text = calisandangelenveri["unvan"].ToString();
                    txtInst.Text = calisandangelenveri["instagramLink"].ToString();
                    txtface.Text = calisandangelenveri["facebookLink"].ToString();
                    txtwit.Text = calisandangelenveri["twitterLink"].ToString();

                }
                baglan.Close();

            }



        }

        protected void btKaydet_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
          
            SqlConnection baglan = new SqlConnection("Server=DESKTOP-6GBHM2T\\SQLEXPRESS;Database=ajans;Integrated Security=true;");
            baglan.Open();


            
            string filename = "";

            if (FileResim.HasFile)
            {
                filename = DateTime.Now.ToString("dd/MM/yyyy hh/mm/ss") + Path.GetFileName(FileResim.FileName);
                
                
                FileResim.SaveAs(Server.MapPath("~/resimler/calisan/") + filename);
                SqlCommand komut1 = new SqlCommand("update calısanlar Set ad=@adi,soyad=@soyadi,unvan=@unvani,resim=@resimi,instagramLink=@instagramLinki,facebookLink=@facebookLinki,twitterLink=@twitterLinki where id=" + id, baglan);
                komut1.Parameters.Add("@adi", SqlDbType.Text).Value = Txtad.Text;
                komut1.Parameters.Add("@soyadi", SqlDbType.Text).Value = txtSoyad.Text;
                komut1.Parameters.Add("@unvani", SqlDbType.Text).Value = txtunvan.Text;
                komut1.Parameters.Add("@resimi", SqlDbType.Text).Value = filename;
                komut1.Parameters.Add("@facebookLinki", SqlDbType.Text).Value = txtface.Text;
                komut1.Parameters.Add("@twitterLinki", SqlDbType.Text).Value = txtwit.Text;
                komut1.Parameters.Add("@instagramLinki", SqlDbType.Text).Value = txtInst.Text;

                komut1.ExecuteNonQuery();


            }
            else
            {
               
                SqlCommand komut1 = new SqlCommand("update calısanlar Set ad=@adi,soyad=@soyadi,unvan=@unvani,instagramLink=@instagramLinki,facebookLink=@facebookLinki,twitterLink=@twitterLinki where id=" + id, baglan);
                komut1.Parameters.Add("@adi", SqlDbType.Text).Value = Txtad.Text;
                komut1.Parameters.Add("@soyadi", SqlDbType.Text).Value = txtSoyad.Text;
                komut1.Parameters.Add("@unvani", SqlDbType.Text).Value = txtunvan.Text;
                komut1.Parameters.Add("@facebookLinki", SqlDbType.Text).Value = txtface.Text;
                komut1.Parameters.Add("@twitterLinki", SqlDbType.Text).Value = txtwit.Text;
                komut1.Parameters.Add("@instagramLinki", SqlDbType.Text).Value = txtInst.Text;

                komut1.ExecuteNonQuery();
            }


            Response.Redirect("CalısanListele.aspx");
            Response.End();

        }
    }
}