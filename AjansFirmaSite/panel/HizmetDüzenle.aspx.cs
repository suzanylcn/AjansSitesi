using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AjansFirmaSite.panel
{
    public partial class HizmetDüzenle : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                SqlConnection baglan = new SqlConnection("Server=DESKTOP-6GBHM2T\\SQLEXPRESS;Database=ajans;Integrated Security=true;");
                baglan.Open();

               


                string islemcik = Request.QueryString["islem"];
                
               
                if (islemcik == "duzenle")
                {
                    int duzenlencekId = Convert.ToInt32(Request.QueryString["id"]);
                    SqlCommand Komut = new SqlCommand("Select * From hizmetler where id=" + duzenlencekId, baglan);
                    SqlDataReader hizmetlerdengelenveri = Komut.ExecuteReader();
                    while (hizmetlerdengelenveri.Read())
                    {
                        Txtbaslik.Text = hizmetlerdengelenveri["baslik"].ToString();
                        txtaciklama.Text = hizmetlerdengelenveri["acıklama"].ToString();
                    }

                    baglan.Close();
                }
            }
        }

        protected void btKaydet_Click(object sender, EventArgs e)
        {
            

            string baslik = Txtbaslik.Text;

            string aciklama = txtaciklama.Text;

            int duzenlencekId = Convert.ToInt32(Request.QueryString["id"]);


            SqlConnection baglan = new SqlConnection("Server=DESKTOP-6GBHM2T\\SQLEXPRESS;Database=ajans;Integrated Security=true;");
            baglan.Open();

            string filename = "";

            if (FileResim.HasFile)
            {
                filename = DateTime.Now.ToString("dd/MM/yyyy hh/mm/ss") + Path.GetFileName(FileResim.FileName);
                FileResim.SaveAs(Server.MapPath("~/resimler/hizmetler/") + filename);
                string islemcik = Request.QueryString["islem"];
                
                    SqlCommand komut1 = new SqlCommand(String.Format("Update hizmetler Set baslik='{0}',acıklama ='{1}',resim='{2}' where id={3}", baslik, aciklama, filename, duzenlencekId), baglan);
                    komut1.ExecuteNonQuery();
            }
            
            else
            {
                SqlCommand komut1 = new SqlCommand(String.Format("Update hizmetler Set baslik='{0}',acıklama ='{1}' where id={2}", baslik, aciklama,  duzenlencekId), baglan);

                komut1.ExecuteNonQuery();

            }
              Response.Redirect("HizmetListele.aspx");
             Response.End();
        }
    }
}