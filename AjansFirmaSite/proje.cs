using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjansFirmaSite
{
    public class proje
    {
        public int id { get; set; }
        public string ad { get; set; }
        public string aciklama { get; set; }
        public string resim { get; set; }
        public string kategori { get; set; }

        public DateTime tarih { get; set; }
        
    }
}