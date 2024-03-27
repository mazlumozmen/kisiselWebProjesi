using System.Data.Entity;

namespace kisiselWebProjesi.Models.siniflar
{
    public class context:DbContext
    {
        public DbSet<admin> Admins { get; set; }
        public DbSet<AnaSayfa> AnaSayfas { get; set; }
        public DbSet<ikonlar> İkonlars { get; set; }
    }
}