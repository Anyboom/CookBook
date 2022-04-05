
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
            this.MainBox = new System.Windows.Forms.GroupBox();
            this.CategoryCheck = new System.Windows.Forms.CheckBox();
            this.CategoryCombo = new System.Windows.Forms.ComboBox();
            this.KitchenCheck = new System.Windows.Forms.CheckBox();
            this.KitchenCombo = new System.Windows.Forms.ComboBox();
            this.DishGrid = new System.Windows.Forms.DataGridView();
            this.MainBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DishGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MainBox
            // 
            this.MainBox.Controls.Add(this.CategoryCheck);
            this.MainBox.Controls.Add(this.CategoryCombo);
            this.MainBox.Controls.Add(this.KitchenCheck);
            this.MainBox.Controls.Add(this.KitchenCombo);
            this.MainBox.Controls.Add(this.DishGrid);
            this.MainBox.Location = new System.Drawing.Point(12, 12);
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
            // 
            // CategoryCombo
            // 
            this.CategoryCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            // 
            // KitchenCombo
            // 
            this.KitchenCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KitchenCombo.FormattingEnabled = true;
            this.KitchenCombo.Location = new System.Drawing.Point(104, 19);
            this.KitchenCombo.Name = "KitchenCombo";
            this.KitchenCombo.Size = new System.Drawing.Size(308, 23);
            this.KitchenCombo.TabIndex = 3;
            // 
            // DishGrid
            // 
            this.DishGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DishGrid.Location = new System.Drawing.Point(13, 75);
            this.DishGrid.Name = "DishGrid";
            this.DishGrid.RowTemplate.Height = 25;
            this.DishGrid.Size = new System.Drawing.Size(399, 399);
            this.DishGrid.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 511);
            this.Controls.Add(this.MainBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MainBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DishGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MainBox;
        private System.Windows.Forms.ComboBox KitchenCombo;
        private System.Windows.Forms.DataGridView DishGrid;
        private System.Windows.Forms.CheckBox CategoryCheck;
        private System.Windows.Forms.ComboBox CategoryCombo;
        private System.Windows.Forms.CheckBox KitchenCheck;
    }
}

