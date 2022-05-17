using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookBook.Services;

namespace CookBook.Models
{
    sealed class MainContext : DbContext
    {
        public MainContext()
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();

            //Categories.Add(new Category()
            //{
            //    Name = "Пицца"
            //});

            //Kitchens.Add(new Kitchen()
            //{
            //    Name = "Итальянская"
            //});

            //Kitchens.Add(new Kitchen()
            //{
            //    Name = "Русская"
            //});

            //Roles.Add(new Role()
            //{
            //    Name = "User"
            //});

            //Roles.Add(new Role()
            //{
            //    Name = "Admin"
            //});

            //SaveChanges();

            //Users.Add(new User()
            //{
            //    Login = "login",
            //    Password = MD5Service.Create("admin"),
            //    CreatedAt = DateTime.Now,
            //    Role = Roles.First(c => c.Name == "Admin")
            //});

            //SaveChanges();

            //Dishes.Add(new Dish()
            //{
            //    Title = "Сырная",
            //    Recipe = "Томатный соус, сыр моццарела, смесь сыров",
            //    CategoryId = 1,
            //    KitchenId = 1,
            //    User = Users.First()
            //});

            //SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Variables.ConnectionString);
            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Kitchen> Kitchens { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }

}
