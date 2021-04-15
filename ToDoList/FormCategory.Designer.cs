
namespace ToDoList
{
    partial class FormCategory
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
            this.btnAddEditDelCat = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelNameCategory = new System.Windows.Forms.Label();
            this.textBoxNameCategory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddEditDelCat
            // 
            this.btnAddEditDelCat.Location = new System.Drawing.Point(69, 200);
            this.btnAddEditDelCat.Name = "btnAddEditDelCat";
            this.btnAddEditDelCat.Size = new System.Drawing.Size(75, 23);
            this.btnAddEditDelCat.TabIndex = 0;
            this.btnAddEditDelCat.UseVisualStyleBackColor = true;
            this.btnAddEditDelCat.Click += new System.EventHandler(this.btnAddEditDelCat_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(180, 200);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 24);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelNameCategory
            // 
            this.labelNameCategory.AutoSize = true;
            this.labelNameCategory.Location = new System.Drawing.Point(66, 70);
            this.labelNameCategory.Name = "labelNameCategory";
            this.labelNameCategory.Size = new System.Drawing.Size(83, 13);
            this.labelNameCategory.TabIndex = 2;
            this.labelNameCategory.Text = "Nazwa kategorii";
            // 
            // textBoxNameCategory
            // 
            this.textBoxNameCategory.Location = new System.Drawing.Point(69, 122);
            this.textBoxNameCategory.Name = "textBoxNameCategory";
            this.textBoxNameCategory.Size = new System.Drawing.Size(186, 20);
            this.textBoxNameCategory.TabIndex = 3;
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 278);
            this.Controls.Add(this.textBoxNameCategory);
            this.Controls.Add(this.labelNameCategory);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddEditDelCat);
            this.Name = "FormCategory";
            this.Text = "Kategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddEditDelCat;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelNameCategory;
        private System.Windows.Forms.TextBox textBoxNameCategory;
    }
}