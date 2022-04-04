using System;
using System.Windows.Forms;

using CookBook.Instances;
using CookBook.Models;
using CookBook.Services;

namespace CookBook
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            App.Instance.MainForm = new MainForm();

            using (MainContext db = new MainContext())
            {
                if (db.Database.CanConnect() == false)
                {
                    MessageService.ShowError("Соединение не установлено.");

                    Application.Exit();
                }
                else
                {
                    Application.Run(App.Instance);
                }
            }
        }
    }
}
