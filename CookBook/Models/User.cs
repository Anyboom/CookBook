using System;
using System.Collections.Generic;

namespace CookBook.Models
{
    class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public List<Dish> Dishes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public User()
        {
            Dishes = new List<Dish>();
        }
    }
}
