using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CookBook.Models;
using Microsoft.EntityFrameworkCore;

namespace CookBook.Dialogs.Dish
{
    public partial class ShowDishForm : Form
    {
        internal ShowDishForm(int idDish)
        {
            InitializeComponent();

            using MainContext db = new MainContext();
            Models.Dish selectDish = db.Dishes.Include(c => c.Kitchen).Include(c => c.Category).First(c => c.Id == idDish);

            KitchenResultLabel.Text = selectDish.Kitchen.Name;
            CategoryResultLabel.Text = selectDish.Category.Name;
            RecipeTextBox.Text = selectDish.Recipe;
        }
    }
}
