
using CookBook.Models;

namespace CookBook
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainBox = new System.Windows.Forms.GroupBox();
            this.CategoryCheck = new System.Windows.Forms.CheckBox();
            this.CategoryCombo = new System.Windows.Forms.ComboBox();
            this.KitchenCheck = new System.Windows.Forms.CheckBox();
            this.KitchenCombo = new System.Windows.Forms.ComboBox();
            this.DishGrid = new System.Windows.Forms.DataGridView();
            this.MainContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddDishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditDishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowDishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FirstSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ShowCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowKitchensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SecondSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.UpdateTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.AccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SignUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DishGrid)).BeginInit();
            this.MainContextMenu.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainBox
            // 
            this.MainBox.Controls.Add(this.CategoryCheck);
            this.MainBox.Controls.Add(this.CategoryCombo);
            this.MainBox.Controls.Add(this.KitchenCheck);
            this.MainBox.Controls.Add(this.KitchenCombo);
            this.MainBox.Controls.Add(this.DishGrid);
            this.MainBox.Location = new System.Drawing.Point(12, 28);
            this.MainBox.Name = "MainBox";
            this.MainBox.Padding = new System.Windows.Forms.Padding(10);
            this.MainBox.Size = new System.Drawing.Size(425, 487);
            this.MainBox.TabIndex = 0;
            this.MainBox.TabStop = false;
            // 
            // CategoryCheck
            // 
            this.CategoryCheck.Location = new System.Drawing.Point(13, 48);
            this.CategoryCheck.Name = "CategoryCheck";
            this.CategoryCheck.Size = new System.Drawing.Size(85, 19);
            this.CategoryCheck.TabIndex = 9;
            this.CategoryCheck.Text = "Категория:";
            this.CategoryCheck.UseVisualStyleBackColor = true;
            this.CategoryCheck.CheckedChanged += new System.EventHandler(this.CategoryCheck_CheckedChanged);
            // 
            // CategoryCombo
            // 
            this.CategoryCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryCombo.Enabled = false;
            this.CategoryCombo.FormattingEnabled = true;
            this.CategoryCombo.Location = new System.Drawing.Point(104, 46);
            this.CategoryCombo.Name = "CategoryCombo";
            this.CategoryCombo.Size = new System.Drawing.Size(308, 23);
            this.CategoryCombo.TabIndex = 8;
            // 
            // KitchenCheck
            // 
            this.KitchenCheck.Location = new System.Drawing.Point(13, 21);
            this.KitchenCheck.Name = "KitchenCheck";
            this.KitchenCheck.Size = new System.Drawing.Size(85, 19);
            this.KitchenCheck.TabIndex = 6;
            this.KitchenCheck.Text = "Кухня:";
            this.KitchenCheck.UseVisualStyleBackColor = true;
            this.KitchenCheck.CheckedChanged += new System.EventHandler(this.KitchenCheck_CheckedChanged);
            // 
            // KitchenCombo
            // 
            this.KitchenCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KitchenCombo.Enabled = false;
            this.KitchenCombo.FormattingEnabled = true;
            this.KitchenCombo.Location = new System.Drawing.Point(104, 19);
            this.KitchenCombo.Name = "KitchenCombo";
            this.KitchenCombo.Size = new System.Drawing.Size(308, 23);
            this.KitchenCombo.TabIndex = 3;
            // 
            // DishGrid
            // 
            this.DishGrid.AllowUserToAddRows = false;
            this.DishGrid.AllowUserToDeleteRows = false;
            this.DishGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DishGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DishGrid.ContextMenuStrip = this.MainContextMenu;
            this.DishGrid.Location = new System.Drawing.Point(13, 75);
            this.DishGrid.MultiSelect = false;
            this.DishGrid.Name = "DishGrid";
            this.DishGrid.ReadOnly = true;
            this.DishGrid.RowTemplate.Height = 25;
            this.DishGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DishGrid.Size = new System.Drawing.Size(399, 399);
            this.DishGrid.TabIndex = 0;
            this.DishGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DishGrid_DataBindingComplete);
            // 
            // MainContextMenu
            // 
            this.MainContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddDishToolStripMenuItem,
            this.EditDishToolStripMenuItem,
            this.ShowDishToolStripMenuItem,
            this.FirstSeparator,
            this.ShowCategoriesToolStripMenuItem,
            this.ShowKitchensToolStripMenuItem,
            this.SecondSeparator,
            this.UpdateTableToolStripMenuItem});
            this.MainContextMenu.Name = "MainContextMenu";
            this.MainContextMenu.ShowImageMargin = false;
            this.MainContextMenu.Size = new System.Drawing.Size(184, 148);
            // 
            // AddDishToolStripMenuItem
            // 
            this.AddDishToolStripMenuItem.Name = "AddDishToolStripMenuItem";
            this.AddDishToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.AddDishToolStripMenuItem.Text = "Добавить блюдо";
            this.AddDishToolStripMenuItem.Visible = false;
            this.AddDishToolStripMenuItem.Click += new System.EventHandler(this.AddDishToolStripMenuItem_Click);
            // 
            // EditDishToolStripMenuItem
            // 
            this.EditDishToolStripMenuItem.Name = "EditDishToolStripMenuItem";
            this.EditDishToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.EditDishToolStripMenuItem.Text = "Отредактировать блюдо";
            this.EditDishToolStripMenuItem.Click += new System.EventHandler(this.EditDishToolStripMenuItem_Click);
            // 
            // ShowDishToolStripMenuItem
            // 
            this.ShowDishToolStripMenuItem.Name = "ShowDishToolStripMenuItem";
            this.ShowDishToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.ShowDishToolStripMenuItem.Text = "Открыть блюдо";
            this.ShowDishToolStripMenuItem.Click += new System.EventHandler(this.ShowDishToolStripMenuItem_Click);
            // 
            // FirstSeparator
            // 
            this.FirstSeparator.Name = "FirstSeparator";
            this.FirstSeparator.Size = new System.Drawing.Size(180, 6);
            // 
            // ShowCategoriesToolStripMenuItem
            // 
            this.ShowCategoriesToolStripMenuItem.Name = "ShowCategoriesToolStripMenuItem";
            this.ShowCategoriesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.ShowCategoriesToolStripMenuItem.Text = "Открыть категории";
            this.ShowCategoriesToolStripMenuItem.Click += new System.EventHandler(this.ShowCategoriesToolStripMenuItem_Click);
            // 
            // ShowKitchensToolStripMenuItem
            // 
            this.ShowKitchensToolStripMenuItem.Name = "ShowKitchensToolStripMenuItem";
            this.ShowKitchensToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.ShowKitchensToolStripMenuItem.Text = "Открыть кухни";
            this.ShowKitchensToolStripMenuItem.Click += new System.EventHandler(this.ShowKitchensToolStripMenuItem_Click);
            // 
            // SecondSeparator
            // 
            this.SecondSeparator.Name = "SecondSeparator";
            this.SecondSeparator.Size = new System.Drawing.Size(180, 6);
            // 
            // UpdateTableToolStripMenuItem
            // 
            this.UpdateTableToolStripMenuItem.Name = "UpdateTableToolStripMenuItem";
            this.UpdateTableToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.UpdateTableToolStripMenuItem.Text = "Обновить таблицу";
            this.UpdateTableToolStripMenuItem.Click += new System.EventHandler(this.UpdateTableToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccountToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(449, 24);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            // 
            // AccountToolStripMenuItem
            // 
            this.AccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginToolStripMenuItem,
            this.SignUpToolStripMenuItem,
            this.LogoutToolStripMenuItem});
            this.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem";
            this.AccountToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.AccountToolStripMenuItem.Text = "Аккаунт";
            // 
            // LoginToolStripMenuItem
            // 
            this.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem";
            this.LoginToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.LoginToolStripMenuItem.Text = "Авторизоваться";
            this.LoginToolStripMenuItem.Click += new System.EventHandler(this.LoginToolStripMenuItem_Click);
            // 
            // SignUpToolStripMenuItem
            // 
            this.SignUpToolStripMenuItem.Name = "SignUpToolStripMenuItem";
            this.SignUpToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.SignUpToolStripMenuItem.Text = "Зарегистрироваться";
            this.SignUpToolStripMenuItem.Click += new System.EventHandler(this.SignUpToolStripMenuItem_Click);
            // 
            // LogoutToolStripMenuItem
            // 
            this.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem";
            this.LogoutToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.LogoutToolStripMenuItem.Text = "Выйти";
            this.LogoutToolStripMenuItem.Visible = false;
            this.LogoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 527);
            this.Controls.Add(this.MainBox);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MainBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DishGrid)).EndInit();
            this.MainContextMenu.ResumeLayout(false);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MainBox;
        private System.Windows.Forms.ComboBox KitchenCombo;
        private System.Windows.Forms.DataGridView DishGrid;
        private System.Windows.Forms.CheckBox CategoryCheck;
        private System.Windows.Forms.ComboBox CategoryCombo;
        private System.Windows.Forms.CheckBox KitchenCheck;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem AccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SignUpToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip MainContextMenu;
        private System.Windows.Forms.ToolStripMenuItem AddDishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowCategoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowKitchensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowDishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditDishToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator FirstSeparator;
        private System.Windows.Forms.ToolStripSeparator SecondSeparator;
    }
}

