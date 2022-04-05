using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Models
{
    sealed class MainContext : DbContext
    {
        public MainContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();

            Categories.Add(new Category()
            {
                Name = "Пицца"
            });

            Kitchens.Add(new Kitchen()
            {
                Name = "Итальянская"
            });

            Kitchens.Add(new Kitchen()
            {
                Name = "Русская"
            });

            SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Variables.ConnectionString);
            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Kitchen> Kitchens { get; set; }
        public DbSet<Dish> Dishes { get; set; }
    }
}
