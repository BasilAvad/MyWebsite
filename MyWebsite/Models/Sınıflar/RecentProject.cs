using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWebsite.Models.Sınıflar
{
    public class RecentProject
    {
        [Key]
        public int Id { get; set; }
        public string Baslik { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public string RecentProjectsImage { get; set; }
        public string Aciklama2 { get; set; }
        public string RecentProjectsImage2 { get; set; }
        public string Aciklama3 { get; set; }
        public string RecentProjectsImage3 { get; set; }
        public string Aciklama4 { get; set; }
        public string RecentProjectsImage4 { get; set; }
        public string Aciklama5 { get; set; }
        public string RecentProjectsImage5 { get; set; }
        public string Kaynaklar { get; set; }
        public string Kaynaklar2 { get; set; }
        public string Kaynaklar3 { get; set; }
        public ICollection<Yorumlar> Yorumlars { get; set; }

    }
}