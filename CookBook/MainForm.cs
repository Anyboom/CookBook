using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CookBook.Dialogs.Category;
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

            DishGrid.DataSource = query.Select(s => new
            {
                s.Id,
                s.KitchenId,
                s.CategoryId,
                s.Title,
                KitchenName = s.Kitchen.Name,
                CategoryName = s.Category.Name
            }).ToList();
            
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
    }
}
