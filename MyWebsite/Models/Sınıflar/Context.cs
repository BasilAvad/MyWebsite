using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace MyWebsite.Models.Sınıflar
{
    public class Context:DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Adress> Adresss { get; set; }
        public DbSet<RecentProject> RecentProjectss { get; set; }
        public DbSet<Home> Homes { get; set; }
        public DbSet<AboutMe>AboutMes { get; set; }
        public DbSet<Contact>Contacts { get; set; }
        public DbSet<Yorumlar>Yorumlars { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}