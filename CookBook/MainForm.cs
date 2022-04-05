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
    }
}
