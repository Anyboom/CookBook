using System;
using System.Linq;
using System.Windows.Forms;

using CookBook.Models;
using CookBook.Services;

namespace CookBook.Dialogs.Category
{
    public partial class CategoryForm : Form
    {
        public bool Edited = false;
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            using MainContext db = new MainContext();

            MainList.DataSource = db.Categories.ToList();
            MainList.ValueMember = "Id";
            MainList.DisplayMember = "Name";
        }

        private void AddCategoryMenu_Click(object sender, EventArgs e)
        {
            string name = MessageService.InputBox("Введите имя для новой категории:");

            if (string.IsNullOrEmpty(name))
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

            Edited = true;
        }

        private void RemoveCategoryMenu_Click(object sender, EventArgs e)
        {
            if (MainList.SelectedItem is null)
            {
                return;
            }

            using MainContext db = new MainContext();

            Models.Category categoryForRemove = MainList.SelectedItem as Models.Category;

            if (db.Categories.Any(s => s.Id == categoryForRemove.Id) == false)
            {
                return;
            }

            DialogResult result = MessageService.ShowQuestion(
                $"Вы точно собираетесь удалить категорию {categoryForRemove.Name} ?",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }

            db.Categories.Remove(categoryForRemove);

            db.SaveChanges();

            Edited = true;
        }

        private void EditCategoryMenu_Click(object sender, EventArgs e)
        {
            if (MainList.SelectedItem is null)
            {
                return;
            }

            using MainContext db = new MainContext();

            Models.Category categoryForEdit = MainList.SelectedItem as Models.Category;

            if (db.Categories.Any(s => s.Id == categoryForEdit.Id) == false)
            {
                return;
            }

            string name = MessageService.InputBox("Введите новое имя для категории:");

            if (string.IsNullOrEmpty(name))
            {
                return;
            }

            categoryForEdit.Name = name;

            db.Categories.Update(categoryForEdit);

            db.SaveChanges();

            Edited = true;
        }

        private void UpdateTableMenu_Click(object sender, EventArgs e)
        {
            using MainContext db = new MainContext();

            MainList.DataSource = db.Categories.ToList();
        }

        private void CategoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Edited)
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
