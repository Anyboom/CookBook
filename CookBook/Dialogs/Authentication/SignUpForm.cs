using CookBook.Models;
using CookBook.Services;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBook.Dialogs.Authentication
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            string login = LoginTextBox.Text,
                password = PasswordTextBox.Text,
                repeatPassword = RepeatPasswordTextBox.Text;

            if (String.IsNullOrEmpty(login)
                || String.IsNullOrEmpty(password)
                || String.IsNullOrEmpty(repeatPassword))
            {
                return;
            }

            if (password != repeatPassword)
            {
                return;
            }

            using MainContext db = new MainContext();

            if (db.Users.Any(c => c.Login == login))
            {
                return;
            }

            string newRole = db.Users.Any() ? "User" : "Admin";

            db.Users.Add(new User()
            {
                Login = login,
                Password = MD5Service.Create(password),
                CreatedAt = DateTime.Now,
                Role = db.Roles.First(c => c.Name == newRole)
            });

            db.SaveChanges();

            MessageService.ShowInfo("Вы успешно зарегистрировались !");

            Close();
        }
    }
}
