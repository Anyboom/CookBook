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
                //TODO: message плииз
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
            //BUG: обработать 
            ShowDishForm newShowDishForm = new ShowDishForm((int) DishGrid.SelectedRows[0].Cells[0].Value);
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
            ShowKitchensToolStripMenuItem.Visible = Role.Can(Variables.User, "MainForm.ShowCategories");
            //BUG: поработать с разделителями
        }

        private void KitchenCheck_CheckedChanged(object sender, EventArgs e)
        {
            KitchenCombo.Enabled = KitchenCheck.Checked;
        }

        private void CategoryCheck_CheckedChanged(object sender, EventArgs e)
        {
            CategoryCombo.Enabled = CategoryCheck.Checked;
        }
    }
}
