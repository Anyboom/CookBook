
namespace CookBook.Dialogs.Dish
{
    partial class ShowDishForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowDishForm));
            this.MainGroup = new System.Windows.Forms.GroupBox();
            this.RecipeTextBox = new System.Windows.Forms.TextBox();
            this.CategoryResultLabel = new System.Windows.Forms.Label();
            this.KitchenResultLabel = new System.Windows.Forms.Label();
            this.RecipeLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.KitchenLabel = new System.Windows.Forms.Label();
            this.MainGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGroup
            // 
            this.MainGroup.Controls.Add(this.RecipeTextBox);
            this.MainGroup.Controls.Add(this.CategoryResultLabel);
            this.MainGroup.Controls.Add(this.KitchenResultLabel);
            this.MainGroup.Controls.Add(this.RecipeLabel);
            this.MainGroup.Controls.Add(this.CategoryLabel);
            this.MainGroup.Controls.Add(this.KitchenLabel);
            this.MainGroup.Location = new System.Drawing.Point(12, 12);
            this.MainGroup.Name = "MainGroup";
            this.MainGroup.Padding = new System.Windows.Forms.Padding(10);
            this.MainGroup.Size = new System.Drawing.Size(360, 437);
            this.MainGroup.TabIndex = 0;
            this.MainGroup.TabStop = false;
            // 
            // RecipeTextBox
            // 
            this.RecipeTextBox.Location = new System.Drawing.Point(13, 89);
            this.RecipeTextBox.Multiline = true;
            this.RecipeTextBox.Name = "RecipeTextBox";
            this.RecipeTextBox.ReadOnly = true;
            this.RecipeTextBox.Size = new System.Drawing.Size(334, 335);
            this.RecipeTextBox.TabIndex = 5;
            // 
            // CategoryResultLabel
            // 
            this.CategoryResultLabel.Location = new System.Drawing.Point(79, 46);
            this.CategoryResultLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.CategoryResultLabel.Name = "CategoryResultLabel";
            this.CategoryResultLabel.Size = new System.Drawing.Size(268, 15);
            this.CategoryResultLabel.TabIndex = 4;
            this.CategoryResultLabel.Text = "Закуски";
            // 
            // KitchenResultLabel
            // 
            this.KitchenResultLabel.Location = new System.Drawing.Point(55, 26);
            this.KitchenResultLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.KitchenResultLabel.Name = "KitchenResultLabel";
            this.KitchenResultLabel.Size = new System.Drawing.Size(292, 15);
            this.KitchenResultLabel.TabIndex = 3;
            this.KitchenResultLabel.Text = "Русская";
            // 
            // RecipeLabel
            // 
            this.RecipeLabel.AutoSize = true;
            this.RecipeLabel.Location = new System.Drawing.Point(13, 66);
            this.RecipeLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.RecipeLabel.Name = "RecipeLabel";
            this.RecipeLabel.Size = new System.Drawing.Size(48, 15);
            this.RecipeLabel.TabIndex = 2;
            this.RecipeLabel.Text = "Рецепт:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(13, 46);
            this.CategoryLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(66, 15);
            this.CategoryLabel.TabIndex = 1;
            this.CategoryLabel.Text = "Категория:";
            // 
            // KitchenLabel
            // 
            this.KitchenLabel.AutoSize = true;
            this.KitchenLabel.Location = new System.Drawing.Point(13, 26);
            this.KitchenLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this.KitchenLabel.Name = "KitchenLabel";
            this.KitchenLabel.Size = new System.Drawing.Size(42, 15);
            this.KitchenLabel.TabIndex = 0;
            this.KitchenLabel.Text = "Кухня:";
            // 
            // ShowDishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.MainGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowDishForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Просмотр блюда";
            this.MainGroup.ResumeLayout(false);
            this.MainGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MainGroup;
        private System.Windows.Forms.TextBox RecipeTextBox;
        private System.Windows.Forms.Label CategoryResultLabel;
        private System.Windows.Forms.Label KitchenResultLabel;
        private System.Windows.Forms.Label RecipeLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label KitchenLabel;
    }
}