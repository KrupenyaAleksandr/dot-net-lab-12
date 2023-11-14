namespace dot_net_lab_12
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.sportDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportDBDataSet = new dot_net_lab_12.SportDBDataSet();
            this.sportsmanTableAdapter = new dot_net_lab_12.SportDBDataSetTableAdapters.sportsmanTableAdapter();
            this.sportsmanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.бДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTableSportsmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTableSportClubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSportsman = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewSportsman = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middlenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.sportclubidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorSportsman = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItemSportsman = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItemSportsman = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItemSportsman = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItemSportsman = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItemSportsman = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSportsmanSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItemSportsman = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSportsmanSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItemSportsman = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItemSportsman = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSportsmanSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSaveSportsman = new System.Windows.Forms.ToolStripButton();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loadFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPageSportClub = new System.Windows.Forms.TabPage();
            this.dataGridViewSportClub = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sportclubBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorSportClub = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItemSportClub = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItemSportClub = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItemSportClub = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItemSportClub = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItemSportClub = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSportClubSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItemSportClub = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSportClubSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItemSportClub = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItemSportClub = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSportClubSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSaveSportClub = new System.Windows.Forms.ToolStripButton();
            this.sport_clubTableAdapter = new dot_net_lab_12.SportDBDataSetTableAdapters.sport_clubTableAdapter();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.comboBoxSportClub = new System.Windows.Forms.ComboBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelSportClub = new System.Windows.Forms.Label();
            this.labelPictue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sportDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsmanBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageSportsman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSportsman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorSportsman)).BeginInit();
            this.bindingNavigatorSportsman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabPageSportClub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSportClub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportclubBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorSportClub)).BeginInit();
            this.bindingNavigatorSportClub.SuspendLayout();
            this.SuspendLayout();
            // 
            // sportDBDataSetBindingSource
            // 
            this.sportDBDataSetBindingSource.DataSource = this.sportDBDataSet;
            this.sportDBDataSetBindingSource.Position = 0;
            // 
            // sportDBDataSet
            // 
            this.sportDBDataSet.DataSetName = "SportDBDataSet";
            this.sportDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sportsmanTableAdapter
            // 
            this.sportsmanTableAdapter.ClearBeforeFill = true;
            // 
            // sportsmanBindingSource
            // 
            this.sportsmanBindingSource.DataMember = "sportsman";
            this.sportsmanBindingSource.DataSource = this.sportDBDataSetBindingSource;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.бДToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // бДToolStripMenuItem
            // 
            this.бДToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadTableSportsmanToolStripMenuItem,
            this.loadTableSportClubToolStripMenuItem});
            this.бДToolStripMenuItem.Name = "бДToolStripMenuItem";
            this.бДToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.бДToolStripMenuItem.Text = "БД";
            // 
            // loadTableSportsmanToolStripMenuItem
            // 
            this.loadTableSportsmanToolStripMenuItem.Name = "loadTableSportsmanToolStripMenuItem";
            this.loadTableSportsmanToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.loadTableSportsmanToolStripMenuItem.Text = "Загрузить таблицу \"Спортсмен\"";
            this.loadTableSportsmanToolStripMenuItem.Click += new System.EventHandler(this.loadTableSportsmanToolStripMenuItem_Click);
            // 
            // loadTableSportClubToolStripMenuItem
            // 
            this.loadTableSportClubToolStripMenuItem.Name = "loadTableSportClubToolStripMenuItem";
            this.loadTableSportClubToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.loadTableSportClubToolStripMenuItem.Text = "Загрузить таблицу \"Спортивный клуб\"";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSportsman);
            this.tabControl1.Controls.Add(this.tabPageSportClub);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 488);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageSportsman
            // 
            this.tabPageSportsman.Controls.Add(this.splitContainer1);
            this.tabPageSportsman.Controls.Add(this.statusStrip1);
            this.tabPageSportsman.Location = new System.Drawing.Point(4, 22);
            this.tabPageSportsman.Name = "tabPageSportsman";
            this.tabPageSportsman.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSportsman.Size = new System.Drawing.Size(792, 462);
            this.tabPageSportsman.TabIndex = 0;
            this.tabPageSportsman.Text = "Список спортсменов";
            this.tabPageSportsman.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewSportsman);
            this.splitContainer1.Panel1.Controls.Add(this.bindingNavigatorSportsman);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.labelPictue);
            this.splitContainer1.Panel2.Controls.Add(this.labelSportClub);
            this.splitContainer1.Panel2.Controls.Add(this.labelLastName);
            this.splitContainer1.Panel2.Controls.Add(this.labelMiddleName);
            this.splitContainer1.Panel2.Controls.Add(this.labelFirstName);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxSportClub);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxLastName);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxMiddleName);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxFirstName);
            this.splitContainer1.Panel2.Controls.Add(this.photoPictureBox);
            this.splitContainer1.Size = new System.Drawing.Size(786, 434);
            this.splitContainer1.SplitterDistance = 608;
            this.splitContainer1.TabIndex = 1;
            // 
            // dataGridViewSportsman
            // 
            this.dataGridViewSportsman.AutoGenerateColumns = false;
            this.dataGridViewSportsman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSportsman.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.middlenameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.photoDataGridViewImageColumn,
            this.sportclubidDataGridViewTextBoxColumn});
            this.dataGridViewSportsman.DataSource = this.sportsmanBindingSource;
            this.dataGridViewSportsman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSportsman.Location = new System.Drawing.Point(0, 25);
            this.dataGridViewSportsman.Name = "dataGridViewSportsman";
            this.dataGridViewSportsman.Size = new System.Drawing.Size(608, 409);
            this.dataGridViewSportsman.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 30;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.Width = 120;
            // 
            // middlenameDataGridViewTextBoxColumn
            // 
            this.middlenameDataGridViewTextBoxColumn.DataPropertyName = "middle_name";
            this.middlenameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.middlenameDataGridViewTextBoxColumn.Name = "middlenameDataGridViewTextBoxColumn";
            this.middlenameDataGridViewTextBoxColumn.Width = 120;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.Width = 120;
            // 
            // photoDataGridViewImageColumn
            // 
            this.photoDataGridViewImageColumn.DataPropertyName = "photo";
            this.photoDataGridViewImageColumn.HeaderText = "Фото";
            this.photoDataGridViewImageColumn.Name = "photoDataGridViewImageColumn";
            // 
            // sportclubidDataGridViewTextBoxColumn
            // 
            this.sportclubidDataGridViewTextBoxColumn.DataPropertyName = "sport_club_id";
            this.sportclubidDataGridViewTextBoxColumn.HeaderText = "Номер команды";
            this.sportclubidDataGridViewTextBoxColumn.Name = "sportclubidDataGridViewTextBoxColumn";
            this.sportclubidDataGridViewTextBoxColumn.Width = 70;
            // 
            // bindingNavigatorSportsman
            // 
            this.bindingNavigatorSportsman.AddNewItem = this.bindingNavigatorAddNewItemSportsman;
            this.bindingNavigatorSportsman.BindingSource = this.sportsmanBindingSource;
            this.bindingNavigatorSportsman.CountItem = this.bindingNavigatorCountItemSportsman;
            this.bindingNavigatorSportsman.DeleteItem = this.bindingNavigatorDeleteItemSportsman;
            this.bindingNavigatorSportsman.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItemSportsman,
            this.bindingNavigatorMovePreviousItemSportsman,
            this.bindingNavigatorSportsmanSeparator1,
            this.bindingNavigatorPositionItemSportsman,
            this.bindingNavigatorCountItemSportsman,
            this.bindingNavigatorSportsmanSeparator2,
            this.bindingNavigatorMoveNextItemSportsman,
            this.bindingNavigatorMoveLastItemSportsman,
            this.bindingNavigatorSportsmanSeparator3,
            this.bindingNavigatorAddNewItemSportsman,
            this.bindingNavigatorDeleteItemSportsman,
            this.bindingNavigatorSaveSportsman});
            this.bindingNavigatorSportsman.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorSportsman.MoveFirstItem = this.bindingNavigatorMoveFirstItemSportsman;
            this.bindingNavigatorSportsman.MoveLastItem = this.bindingNavigatorMoveLastItemSportsman;
            this.bindingNavigatorSportsman.MoveNextItem = this.bindingNavigatorMoveNextItemSportsman;
            this.bindingNavigatorSportsman.MovePreviousItem = this.bindingNavigatorMovePreviousItemSportsman;
            this.bindingNavigatorSportsman.Name = "bindingNavigatorSportsman";
            this.bindingNavigatorSportsman.PositionItem = this.bindingNavigatorPositionItemSportsman;
            this.bindingNavigatorSportsman.Size = new System.Drawing.Size(608, 25);
            this.bindingNavigatorSportsman.TabIndex = 0;
            this.bindingNavigatorSportsman.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItemSportsman
            // 
            this.bindingNavigatorAddNewItemSportsman.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItemSportsman.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItemSportsman.Image")));
            this.bindingNavigatorAddNewItemSportsman.Name = "bindingNavigatorAddNewItemSportsman";
            this.bindingNavigatorAddNewItemSportsman.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItemSportsman.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItemSportsman.Text = "Добавить";
            // 
            // bindingNavigatorCountItemSportsman
            // 
            this.bindingNavigatorCountItemSportsman.Name = "bindingNavigatorCountItemSportsman";
            this.bindingNavigatorCountItemSportsman.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItemSportsman.Text = "для {0}";
            this.bindingNavigatorCountItemSportsman.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItemSportsman
            // 
            this.bindingNavigatorDeleteItemSportsman.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItemSportsman.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItemSportsman.Image")));
            this.bindingNavigatorDeleteItemSportsman.Name = "bindingNavigatorDeleteItemSportsman";
            this.bindingNavigatorDeleteItemSportsman.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItemSportsman.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItemSportsman.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItemSportsman
            // 
            this.bindingNavigatorMoveFirstItemSportsman.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItemSportsman.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItemSportsman.Image")));
            this.bindingNavigatorMoveFirstItemSportsman.Name = "bindingNavigatorMoveFirstItemSportsman";
            this.bindingNavigatorMoveFirstItemSportsman.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItemSportsman.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItemSportsman.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItemSportsman
            // 
            this.bindingNavigatorMovePreviousItemSportsman.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItemSportsman.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItemSportsman.Image")));
            this.bindingNavigatorMovePreviousItemSportsman.Name = "bindingNavigatorMovePreviousItemSportsman";
            this.bindingNavigatorMovePreviousItemSportsman.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItemSportsman.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItemSportsman.Text = "Переместить назад";
            // 
            // bindingNavigatorSportsmanSeparator1
            // 
            this.bindingNavigatorSportsmanSeparator1.Name = "bindingNavigatorSportsmanSeparator1";
            this.bindingNavigatorSportsmanSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItemSportsman
            // 
            this.bindingNavigatorPositionItemSportsman.AccessibleName = "Положение";
            this.bindingNavigatorPositionItemSportsman.AutoSize = false;
            this.bindingNavigatorPositionItemSportsman.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItemSportsman.Name = "bindingNavigatorPositionItemSportsman";
            this.bindingNavigatorPositionItemSportsman.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItemSportsman.Text = "0";
            this.bindingNavigatorPositionItemSportsman.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSportsmanSeparator2
            // 
            this.bindingNavigatorSportsmanSeparator2.Name = "bindingNavigatorSportsmanSeparator2";
            this.bindingNavigatorSportsmanSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItemSportsman
            // 
            this.bindingNavigatorMoveNextItemSportsman.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItemSportsman.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItemSportsman.Image")));
            this.bindingNavigatorMoveNextItemSportsman.Name = "bindingNavigatorMoveNextItemSportsman";
            this.bindingNavigatorMoveNextItemSportsman.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItemSportsman.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItemSportsman.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItemSportsman
            // 
            this.bindingNavigatorMoveLastItemSportsman.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItemSportsman.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItemSportsman.Image")));
            this.bindingNavigatorMoveLastItemSportsman.Name = "bindingNavigatorMoveLastItemSportsman";
            this.bindingNavigatorMoveLastItemSportsman.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItemSportsman.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItemSportsman.Text = "Переместить в конец";
            // 
            // bindingNavigatorSportsmanSeparator3
            // 
            this.bindingNavigatorSportsmanSeparator3.Name = "bindingNavigatorSportsmanSeparator3";
            this.bindingNavigatorSportsmanSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSaveSportsman
            // 
            this.bindingNavigatorSaveSportsman.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorSaveSportsman.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSaveSportsman.Image")));
            this.bindingNavigatorSaveSportsman.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorSaveSportsman.Name = "bindingNavigatorSaveSportsman";
            this.bindingNavigatorSaveSportsman.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorSaveSportsman.Text = "toolStripButton1";
            this.bindingNavigatorSaveSportsman.Click += new System.EventHandler(this.bindingNavigatorSaveSportsman_Click);
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.photoPictureBox.ContextMenuStrip = this.contextMenuStrip1;
            this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.sportsmanBindingSource, "photo", true));
            this.photoPictureBox.Location = new System.Drawing.Point(22, 275);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(121, 145);
            this.photoPictureBox.TabIndex = 0;
            this.photoPictureBox.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFromFileToolStripMenuItem,
            this.saveToFileToolStripMenuItem,
            this.propertiesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 70);
            // 
            // loadFromFileToolStripMenuItem
            // 
            this.loadFromFileToolStripMenuItem.Name = "loadFromFileToolStripMenuItem";
            this.loadFromFileToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.loadFromFileToolStripMenuItem.Text = "Загрузить из файла";
            this.loadFromFileToolStripMenuItem.Click += new System.EventHandler(this.loadFromFileToolStripMenuItem_Click);
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.saveToFileToolStripMenuItem.Text = "Сохранить в файл";
            this.saveToFileToolStripMenuItem.Click += new System.EventHandler(this.saveToFileToolStripMenuItem_Click);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.propertiesToolStripMenuItem.Text = "Свойства";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 437);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(786, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel1.Text = "Готово";
            // 
            // tabPageSportClub
            // 
            this.tabPageSportClub.Controls.Add(this.dataGridViewSportClub);
            this.tabPageSportClub.Controls.Add(this.bindingNavigatorSportClub);
            this.tabPageSportClub.Location = new System.Drawing.Point(4, 22);
            this.tabPageSportClub.Name = "tabPageSportClub";
            this.tabPageSportClub.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSportClub.Size = new System.Drawing.Size(792, 462);
            this.tabPageSportClub.TabIndex = 1;
            this.tabPageSportClub.Text = "Список команд";
            this.tabPageSportClub.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSportClub
            // 
            this.dataGridViewSportClub.AutoGenerateColumns = false;
            this.dataGridViewSportClub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSportClub.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.titleDataGridViewTextBoxColumn});
            this.dataGridViewSportClub.DataSource = this.sportclubBindingSource;
            this.dataGridViewSportClub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSportClub.Location = new System.Drawing.Point(3, 28);
            this.dataGridViewSportClub.Name = "dataGridViewSportClub";
            this.dataGridViewSportClub.Size = new System.Drawing.Size(786, 431);
            this.dataGridViewSportClub.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 40;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Название";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 160;
            // 
            // sportclubBindingSource
            // 
            this.sportclubBindingSource.DataMember = "sport_club";
            this.sportclubBindingSource.DataSource = this.sportDBDataSetBindingSource;
            // 
            // bindingNavigatorSportClub
            // 
            this.bindingNavigatorSportClub.AddNewItem = this.bindingNavigatorAddNewItemSportClub;
            this.bindingNavigatorSportClub.BindingSource = this.sportclubBindingSource;
            this.bindingNavigatorSportClub.CountItem = this.bindingNavigatorCountItemSportClub;
            this.bindingNavigatorSportClub.DeleteItem = this.bindingNavigatorDeleteItemSportClub;
            this.bindingNavigatorSportClub.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItemSportClub,
            this.bindingNavigatorMovePreviousItemSportClub,
            this.bindingNavigatorSportClubSeparator1,
            this.bindingNavigatorPositionItemSportClub,
            this.bindingNavigatorCountItemSportClub,
            this.bindingNavigatorSportClubSeparator2,
            this.bindingNavigatorMoveNextItemSportClub,
            this.bindingNavigatorMoveLastItemSportClub,
            this.bindingNavigatorSportClubSeparator3,
            this.bindingNavigatorAddNewItemSportClub,
            this.bindingNavigatorDeleteItemSportClub,
            this.bindingNavigatorSaveSportClub});
            this.bindingNavigatorSportClub.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigatorSportClub.MoveFirstItem = this.bindingNavigatorMoveFirstItemSportClub;
            this.bindingNavigatorSportClub.MoveLastItem = this.bindingNavigatorMoveLastItemSportClub;
            this.bindingNavigatorSportClub.MoveNextItem = this.bindingNavigatorMoveNextItemSportClub;
            this.bindingNavigatorSportClub.MovePreviousItem = this.bindingNavigatorMovePreviousItemSportClub;
            this.bindingNavigatorSportClub.Name = "bindingNavigatorSportClub";
            this.bindingNavigatorSportClub.PositionItem = this.bindingNavigatorPositionItemSportClub;
            this.bindingNavigatorSportClub.Size = new System.Drawing.Size(786, 25);
            this.bindingNavigatorSportClub.TabIndex = 0;
            this.bindingNavigatorSportClub.Text = "bindingNavigator2";
            // 
            // bindingNavigatorAddNewItemSportClub
            // 
            this.bindingNavigatorAddNewItemSportClub.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItemSportClub.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItemSportClub.Image")));
            this.bindingNavigatorAddNewItemSportClub.Name = "bindingNavigatorAddNewItemSportClub";
            this.bindingNavigatorAddNewItemSportClub.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItemSportClub.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItemSportClub.Text = "Добавить";
            // 
            // bindingNavigatorCountItemSportClub
            // 
            this.bindingNavigatorCountItemSportClub.Name = "bindingNavigatorCountItemSportClub";
            this.bindingNavigatorCountItemSportClub.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItemSportClub.Text = "для {0}";
            this.bindingNavigatorCountItemSportClub.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItemSportClub
            // 
            this.bindingNavigatorDeleteItemSportClub.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItemSportClub.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItemSportClub.Image")));
            this.bindingNavigatorDeleteItemSportClub.Name = "bindingNavigatorDeleteItemSportClub";
            this.bindingNavigatorDeleteItemSportClub.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItemSportClub.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItemSportClub.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItemSportClub
            // 
            this.bindingNavigatorMoveFirstItemSportClub.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItemSportClub.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItemSportClub.Image")));
            this.bindingNavigatorMoveFirstItemSportClub.Name = "bindingNavigatorMoveFirstItemSportClub";
            this.bindingNavigatorMoveFirstItemSportClub.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItemSportClub.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItemSportClub.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItemSportClub
            // 
            this.bindingNavigatorMovePreviousItemSportClub.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItemSportClub.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItemSportClub.Image")));
            this.bindingNavigatorMovePreviousItemSportClub.Name = "bindingNavigatorMovePreviousItemSportClub";
            this.bindingNavigatorMovePreviousItemSportClub.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItemSportClub.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItemSportClub.Text = "Переместить назад";
            // 
            // bindingNavigatorSportClubSeparator1
            // 
            this.bindingNavigatorSportClubSeparator1.Name = "bindingNavigatorSportClubSeparator1";
            this.bindingNavigatorSportClubSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItemSportClub
            // 
            this.bindingNavigatorPositionItemSportClub.AccessibleName = "Положение";
            this.bindingNavigatorPositionItemSportClub.AutoSize = false;
            this.bindingNavigatorPositionItemSportClub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItemSportClub.Name = "bindingNavigatorPositionItemSportClub";
            this.bindingNavigatorPositionItemSportClub.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItemSportClub.Text = "0";
            this.bindingNavigatorPositionItemSportClub.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSportClubSeparator2
            // 
            this.bindingNavigatorSportClubSeparator2.Name = "bindingNavigatorSportClubSeparator2";
            this.bindingNavigatorSportClubSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItemSportClub
            // 
            this.bindingNavigatorMoveNextItemSportClub.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItemSportClub.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItemSportClub.Image")));
            this.bindingNavigatorMoveNextItemSportClub.Name = "bindingNavigatorMoveNextItemSportClub";
            this.bindingNavigatorMoveNextItemSportClub.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItemSportClub.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItemSportClub.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItemSportClub
            // 
            this.bindingNavigatorMoveLastItemSportClub.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItemSportClub.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItemSportClub.Image")));
            this.bindingNavigatorMoveLastItemSportClub.Name = "bindingNavigatorMoveLastItemSportClub";
            this.bindingNavigatorMoveLastItemSportClub.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItemSportClub.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItemSportClub.Text = "Переместить в конец";
            // 
            // bindingNavigatorSportClubSeparator3
            // 
            this.bindingNavigatorSportClubSeparator3.Name = "bindingNavigatorSportClubSeparator3";
            this.bindingNavigatorSportClubSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSaveSportClub
            // 
            this.bindingNavigatorSaveSportClub.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorSaveSportClub.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSaveSportClub.Image")));
            this.bindingNavigatorSaveSportClub.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorSaveSportClub.Name = "bindingNavigatorSaveSportClub";
            this.bindingNavigatorSaveSportClub.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorSaveSportClub.Text = "toolStripButton2";
            // 
            // sport_clubTableAdapter
            // 
            this.sport_clubTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sportsmanBindingSource, "first_name", true));
            this.textBoxFirstName.Location = new System.Drawing.Point(22, 35);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(121, 20);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sportsmanBindingSource, "middle_name", true));
            this.textBoxMiddleName.Location = new System.Drawing.Point(22, 95);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(121, 20);
            this.textBoxMiddleName.TabIndex = 2;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sportsmanBindingSource, "last_name", true));
            this.textBoxLastName.Location = new System.Drawing.Point(22, 155);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(121, 20);
            this.textBoxLastName.TabIndex = 3;
            // 
            // comboBoxSportClub
            // 
            this.comboBoxSportClub.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sportsmanBindingSource, "sport_club_id", true));
            this.comboBoxSportClub.DataSource = this.sportclubBindingSource;
            this.comboBoxSportClub.DisplayMember = "title";
            this.comboBoxSportClub.FormattingEnabled = true;
            this.comboBoxSportClub.Location = new System.Drawing.Point(22, 215);
            this.comboBoxSportClub.Name = "comboBoxSportClub";
            this.comboBoxSportClub.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSportClub.TabIndex = 4;
            this.comboBoxSportClub.ValueMember = "id";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(25, 15);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(29, 13);
            this.labelFirstName.TabIndex = 5;
            this.labelFirstName.Text = "Имя";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(25, 75);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(54, 13);
            this.labelMiddleName.TabIndex = 6;
            this.labelMiddleName.Text = "Отчество";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(25, 135);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(56, 13);
            this.labelLastName.TabIndex = 7;
            this.labelLastName.Text = "Фамилия";
            // 
            // labelSportClub
            // 
            this.labelSportClub.AutoSize = true;
            this.labelSportClub.Location = new System.Drawing.Point(25, 195);
            this.labelSportClub.Name = "labelSportClub";
            this.labelSportClub.Size = new System.Drawing.Size(52, 13);
            this.labelSportClub.TabIndex = 8;
            this.labelSportClub.Text = "Команда";
            // 
            // labelPictue
            // 
            this.labelPictue.AutoSize = true;
            this.labelPictue.Location = new System.Drawing.Point(25, 255);
            this.labelPictue.Name = "labelPictue";
            this.labelPictue.Size = new System.Drawing.Size(72, 13);
            this.labelPictue.TabIndex = 9;
            this.labelPictue.Text = "Фотография";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sportDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsmanBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageSportsman.ResumeLayout(false);
            this.tabPageSportsman.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSportsman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorSportsman)).EndInit();
            this.bindingNavigatorSportsman.ResumeLayout(false);
            this.bindingNavigatorSportsman.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPageSportClub.ResumeLayout(false);
            this.tabPageSportClub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSportClub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportclubBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorSportClub)).EndInit();
            this.bindingNavigatorSportClub.ResumeLayout(false);
            this.bindingNavigatorSportClub.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource sportDBDataSetBindingSource;
        private SportDBDataSet sportDBDataSet;
        private SportDBDataSetTableAdapters.sportsmanTableAdapter sportsmanTableAdapter;
        private System.Windows.Forms.BindingSource sportsmanBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem бДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSportsman;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabPage tabPageSportClub;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewSportsman;
        private System.Windows.Forms.BindingNavigator bindingNavigatorSportsman;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItemSportsman;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItemSportsman;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItemSportsman;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItemSportsman;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItemSportsman;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSportsmanSeparator1;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItemSportsman;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSportsmanSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItemSportsman;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItemSportsman;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSportsmanSeparator3;
        private System.Windows.Forms.DataGridView dataGridViewSportClub;
        private System.Windows.Forms.BindingNavigator bindingNavigatorSportClub;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItemSportClub;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItemSportClub;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItemSportClub;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItemSportClub;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItemSportClub;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSportClubSeparator1;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItemSportClub;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSportClubSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItemSportClub;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItemSportClub;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSportClubSeparator3;
        private System.Windows.Forms.BindingSource sportclubBindingSource;
        private SportDBDataSetTableAdapters.sport_clubTableAdapter sport_clubTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveSportsman;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveSportClub;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.ToolStripMenuItem loadTableSportsmanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadTableSportClubToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middlenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sportclubidDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.ComboBox comboBoxSportClub;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelPictue;
        private System.Windows.Forms.Label labelSportClub;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelMiddleName;
    }
}

