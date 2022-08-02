using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kategori.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost; user=root; database=Category; password=GOKKAYA52.o; port=3306");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Urunler> Urunlers { get; set; }
        public DbSet<AdminUser> AdminUsers { get; set; }
    }
}
