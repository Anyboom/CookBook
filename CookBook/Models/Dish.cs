using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Models
{
    class Dish
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Recipe { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int KitchenId { get; set; }
        public Kitchen Kitchen { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
