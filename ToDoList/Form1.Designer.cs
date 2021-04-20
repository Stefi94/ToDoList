namespace ToDoList
{
    partial class FormMainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.użytkownikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutAndCloseProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zadaniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddTaskRepeatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńWszystkieZadaniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńWszystkieZrealizowaneZadaniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńZadaniaZPrzedziałuCzasuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioBtnShowAll = new System.Windows.Forms.RadioButton();
            this.radioBtnShowUnrealized = new System.Windows.Forms.RadioButton();
            this.labelToDoList = new System.Windows.Forms.Label();
            this.listViewTask = new System.Windows.Forms.ListView();
            this.columnOrdinalNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnContext = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCreateDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDateLimit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIsRealized = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnShowEdit = new System.Windows.Forms.Button();
            this.labelWhoIsLogged = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.użytkownikToolStripMenuItem,
            this.kategoriaToolStripMenuItem,
            this.zadaniaToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(986, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // użytkownikToolStripMenuItem
            // 
            this.użytkownikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogOutToolStripMenuItem,
            this.LogOutAndCloseProgramToolStripMenuItem,
            this.ChangeLoginToolStripMenuItem,
            this.ChangePasswordToolStripMenuItem,
            this.DeleteAccountToolStripMenuItem});
            this.użytkownikToolStripMenuItem.Name = "użytkownikToolStripMenuItem";
            this.użytkownikToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.użytkownikToolStripMenuItem.Text = "Użytkownik";
            // 
            // LogOutToolStripMenuItem
            // 
            this.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem";
            this.LogOutToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.LogOutToolStripMenuItem.Text = "Wyloguj";
            this.LogOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click);
            // 
            // LogOutAndCloseProgramToolStripMenuItem
            // 
            this.LogOutAndCloseProgramToolStripMenuItem.Name = "LogOutAndCloseProgramToolStripMenuItem";
            this.LogOutAndCloseProgramToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.LogOutAndCloseProgramToolStripMenuItem.Text = "Wyloguj i zamknij program";
            this.LogOutAndCloseProgramToolStripMenuItem.Click += new System.EventHandler(this.LogOutAndCloseProgramToolStripMenuItem_Click);
            // 
            // ChangeLoginToolStripMenuItem
            // 
            this.ChangeLoginToolStripMenuItem.Name = "ChangeLoginToolStripMenuItem";
            this.ChangeLoginToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.ChangeLoginToolStripMenuItem.Text = "Zmień login";
            this.ChangeLoginToolStripMenuItem.Click += new System.EventHandler(this.ChangeLoginToolStripMenuItem_Click);
            // 
            // ChangePasswordToolStripMenuItem
            // 
            this.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem";
            this.ChangePasswordToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.ChangePasswordToolStripMenuItem.Text = "Zmień hasło";
            this.ChangePasswordToolStripMenuItem.Click += new System.EventHandler(this.ChangePasswordToolStripMenuItem_Click);
            // 
            // DeleteAccountToolStripMenuItem
            // 
            this.DeleteAccountToolStripMenuItem.Name = "DeleteAccountToolStripMenuItem";
            this.DeleteAccountToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.DeleteAccountToolStripMenuItem.Text = "Usuń konto";
            this.DeleteAccountToolStripMenuItem.Click += new System.EventHandler(this.DeleteAccountToolStripMenuItem_Click);
            // 
            // kategoriaToolStripMenuItem
            // 
            this.kategoriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCategoryToolStripMenuItem,
            this.EditCategoryToolStripMenuItem,
            this.DeleteCategoryToolStripMenuItem});
            this.kategoriaToolStripMenuItem.Name = "kategoriaToolStripMenuItem";
            this.kategoriaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.kategoriaToolStripMenuItem.Text = "Kategoria";
            // 
            // AddCategoryToolStripMenuItem
            // 
            this.AddCategoryToolStripMenuItem.Name = "AddCategoryToolStripMenuItem";
            this.AddCategoryToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.AddCategoryToolStripMenuItem.Text = "Dodaj nową kategorię";
            this.AddCategoryToolStripMenuItem.Click += new System.EventHandler(this.AddCategoryToolStripMenuItem_Click);
            // 
            // EditCategoryToolStripMenuItem
            // 
            this.EditCategoryToolStripMenuItem.Name = "EditCategoryToolStripMenuItem";
            this.EditCategoryToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.EditCategoryToolStripMenuItem.Text = "Edytuj kategorię";
            this.EditCategoryToolStripMenuItem.Click += new System.EventHandler(this.EditCategoryToolStripMenuItem_Click);
            // 
            // DeleteCategoryToolStripMenuItem
            // 
            this.DeleteCategoryToolStripMenuItem.Name = "DeleteCategoryToolStripMenuItem";
            this.DeleteCategoryToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.DeleteCategoryToolStripMenuItem.Text = "Usuń kategorię";
            this.DeleteCategoryToolStripMenuItem.Click += new System.EventHandler(this.DeleteCategoryToolStripMenuItem_Click);
            // 
            // zadaniaToolStripMenuItem
            // 
            this.zadaniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddTaskRepeatToolStripMenuItem,
            this.AddTaskToolStripMenuItem,
            this.usuńWszystkieZadaniaToolStripMenuItem,
            this.usuńWszystkieZrealizowaneZadaniaToolStripMenuItem,
            this.usuńZadaniaZPrzedziałuCzasuToolStripMenuItem});
            this.zadaniaToolStripMenuItem.Name = "zadaniaToolStripMenuItem";
            this.zadaniaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.zadaniaToolStripMenuItem.Text = "Zadania";
            // 
            // AddTaskRepeatToolStripMenuItem
            // 
            this.AddTaskRepeatToolStripMenuItem.Name = "AddTaskRepeatToolStripMenuItem";
            this.AddTaskRepeatToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.AddTaskRepeatToolStripMenuItem.Text = "Dodaj zadanie powtarzające się";
            this.AddTaskRepeatToolStripMenuItem.Click += new System.EventHandler(this.AddTaskRepeatToolStripMenuItem_Click);
            // 
            // AddTaskToolStripMenuItem
            // 
            this.AddTaskToolStripMenuItem.Name = "AddTaskToolStripMenuItem";
            this.AddTaskToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.AddTaskToolStripMenuItem.Text = "Dodaj nowe zadanie";
            this.AddTaskToolStripMenuItem.Click += new System.EventHandler(this.AddTaskToolStripMenuItem_Click);
            // 
            // usuńWszystkieZadaniaToolStripMenuItem
            // 
            this.usuńWszystkieZadaniaToolStripMenuItem.Name = "usuńWszystkieZadaniaToolStripMenuItem";
            this.usuńWszystkieZadaniaToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.usuńWszystkieZadaniaToolStripMenuItem.Text = "Usuń wszystkie zadania";
            // 
            // usuńWszystkieZrealizowaneZadaniaToolStripMenuItem
            // 
            this.usuńWszystkieZrealizowaneZadaniaToolStripMenuItem.Name = "usuńWszystkieZrealizowaneZadaniaToolStripMenuItem";
            this.usuńWszystkieZrealizowaneZadaniaToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.usuńWszystkieZrealizowaneZadaniaToolStripMenuItem.Text = "Usuń wszystkie zrealizowane zadania";
            // 
            // usuńZadaniaZPrzedziałuCzasuToolStripMenuItem
            // 
            this.usuńZadaniaZPrzedziałuCzasuToolStripMenuItem.Name = "usuńZadaniaZPrzedziałuCzasuToolStripMenuItem";
            this.usuńZadaniaZPrzedziałuCzasuToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.usuńZadaniaZPrzedziałuCzasuToolStripMenuItem.Text = "Usuń zadania z przedziału czasu";
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // radioBtnShowAll
            // 
            this.radioBtnShowAll.AutoSize = true;
            this.radioBtnShowAll.Location = new System.Drawing.Point(172, 53);
            this.radioBtnShowAll.Name = "radioBtnShowAll";
            this.radioBtnShowAll.Size = new System.Drawing.Size(143, 17);
            this.radioBtnShowAll.TabIndex = 1;
            this.radioBtnShowAll.TabStop = true;
            this.radioBtnShowAll.Text = "Pokaż wszystkie zadania";
            this.radioBtnShowAll.UseVisualStyleBackColor = true;
            // 
            // radioBtnShowUnrealized
            // 
            this.radioBtnShowUnrealized.AutoSize = true;
            this.radioBtnShowUnrealized.Location = new System.Drawing.Point(172, 77);
            this.radioBtnShowUnrealized.Name = "radioBtnShowUnrealized";
            this.radioBtnShowUnrealized.Size = new System.Drawing.Size(198, 17);
            this.radioBtnShowUnrealized.TabIndex = 2;
            this.radioBtnShowUnrealized.TabStop = true;
            this.radioBtnShowUnrealized.Text = "Pokaż tylko niezrealizowane zadania";
            this.radioBtnShowUnrealized.UseVisualStyleBackColor = true;
            // 
            // labelToDoList
            // 
            this.labelToDoList.AutoSize = true;
            this.labelToDoList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelToDoList.Location = new System.Drawing.Point(23, 71);
            this.labelToDoList.Name = "labelToDoList";
            this.labelToDoList.Size = new System.Drawing.Size(108, 24);
            this.labelToDoList.TabIndex = 3;
            this.labelToDoList.Text = "Lista zadań:";
            // 
            // listViewTask
            // 
            this.listViewTask.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnOrdinalNumber,
            this.columnCategory,
            this.columnTitle,
            this.columnContext,
            this.columnCreateDate,
            this.columnDateLimit,
            this.columnIsRealized});
            this.listViewTask.HideSelection = false;
            this.listViewTask.Location = new System.Drawing.Point(27, 121);
            this.listViewTask.Name = "listViewTask";
            this.listViewTask.Size = new System.Drawing.Size(696, 297);
            this.listViewTask.TabIndex = 4;
            this.listViewTask.UseCompatibleStateImageBehavior = false;
            this.listViewTask.View = System.Windows.Forms.View.Details;
            // 
            // columnOrdinalNumber
            // 
            this.columnOrdinalNumber.Text = "Lp.";
            this.columnOrdinalNumber.Width = 30;
            // 
            // columnCategory
            // 
            this.columnCategory.Text = "Kategoria";
            this.columnCategory.Width = 80;
            // 
            // columnTitle
            // 
            this.columnTitle.Text = "Tytuł";
            this.columnTitle.Width = 120;
            // 
            // columnContext
            // 
            this.columnContext.Text = "Treść";
            this.columnContext.Width = 160;
            // 
            // columnCreateDate
            // 
            this.columnCreateDate.Text = "Data utworzenia";
            this.columnCreateDate.Width = 90;
            // 
            // columnDateLimit
            // 
            this.columnDateLimit.Text = "Termin";
            this.columnDateLimit.Width = 90;
            // 
            // columnIsRealized
            // 
            this.columnIsRealized.Text = "Zrealizowane";
            this.columnIsRealized.Width = 90;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(27, 466);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(104, 39);
            this.btnAddTask.TabIndex = 5;
            this.btnAddTask.Text = "Dodaj nowe zadanie";
            this.btnAddTask.UseVisualStyleBackColor = true;
            // 
            // btnShowEdit
            // 
            this.btnShowEdit.Location = new System.Drawing.Point(198, 466);
            this.btnShowEdit.Name = "btnShowEdit";
            this.btnShowEdit.Size = new System.Drawing.Size(104, 39);
            this.btnShowEdit.TabIndex = 6;
            this.btnShowEdit.Text = "Wyświetl lub edytuj";
            this.btnShowEdit.UseVisualStyleBackColor = true;
            this.btnShowEdit.Click += new System.EventHandler(this.btnShowEdit_Click_1);
            // 
            // labelWhoIsLogged
            // 
            this.labelWhoIsLogged.AutoSize = true;
            this.labelWhoIsLogged.Location = new System.Drawing.Point(468, 53);
            this.labelWhoIsLogged.Name = "labelWhoIsLogged";
            this.labelWhoIsLogged.Size = new System.Drawing.Size(83, 13);
            this.labelWhoIsLogged.TabIndex = 7;
            this.labelWhoIsLogged.Text = "Nie zalogowano";
            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 555);
            this.Controls.Add(this.labelWhoIsLogged);
            this.Controls.Add(this.btnShowEdit);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.listViewTask);
            this.Controls.Add(this.labelToDoList);
            this.Controls.Add(this.radioBtnShowUnrealized);
            this.Controls.Add(this.radioBtnShowAll);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMainWindow";
            this.Text = "ToDoList";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem użytkownikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zadaniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddTaskRepeatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńWszystkieZadaniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńWszystkieZrealizowaneZadaniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńZadaniaZPrzedziałuCzasuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioBtnShowAll;
        private System.Windows.Forms.RadioButton radioBtnShowUnrealized;
        private System.Windows.Forms.Label labelToDoList;
        private System.Windows.Forms.ListView listViewTask;
        private System.Windows.Forms.ColumnHeader columnOrdinalNumber;
        private System.Windows.Forms.ColumnHeader columnTitle;
        private System.Windows.Forms.ColumnHeader columnCategory;
        private System.Windows.Forms.ColumnHeader columnContext;
        private System.Windows.Forms.ColumnHeader columnCreateDate;
        private System.Windows.Forms.ColumnHeader columnDateLimit;
        private System.Windows.Forms.ColumnHeader columnIsRealized;
        private System.Windows.Forms.ToolStripMenuItem AddTaskToolStripMenuItem;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnShowEdit;
        private System.Windows.Forms.ToolStripMenuItem LogOutAndCloseProgramToolStripMenuItem;
        private System.Windows.Forms.Label labelWhoIsLogged;
    }
}