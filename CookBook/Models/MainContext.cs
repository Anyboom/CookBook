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
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Variables.ConnectionString);
            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }
    }
}
