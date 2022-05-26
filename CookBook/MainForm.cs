using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CookBook.Dialogs.Authentication;
using CookBook.Dialogs.Category;
using CookBook.Dialogs.Dish;
using CookBook.Dialogs.Kitchen;
using CookBook.Models;
using CookBook.Services;

namespace CookBook
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.Text = Variables.TitleProject;

            using MainContext db = new MainContext();

            KitchenCombo.DataSource = db.Kitchens.ToList();
            KitchenCombo.DisplayMember = "Name";
            KitchenCombo.ValueMember = "Id";

            CategoryCombo.DataSource = db.Categories.ToList();
            CategoryCombo.DisplayMember = "Name";
            CategoryCombo.ValueMember = "Id";

            UpdateView();

        }

        private void UpdateTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using MainContext db = new MainContext();

            IQueryable<Dish> query = db.Dishes;

            if (CategoryCheck.Checked && CategoryCombo.SelectedValue is not null)
            {
                query = query.Where(s => s.CategoryId == (int) CategoryCombo.SelectedValue);
            }

            if (KitchenCheck.Checked && KitchenCombo.SelectedValue is not null)
            {
                query = query.Where(s => s.KitchenId == (int) KitchenCombo.SelectedValue);
            }
            

            DishGrid.DataSource = query.Select(s => new { s.Id, s.KitchenId, s.CategoryId, s.Title, KitchenName = s.Kitchen.Name, CategoryName = s.Category.Name }).ToList();
        }

        private void DishGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DishGrid.Columns["Id"].HeaderText = "ИД";
            DishGrid.Columns["Title"].HeaderText = "НАЗВАНИЕ";
            DishGrid.Columns["KitchenName"].HeaderText = "КУХНЯ";
            DishGrid.Columns["CategoryName"].HeaderText = "КАТЕГОРИЯ";

            DishGrid.Columns["KitchenId"].Visible = false;
            DishGrid.Columns["CategoryId"].Visible = false;

        }

        private void ShowCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm newDialogForm = new CategoryForm();
            DialogResult result = newDialogForm.ShowDialog();

            using MainContext db = new MainContext();

            if (result == DialogResult.OK)
            {
                CategoryCombo.DataSource = db.Categories.ToList();
            }
        }

        private void ShowKitchensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitchenForm newDialogForm = new KitchenForm();
            DialogResult result = newDialogForm.ShowDialog();

            using MainContext db = new MainContext();

            if (result == DialogResult.OK)
            {
                KitchenCombo.DataSource = db.Kitchens.ToList();
            }
        }

        private void AddDishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KitchenCombo.Items.Count == 0 || CategoryCombo.Items.Count == 0)
            {
                MessageService.ShowError("Не заполнены данные в таблице 'Кухня' или 'Категория'");
                return;
            }

            AddDishForm newDialogForm = new AddDishForm();
            DialogResult result = newDialogForm.ShowDialog();
        }

        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm newDialogForm = new LoginForm();
            DialogResult result = newDialogForm.ShowDialog();

            if (DialogResult.OK == result)
            {
                AccountToolStripMenuItem.Text = Variables.User.Login;

                if (Role.IsAdmin(Variables.User))
                {
                    AccountToolStripMenuItem.Text += " [A]";
                }

                UpdateView();
            }
        }

        private void SignUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignUpForm newDialogForm = new SignUpForm();
            DialogResult result = newDialogForm.ShowDialog();
        }

        private void ShowDishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DishGrid.SelectedRows.Count == 0)
            {
                return;
            }

            int selectedId = (int)DishGrid.SelectedRows[0].Cells[0].Value;

            ShowDishForm newShowDishForm = new ShowDishForm(selectedId);
            DialogResult result = newShowDishForm.ShowDialog();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Variables.User = null;

            AccountToolStripMenuItem.Text = "Аккаунт";

            UpdateView();
        }

        private void UpdateView()
        {
            LoginToolStripMenuItem.Visible = Role.Can(Variables.User, "MainForm.Login");
            SignUpToolStripMenuItem.Visible = Role.Can(Variables.User, "MainForm.SignUp");
            LogoutToolStripMenuItem.Visible = Role.Can(Variables.User, "MainForm.Logout");

            AddDishToolStripMenuItem.Visible = Role.Can(Variables.User, "MainForm.AddDish");

            ShowCategoriesToolStripMenuItem.Visible = Role.Can(Variables.User, "MainForm.ShowCategories");
            ShowKitchensToolStripMenuItem.Visible = Role.Can(Variables.User, "MainForm.ShowKitchens");

            FirstSeparator.Visible = Role.Can(Variables.User, "MainForm.FirstSeparator");

            RemoveDishToolStripMenuItem.Visible = Role.Can(Variables.User, "MainForm.RemoveDish");
        }

        private void KitchenCheck_CheckedChanged(object sender, EventArgs e)
        {
            KitchenCombo.Enabled = KitchenCheck.Checked;
        }

        private void CategoryCheck_CheckedChanged(object sender, EventArgs e)
        {
            CategoryCombo.Enabled = CategoryCheck.Checked;
        }

        private void RemoveDishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DishGrid.SelectedRows.Count == 0)
            {
                return;
            }

            int selectedId = (int) DishGrid.SelectedRows[0].Cells[0].Value,
                selectedIndex = DishGrid.SelectedRows[0].Index;

            using MainContext db = new MainContext();

            if (db.Dishes.Any(c => c.Id == selectedId && c.User.Id == Variables.User.Id) || Variables.User.Role.Name == "Admin")
            {
                DialogResult dialogResult = MessageService.ShowQuestion($"Вы уверены, что хотите удалить рецепт с ИД: {selectedId} ?", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    Dish removeDish = db.Dishes.FirstOrDefault(c => c.Id == selectedId);

                    if (removeDish == null)
                    {
                        return;
                    }

                    db.Dishes.Remove(removeDish);
                    db.SaveChanges();

                    MessageService.ShowInfo("Вы успешно удалили запись. Обновите таблицу !");
                }
            }
            else
            {
                MessageService.ShowInfo("К сожалению, вы не автор этого рецепта, вы не можете его удалить.");
            }
        }
    }
}
