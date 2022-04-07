
namespace CookBook.Dialogs.Dish
{
    partial class AddDishForm
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
            this.MainGroup = new System.Windows.Forms.GroupBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.RecipeLabel = new System.Windows.Forms.Label();
            this.RecipeTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CategoryCombo = new System.Windows.Forms.ComboBox();
            this.KitchenCombo = new System.Windows.Forms.ComboBox();
            this.KitchenLabel = new System.Windows.Forms.Label();
            this.MainGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGroup
            // 
            this.MainGroup.Controls.Add(this.AddButton);
            this.MainGroup.Controls.Add(this.RecipeLabel);
            this.MainGroup.Controls.Add(this.RecipeTextBox);
            this.MainGroup.Controls.Add(this.TitleTextBox);
            this.MainGroup.Controls.Add(this.TitleLabel);
            this.MainGroup.Controls.Add(this.CategoryLabel);
            this.MainGroup.Controls.Add(this.CategoryCombo);
            this.MainGroup.Controls.Add(this.KitchenCombo);
            this.MainGroup.Controls.Add(this.KitchenLabel);
            this.MainGroup.Location = new System.Drawing.Point(12, 12);
            this.MainGroup.Name = "MainGroup";
            this.MainGroup.Padding = new System.Windows.Forms.Padding(10);
            this.MainGroup.Size = new System.Drawing.Size(360, 437);
            this.MainGroup.TabIndex = 0;
            this.MainGroup.TabStop = false;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(272, 401);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RecipeLabel
            // 
            this.RecipeLabel.Location = new System.Drawing.Point(13, 102);
            this.RecipeLabel.Name = "RecipeLabel";
            this.RecipeLabel.Size = new System.Drawing.Size(62, 55);
            this.RecipeLabel.TabIndex = 7;
            this.RecipeLabel.Text = "Рецепт приготовления:";
            // 
            // RecipeTextBox
            // 
            this.RecipeTextBox.Location = new System.Drawing.Point(81, 102);
            this.RecipeTextBox.Multiline = true;
            this.RecipeTextBox.Name = "RecipeTextBox";
            this.RecipeTextBox.Size = new System.Drawing.Size(266, 293);
            this.RecipeTextBox.TabIndex = 6;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(81, 73);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(266, 23);
            this.TitleTextBox.TabIndex = 5;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(13, 76);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(62, 15);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Название:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(184, 26);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(66, 15);
            this.CategoryLabel.TabIndex = 3;
            this.CategoryLabel.Text = "Категория:";
            // 
            // CategoryCombo
            // 
            this.CategoryCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryCombo.FormattingEnabled = true;
            this.CategoryCombo.Location = new System.Drawing.Point(184, 44);
            this.CategoryCombo.Name = "CategoryCombo";
            this.CategoryCombo.Size = new System.Drawing.Size(163, 23);
            this.CategoryCombo.TabIndex = 2;
            // 
            // KitchenCombo
            // 
            this.KitchenCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KitchenCombo.FormattingEnabled = true;
            this.KitchenCombo.Location = new System.Drawing.Point(13, 44);
            this.KitchenCombo.Name = "KitchenCombo";
            this.KitchenCombo.Size = new System.Drawing.Size(163, 23);
            this.KitchenCombo.TabIndex = 1;
            // 
            // KitchenLabel
            // 
            this.KitchenLabel.AutoSize = true;
            this.KitchenLabel.Location = new System.Drawing.Point(13, 26);
            this.KitchenLabel.Name = "KitchenLabel";
            this.KitchenLabel.Size = new System.Drawing.Size(42, 15);
            this.KitchenLabel.TabIndex = 0;
            this.KitchenLabel.Text = "Кухня:";
            // 
            // AddDishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.MainGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddDishForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ActionDishForm";
            this.Load += new System.EventHandler(this.AddDishForm_Load);
            this.MainGroup.ResumeLayout(false);
            this.MainGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MainGroup;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ComboBox CategoryCombo;
        private System.Windows.Forms.ComboBox KitchenCombo;
        private System.Windows.Forms.Label KitchenLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label RecipeLabel;
        private System.Windows.Forms.TextBox RecipeTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label TitleLabel;
    }
}