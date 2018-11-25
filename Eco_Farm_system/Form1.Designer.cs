namespace Eco_Farm_system
{
    partial class Form1
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
            this.ecoFarmDataSet = new Eco_Farm_system.EcoFarmDataSet();
            this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.positionTableAdapter = new Eco_Farm_system.EcoFarmDataSetTableAdapters.PositionTableAdapter();
            this.tableAdapterManager = new Eco_Farm_system.EcoFarmDataSetTableAdapters.TableAdapterManager();
            this.employeesTableAdapter = new Eco_Farm_system.EcoFarmDataSetTableAdapters.EmployeesTableAdapter();
            this.positionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.positionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ConnectBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.DisconnectBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SortPos = new System.Windows.Forms.ToolStripButton();
            this.SortPosBy = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.FilterPos = new System.Windows.Forms.ToolStripButton();
            this.FilterPosBy = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.FilterField = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.SearchPosBtn = new System.Windows.Forms.ToolStripButton();
            this.SearchPosBy = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.SearchPosField = new System.Windows.Forms.ToolStripComboBox();
            this.positionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchEmpField = new System.Windows.Forms.ComboBox();
            this.SearchEmpBy = new System.Windows.Forms.TextBox();
            this.SearchEmp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FilterEmpField = new System.Windows.Forms.ComboBox();
            this.FilterEmpBy = new System.Windows.Forms.TextBox();
            this.FilterEmp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SortEmpBy = new System.Windows.Forms.ComboBox();
            this.SortEmp = new System.Windows.Forms.Button();
            this.LastBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.PreviousBtn = new System.Windows.Forms.Button();
            this.FirstBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BirthDateTXT = new System.Windows.Forms.TextBox();
            this.PassportSeriesTXT = new System.Windows.Forms.TextBox();
            this.PassportNumTXT = new System.Windows.Forms.TextBox();
            this.PositionCodeTXT = new System.Windows.Forms.TextBox();
            this.AdressTXT = new System.Windows.Forms.TextBox();
            this.PhoneTXT = new System.Windows.Forms.TextBox();
            this.NameTXT = new System.Windows.Forms.TextBox();
            this.EmpNumbTXT = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SaveEmp = new System.Windows.Forms.Button();
            this.DeleteEmp = new System.Windows.Forms.Button();
            this.ClrFilter = new System.Windows.Forms.Button();
            this.Col_Pos = new System.Windows.Forms.Button();
            this.Col_Emp = new System.Windows.Forms.Button();
            this.Col_Field_Pos = new System.Windows.Forms.ComboBox();
            this.Col_Field_Emp = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ecoFarmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingNavigator)).BeginInit();
            this.positionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ecoFarmDataSet
            // 
            this.ecoFarmDataSet.DataSetName = "EcoFarmDataSet";
            this.ecoFarmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // positionBindingSource
            // 
            this.positionBindingSource.DataMember = "Position";
            this.positionBindingSource.DataSource = this.ecoFarmDataSet;
            // 
            // positionTableAdapter
            // 
            this.positionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.PositionTableAdapter = this.positionTableAdapter;
            this.tableAdapterManager.UpdateOrder = Eco_Farm_system.EcoFarmDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // positionBindingNavigator
            // 
            this.positionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.positionBindingNavigator.BindingSource = this.positionBindingSource;
            this.positionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.positionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.positionBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.positionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.positionBindingNavigatorSaveItem,
            this.ConnectBtn,
            this.toolStripLabel1,
            this.DisconnectBtn,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.SortPos,
            this.SortPosBy,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.FilterPos,
            this.FilterPosBy,
            this.toolStripLabel3,
            this.FilterField,
            this.toolStripSeparator5,
            this.toolStripSeparator6,
            this.SearchPosBtn,
            this.SearchPosBy,
            this.toolStripLabel2,
            this.SearchPosField});
            this.positionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.positionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.positionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.positionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.positionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.positionBindingNavigator.Name = "positionBindingNavigator";
            this.positionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.positionBindingNavigator.Size = new System.Drawing.Size(1526, 28);
            this.positionBindingNavigator.TabIndex = 0;
            this.positionBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorAddNewItem.Text = "+";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 25);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorDeleteItem.Text = "X";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorMoveFirstItem.ImageTransparentColor = System.Drawing.Color.Red;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(27, 25);
            this.bindingNavigatorMoveFirstItem.Text = "|<";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMovePreviousItem.Text = "<";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 28);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMoveNextItem.Text = ">";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(27, 25);
            this.bindingNavigatorMoveLastItem.Text = ">|";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // positionBindingNavigatorSaveItem
            // 
            this.positionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.positionBindingNavigatorSaveItem.Name = "positionBindingNavigatorSaveItem";
            this.positionBindingNavigatorSaveItem.Size = new System.Drawing.Size(44, 25);
            this.positionBindingNavigatorSaveItem.Text = "Save";
            this.positionBindingNavigatorSaveItem.Click += new System.EventHandler(this.positionBindingNavigatorSaveItem_Click);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ConnectBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ConnectBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(67, 25);
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.Yellow;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(15, 25);
            this.toolStripLabel1.Text = "/";
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.BackColor = System.Drawing.Color.Red;
            this.DisconnectBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DisconnectBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(86, 25);
            this.DisconnectBtn.Text = "Disconnect";
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // SortPos
            // 
            this.SortPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SortPos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SortPos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SortPos.Name = "SortPos";
            this.SortPos.Size = new System.Drawing.Size(63, 25);
            this.SortPos.Text = "Sort by:";
            this.SortPos.Click += new System.EventHandler(this.SortPos_Click);
            // 
            // SortPosBy
            // 
            this.SortPosBy.Items.AddRange(new object[] {
            "Position_Code",
            "Position",
            "Department_Code",
            "Activity"});
            this.SortPosBy.Name = "SortPosBy";
            this.SortPosBy.Size = new System.Drawing.Size(121, 28);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // FilterPos
            // 
            this.FilterPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FilterPos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FilterPos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FilterPos.Name = "FilterPos";
            this.FilterPos.Size = new System.Drawing.Size(69, 25);
            this.FilterPos.Text = "Filter by:";
            this.FilterPos.Click += new System.EventHandler(this.FilterPos_Click);
            // 
            // FilterPosBy
            // 
            this.FilterPosBy.Name = "FilterPosBy";
            this.FilterPosBy.Size = new System.Drawing.Size(100, 28);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(21, 25);
            this.toolStripLabel3.Text = "in";
            // 
            // FilterField
            // 
            this.FilterField.Items.AddRange(new object[] {
            "Position_Code",
            "Position",
            "Department_Code",
            "Activity"});
            this.FilterField.Name = "FilterField";
            this.FilterField.Size = new System.Drawing.Size(121, 28);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 28);
            // 
            // SearchPosBtn
            // 
            this.SearchPosBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SearchPosBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SearchPosBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchPosBtn.Name = "SearchPosBtn";
            this.SearchPosBtn.Size = new System.Drawing.Size(83, 25);
            this.SearchPosBtn.Text = "Search for:";
            this.SearchPosBtn.Click += new System.EventHandler(this.SearchPosBtn_Click);
            // 
            // SearchPosBy
            // 
            this.SearchPosBy.Name = "SearchPosBy";
            this.SearchPosBy.Size = new System.Drawing.Size(100, 28);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(21, 25);
            this.toolStripLabel2.Text = "in";
            // 
            // SearchPosField
            // 
            this.SearchPosField.Items.AddRange(new object[] {
            "Position_Code",
            "Position",
            "Department_Code",
            "Activity"});
            this.SearchPosField.Name = "SearchPosField";
            this.SearchPosField.Size = new System.Drawing.Size(121, 28);
            // 
            // positionDataGridView
            // 
            this.positionDataGridView.AutoGenerateColumns = false;
            this.positionDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.positionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.positionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.positionDataGridView.DataSource = this.positionBindingSource;
            this.positionDataGridView.Location = new System.Drawing.Point(12, 31);
            this.positionDataGridView.MultiSelect = false;
            this.positionDataGridView.Name = "positionDataGridView";
            this.positionDataGridView.RowTemplate.Height = 24;
            this.positionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.positionDataGridView.Size = new System.Drawing.Size(1367, 209);
            this.positionDataGridView.TabIndex = 1;
            this.positionDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.positionDataGridView_CellContentClick);
            this.positionDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.positionDataGridView_CellMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Position_Code";
            this.dataGridViewTextBoxColumn1.HeaderText = "Position_Code";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Position";
            this.dataGridViewTextBoxColumn2.HeaderText = "Position";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Department_Code";
            this.dataGridViewTextBoxColumn3.HeaderText = "Department_Code";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Activity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Activity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.ecoFarmDataSet;
            // 
            // employeesDataGridView
            // 
            this.employeesDataGridView.AutoGenerateColumns = false;
            this.employeesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.employeesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.employeesDataGridView.DataSource = this.employeesBindingSource;
            this.employeesDataGridView.Location = new System.Drawing.Point(12, 246);
            this.employeesDataGridView.MultiSelect = false;
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.RowTemplate.Height = 24;
            this.employeesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeesDataGridView.Size = new System.Drawing.Size(1367, 384);
            this.employeesDataGridView.TabIndex = 2;
            this.employeesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeesDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Employee_Number";
            this.dataGridViewTextBoxColumn5.HeaderText = "Employee_Number";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Full_Name";
            this.dataGridViewTextBoxColumn6.HeaderText = "Full_Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Phone_Number";
            this.dataGridViewTextBoxColumn7.HeaderText = "Phone_Number";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Adress";
            this.dataGridViewTextBoxColumn8.HeaderText = "Adress";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Position_Code";
            this.dataGridViewTextBoxColumn9.HeaderText = "Position_Code";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Passport_Number";
            this.dataGridViewTextBoxColumn10.HeaderText = "Passport_Number";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Passport_Series";
            this.dataGridViewTextBoxColumn11.HeaderText = "Passport_Series";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Birth_Date";
            this.dataGridViewTextBoxColumn12.HeaderText = "Birth_Date";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.SearchEmpField);
            this.groupBox1.Controls.Add(this.SearchEmpBy);
            this.groupBox1.Controls.Add(this.SearchEmp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FilterEmpField);
            this.groupBox1.Controls.Add(this.FilterEmpBy);
            this.groupBox1.Controls.Add(this.FilterEmp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SortEmpBy);
            this.groupBox1.Controls.Add(this.SortEmp);
            this.groupBox1.Controls.Add(this.LastBtn);
            this.groupBox1.Controls.Add(this.NextBtn);
            this.groupBox1.Controls.Add(this.PreviousBtn);
            this.groupBox1.Controls.Add(this.FirstBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 636);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1093, 46);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(906, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "in";
            // 
            // SearchEmpField
            // 
            this.SearchEmpField.FormattingEnabled = true;
            this.SearchEmpField.Items.AddRange(new object[] {
            "Employee_Number",
            "Full_Name",
            "Phone_Number",
            "Adress",
            "Position_Code",
            "Passport_Number",
            "Passport_Series",
            "Birth_Date"});
            this.SearchEmpField.Location = new System.Drawing.Point(931, 15);
            this.SearchEmpField.Name = "SearchEmpField";
            this.SearchEmpField.Size = new System.Drawing.Size(121, 24);
            this.SearchEmpField.TabIndex = 16;
            // 
            // SearchEmpBy
            // 
            this.SearchEmpBy.Location = new System.Drawing.Point(802, 17);
            this.SearchEmpBy.Name = "SearchEmpBy";
            this.SearchEmpBy.Size = new System.Drawing.Size(100, 22);
            this.SearchEmpBy.TabIndex = 15;
            // 
            // SearchEmp
            // 
            this.SearchEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SearchEmp.Location = new System.Drawing.Point(721, 12);
            this.SearchEmp.Name = "SearchEmp";
            this.SearchEmp.Size = new System.Drawing.Size(75, 32);
            this.SearchEmp.TabIndex = 14;
            this.SearchEmp.Text = "Search for:";
            this.SearchEmp.UseVisualStyleBackColor = false;
            this.SearchEmp.Click += new System.EventHandler(this.SearchEmp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(701, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "||";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(549, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "in";
            // 
            // FilterEmpField
            // 
            this.FilterEmpField.FormattingEnabled = true;
            this.FilterEmpField.Items.AddRange(new object[] {
            "Employee_Number",
            "Full_Name",
            "Phone_Number",
            "Adress",
            "Position_Code",
            "Passport_Number",
            "Passport_Series",
            "Birth_Date"});
            this.FilterEmpField.Location = new System.Drawing.Point(574, 17);
            this.FilterEmpField.Name = "FilterEmpField";
            this.FilterEmpField.Size = new System.Drawing.Size(121, 24);
            this.FilterEmpField.TabIndex = 11;
            // 
            // FilterEmpBy
            // 
            this.FilterEmpBy.Location = new System.Drawing.Point(443, 18);
            this.FilterEmpBy.Name = "FilterEmpBy";
            this.FilterEmpBy.Size = new System.Drawing.Size(100, 22);
            this.FilterEmpBy.TabIndex = 10;
            // 
            // FilterEmp
            // 
            this.FilterEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FilterEmp.Location = new System.Drawing.Point(362, 13);
            this.FilterEmp.Name = "FilterEmp";
            this.FilterEmp.Size = new System.Drawing.Size(75, 33);
            this.FilterEmp.TabIndex = 9;
            this.FilterEmp.Text = "Filter by:";
            this.FilterEmp.UseVisualStyleBackColor = false;
            this.FilterEmp.Click += new System.EventHandler(this.FilterEmp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "||";
            // 
            // SortEmpBy
            // 
            this.SortEmpBy.FormattingEnabled = true;
            this.SortEmpBy.Items.AddRange(new object[] {
            "Employee_Number",
            "Full_Name",
            "Phone_Number",
            "Adress",
            "Position_Code",
            "Passport_Number",
            "Passport_Series",
            "Birth_Date"});
            this.SortEmpBy.Location = new System.Drawing.Point(215, 17);
            this.SortEmpBy.Name = "SortEmpBy";
            this.SortEmpBy.Size = new System.Drawing.Size(121, 24);
            this.SortEmpBy.TabIndex = 6;
            // 
            // SortEmp
            // 
            this.SortEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SortEmp.Location = new System.Drawing.Point(134, 13);
            this.SortEmp.Name = "SortEmp";
            this.SortEmp.Size = new System.Drawing.Size(75, 31);
            this.SortEmp.TabIndex = 5;
            this.SortEmp.Text = "Sort by:";
            this.SortEmp.UseVisualStyleBackColor = false;
            this.SortEmp.Click += new System.EventHandler(this.SortEmp_Click);
            // 
            // LastBtn
            // 
            this.LastBtn.Location = new System.Drawing.Point(97, 17);
            this.LastBtn.Name = "LastBtn";
            this.LastBtn.Size = new System.Drawing.Size(33, 24);
            this.LastBtn.TabIndex = 3;
            this.LastBtn.Text = ">|";
            this.LastBtn.UseVisualStyleBackColor = true;
            this.LastBtn.Click += new System.EventHandler(this.LastBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(67, 17);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(24, 24);
            this.NextBtn.TabIndex = 2;
            this.NextBtn.Text = ">";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // PreviousBtn
            // 
            this.PreviousBtn.Location = new System.Drawing.Point(39, 16);
            this.PreviousBtn.Name = "PreviousBtn";
            this.PreviousBtn.Size = new System.Drawing.Size(22, 24);
            this.PreviousBtn.TabIndex = 1;
            this.PreviousBtn.Text = "<";
            this.PreviousBtn.UseVisualStyleBackColor = true;
            this.PreviousBtn.Click += new System.EventHandler(this.PreviousBtn_Click);
            // 
            // FirstBtn
            // 
            this.FirstBtn.Location = new System.Drawing.Point(0, 16);
            this.FirstBtn.Name = "FirstBtn";
            this.FirstBtn.Size = new System.Drawing.Size(33, 23);
            this.FirstBtn.TabIndex = 0;
            this.FirstBtn.Text = "|<";
            this.FirstBtn.UseVisualStyleBackColor = true;
            this.FirstBtn.Click += new System.EventHandler(this.FirstBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Employee number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Full name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BirthDateTXT);
            this.groupBox2.Controls.Add(this.PassportSeriesTXT);
            this.groupBox2.Controls.Add(this.PassportNumTXT);
            this.groupBox2.Controls.Add(this.PositionCodeTXT);
            this.groupBox2.Controls.Add(this.AdressTXT);
            this.groupBox2.Controls.Add(this.PhoneTXT);
            this.groupBox2.Controls.Add(this.NameTXT);
            this.groupBox2.Controls.Add(this.EmpNumbTXT);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(1518, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 280);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employees";
            this.groupBox2.Visible = false;
            // 
            // BirthDateTXT
            // 
            this.BirthDateTXT.Location = new System.Drawing.Point(134, 241);
            this.BirthDateTXT.Name = "BirthDateTXT";
            this.BirthDateTXT.Size = new System.Drawing.Size(215, 22);
            this.BirthDateTXT.TabIndex = 21;
            // 
            // PassportSeriesTXT
            // 
            this.PassportSeriesTXT.Location = new System.Drawing.Point(134, 211);
            this.PassportSeriesTXT.Name = "PassportSeriesTXT";
            this.PassportSeriesTXT.Size = new System.Drawing.Size(215, 22);
            this.PassportSeriesTXT.TabIndex = 20;
            // 
            // PassportNumTXT
            // 
            this.PassportNumTXT.Location = new System.Drawing.Point(134, 183);
            this.PassportNumTXT.Name = "PassportNumTXT";
            this.PassportNumTXT.Size = new System.Drawing.Size(215, 22);
            this.PassportNumTXT.TabIndex = 19;
            // 
            // PositionCodeTXT
            // 
            this.PositionCodeTXT.Location = new System.Drawing.Point(134, 154);
            this.PositionCodeTXT.Name = "PositionCodeTXT";
            this.PositionCodeTXT.Size = new System.Drawing.Size(215, 22);
            this.PositionCodeTXT.TabIndex = 18;
            // 
            // AdressTXT
            // 
            this.AdressTXT.Location = new System.Drawing.Point(134, 122);
            this.AdressTXT.Name = "AdressTXT";
            this.AdressTXT.Size = new System.Drawing.Size(215, 22);
            this.AdressTXT.TabIndex = 17;
            // 
            // PhoneTXT
            // 
            this.PhoneTXT.Location = new System.Drawing.Point(134, 92);
            this.PhoneTXT.Name = "PhoneTXT";
            this.PhoneTXT.Size = new System.Drawing.Size(215, 22);
            this.PhoneTXT.TabIndex = 16;
            // 
            // NameTXT
            // 
            this.NameTXT.Location = new System.Drawing.Point(134, 62);
            this.NameTXT.Name = "NameTXT";
            this.NameTXT.Size = new System.Drawing.Size(215, 22);
            this.NameTXT.TabIndex = 15;
            // 
            // EmpNumbTXT
            // 
            this.EmpNumbTXT.Location = new System.Drawing.Point(134, 30);
            this.EmpNumbTXT.Name = "EmpNumbTXT";
            this.EmpNumbTXT.Size = new System.Drawing.Size(215, 22);
            this.EmpNumbTXT.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 244);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "Birth date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Passport series";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Passport number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Position code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Adress";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Phone number";
            // 
            // SaveEmp
            // 
            this.SaveEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SaveEmp.Location = new System.Drawing.Point(1275, 636);
            this.SaveEmp.Name = "SaveEmp";
            this.SaveEmp.Size = new System.Drawing.Size(78, 46);
            this.SaveEmp.TabIndex = 24;
            this.SaveEmp.Text = "Save";
            this.SaveEmp.UseVisualStyleBackColor = false;
            this.SaveEmp.Click += new System.EventHandler(this.SaveEmp_Click);
            // 
            // DeleteEmp
            // 
            this.DeleteEmp.BackColor = System.Drawing.Color.Red;
            this.DeleteEmp.FlatAppearance.BorderSize = 0;
            this.DeleteEmp.Location = new System.Drawing.Point(1171, 636);
            this.DeleteEmp.Name = "DeleteEmp";
            this.DeleteEmp.Size = new System.Drawing.Size(75, 46);
            this.DeleteEmp.TabIndex = 23;
            this.DeleteEmp.Text = "Delete";
            this.DeleteEmp.UseVisualStyleBackColor = false;
            this.DeleteEmp.Click += new System.EventHandler(this.DeleteEmp_Click);
            // 
            // ClrFilter
            // 
            this.ClrFilter.BackColor = System.Drawing.Color.Yellow;
            this.ClrFilter.Location = new System.Drawing.Point(1407, 206);
            this.ClrFilter.Name = "ClrFilter";
            this.ClrFilter.Size = new System.Drawing.Size(81, 79);
            this.ClrFilter.TabIndex = 25;
            this.ClrFilter.Text = "Clear Filter";
            this.ClrFilter.UseVisualStyleBackColor = false;
            this.ClrFilter.Click += new System.EventHandler(this.ClrFilter_Click);
            // 
            // Col_Pos
            // 
            this.Col_Pos.Location = new System.Drawing.Point(1402, 31);
            this.Col_Pos.Name = "Col_Pos";
            this.Col_Pos.Size = new System.Drawing.Size(86, 54);
            this.Col_Pos.TabIndex = 26;
            this.Col_Pos.Text = "Change Colour";
            this.Col_Pos.UseVisualStyleBackColor = true;
            this.Col_Pos.Click += new System.EventHandler(this.Col_Pos_Click);
            // 
            // Col_Emp
            // 
            this.Col_Emp.Location = new System.Drawing.Point(1402, 351);
            this.Col_Emp.Name = "Col_Emp";
            this.Col_Emp.Size = new System.Drawing.Size(86, 54);
            this.Col_Emp.TabIndex = 27;
            this.Col_Emp.Text = "Change Colour";
            this.Col_Emp.UseVisualStyleBackColor = true;
            this.Col_Emp.Click += new System.EventHandler(this.Col_Emp_Click);
            // 
            // Col_Field_Pos
            // 
            this.Col_Field_Pos.FormattingEnabled = true;
            this.Col_Field_Pos.Items.AddRange(new object[] {
            "Position_Code",
            "Position",
            "Department_Code",
            "Activity"});
            this.Col_Field_Pos.Location = new System.Drawing.Point(1385, 104);
            this.Col_Field_Pos.Name = "Col_Field_Pos";
            this.Col_Field_Pos.Size = new System.Drawing.Size(121, 24);
            this.Col_Field_Pos.TabIndex = 28;
            // 
            // Col_Field_Emp
            // 
            this.Col_Field_Emp.FormattingEnabled = true;
            this.Col_Field_Emp.Items.AddRange(new object[] {
            "Employee_Number",
            "Full_Name",
            "Phone_Number",
            "Adress",
            "Position_Code",
            "Passport_Number",
            "Passport_Series",
            "Birth_Date"});
            this.Col_Field_Emp.Location = new System.Drawing.Point(1385, 443);
            this.Col_Field_Emp.Name = "Col_Field_Emp";
            this.Col_Field_Emp.Size = new System.Drawing.Size(121, 24);
            this.Col_Field_Emp.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1526, 683);
            this.Controls.Add(this.Col_Field_Emp);
            this.Controls.Add(this.Col_Field_Pos);
            this.Controls.Add(this.Col_Emp);
            this.Controls.Add(this.Col_Pos);
            this.Controls.Add(this.ClrFilter);
            this.Controls.Add(this.SaveEmp);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DeleteEmp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.employeesDataGridView);
            this.Controls.Add(this.positionDataGridView);
            this.Controls.Add(this.positionBindingNavigator);
            this.Name = "Form1";
            this.Text = "Eco Farm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ecoFarmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingNavigator)).EndInit();
            this.positionBindingNavigator.ResumeLayout(false);
            this.positionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private EcoFarmDataSet ecoFarmDataSet;
        private System.Windows.Forms.BindingSource positionBindingSource;
        private EcoFarmDataSetTableAdapters.PositionTableAdapter positionTableAdapter;
        private EcoFarmDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator positionBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton positionBindingNavigatorSaveItem;
        private EcoFarmDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridView positionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private System.Windows.Forms.DataGridView employeesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.ToolStripButton ConnectBtn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton DisconnectBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button LastBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button PreviousBtn;
        private System.Windows.Forms.Button FirstBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton SortPos;
        private System.Windows.Forms.ToolStripComboBox SortPosBy;
        private System.Windows.Forms.ToolStripButton FilterPos;
        private System.Windows.Forms.ToolStripTextBox FilterPosBy;
        private System.Windows.Forms.ToolStripComboBox FilterField;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton SearchPosBtn;
        private System.Windows.Forms.ToolStripTextBox SearchPosBy;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox SearchPosField;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ComboBox SortEmpBy;
        private System.Windows.Forms.Button SortEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FilterEmpField;
        private System.Windows.Forms.TextBox FilterEmpBy;
        private System.Windows.Forms.Button FilterEmp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SearchEmpField;
        private System.Windows.Forms.TextBox SearchEmpBy;
        private System.Windows.Forms.Button SearchEmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SaveEmp;
        private System.Windows.Forms.Button DeleteEmp;
        private System.Windows.Forms.TextBox BirthDateTXT;
        private System.Windows.Forms.TextBox PassportSeriesTXT;
        private System.Windows.Forms.TextBox PassportNumTXT;
        private System.Windows.Forms.TextBox PositionCodeTXT;
        private System.Windows.Forms.TextBox AdressTXT;
        private System.Windows.Forms.TextBox PhoneTXT;
        private System.Windows.Forms.TextBox NameTXT;
        private System.Windows.Forms.TextBox EmpNumbTXT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ClrFilter;
        private System.Windows.Forms.Button Col_Pos;
        private System.Windows.Forms.Button Col_Emp;
        private System.Windows.Forms.ComboBox Col_Field_Pos;
        private System.Windows.Forms.ComboBox Col_Field_Emp;
    }
}

