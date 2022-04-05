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

namespace CookBook.Dialogs.Dish
{
    public partial class AddDishForm : Form
    {
        public AddDishForm()
        {
            InitializeComponent();
        }

        private void AddDishForm_Load(object sender, EventArgs e)
        {
            using MainContext db = new MainContext();

            KitchenCombo.DataSource = db.Kitchens.ToList();
            KitchenCombo.ValueMember = "Id";
            KitchenCombo.DisplayMember = "Name";

            CategoryCombo.DataSource = db.Categories.ToList();
            CategoryCombo.ValueMember = "Id";
            CategoryCombo.DisplayMember = "Name";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //TODO: доделать валидацию

            if (CategoryCombo.SelectedValue is null)
            {
                return;
            }

            if (KitchenCombo.SelectedValue is null)
            {
                return;
            }

            if (string.IsNullOrEmpty(RecipeTextBox.Text))
            {
                return;
            }

            if (string.IsNullOrEmpty(TitleTextBox.Text))
            {
                return;
            }

            using MainContext db = new MainContext();

            Models.Dish newDish = new Models.Dish()
            {
                CategoryId = (int) CategoryCombo.SelectedValue,
                KitchenId = (int) KitchenCombo.SelectedValue,
                Recipe = RecipeTextBox.Text,
                Title = TitleTextBox.Text
            };

            db.Dishes.Add(newDish);

            db.SaveChanges();

            DialogResult = DialogResult.OK;
        }
    }
}
