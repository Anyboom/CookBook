using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Models
{
    // guest, user, admin
    class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private static Dictionary<string, string[]> areas = new Dictionary<string, string[]>()
        {
            {
                "MainForm.Logout", new []
                {
                    "user", "admin"
                }
            },
            {
                "MainForm.Login", new []
                {
                    "guest"
                }
            },
            {
                "MainForm.SignUp", new []
                {
                    "guest"
                }
            },
            {
                "MainForm.AddDish", new []
                {
                    "user", "admin"
                }
            },
            {
                "MainForm.ShowCategories", new []
                {
                    "admin"
                }
            },
            {
                "MainForm.ShowKitchens", new []
                {
                    "admin"
                }
            },
            {
                "MainForm.EditDish", new []
                {
                    "user", "admin"
                }
            },
            {
                "MainForm.FirstSeparator", new []
                {
                    "admin"
                }
            }
        };
        public static bool Can(User user, string area)
        {
            string role = "guest";

            if (user is not null)
            {
                role = user.Role.Name.ToLower();
            }

            return areas[area].Any(c => c == role);
        }

        public static bool Can(User user, string area, Func<User, bool> condition)
        {
            return Can(user, area) && condition(user);
        }
    }
}
