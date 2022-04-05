using System;
using System.Linq;
using System.Windows.Forms;

using CookBook.Models;
using CookBook.Services;

namespace CookBook.Dialogs.Category
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            MainList.DataSource = new Models.Category();
            MainList.ValueMember = "Id";
            MainList.DisplayMember = "Name";
        }

        private void AddCategoryMenu_Click(object sender, EventArgs e)
        {
            string name = MessageService.InputBox("Введите имя для новой категории:");

            if (string.IsNullOrEmpty((name)))
            {
                return;
            }

            using MainContext db = new MainContext();

            Models.Category newCategory = new Models.Category()
            {
                Name = name
            };

            db.Categories.Add(newCategory);

            db.SaveChanges();
        }

        private void RemoveCategoryMenu_Click(object sender, EventArgs e)
        {
            if (MainList.SelectedItem is null)
            {
                return;
            }

            Models.Category categoryForRemove = MainList.SelectedItem as Models.Category;

            DialogResult result = MessageService.ShowQuestion(
                $"Вы точно собираетесь удалить категорию {categoryForRemove.Name} ?",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }

            using MainContext db = new MainContext();

            db.Categories.Remove(categoryForRemove);

            db.SaveChanges();
        }

        private void EditCategoryMenu_Click(object sender, EventArgs e)
        {
            if (MainList.SelectedItem is null)
            {
                return;
            }

            string name = MessageService.InputBox("Введите новое имя для категории:");

            if (string.IsNullOrEmpty(name))
            {
                return;
            }

            Models.Category categoryForEdit = MainList.SelectedItem as Models.Category;

            categoryForEdit.Name = name;

            using MainContext db = new MainContext();

            db.Categories.Update(categoryForEdit);

            db.SaveChanges();
        }

        private void UpdateTableMenu_Click(object sender, EventArgs e)
        {
            using MainContext db = new MainContext();

            MainList.DataSource = db.Categories.ToList();
        }
    }
}
