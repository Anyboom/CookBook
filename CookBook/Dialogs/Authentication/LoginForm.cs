using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CookBook.Instances;
using CookBook.Models;
using CookBook.Services;
using Microsoft.EntityFrameworkCore;

namespace CookBook.Dialogs.Authentication
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string login = LoginTextBox.Text,
                password = PasswordTextBox.Text;

            if (String.IsNullOrEmpty(Name)
                || String.IsNullOrEmpty(password))
            {
                MessageService.ShowError("Нужно что-нибудь ввести.");
                return;
            }

            using (MainContext db = new MainContext())
            {
                User temp = db.Users.Include(c => c.Role).Where(c => c.Login == login && c.DeletedAt == null).FirstOrDefault();

                if (temp == null)
                {
                    MessageService.ShowWarn("Данного аккаунта с таким именем нет !");
                    return;
                }

                if (MD5Service.Create(password) != temp.Password)
                {
                    MessageService.ShowWarn("Неправильный пароль.");
                    return;
                }

                Variables.User = temp;

                DialogResult = DialogResult.OK;
            }

            //TODO: CANCANCANCANCAN роли
        }
    }
}
