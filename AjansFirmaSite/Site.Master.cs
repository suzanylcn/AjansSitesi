using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AjansFirmaSite
{
    public partial class SiteMaster : MasterPage
    {
        public static Ayar ayarcik = new Ayar();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection baglan1 = new SqlConnection("Server=DESKTOP-6GBHM2T\\SQLEXPRESS;Database=ajans;Integrated Security=true;");
            baglan1.Open();
            SqlCommand komut1 = new SqlCommand("select*from siteayarlari where id=2", baglan1);
            SqlDataReader dabasedengelenveri1 = komut1.ExecuteReader();
            while (dabasedengelenveri1.Read())
            {
                
                ayarcik.id = Convert.ToInt32(dabasedengelenveri1["id"]);
                ayarcik.firmav1 = dabasedengelenveri1["firmav1"].ToString();
                ayarcik.facebook = dabasedengelenveri1["facebook"].ToString();
                ayarcik.twitter= dabasedengelenveri1["twitter"].ToString();
                ayarcik.linkdn = dabasedengelenveri1["linkdn"].ToString();
                ayarcik.tel = dabasedengelenveri1["tel"].ToString();
              
            }
            baglan1.Close();
        }
    }
}