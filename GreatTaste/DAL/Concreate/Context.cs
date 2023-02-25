using EntityLayer.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concreate
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=165.22.76.10;Initial Catalog=HayenTest2;Persist Security Info=True;User ID=gridboxuser;Password=h@y.n34!sehis8?;MultipleActiveResultSets=true;");
        }
        public DbSet<Sebze> Sebzeler { get; set; }
        public DbSet<Yemek> Yemekler { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}
