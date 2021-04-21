using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWebsite.Models.Sınıflar
{
    public class Yorumlar
    {
        [Key]
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }
        public int RecentProjectid { get; set; }
        public virtual RecentProject Blog { get; set; }

    }
}