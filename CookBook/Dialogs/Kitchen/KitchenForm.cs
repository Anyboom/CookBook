using System;
using System.Linq;
using System.Windows.Forms;

using CookBook.Models;
using CookBook.Services;

namespace CookBook.Dialogs.Kitchen
{
    public partial class KitchenForm : Form
    {
        public bool Edited = false;
        public KitchenForm()
        {
            InitializeComponent();
        }

        private void KitchenForm_Load(object sender, EventArgs e)
        {
            using MainContext db = new MainContext();

            MainList.DataSource = db.Kitchens.ToList();
            MainList.ValueMember = "Id";
            MainList.DisplayMember = "Name";
        }

        private void AddKitchenMenu_Click(object sender, EventArgs e)
        {
            string name = MessageService.InputBox("Введите имя для новой кухни:");

            if (string.IsNullOrEmpty(name))
            {
                return;
            }

            using MainContext db = new MainContext();

            Models.Kitchen newKichen = new Models.Kitchen()
            {
                Name = name
            };

            db.Kitchens.Add(newKichen);

            db.SaveChanges();

            Edited = true;
        }

        private void RemoveKitchenMenu_Click(object sender, EventArgs e)
        {
            if (MainList.SelectedItem is null)
            {
                return;
            }

            Models.Kitchen kichenForRemove = MainList.SelectedItem as Models.Kitchen;

            DialogResult result = MessageService.ShowQuestion(
                $"Вы точно собираетесь удалить кухню {kichenForRemove.Name} ?",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }

            using MainContext db = new MainContext();

            db.Kitchens.Remove(kichenForRemove);

            db.SaveChanges();

            Edited = true;
        }

        private void EditKitchenMenu_Click(object sender, EventArgs e)
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

            Models.Kitchen kichenForEdit = MainList.SelectedItem as Models.Kitchen;

            kichenForEdit.Name = name;

            using MainContext db = new MainContext();

            db.Kitchens.Update(kichenForEdit);

            db.SaveChanges();

            Edited = true;
        }

        private void UpdateTableMenu_Click(object sender, EventArgs e)
        {
            using MainContext db = new MainContext();

            MainList.DataSource = db.Kitchens.ToList();
        }

        private void KitchenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Edited)
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
