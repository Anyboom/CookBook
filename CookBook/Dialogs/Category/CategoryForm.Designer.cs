
namespace CookBook.Dialogs.Category
{
    partial class CategoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainGroup = new System.Windows.Forms.GroupBox();
            this.MainList = new System.Windows.Forms.ListBox();
            this.MainContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddCategoryMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveCategoryMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCategoryMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.UpdateTableMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MainGroup.SuspendLayout();
            this.MainContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGroup
            // 
            this.MainGroup.Controls.Add(this.MainList);
            this.MainGroup.Location = new System.Drawing.Point(12, 12);
            this.MainGroup.Name = "MainGroup";
            this.MainGroup.Padding = new System.Windows.Forms.Padding(10);
            this.MainGroup.Size = new System.Drawing.Size(360, 437);
            this.MainGroup.TabIndex = 0;
            this.MainGroup.TabStop = false;
            // 
            // MainList
            // 
            this.MainList.ContextMenuStrip = this.MainContextMenu;
            this.MainList.FormattingEnabled = true;
            this.MainList.ItemHeight = 15;
            this.MainList.Location = new System.Drawing.Point(13, 29);
            this.MainList.Name = "MainList";
            this.MainList.Size = new System.Drawing.Size(334, 394);
            this.MainList.TabIndex = 0;
            // 
            // MainContextMenu
            // 
            this.MainContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCategoryMenu,
            this.RemoveCategoryMenu,
            this.EditCategoryMenu,
            this.toolStripSeparator1,
            this.UpdateTableMenu});
            this.MainContextMenu.Name = "MainContextMenu";
            this.MainContextMenu.Size = new System.Drawing.Size(177, 98);
            // 
            // AddCategoryMenu
            // 
            this.AddCategoryMenu.Name = "AddCategoryMenu";
            this.AddCategoryMenu.Size = new System.Drawing.Size(176, 22);
            this.AddCategoryMenu.Text = "Добавить";
            this.AddCategoryMenu.Click += new System.EventHandler(this.AddCategoryMenu_Click);
            // 
            // RemoveCategoryMenu
            // 
            this.RemoveCategoryMenu.Name = "RemoveCategoryMenu";
            this.RemoveCategoryMenu.Size = new System.Drawing.Size(176, 22);
            this.RemoveCategoryMenu.Text = "Удалить";
            this.RemoveCategoryMenu.Click += new System.EventHandler(this.RemoveCategoryMenu_Click);
            // 
            // EditCategoryMenu
            // 
            this.EditCategoryMenu.Name = "EditCategoryMenu";
            this.EditCategoryMenu.Size = new System.Drawing.Size(176, 22);
            this.EditCategoryMenu.Text = "Редактировать";
            this.EditCategoryMenu.Click += new System.EventHandler(this.EditCategoryMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(173, 6);
            // 
            // UpdateTableMenu
            // 
            this.UpdateTableMenu.Name = "UpdateTableMenu";
            this.UpdateTableMenu.Size = new System.Drawing.Size(176, 22);
            this.UpdateTableMenu.Text = "Обновить таблицу";
            this.UpdateTableMenu.Click += new System.EventHandler(this.UpdateTableMenu_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.MainGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Категории рецептов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CategoryForm_FormClosing);
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.MainGroup.ResumeLayout(false);
            this.MainContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MainGroup;
        private System.Windows.Forms.ListBox MainList;
        private System.Windows.Forms.ContextMenuStrip MainContextMenu;
        private System.Windows.Forms.ToolStripMenuItem AddCategoryMenu;
        private System.Windows.Forms.ToolStripMenuItem RemoveCategoryMenu;
        private System.Windows.Forms.ToolStripMenuItem EditCategoryMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem UpdateTableMenu;
    }
}