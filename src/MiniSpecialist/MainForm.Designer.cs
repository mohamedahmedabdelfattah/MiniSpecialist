using System.Windows.Forms;

namespace MiniSpecialist
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.errorEmpty = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabStock = new System.Windows.Forms.TabPage();
            this.buttonNewStock = new System.Windows.Forms.Button();
            this.buttonDeleteAllStock = new System.Windows.Forms.Button();
            this.buttonSaveStock = new System.Windows.Forms.Button();
            this.labelItemsStock = new System.Windows.Forms.Label();
            this.labelNameStock = new System.Windows.Forms.Label();
            this.buttonUpdateStock = new System.Windows.Forms.Button();
            this.labelPriceStock = new System.Windows.Forms.Label();
            this.textNameStock = new System.Windows.Forms.TextBox();
            this.comboItemsStock = new System.Windows.Forms.ComboBox();
            this.textPriceStock = new System.Windows.Forms.TextBox();
            this.buttonDeleteStock = new System.Windows.Forms.Button();
            this.labelItemIDStock = new System.Windows.Forms.Label();
            this.textItemIDStock = new System.Windows.Forms.TextBox();
            this.tabPurchase = new System.Windows.Forms.TabPage();
            this.buttonDeleteAllPurchase = new System.Windows.Forms.Button();
            this.labelSearchMovesPurchase = new System.Windows.Forms.Label();
            this.comboSearchMovesPurchase = new System.Windows.Forms.ComboBox();
            this.buttonUpdatePurchase = new System.Windows.Forms.Button();
            this.buttonNewPurchase = new System.Windows.Forms.Button();
            this.buttonDeletePurchase = new System.Windows.Forms.Button();
            this.gridPurchase = new System.Windows.Forms.DataGridView();
            this.iDPurchaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIDPurchaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNamePurchaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePurchaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityPurchaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPurchaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moveIDPurchaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moveTypePurchaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moveDatePurchaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MiniSpecialistDataSet = new MiniSpecialist.MiniSpecialistDataSet();
            this.labelMoveIDPurchase = new System.Windows.Forms.Label();
            this.textMoveIDPurchase = new System.Windows.Forms.TextBox();
            this.comboTypePurchase = new System.Windows.Forms.ComboBox();
            this.labelTypePurchase = new System.Windows.Forms.Label();
            this.buttonSavePurchase = new System.Windows.Forms.Button();
            this.textTotalPurchase = new System.Windows.Forms.TextBox();
            this.labelTotalPurchase = new System.Windows.Forms.Label();
            this.labelQuantityPurchase = new System.Windows.Forms.Label();
            this.labelPricePurchase = new System.Windows.Forms.Label();
            this.textQuantityPurchase = new System.Windows.Forms.TextBox();
            this.textPricePurchase = new System.Windows.Forms.TextBox();
            this.labelItemPurchase = new System.Windows.Forms.Label();
            this.comboItemsPurchase = new System.Windows.Forms.ComboBox();
            this.labelDatePurchase = new System.Windows.Forms.Label();
            this.labelItemIDPurchase = new System.Windows.Forms.Label();
            this.datePurchase = new System.Windows.Forms.DateTimePicker();
            this.textItemIDPurchase = new System.Windows.Forms.TextBox();
            this.tabSales = new System.Windows.Forms.TabPage();
            this.buttonDeleteAllSales = new System.Windows.Forms.Button();
            this.labelSearchMovesSales = new System.Windows.Forms.Label();
            this.comboSearchMovesSales = new System.Windows.Forms.ComboBox();
            this.buttonUpdateSales = new System.Windows.Forms.Button();
            this.buttonNewSales = new System.Windows.Forms.Button();
            this.buttonDeleteSales = new System.Windows.Forms.Button();
            this.gridSales = new System.Windows.Forms.DataGridView();
            this.iDSalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIDSalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameSalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceSalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitySalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moveIDSalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moveTypeSalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moveDateSalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeOutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelMoveIDSales = new System.Windows.Forms.Label();
            this.textMoveIDSales = new System.Windows.Forms.TextBox();
            this.comboTypeSales = new System.Windows.Forms.ComboBox();
            this.labelTypeSales = new System.Windows.Forms.Label();
            this.buttonSaveSales = new System.Windows.Forms.Button();
            this.textTotalSales = new System.Windows.Forms.TextBox();
            this.labelTotalSales = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelPriceSales = new System.Windows.Forms.Label();
            this.textQuantitySales = new System.Windows.Forms.TextBox();
            this.textPriceSales = new System.Windows.Forms.TextBox();
            this.labelItemsSales = new System.Windows.Forms.Label();
            this.comboItemsSales = new System.Windows.Forms.ComboBox();
            this.labelDateSales = new System.Windows.Forms.Label();
            this.labelItemIDSales = new System.Windows.Forms.Label();
            this.dateSales = new System.Windows.Forms.DateTimePicker();
            this.textItemIDSales = new System.Windows.Forms.TextBox();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.radioSearchByKeyword = new System.Windows.Forms.RadioButton();
            this.radioSearchByMovesDate = new System.Windows.Forms.RadioButton();
            this.labelSearchDateTo = new System.Windows.Forms.Label();
            this.dateSearchMovesTo = new System.Windows.Forms.DateTimePicker();
            this.dateSearchMovesFrom = new System.Windows.Forms.DateTimePicker();
            this.labelSearchDateFrom = new System.Windows.Forms.Label();
            this.labelSearchBy = new System.Windows.Forms.Label();
            this.comboSearchColumns = new System.Windows.Forms.ComboBox();
            this.labelSearchIn = new System.Windows.Forms.Label();
            this.comboSearchTables = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.gridSearch = new System.Windows.Forms.DataGridView();
            this.textSearchKeyword = new System.Windows.Forms.TextBox();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.comboReports = new System.Windows.Forms.ComboBox();
            this.gridReports = new System.Windows.Forms.DataGridView();
            this.tabEmployees = new System.Windows.Forms.TabPage();
            this.textNameEmployee = new System.Windows.Forms.TextBox();
            this.buttonDeleteAllEmployee = new System.Windows.Forms.Button();
            this.buttonUpdateEmployee = new System.Windows.Forms.Button();
            this.buttonNewEmployee = new System.Windows.Forms.Button();
            this.buttonDeleteEmployee = new System.Windows.Forms.Button();
            this.gridEmployees = new System.Windows.Forms.DataGridView();
            this.iDEmployeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameEmployeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressEmployeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneEmployeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailEmployeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateEmployeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSNEmployeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelEmployeeID = new System.Windows.Forms.Label();
            this.textEmployeeIDEmployee = new System.Windows.Forms.TextBox();
            this.buttonSaveEmployee = new System.Windows.Forms.Button();
            this.textSSNEmployee = new System.Windows.Forms.TextBox();
            this.labelEmployeeSSN = new System.Windows.Forms.Label();
            this.labelEmployeePhone = new System.Windows.Forms.Label();
            this.labelEmployeeEmail = new System.Windows.Forms.Label();
            this.textEmailEmployee = new System.Windows.Forms.TextBox();
            this.textPhoneEmployee = new System.Windows.Forms.TextBox();
            this.labelEmployeeName = new System.Windows.Forms.Label();
            this.labelEmployeeBirthDate = new System.Windows.Forms.Label();
            this.labelEmployeeAddress = new System.Windows.Forms.Label();
            this.dateBirthDateEmployee = new System.Windows.Forms.DateTimePicker();
            this.textAddressEmployee = new System.Windows.Forms.TextBox();
            this.tabAttendance = new System.Windows.Forms.TabPage();
            this.gridAttendance = new System.Windows.Forms.DataGridView();
            this.buttonEmplloyeeSignAttendance = new System.Windows.Forms.Button();
            this.labelAttendanceTime = new System.Windows.Forms.Label();
            this.labelEmployeeIDAttendance = new System.Windows.Forms.Label();
            this.labelEmployeeNameAttendance = new System.Windows.Forms.Label();
            this.textEmployeeIDAttendance = new System.Windows.Forms.TextBox();
            this.comboEmployeeNamesAttendance = new System.Windows.Forms.ComboBox();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.miniSpecialistMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.debugMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.dataAtOnceMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAvailableStockMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.logMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.disableDBMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.resetSettingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.restartMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.bg = new System.ComponentModel.BackgroundWorker();
            this.employeesTableAdapter = new MiniSpecialist.MiniSpecialistDataSetTableAdapters.EmployeesTableAdapter();
            this.overviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.overviewTableAdapter = new MiniSpecialist.MiniSpecialistDataSetTableAdapters.OverviewTableAdapter();
            this.store_InTableAdapter = new MiniSpecialist.MiniSpecialistDataSetTableAdapters.Store_InTableAdapter();
            this.store_OutTableAdapter = new MiniSpecialist.MiniSpecialistDataSetTableAdapters.Store_OutTableAdapter();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.buttonPrintReports = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmpty)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabStock.SuspendLayout();
            this.tabPurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeInBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiniSpecialistDataSet)).BeginInit();
            this.tabSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeOutBindingSource)).BeginInit();
            this.tabSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearch)).BeginInit();
            this.tabReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReports)).BeginInit();
            this.tabEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.tabAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAttendance)).BeginInit();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overviewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // errorEmpty
            // 
            this.errorEmpty.ContainerControl = this;
            // 
            // tabMain
            // 
            this.tabMain.BackgroundImage = global::MiniSpecialist.Properties.Resources.zyklus4;
            this.tabMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabMain.Controls.Add(this.tabStock);
            this.tabMain.Controls.Add(this.tabPurchase);
            this.tabMain.Controls.Add(this.tabSales);
            this.tabMain.Controls.Add(this.tabSearch);
            this.tabMain.Controls.Add(this.tabReports);
            this.tabMain.Controls.Add(this.tabEmployees);
            this.tabMain.Controls.Add(this.tabAttendance);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 24);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(856, 479);
            this.tabMain.TabIndex = 0;
            // 
            // tabStock
            // 
            this.tabStock.BackColor = System.Drawing.SystemColors.Highlight;
            this.tabStock.Controls.Add(this.buttonNewStock);
            this.tabStock.Controls.Add(this.buttonDeleteAllStock);
            this.tabStock.Controls.Add(this.buttonSaveStock);
            this.tabStock.Controls.Add(this.labelItemsStock);
            this.tabStock.Controls.Add(this.labelNameStock);
            this.tabStock.Controls.Add(this.buttonUpdateStock);
            this.tabStock.Controls.Add(this.labelPriceStock);
            this.tabStock.Controls.Add(this.textNameStock);
            this.tabStock.Controls.Add(this.comboItemsStock);
            this.tabStock.Controls.Add(this.textPriceStock);
            this.tabStock.Controls.Add(this.buttonDeleteStock);
            this.tabStock.Controls.Add(this.labelItemIDStock);
            this.tabStock.Controls.Add(this.textItemIDStock);
            this.tabStock.Location = new System.Drawing.Point(4, 22);
            this.tabStock.Name = "tabStock";
            this.tabStock.Padding = new System.Windows.Forms.Padding(3);
            this.tabStock.Size = new System.Drawing.Size(848, 453);
            this.tabStock.TabIndex = 0;
            this.tabStock.Text = "Stock";
            this.tabStock.Enter += new System.EventHandler(this.tabStock_Enter);
            // 
            // buttonNewStock
            // 
            this.buttonNewStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNewStock.Location = new System.Drawing.Point(225, 295);
            this.buttonNewStock.Name = "buttonNewStock";
            this.buttonNewStock.Size = new System.Drawing.Size(75, 23);
            this.buttonNewStock.TabIndex = 4;
            this.buttonNewStock.Text = "New";
            this.buttonNewStock.UseVisualStyleBackColor = true;
            this.buttonNewStock.Click += new System.EventHandler(this.buttonNewStock_Click);
            // 
            // buttonDeleteAllStock
            // 
            this.buttonDeleteAllStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteAllStock.Location = new System.Drawing.Point(549, 295);
            this.buttonDeleteAllStock.Name = "buttonDeleteAllStock";
            this.buttonDeleteAllStock.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteAllStock.TabIndex = 6;
            this.buttonDeleteAllStock.Text = "Delete All";
            this.buttonDeleteAllStock.UseVisualStyleBackColor = true;
            this.buttonDeleteAllStock.Click += new System.EventHandler(this.buttonDeleteAllStock_Click);
            // 
            // buttonSaveStock
            // 
            this.buttonSaveStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSaveStock.Location = new System.Drawing.Point(306, 295);
            this.buttonSaveStock.Name = "buttonSaveStock";
            this.buttonSaveStock.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveStock.TabIndex = 2;
            this.buttonSaveStock.Text = "Save";
            this.buttonSaveStock.UseVisualStyleBackColor = true;
            this.buttonSaveStock.Click += new System.EventHandler(this.buttonSaveStock_Click);
            // 
            // labelItemsStock
            // 
            this.labelItemsStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelItemsStock.AutoSize = true;
            this.labelItemsStock.ForeColor = System.Drawing.Color.White;
            this.labelItemsStock.Location = new System.Drawing.Point(286, 137);
            this.labelItemsStock.Name = "labelItemsStock";
            this.labelItemsStock.Size = new System.Drawing.Size(34, 13);
            this.labelItemsStock.TabIndex = 9;
            this.labelItemsStock.Text = "Items";
            // 
            // labelNameStock
            // 
            this.labelNameStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNameStock.AutoSize = true;
            this.labelNameStock.ForeColor = System.Drawing.Color.White;
            this.labelNameStock.Location = new System.Drawing.Point(286, 218);
            this.labelNameStock.Name = "labelNameStock";
            this.labelNameStock.Size = new System.Drawing.Size(34, 13);
            this.labelNameStock.TabIndex = 11;
            this.labelNameStock.Text = "Name";
            // 
            // buttonUpdateStock
            // 
            this.buttonUpdateStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdateStock.Location = new System.Drawing.Point(387, 295);
            this.buttonUpdateStock.Name = "buttonUpdateStock";
            this.buttonUpdateStock.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateStock.TabIndex = 3;
            this.buttonUpdateStock.Text = "Update";
            this.buttonUpdateStock.UseVisualStyleBackColor = true;
            this.buttonUpdateStock.Click += new System.EventHandler(this.buttonUpdateStock_Click);
            // 
            // labelPriceStock
            // 
            this.labelPriceStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPriceStock.AutoSize = true;
            this.labelPriceStock.ForeColor = System.Drawing.Color.White;
            this.labelPriceStock.Location = new System.Drawing.Point(286, 258);
            this.labelPriceStock.Name = "labelPriceStock";
            this.labelPriceStock.Size = new System.Drawing.Size(30, 13);
            this.labelPriceStock.TabIndex = 12;
            this.labelPriceStock.Text = "Price";
            // 
            // textNameStock
            // 
            this.textNameStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textNameStock.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textNameStock.Location = new System.Drawing.Point(360, 215);
            this.textNameStock.MaxLength = 50;
            this.textNameStock.Name = "textNameStock";
            this.textNameStock.Size = new System.Drawing.Size(199, 20);
            this.textNameStock.TabIndex = 0;
            this.textNameStock.TextChanged += new System.EventHandler(this.text_All_Stock_TextChanged);
            this.textNameStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_All_Name_KeyPress);
            // 
            // comboItemsStock
            // 
            this.comboItemsStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboItemsStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboItemsStock.FormattingEnabled = true;
            this.comboItemsStock.Location = new System.Drawing.Point(360, 134);
            this.comboItemsStock.Name = "comboItemsStock";
            this.comboItemsStock.Size = new System.Drawing.Size(200, 21);
            this.comboItemsStock.TabIndex = 7;
            this.comboItemsStock.SelectedIndexChanged += new System.EventHandler(this.comboItems_All_SelectedIndexChanged);
            this.comboItemsStock.TextChanged += new System.EventHandler(this.text_All_Stock_TextChanged);
            // 
            // textPriceStock
            // 
            this.textPriceStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textPriceStock.Location = new System.Drawing.Point(360, 255);
            this.textPriceStock.MaxLength = 10;
            this.textPriceStock.Name = "textPriceStock";
            this.textPriceStock.Size = new System.Drawing.Size(200, 20);
            this.textPriceStock.TabIndex = 1;
            this.textPriceStock.TextChanged += new System.EventHandler(this.text_All_Stock_TextChanged);
            this.textPriceStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_All_Numbers_KeyPress);
            // 
            // buttonDeleteStock
            // 
            this.buttonDeleteStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteStock.Location = new System.Drawing.Point(468, 295);
            this.buttonDeleteStock.Name = "buttonDeleteStock";
            this.buttonDeleteStock.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteStock.TabIndex = 5;
            this.buttonDeleteStock.Text = "Delete";
            this.buttonDeleteStock.UseVisualStyleBackColor = true;
            this.buttonDeleteStock.Click += new System.EventHandler(this.buttonDeleteStock_Click);
            // 
            // labelItemIDStock
            // 
            this.labelItemIDStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelItemIDStock.AutoSize = true;
            this.labelItemIDStock.ForeColor = System.Drawing.Color.White;
            this.labelItemIDStock.Location = new System.Drawing.Point(286, 178);
            this.labelItemIDStock.Name = "labelItemIDStock";
            this.labelItemIDStock.Size = new System.Drawing.Size(18, 13);
            this.labelItemIDStock.TabIndex = 10;
            this.labelItemIDStock.Text = "ID";
            // 
            // textItemIDStock
            // 
            this.textItemIDStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textItemIDStock.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textItemIDStock.Location = new System.Drawing.Point(360, 175);
            this.textItemIDStock.Name = "textItemIDStock";
            this.textItemIDStock.ReadOnly = true;
            this.textItemIDStock.Size = new System.Drawing.Size(200, 20);
            this.textItemIDStock.TabIndex = 8;
            // 
            // tabPurchase
            // 
            this.tabPurchase.BackColor = System.Drawing.SystemColors.Highlight;
            this.tabPurchase.Controls.Add(this.buttonDeleteAllPurchase);
            this.tabPurchase.Controls.Add(this.labelSearchMovesPurchase);
            this.tabPurchase.Controls.Add(this.comboSearchMovesPurchase);
            this.tabPurchase.Controls.Add(this.buttonUpdatePurchase);
            this.tabPurchase.Controls.Add(this.buttonNewPurchase);
            this.tabPurchase.Controls.Add(this.buttonDeletePurchase);
            this.tabPurchase.Controls.Add(this.gridPurchase);
            this.tabPurchase.Controls.Add(this.labelMoveIDPurchase);
            this.tabPurchase.Controls.Add(this.textMoveIDPurchase);
            this.tabPurchase.Controls.Add(this.comboTypePurchase);
            this.tabPurchase.Controls.Add(this.labelTypePurchase);
            this.tabPurchase.Controls.Add(this.buttonSavePurchase);
            this.tabPurchase.Controls.Add(this.textTotalPurchase);
            this.tabPurchase.Controls.Add(this.labelTotalPurchase);
            this.tabPurchase.Controls.Add(this.labelQuantityPurchase);
            this.tabPurchase.Controls.Add(this.labelPricePurchase);
            this.tabPurchase.Controls.Add(this.textQuantityPurchase);
            this.tabPurchase.Controls.Add(this.textPricePurchase);
            this.tabPurchase.Controls.Add(this.labelItemPurchase);
            this.tabPurchase.Controls.Add(this.comboItemsPurchase);
            this.tabPurchase.Controls.Add(this.labelDatePurchase);
            this.tabPurchase.Controls.Add(this.labelItemIDPurchase);
            this.tabPurchase.Controls.Add(this.datePurchase);
            this.tabPurchase.Controls.Add(this.textItemIDPurchase);
            this.tabPurchase.Location = new System.Drawing.Point(4, 22);
            this.tabPurchase.Name = "tabPurchase";
            this.tabPurchase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPurchase.Size = new System.Drawing.Size(848, 453);
            this.tabPurchase.TabIndex = 1;
            this.tabPurchase.Text = "Purchase";
            this.tabPurchase.Enter += new System.EventHandler(this.tabPurchase_Enter);
            // 
            // buttonDeleteAllPurchase
            // 
            this.buttonDeleteAllPurchase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteAllPurchase.Location = new System.Drawing.Point(550, 141);
            this.buttonDeleteAllPurchase.Name = "buttonDeleteAllPurchase";
            this.buttonDeleteAllPurchase.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteAllPurchase.TabIndex = 63;
            this.buttonDeleteAllPurchase.Text = "Delete All";
            this.buttonDeleteAllPurchase.UseVisualStyleBackColor = true;
            this.buttonDeleteAllPurchase.Click += new System.EventHandler(this.buttonDeleteAllPurchase_Click);
            // 
            // labelSearchMovesPurchase
            // 
            this.labelSearchMovesPurchase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSearchMovesPurchase.AutoSize = true;
            this.labelSearchMovesPurchase.ForeColor = System.Drawing.Color.White;
            this.labelSearchMovesPurchase.Location = new System.Drawing.Point(325, 179);
            this.labelSearchMovesPurchase.Name = "labelSearchMovesPurchase";
            this.labelSearchMovesPurchase.Size = new System.Drawing.Size(61, 13);
            this.labelSearchMovesPurchase.TabIndex = 62;
            this.labelSearchMovesPurchase.Text = "Find Moves";
            // 
            // comboSearchMovesPurchase
            // 
            this.comboSearchMovesPurchase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboSearchMovesPurchase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSearchMovesPurchase.FormattingEnabled = true;
            this.comboSearchMovesPurchase.Items.AddRange(new object[] {
            "All"});
            this.comboSearchMovesPurchase.Location = new System.Drawing.Point(392, 176);
            this.comboSearchMovesPurchase.Name = "comboSearchMovesPurchase";
            this.comboSearchMovesPurchase.Size = new System.Drawing.Size(131, 21);
            this.comboSearchMovesPurchase.TabIndex = 61;
            this.comboSearchMovesPurchase.SelectedIndexChanged += new System.EventHandler(this.comboFindByID_SelectedIndexChanged);
            // 
            // buttonUpdatePurchase
            // 
            this.buttonUpdatePurchase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdatePurchase.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonUpdatePurchase.Location = new System.Drawing.Point(386, 141);
            this.buttonUpdatePurchase.Name = "buttonUpdatePurchase";
            this.buttonUpdatePurchase.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdatePurchase.TabIndex = 60;
            this.buttonUpdatePurchase.Text = "Update";
            this.buttonUpdatePurchase.UseVisualStyleBackColor = true;
            this.buttonUpdatePurchase.Click += new System.EventHandler(this.buttonUpdatePurchase_Click);
            // 
            // buttonNewPurchase
            // 
            this.buttonNewPurchase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNewPurchase.Location = new System.Drawing.Point(224, 141);
            this.buttonNewPurchase.Name = "buttonNewPurchase";
            this.buttonNewPurchase.Size = new System.Drawing.Size(75, 23);
            this.buttonNewPurchase.TabIndex = 59;
            this.buttonNewPurchase.Text = "New";
            this.buttonNewPurchase.UseVisualStyleBackColor = true;
            this.buttonNewPurchase.Click += new System.EventHandler(this.buttonNewPurchase_Click);
            // 
            // buttonDeletePurchase
            // 
            this.buttonDeletePurchase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeletePurchase.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDeletePurchase.Location = new System.Drawing.Point(467, 141);
            this.buttonDeletePurchase.Name = "buttonDeletePurchase";
            this.buttonDeletePurchase.Size = new System.Drawing.Size(75, 23);
            this.buttonDeletePurchase.TabIndex = 57;
            this.buttonDeletePurchase.Text = "Delete";
            this.buttonDeletePurchase.UseVisualStyleBackColor = true;
            this.buttonDeletePurchase.Click += new System.EventHandler(this.buttonDeletePurchase_Click);
            // 
            // gridPurchase
            // 
            this.gridPurchase.AllowUserToAddRows = false;
            this.gridPurchase.AllowUserToDeleteRows = false;
            this.gridPurchase.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridPurchase.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPurchase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridPurchase.AutoGenerateColumns = false;
            this.gridPurchase.BackgroundColor = System.Drawing.Color.LightGray;
            this.gridPurchase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridPurchase.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.gridPurchase.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridPurchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPurchaseDataGridViewTextBoxColumn,
            this.itemIDPurchaseDataGridViewTextBoxColumn,
            this.itemNamePurchaseDataGridViewTextBoxColumn,
            this.pricePurchaseDataGridViewTextBoxColumn,
            this.quantityPurchaseDataGridViewTextBoxColumn,
            this.totalPurchaseDataGridViewTextBoxColumn,
            this.moveIDPurchaseDataGridViewTextBoxColumn,
            this.moveTypePurchaseDataGridViewTextBoxColumn,
            this.moveDatePurchaseDataGridViewTextBoxColumn});
            this.gridPurchase.DataSource = this.storeInBindingSource;
            this.gridPurchase.Location = new System.Drawing.Point(8, 215);
            this.gridPurchase.MultiSelect = false;
            this.gridPurchase.Name = "gridPurchase";
            this.gridPurchase.ReadOnly = true;
            this.gridPurchase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPurchase.Size = new System.Drawing.Size(832, 230);
            this.gridPurchase.TabIndex = 56;
            this.gridPurchase.VirtualMode = true;
            this.gridPurchase.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPurchase_CellClick);
            this.gridPurchase.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_DataBindingComplete);
            // 
            // iDPurchaseDataGridViewTextBoxColumn
            // 
            this.iDPurchaseDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDPurchaseDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDPurchaseDataGridViewTextBoxColumn.Name = "iDPurchaseDataGridViewTextBoxColumn";
            this.iDPurchaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPurchaseDataGridViewTextBoxColumn.Width = 88;
            // 
            // itemIDPurchaseDataGridViewTextBoxColumn
            // 
            this.itemIDPurchaseDataGridViewTextBoxColumn.DataPropertyName = "Item_ID";
            this.itemIDPurchaseDataGridViewTextBoxColumn.HeaderText = "Item ID";
            this.itemIDPurchaseDataGridViewTextBoxColumn.Name = "itemIDPurchaseDataGridViewTextBoxColumn";
            this.itemIDPurchaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemIDPurchaseDataGridViewTextBoxColumn.Width = 87;
            // 
            // itemNamePurchaseDataGridViewTextBoxColumn
            // 
            this.itemNamePurchaseDataGridViewTextBoxColumn.DataPropertyName = "Item_Name";
            this.itemNamePurchaseDataGridViewTextBoxColumn.HeaderText = "Item Name";
            this.itemNamePurchaseDataGridViewTextBoxColumn.Name = "itemNamePurchaseDataGridViewTextBoxColumn";
            this.itemNamePurchaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemNamePurchaseDataGridViewTextBoxColumn.Width = 88;
            // 
            // pricePurchaseDataGridViewTextBoxColumn
            // 
            this.pricePurchaseDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.pricePurchaseDataGridViewTextBoxColumn.HeaderText = "Price";
            this.pricePurchaseDataGridViewTextBoxColumn.Name = "pricePurchaseDataGridViewTextBoxColumn";
            this.pricePurchaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.pricePurchaseDataGridViewTextBoxColumn.Width = 88;
            // 
            // quantityPurchaseDataGridViewTextBoxColumn
            // 
            this.quantityPurchaseDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityPurchaseDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityPurchaseDataGridViewTextBoxColumn.Name = "quantityPurchaseDataGridViewTextBoxColumn";
            this.quantityPurchaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityPurchaseDataGridViewTextBoxColumn.Width = 87;
            // 
            // totalPurchaseDataGridViewTextBoxColumn
            // 
            this.totalPurchaseDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalPurchaseDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalPurchaseDataGridViewTextBoxColumn.Name = "totalPurchaseDataGridViewTextBoxColumn";
            this.totalPurchaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPurchaseDataGridViewTextBoxColumn.Width = 88;
            // 
            // moveIDPurchaseDataGridViewTextBoxColumn
            // 
            this.moveIDPurchaseDataGridViewTextBoxColumn.DataPropertyName = "Move_ID";
            this.moveIDPurchaseDataGridViewTextBoxColumn.HeaderText = "Move ID";
            this.moveIDPurchaseDataGridViewTextBoxColumn.Name = "moveIDPurchaseDataGridViewTextBoxColumn";
            this.moveIDPurchaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.moveIDPurchaseDataGridViewTextBoxColumn.Width = 88;
            // 
            // moveTypePurchaseDataGridViewTextBoxColumn
            // 
            this.moveTypePurchaseDataGridViewTextBoxColumn.DataPropertyName = "Move_Type";
            this.moveTypePurchaseDataGridViewTextBoxColumn.HeaderText = "Move Type";
            this.moveTypePurchaseDataGridViewTextBoxColumn.Name = "moveTypePurchaseDataGridViewTextBoxColumn";
            this.moveTypePurchaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.moveTypePurchaseDataGridViewTextBoxColumn.Width = 87;
            // 
            // moveDatePurchaseDataGridViewTextBoxColumn
            // 
            this.moveDatePurchaseDataGridViewTextBoxColumn.DataPropertyName = "Move_Date";
            this.moveDatePurchaseDataGridViewTextBoxColumn.HeaderText = "Move Date";
            this.moveDatePurchaseDataGridViewTextBoxColumn.Name = "moveDatePurchaseDataGridViewTextBoxColumn";
            this.moveDatePurchaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.moveDatePurchaseDataGridViewTextBoxColumn.Width = 88;
            // 
            // storeInBindingSource
            // 
            this.storeInBindingSource.DataMember = "Store_In";
            this.storeInBindingSource.DataSource = this.MiniSpecialistDataSet;
            // 
            // MiniSpecialistDataSet
            // 
            this.MiniSpecialistDataSet.DataSetName = "MiniSpecialistDataSet";
            this.MiniSpecialistDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelMoveIDPurchase
            // 
            this.labelMoveIDPurchase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMoveIDPurchase.AutoSize = true;
            this.labelMoveIDPurchase.ForeColor = System.Drawing.Color.White;
            this.labelMoveIDPurchase.Location = new System.Drawing.Point(191, 20);
            this.labelMoveIDPurchase.Name = "labelMoveIDPurchase";
            this.labelMoveIDPurchase.Size = new System.Drawing.Size(47, 13);
            this.labelMoveIDPurchase.TabIndex = 36;
            this.labelMoveIDPurchase.Text = "Move ID";
            // 
            // textMoveIDPurchase
            // 
            this.textMoveIDPurchase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textMoveIDPurchase.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textMoveIDPurchase.Location = new System.Drawing.Point(258, 17);
            this.textMoveIDPurchase.Name = "textMoveIDPurchase";
            this.textMoveIDPurchase.ReadOnly = true;
            this.textMoveIDPurchase.Size = new System.Drawing.Size(131, 20);
            this.textMoveIDPurchase.TabIndex = 4;
            // 
            // comboTypePurchase
            // 
            this.comboTypePurchase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboTypePurchase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTypePurchase.FormattingEnabled = true;
            this.comboTypePurchase.Items.AddRange(new object[] {
            "Invoice",
            "Return",
            "Supply"});
            this.comboTypePurchase.Location = new System.Drawing.Point(258, 107);
            this.comboTypePurchase.Name = "comboTypePurchase";
            this.comboTypePurchase.Size = new System.Drawing.Size(131, 21);
            this.comboTypePurchase.TabIndex = 1;
            // 
            // labelTypePurchase
            // 
            this.labelTypePurchase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTypePurchase.AutoSize = true;
            this.labelTypePurchase.ForeColor = System.Drawing.Color.White;
            this.labelTypePurchase.Location = new System.Drawing.Point(191, 110);
            this.labelTypePurchase.Name = "labelTypePurchase";
            this.labelTypePurchase.Size = new System.Drawing.Size(31, 13);
            this.labelTypePurchase.TabIndex = 33;
            this.labelTypePurchase.Text = "Type";
            // 
            // buttonSavePurchase
            // 
            this.buttonSavePurchase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSavePurchase.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSavePurchase.Location = new System.Drawing.Point(305, 141);
            this.buttonSavePurchase.Name = "buttonSavePurchase";
            this.buttonSavePurchase.Size = new System.Drawing.Size(75, 23);
            this.buttonSavePurchase.TabIndex = 3;
            this.buttonSavePurchase.Text = "Save";
            this.buttonSavePurchase.UseVisualStyleBackColor = true;
            this.buttonSavePurchase.Click += new System.EventHandler(this.buttonSavePurchase_Click);
            // 
            // textTotalPurchase
            // 
            this.textTotalPurchase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textTotalPurchase.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textTotalPurchase.Location = new System.Drawing.Point(526, 107);
            this.textTotalPurchase.Name = "textTotalPurchase";
            this.textTotalPurchase.ReadOnly = true;
            this.textTotalPurchase.Size = new System.Drawing.Size(131, 20);
            this.textTotalPurchase.TabIndex = 7;
            // 
            // labelTotalPurchase
            // 
            this.labelTotalPurchase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTotalPurchase.AutoSize = true;
            this.labelTotalPurchase.ForeColor = System.Drawing.Color.White;
            this.labelTotalPurchase.Location = new System.Drawing.Point(433, 108);
            this.labelTotalPurchase.Name = "labelTotalPurchase";
            this.labelTotalPurchase.Size = new System.Drawing.Size(31, 13);
            this.labelTotalPurchase.TabIndex = 29;
            this.labelTotalPurchase.Text = "Total";
            // 
            // labelQuantityPurchase
            // 
            this.labelQuantityPurchase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelQuantityPurchase.AutoSize = true;
            this.labelQuantityPurchase.ForeColor = System.Drawing.Color.White;
            this.labelQuantityPurchase.Location = new System.Drawing.Point(432, 79);
            this.labelQuantityPurchase.Name = "labelQuantityPurchase";
            this.labelQuantityPurchase.Size = new System.Drawing.Size(49, 13);
            this.labelQuantityPurchase.TabIndex = 28;
            this.labelQuantityPurchase.Text = "Quantity";
            // 
            // labelPricePurchase
            // 
            this.labelPricePurchase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPricePurchase.AutoSize = true;
            this.labelPricePurchase.ForeColor = System.Drawing.Color.White;
            this.labelPricePurchase.Location = new System.Drawing.Point(191, 81);
            this.labelPricePurchase.Name = "labelPricePurchase";
            this.labelPricePurchase.Size = new System.Drawing.Size(30, 13);
            this.labelPricePurchase.TabIndex = 27;
            this.labelPricePurchase.Text = "Price";
            // 
            // textQuantityPurchase
            // 
            this.textQuantityPurchase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textQuantityPurchase.Location = new System.Drawing.Point(526, 78);
            this.textQuantityPurchase.MaxLength = 10;
            this.textQuantityPurchase.Name = "textQuantityPurchase";
            this.textQuantityPurchase.Size = new System.Drawing.Size(131, 20);
            this.textQuantityPurchase.TabIndex = 2;
            this.textQuantityPurchase.TextChanged += new System.EventHandler(this.text_All_Quantity_TextChanged);
            this.textQuantityPurchase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_All_Numbers_KeyPress);
            // 
            // textPricePurchase
            // 
            this.textPricePurchase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textPricePurchase.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textPricePurchase.Location = new System.Drawing.Point(258, 78);
            this.textPricePurchase.Name = "textPricePurchase";
            this.textPricePurchase.ReadOnly = true;
            this.textPricePurchase.Size = new System.Drawing.Size(131, 20);
            this.textPricePurchase.TabIndex = 5;
            // 
            // labelItemPurchase
            // 
            this.labelItemPurchase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelItemPurchase.AutoSize = true;
            this.labelItemPurchase.ForeColor = System.Drawing.Color.White;
            this.labelItemPurchase.Location = new System.Drawing.Point(191, 52);
            this.labelItemPurchase.Name = "labelItemPurchase";
            this.labelItemPurchase.Size = new System.Drawing.Size(29, 13);
            this.labelItemPurchase.TabIndex = 24;
            this.labelItemPurchase.Text = "Item";
            // 
            // comboItemsPurchase
            // 
            this.comboItemsPurchase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboItemsPurchase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboItemsPurchase.FormattingEnabled = true;
            this.comboItemsPurchase.Location = new System.Drawing.Point(258, 49);
            this.comboItemsPurchase.Name = "comboItemsPurchase";
            this.comboItemsPurchase.Size = new System.Drawing.Size(131, 21);
            this.comboItemsPurchase.TabIndex = 0;
            this.comboItemsPurchase.SelectedIndexChanged += new System.EventHandler(this.comboItems_All_SelectedIndexChanged);
            // 
            // labelDatePurchase
            // 
            this.labelDatePurchase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDatePurchase.AutoSize = true;
            this.labelDatePurchase.ForeColor = System.Drawing.Color.White;
            this.labelDatePurchase.Location = new System.Drawing.Point(433, 20);
            this.labelDatePurchase.Name = "labelDatePurchase";
            this.labelDatePurchase.Size = new System.Drawing.Size(30, 13);
            this.labelDatePurchase.TabIndex = 22;
            this.labelDatePurchase.Text = "Date";
            // 
            // labelItemIDPurchase
            // 
            this.labelItemIDPurchase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelItemIDPurchase.AutoSize = true;
            this.labelItemIDPurchase.ForeColor = System.Drawing.Color.White;
            this.labelItemIDPurchase.Location = new System.Drawing.Point(433, 50);
            this.labelItemIDPurchase.Name = "labelItemIDPurchase";
            this.labelItemIDPurchase.Size = new System.Drawing.Size(43, 13);
            this.labelItemIDPurchase.TabIndex = 21;
            this.labelItemIDPurchase.Text = "Item ID";
            // 
            // datePurchase
            // 
            this.datePurchase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datePurchase.CustomFormat = "";
            this.datePurchase.Enabled = false;
            this.datePurchase.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePurchase.Location = new System.Drawing.Point(526, 16);
            this.datePurchase.Name = "datePurchase";
            this.datePurchase.Size = new System.Drawing.Size(131, 20);
            this.datePurchase.TabIndex = 20;
            // 
            // textItemIDPurchase
            // 
            this.textItemIDPurchase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textItemIDPurchase.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textItemIDPurchase.Location = new System.Drawing.Point(526, 49);
            this.textItemIDPurchase.Name = "textItemIDPurchase";
            this.textItemIDPurchase.ReadOnly = true;
            this.textItemIDPurchase.Size = new System.Drawing.Size(131, 20);
            this.textItemIDPurchase.TabIndex = 6;
            // 
            // tabSales
            // 
            this.tabSales.BackColor = System.Drawing.SystemColors.Highlight;
            this.tabSales.Controls.Add(this.buttonDeleteAllSales);
            this.tabSales.Controls.Add(this.labelSearchMovesSales);
            this.tabSales.Controls.Add(this.comboSearchMovesSales);
            this.tabSales.Controls.Add(this.buttonUpdateSales);
            this.tabSales.Controls.Add(this.buttonNewSales);
            this.tabSales.Controls.Add(this.buttonDeleteSales);
            this.tabSales.Controls.Add(this.gridSales);
            this.tabSales.Controls.Add(this.labelMoveIDSales);
            this.tabSales.Controls.Add(this.textMoveIDSales);
            this.tabSales.Controls.Add(this.comboTypeSales);
            this.tabSales.Controls.Add(this.labelTypeSales);
            this.tabSales.Controls.Add(this.buttonSaveSales);
            this.tabSales.Controls.Add(this.textTotalSales);
            this.tabSales.Controls.Add(this.labelTotalSales);
            this.tabSales.Controls.Add(this.labelQuantity);
            this.tabSales.Controls.Add(this.labelPriceSales);
            this.tabSales.Controls.Add(this.textQuantitySales);
            this.tabSales.Controls.Add(this.textPriceSales);
            this.tabSales.Controls.Add(this.labelItemsSales);
            this.tabSales.Controls.Add(this.comboItemsSales);
            this.tabSales.Controls.Add(this.labelDateSales);
            this.tabSales.Controls.Add(this.labelItemIDSales);
            this.tabSales.Controls.Add(this.dateSales);
            this.tabSales.Controls.Add(this.textItemIDSales);
            this.tabSales.Location = new System.Drawing.Point(4, 22);
            this.tabSales.Name = "tabSales";
            this.tabSales.Size = new System.Drawing.Size(848, 453);
            this.tabSales.TabIndex = 2;
            this.tabSales.Text = "Sales";
            this.tabSales.Enter += new System.EventHandler(this.tabSales_Enter);
            // 
            // buttonDeleteAllSales
            // 
            this.buttonDeleteAllSales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteAllSales.Location = new System.Drawing.Point(550, 141);
            this.buttonDeleteAllSales.Name = "buttonDeleteAllSales";
            this.buttonDeleteAllSales.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteAllSales.TabIndex = 65;
            this.buttonDeleteAllSales.Text = "Delete All";
            this.buttonDeleteAllSales.UseVisualStyleBackColor = true;
            this.buttonDeleteAllSales.Click += new System.EventHandler(this.buttonDeleteAllSales_Click);
            // 
            // labelSearchMovesSales
            // 
            this.labelSearchMovesSales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSearchMovesSales.AutoSize = true;
            this.labelSearchMovesSales.ForeColor = System.Drawing.Color.White;
            this.labelSearchMovesSales.Location = new System.Drawing.Point(325, 179);
            this.labelSearchMovesSales.Name = "labelSearchMovesSales";
            this.labelSearchMovesSales.Size = new System.Drawing.Size(61, 13);
            this.labelSearchMovesSales.TabIndex = 64;
            this.labelSearchMovesSales.Text = "Find Moves";
            // 
            // comboSearchMovesSales
            // 
            this.comboSearchMovesSales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboSearchMovesSales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSearchMovesSales.FormattingEnabled = true;
            this.comboSearchMovesSales.Items.AddRange(new object[] {
            "All"});
            this.comboSearchMovesSales.Location = new System.Drawing.Point(392, 176);
            this.comboSearchMovesSales.Name = "comboSearchMovesSales";
            this.comboSearchMovesSales.Size = new System.Drawing.Size(131, 21);
            this.comboSearchMovesSales.TabIndex = 63;
            this.comboSearchMovesSales.SelectedIndexChanged += new System.EventHandler(this.comboFindByID_SelectedIndexChanged);
            // 
            // buttonUpdateSales
            // 
            this.buttonUpdateSales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdateSales.Location = new System.Drawing.Point(386, 141);
            this.buttonUpdateSales.Name = "buttonUpdateSales";
            this.buttonUpdateSales.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateSales.TabIndex = 62;
            this.buttonUpdateSales.Text = "Update";
            this.buttonUpdateSales.UseVisualStyleBackColor = true;
            this.buttonUpdateSales.Click += new System.EventHandler(this.buttonUpdateSales_Click);
            // 
            // buttonNewSales
            // 
            this.buttonNewSales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNewSales.Location = new System.Drawing.Point(224, 141);
            this.buttonNewSales.Name = "buttonNewSales";
            this.buttonNewSales.Size = new System.Drawing.Size(75, 23);
            this.buttonNewSales.TabIndex = 61;
            this.buttonNewSales.Text = "New";
            this.buttonNewSales.UseVisualStyleBackColor = true;
            this.buttonNewSales.Click += new System.EventHandler(this.buttonNewSales_Click);
            // 
            // buttonDeleteSales
            // 
            this.buttonDeleteSales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteSales.Location = new System.Drawing.Point(467, 141);
            this.buttonDeleteSales.Name = "buttonDeleteSales";
            this.buttonDeleteSales.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteSales.TabIndex = 59;
            this.buttonDeleteSales.Text = "Delete";
            this.buttonDeleteSales.UseVisualStyleBackColor = true;
            this.buttonDeleteSales.Click += new System.EventHandler(this.buttonDeleteSales_Click);
            // 
            // gridSales
            // 
            this.gridSales.AllowUserToAddRows = false;
            this.gridSales.AllowUserToDeleteRows = false;
            this.gridSales.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.gridSales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridSales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridSales.AutoGenerateColumns = false;
            this.gridSales.BackgroundColor = System.Drawing.Color.LightGray;
            this.gridSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridSales.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.gridSales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSalesDataGridViewTextBoxColumn,
            this.itemIDSalesDataGridViewTextBoxColumn,
            this.itemNameSalesDataGridViewTextBoxColumn,
            this.priceSalesDataGridViewTextBoxColumn,
            this.quantitySalesDataGridViewTextBoxColumn,
            this.totalSalesDataGridViewTextBoxColumn,
            this.moveIDSalesDataGridViewTextBoxColumn,
            this.moveTypeSalesDataGridViewTextBoxColumn,
            this.moveDateSalesDataGridViewTextBoxColumn});
            this.gridSales.DataSource = this.storeOutBindingSource;
            this.gridSales.Location = new System.Drawing.Point(8, 215);
            this.gridSales.Name = "gridSales";
            this.gridSales.ReadOnly = true;
            this.gridSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSales.Size = new System.Drawing.Size(832, 230);
            this.gridSales.TabIndex = 57;
            this.gridSales.VirtualMode = true;
            this.gridSales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSales_CellClick);
            this.gridSales.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_DataBindingComplete);
            // 
            // iDSalesDataGridViewTextBoxColumn
            // 
            this.iDSalesDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDSalesDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDSalesDataGridViewTextBoxColumn.Name = "iDSalesDataGridViewTextBoxColumn";
            this.iDSalesDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDSalesDataGridViewTextBoxColumn.Width = 88;
            // 
            // itemIDSalesDataGridViewTextBoxColumn
            // 
            this.itemIDSalesDataGridViewTextBoxColumn.DataPropertyName = "Item_ID";
            this.itemIDSalesDataGridViewTextBoxColumn.HeaderText = "Item ID";
            this.itemIDSalesDataGridViewTextBoxColumn.Name = "itemIDSalesDataGridViewTextBoxColumn";
            this.itemIDSalesDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemIDSalesDataGridViewTextBoxColumn.Width = 87;
            // 
            // itemNameSalesDataGridViewTextBoxColumn
            // 
            this.itemNameSalesDataGridViewTextBoxColumn.DataPropertyName = "Item_Name";
            this.itemNameSalesDataGridViewTextBoxColumn.HeaderText = "Item Name";
            this.itemNameSalesDataGridViewTextBoxColumn.Name = "itemNameSalesDataGridViewTextBoxColumn";
            this.itemNameSalesDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemNameSalesDataGridViewTextBoxColumn.Width = 88;
            // 
            // priceSalesDataGridViewTextBoxColumn
            // 
            this.priceSalesDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceSalesDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceSalesDataGridViewTextBoxColumn.Name = "priceSalesDataGridViewTextBoxColumn";
            this.priceSalesDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceSalesDataGridViewTextBoxColumn.Width = 88;
            // 
            // quantitySalesDataGridViewTextBoxColumn
            // 
            this.quantitySalesDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantitySalesDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantitySalesDataGridViewTextBoxColumn.Name = "quantitySalesDataGridViewTextBoxColumn";
            this.quantitySalesDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantitySalesDataGridViewTextBoxColumn.Width = 87;
            // 
            // totalSalesDataGridViewTextBoxColumn
            // 
            this.totalSalesDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalSalesDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalSalesDataGridViewTextBoxColumn.Name = "totalSalesDataGridViewTextBoxColumn";
            this.totalSalesDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalSalesDataGridViewTextBoxColumn.Width = 88;
            // 
            // moveIDSalesDataGridViewTextBoxColumn
            // 
            this.moveIDSalesDataGridViewTextBoxColumn.DataPropertyName = "Move_ID";
            this.moveIDSalesDataGridViewTextBoxColumn.HeaderText = "Move ID";
            this.moveIDSalesDataGridViewTextBoxColumn.Name = "moveIDSalesDataGridViewTextBoxColumn";
            this.moveIDSalesDataGridViewTextBoxColumn.ReadOnly = true;
            this.moveIDSalesDataGridViewTextBoxColumn.Width = 88;
            // 
            // moveTypeSalesDataGridViewTextBoxColumn
            // 
            this.moveTypeSalesDataGridViewTextBoxColumn.DataPropertyName = "Move_Type";
            this.moveTypeSalesDataGridViewTextBoxColumn.HeaderText = "Move Type";
            this.moveTypeSalesDataGridViewTextBoxColumn.Name = "moveTypeSalesDataGridViewTextBoxColumn";
            this.moveTypeSalesDataGridViewTextBoxColumn.ReadOnly = true;
            this.moveTypeSalesDataGridViewTextBoxColumn.Width = 87;
            // 
            // moveDateSalesDataGridViewTextBoxColumn
            // 
            this.moveDateSalesDataGridViewTextBoxColumn.DataPropertyName = "Move_Date";
            this.moveDateSalesDataGridViewTextBoxColumn.HeaderText = "Move Date";
            this.moveDateSalesDataGridViewTextBoxColumn.Name = "moveDateSalesDataGridViewTextBoxColumn";
            this.moveDateSalesDataGridViewTextBoxColumn.ReadOnly = true;
            this.moveDateSalesDataGridViewTextBoxColumn.Width = 88;
            // 
            // storeOutBindingSource
            // 
            this.storeOutBindingSource.DataMember = "Store_Out";
            this.storeOutBindingSource.DataSource = this.MiniSpecialistDataSet;
            // 
            // labelMoveIDSales
            // 
            this.labelMoveIDSales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMoveIDSales.AutoSize = true;
            this.labelMoveIDSales.ForeColor = System.Drawing.Color.White;
            this.labelMoveIDSales.Location = new System.Drawing.Point(191, 20);
            this.labelMoveIDSales.Name = "labelMoveIDSales";
            this.labelMoveIDSales.Size = new System.Drawing.Size(47, 13);
            this.labelMoveIDSales.TabIndex = 54;
            this.labelMoveIDSales.Text = "Move ID";
            // 
            // textMoveIDSales
            // 
            this.textMoveIDSales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textMoveIDSales.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textMoveIDSales.Location = new System.Drawing.Point(258, 17);
            this.textMoveIDSales.Name = "textMoveIDSales";
            this.textMoveIDSales.ReadOnly = true;
            this.textMoveIDSales.Size = new System.Drawing.Size(131, 20);
            this.textMoveIDSales.TabIndex = 4;
            // 
            // comboTypeSales
            // 
            this.comboTypeSales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboTypeSales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTypeSales.FormattingEnabled = true;
            this.comboTypeSales.Items.AddRange(new object[] {
            "Invoice",
            "Return",
            "Supply"});
            this.comboTypeSales.Location = new System.Drawing.Point(258, 107);
            this.comboTypeSales.Name = "comboTypeSales";
            this.comboTypeSales.Size = new System.Drawing.Size(131, 21);
            this.comboTypeSales.TabIndex = 1;
            // 
            // labelTypeSales
            // 
            this.labelTypeSales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTypeSales.AutoSize = true;
            this.labelTypeSales.ForeColor = System.Drawing.Color.White;
            this.labelTypeSales.Location = new System.Drawing.Point(191, 110);
            this.labelTypeSales.Name = "labelTypeSales";
            this.labelTypeSales.Size = new System.Drawing.Size(31, 13);
            this.labelTypeSales.TabIndex = 51;
            this.labelTypeSales.Text = "Type";
            // 
            // buttonSaveSales
            // 
            this.buttonSaveSales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSaveSales.Location = new System.Drawing.Point(305, 141);
            this.buttonSaveSales.Name = "buttonSaveSales";
            this.buttonSaveSales.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveSales.TabIndex = 3;
            this.buttonSaveSales.Text = "Save";
            this.buttonSaveSales.UseVisualStyleBackColor = true;
            this.buttonSaveSales.Click += new System.EventHandler(this.buttonSaveSales_Click);
            // 
            // textTotalSales
            // 
            this.textTotalSales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textTotalSales.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textTotalSales.Location = new System.Drawing.Point(526, 107);
            this.textTotalSales.Name = "textTotalSales";
            this.textTotalSales.ReadOnly = true;
            this.textTotalSales.Size = new System.Drawing.Size(131, 20);
            this.textTotalSales.TabIndex = 7;
            // 
            // labelTotalSales
            // 
            this.labelTotalSales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTotalSales.AutoSize = true;
            this.labelTotalSales.ForeColor = System.Drawing.Color.White;
            this.labelTotalSales.Location = new System.Drawing.Point(433, 108);
            this.labelTotalSales.Name = "labelTotalSales";
            this.labelTotalSales.Size = new System.Drawing.Size(31, 13);
            this.labelTotalSales.TabIndex = 47;
            this.labelTotalSales.Text = "Total";
            // 
            // labelQuantity
            // 
            this.labelQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.ForeColor = System.Drawing.Color.White;
            this.labelQuantity.Location = new System.Drawing.Point(432, 79);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(49, 13);
            this.labelQuantity.TabIndex = 46;
            this.labelQuantity.Text = "Quantity";
            // 
            // labelPriceSales
            // 
            this.labelPriceSales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPriceSales.AutoSize = true;
            this.labelPriceSales.ForeColor = System.Drawing.Color.White;
            this.labelPriceSales.Location = new System.Drawing.Point(191, 81);
            this.labelPriceSales.Name = "labelPriceSales";
            this.labelPriceSales.Size = new System.Drawing.Size(30, 13);
            this.labelPriceSales.TabIndex = 45;
            this.labelPriceSales.Text = "Price";
            // 
            // textQuantitySales
            // 
            this.textQuantitySales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textQuantitySales.Location = new System.Drawing.Point(526, 78);
            this.textQuantitySales.MaxLength = 10;
            this.textQuantitySales.Name = "textQuantitySales";
            this.textQuantitySales.Size = new System.Drawing.Size(131, 20);
            this.textQuantitySales.TabIndex = 2;
            this.textQuantitySales.TextChanged += new System.EventHandler(this.text_All_Quantity_TextChanged);
            this.textQuantitySales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_All_Numbers_KeyPress);
            // 
            // textPriceSales
            // 
            this.textPriceSales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textPriceSales.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textPriceSales.Location = new System.Drawing.Point(258, 78);
            this.textPriceSales.Name = "textPriceSales";
            this.textPriceSales.ReadOnly = true;
            this.textPriceSales.Size = new System.Drawing.Size(131, 20);
            this.textPriceSales.TabIndex = 5;
            // 
            // labelItemsSales
            // 
            this.labelItemsSales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelItemsSales.AutoSize = true;
            this.labelItemsSales.ForeColor = System.Drawing.Color.White;
            this.labelItemsSales.Location = new System.Drawing.Point(191, 52);
            this.labelItemsSales.Name = "labelItemsSales";
            this.labelItemsSales.Size = new System.Drawing.Size(29, 13);
            this.labelItemsSales.TabIndex = 42;
            this.labelItemsSales.Text = "Item";
            // 
            // comboItemsSales
            // 
            this.comboItemsSales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboItemsSales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboItemsSales.FormattingEnabled = true;
            this.comboItemsSales.Location = new System.Drawing.Point(258, 49);
            this.comboItemsSales.Name = "comboItemsSales";
            this.comboItemsSales.Size = new System.Drawing.Size(131, 21);
            this.comboItemsSales.TabIndex = 0;
            this.comboItemsSales.SelectedIndexChanged += new System.EventHandler(this.comboItems_All_SelectedIndexChanged);
            // 
            // labelDateSales
            // 
            this.labelDateSales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDateSales.AutoSize = true;
            this.labelDateSales.ForeColor = System.Drawing.Color.White;
            this.labelDateSales.Location = new System.Drawing.Point(433, 20);
            this.labelDateSales.Name = "labelDateSales";
            this.labelDateSales.Size = new System.Drawing.Size(30, 13);
            this.labelDateSales.TabIndex = 40;
            this.labelDateSales.Text = "Date";
            // 
            // labelItemIDSales
            // 
            this.labelItemIDSales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelItemIDSales.AutoSize = true;
            this.labelItemIDSales.ForeColor = System.Drawing.Color.White;
            this.labelItemIDSales.Location = new System.Drawing.Point(433, 50);
            this.labelItemIDSales.Name = "labelItemIDSales";
            this.labelItemIDSales.Size = new System.Drawing.Size(43, 13);
            this.labelItemIDSales.TabIndex = 39;
            this.labelItemIDSales.Text = "Item ID";
            // 
            // dateSales
            // 
            this.dateSales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateSales.CustomFormat = "";
            this.dateSales.Enabled = false;
            this.dateSales.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSales.Location = new System.Drawing.Point(526, 16);
            this.dateSales.Name = "dateSales";
            this.dateSales.Size = new System.Drawing.Size(131, 20);
            this.dateSales.TabIndex = 38;
            // 
            // textItemIDSales
            // 
            this.textItemIDSales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textItemIDSales.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textItemIDSales.Location = new System.Drawing.Point(526, 49);
            this.textItemIDSales.Name = "textItemIDSales";
            this.textItemIDSales.ReadOnly = true;
            this.textItemIDSales.Size = new System.Drawing.Size(131, 20);
            this.textItemIDSales.TabIndex = 6;
            // 
            // tabSearch
            // 
            this.tabSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.tabSearch.Controls.Add(this.radioSearchByKeyword);
            this.tabSearch.Controls.Add(this.radioSearchByMovesDate);
            this.tabSearch.Controls.Add(this.labelSearchDateTo);
            this.tabSearch.Controls.Add(this.dateSearchMovesTo);
            this.tabSearch.Controls.Add(this.dateSearchMovesFrom);
            this.tabSearch.Controls.Add(this.labelSearchDateFrom);
            this.tabSearch.Controls.Add(this.labelSearchBy);
            this.tabSearch.Controls.Add(this.comboSearchColumns);
            this.tabSearch.Controls.Add(this.labelSearchIn);
            this.tabSearch.Controls.Add(this.comboSearchTables);
            this.tabSearch.Controls.Add(this.buttonSearch);
            this.tabSearch.Controls.Add(this.gridSearch);
            this.tabSearch.Controls.Add(this.textSearchKeyword);
            this.tabSearch.Location = new System.Drawing.Point(4, 22);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(848, 453);
            this.tabSearch.TabIndex = 3;
            this.tabSearch.Text = "Search";
            this.tabSearch.Enter += new System.EventHandler(this.tabSearch_Enter);
            // 
            // radioSearchByKeyword
            // 
            this.radioSearchByKeyword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioSearchByKeyword.AutoSize = true;
            this.radioSearchByKeyword.ForeColor = System.Drawing.Color.White;
            this.radioSearchByKeyword.Location = new System.Drawing.Point(144, 20);
            this.radioSearchByKeyword.Name = "radioSearchByKeyword";
            this.radioSearchByKeyword.Size = new System.Drawing.Size(67, 17);
            this.radioSearchByKeyword.TabIndex = 30;
            this.radioSearchByKeyword.Text = "Keyword";
            this.radioSearchByKeyword.UseVisualStyleBackColor = true;
            this.radioSearchByKeyword.CheckedChanged += new System.EventHandler(this.radioSearchByKeyword_CheckedChanged);
            // 
            // radioSearchByMovesDate
            // 
            this.radioSearchByMovesDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioSearchByMovesDate.AutoSize = true;
            this.radioSearchByMovesDate.ForeColor = System.Drawing.Color.White;
            this.radioSearchByMovesDate.Location = new System.Drawing.Point(144, 48);
            this.radioSearchByMovesDate.Name = "radioSearchByMovesDate";
            this.radioSearchByMovesDate.Size = new System.Drawing.Size(71, 17);
            this.radioSearchByMovesDate.TabIndex = 29;
            this.radioSearchByMovesDate.Text = "Overview";
            this.radioSearchByMovesDate.UseVisualStyleBackColor = true;
            this.radioSearchByMovesDate.CheckedChanged += new System.EventHandler(this.radioSearchByMovesDate_CheckedChanged);
            // 
            // labelSearchDateTo
            // 
            this.labelSearchDateTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSearchDateTo.AutoSize = true;
            this.labelSearchDateTo.ForeColor = System.Drawing.Color.White;
            this.labelSearchDateTo.Location = new System.Drawing.Point(380, 50);
            this.labelSearchDateTo.Name = "labelSearchDateTo";
            this.labelSearchDateTo.Size = new System.Drawing.Size(19, 13);
            this.labelSearchDateTo.TabIndex = 28;
            this.labelSearchDateTo.Text = "To";
            // 
            // dateSearchMovesTo
            // 
            this.dateSearchMovesTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateSearchMovesTo.CustomFormat = "";
            this.dateSearchMovesTo.Enabled = false;
            this.dateSearchMovesTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSearchMovesTo.Location = new System.Drawing.Point(405, 46);
            this.dateSearchMovesTo.Name = "dateSearchMovesTo";
            this.dateSearchMovesTo.Size = new System.Drawing.Size(121, 20);
            this.dateSearchMovesTo.TabIndex = 27;
            this.dateSearchMovesTo.Value = new System.DateTime(2012, 11, 27, 0, 0, 0, 0);
            // 
            // dateSearchMovesFrom
            // 
            this.dateSearchMovesFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateSearchMovesFrom.CustomFormat = "";
            this.dateSearchMovesFrom.Enabled = false;
            this.dateSearchMovesFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSearchMovesFrom.Location = new System.Drawing.Point(261, 46);
            this.dateSearchMovesFrom.Name = "dateSearchMovesFrom";
            this.dateSearchMovesFrom.Size = new System.Drawing.Size(113, 20);
            this.dateSearchMovesFrom.TabIndex = 26;
            this.dateSearchMovesFrom.Value = new System.DateTime(2012, 11, 27, 0, 0, 0, 0);
            // 
            // labelSearchDateFrom
            // 
            this.labelSearchDateFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSearchDateFrom.AutoSize = true;
            this.labelSearchDateFrom.ForeColor = System.Drawing.Color.White;
            this.labelSearchDateFrom.Location = new System.Drawing.Point(224, 50);
            this.labelSearchDateFrom.Name = "labelSearchDateFrom";
            this.labelSearchDateFrom.Size = new System.Drawing.Size(31, 13);
            this.labelSearchDateFrom.TabIndex = 25;
            this.labelSearchDateFrom.Text = "From";
            // 
            // labelSearchBy
            // 
            this.labelSearchBy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSearchBy.AutoSize = true;
            this.labelSearchBy.ForeColor = System.Drawing.Color.White;
            this.labelSearchBy.Location = new System.Drawing.Point(559, 22);
            this.labelSearchBy.Name = "labelSearchBy";
            this.labelSearchBy.Size = new System.Drawing.Size(19, 13);
            this.labelSearchBy.TabIndex = 14;
            this.labelSearchBy.Text = "By";
            // 
            // comboSearchColumns
            // 
            this.comboSearchColumns.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboSearchColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSearchColumns.Enabled = false;
            this.comboSearchColumns.FormattingEnabled = true;
            this.comboSearchColumns.Location = new System.Drawing.Point(584, 19);
            this.comboSearchColumns.Name = "comboSearchColumns";
            this.comboSearchColumns.Size = new System.Drawing.Size(121, 21);
            this.comboSearchColumns.TabIndex = 13;
            // 
            // labelSearchIn
            // 
            this.labelSearchIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSearchIn.AutoSize = true;
            this.labelSearchIn.ForeColor = System.Drawing.Color.White;
            this.labelSearchIn.Location = new System.Drawing.Point(417, 22);
            this.labelSearchIn.Name = "labelSearchIn";
            this.labelSearchIn.Size = new System.Drawing.Size(17, 13);
            this.labelSearchIn.TabIndex = 12;
            this.labelSearchIn.Text = "In";
            // 
            // comboSearchTables
            // 
            this.comboSearchTables.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboSearchTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSearchTables.Enabled = false;
            this.comboSearchTables.FormattingEnabled = true;
            this.comboSearchTables.Location = new System.Drawing.Point(440, 19);
            this.comboSearchTables.Name = "comboSearchTables";
            this.comboSearchTables.Size = new System.Drawing.Size(113, 21);
            this.comboSearchTables.TabIndex = 10;
            this.comboSearchTables.SelectedIndexChanged += new System.EventHandler(this.comboSearchTable_SelectedIndexChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSearch.AutoSize = true;
            this.buttonSearch.Enabled = false;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSearch.Location = new System.Drawing.Point(387, 72);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 25);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // gridSearch
            // 
            this.gridSearch.AllowUserToAddRows = false;
            this.gridSearch.AllowUserToDeleteRows = false;
            this.gridSearch.AllowUserToResizeRows = false;
            this.gridSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridSearch.BackgroundColor = System.Drawing.Color.LightGray;
            this.gridSearch.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.gridSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridSearch.Location = new System.Drawing.Point(8, 103);
            this.gridSearch.MultiSelect = false;
            this.gridSearch.Name = "gridSearch";
            this.gridSearch.ReadOnly = true;
            this.gridSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSearch.Size = new System.Drawing.Size(832, 342);
            this.gridSearch.TabIndex = 9;
            this.gridSearch.VirtualMode = true;
            this.gridSearch.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_DataBindingComplete);
            // 
            // textSearchKeyword
            // 
            this.textSearchKeyword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textSearchKeyword.Enabled = false;
            this.textSearchKeyword.Location = new System.Drawing.Point(227, 19);
            this.textSearchKeyword.Name = "textSearchKeyword";
            this.textSearchKeyword.Size = new System.Drawing.Size(184, 20);
            this.textSearchKeyword.TabIndex = 0;
            this.textSearchKeyword.TextChanged += new System.EventHandler(this.textSearchKeyword_TextChanged);
            // 
            // tabReports
            // 
            this.tabReports.BackColor = System.Drawing.SystemColors.Highlight;
            this.tabReports.Controls.Add(this.buttonPrintReports);
            this.tabReports.Controls.Add(this.label1);
            this.tabReports.Controls.Add(this.comboReports);
            this.tabReports.Controls.Add(this.gridReports);
            this.tabReports.Location = new System.Drawing.Point(4, 22);
            this.tabReports.Name = "tabReports";
            this.tabReports.Size = new System.Drawing.Size(848, 453);
            this.tabReports.TabIndex = 4;
            this.tabReports.Text = "Reports";
            this.tabReports.Enter += new System.EventHandler(this.tabReports_Enter);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(274, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Reports";
            // 
            // comboReports
            // 
            this.comboReports.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboReports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboReports.FormattingEnabled = true;
            this.comboReports.Location = new System.Drawing.Point(325, 21);
            this.comboReports.Name = "comboReports";
            this.comboReports.Size = new System.Drawing.Size(168, 21);
            this.comboReports.TabIndex = 1;
            this.comboReports.SelectedIndexChanged += new System.EventHandler(this.comboReports_SelectedIndexChanged);
            // 
            // gridReports
            // 
            this.gridReports.AllowUserToAddRows = false;
            this.gridReports.AllowUserToDeleteRows = false;
            this.gridReports.AllowUserToResizeRows = false;
            this.gridReports.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridReports.BackgroundColor = System.Drawing.Color.LightGray;
            this.gridReports.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.gridReports.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridReports.Location = new System.Drawing.Point(8, 60);
            this.gridReports.Name = "gridReports";
            this.gridReports.ReadOnly = true;
            this.gridReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridReports.Size = new System.Drawing.Size(832, 385);
            this.gridReports.TabIndex = 0;
            this.gridReports.VirtualMode = true;
            this.gridReports.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_DataBindingComplete);
            // 
            // tabEmployees
            // 
            this.tabEmployees.BackColor = System.Drawing.SystemColors.Highlight;
            this.tabEmployees.Controls.Add(this.textNameEmployee);
            this.tabEmployees.Controls.Add(this.buttonDeleteAllEmployee);
            this.tabEmployees.Controls.Add(this.buttonUpdateEmployee);
            this.tabEmployees.Controls.Add(this.buttonNewEmployee);
            this.tabEmployees.Controls.Add(this.buttonDeleteEmployee);
            this.tabEmployees.Controls.Add(this.gridEmployees);
            this.tabEmployees.Controls.Add(this.labelEmployeeID);
            this.tabEmployees.Controls.Add(this.textEmployeeIDEmployee);
            this.tabEmployees.Controls.Add(this.buttonSaveEmployee);
            this.tabEmployees.Controls.Add(this.textSSNEmployee);
            this.tabEmployees.Controls.Add(this.labelEmployeeSSN);
            this.tabEmployees.Controls.Add(this.labelEmployeePhone);
            this.tabEmployees.Controls.Add(this.labelEmployeeEmail);
            this.tabEmployees.Controls.Add(this.textEmailEmployee);
            this.tabEmployees.Controls.Add(this.textPhoneEmployee);
            this.tabEmployees.Controls.Add(this.labelEmployeeName);
            this.tabEmployees.Controls.Add(this.labelEmployeeBirthDate);
            this.tabEmployees.Controls.Add(this.labelEmployeeAddress);
            this.tabEmployees.Controls.Add(this.dateBirthDateEmployee);
            this.tabEmployees.Controls.Add(this.textAddressEmployee);
            this.tabEmployees.Location = new System.Drawing.Point(4, 22);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.Size = new System.Drawing.Size(848, 453);
            this.tabEmployees.TabIndex = 5;
            this.tabEmployees.Text = "Employees";
            this.tabEmployees.Enter += new System.EventHandler(this.tabEmployees_Enter);
            // 
            // textNameEmployee
            // 
            this.textNameEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textNameEmployee.Location = new System.Drawing.Point(258, 21);
            this.textNameEmployee.MaxLength = 100;
            this.textNameEmployee.Name = "textNameEmployee";
            this.textNameEmployee.Size = new System.Drawing.Size(398, 20);
            this.textNameEmployee.TabIndex = 90;
            // 
            // buttonDeleteAllEmployee
            // 
            this.buttonDeleteAllEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteAllEmployee.Location = new System.Drawing.Point(550, 143);
            this.buttonDeleteAllEmployee.Name = "buttonDeleteAllEmployee";
            this.buttonDeleteAllEmployee.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteAllEmployee.TabIndex = 89;
            this.buttonDeleteAllEmployee.Text = "Delete All";
            this.buttonDeleteAllEmployee.UseVisualStyleBackColor = true;
            this.buttonDeleteAllEmployee.Click += new System.EventHandler(this.buttonDeleteAllEmployee_Click);
            // 
            // buttonUpdateEmployee
            // 
            this.buttonUpdateEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdateEmployee.Location = new System.Drawing.Point(386, 143);
            this.buttonUpdateEmployee.Name = "buttonUpdateEmployee";
            this.buttonUpdateEmployee.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateEmployee.TabIndex = 86;
            this.buttonUpdateEmployee.Text = "Update";
            this.buttonUpdateEmployee.UseVisualStyleBackColor = true;
            this.buttonUpdateEmployee.Click += new System.EventHandler(this.buttonUpdateEmployee_Click);
            // 
            // buttonNewEmployee
            // 
            this.buttonNewEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNewEmployee.Location = new System.Drawing.Point(224, 143);
            this.buttonNewEmployee.Name = "buttonNewEmployee";
            this.buttonNewEmployee.Size = new System.Drawing.Size(75, 23);
            this.buttonNewEmployee.TabIndex = 85;
            this.buttonNewEmployee.Text = "New";
            this.buttonNewEmployee.UseVisualStyleBackColor = true;
            this.buttonNewEmployee.Click += new System.EventHandler(this.buttonNewEmployee_Click);
            // 
            // buttonDeleteEmployee
            // 
            this.buttonDeleteEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteEmployee.Location = new System.Drawing.Point(467, 143);
            this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            this.buttonDeleteEmployee.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteEmployee.TabIndex = 84;
            this.buttonDeleteEmployee.Text = "Delete";
            this.buttonDeleteEmployee.UseVisualStyleBackColor = true;
            this.buttonDeleteEmployee.Click += new System.EventHandler(this.buttonDeleteEmployee_Click);
            // 
            // gridEmployees
            // 
            this.gridEmployees.AllowUserToAddRows = false;
            this.gridEmployees.AllowUserToDeleteRows = false;
            this.gridEmployees.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.gridEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridEmployees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridEmployees.AutoGenerateColumns = false;
            this.gridEmployees.BackgroundColor = System.Drawing.Color.LightGray;
            this.gridEmployees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridEmployees.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.gridEmployees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDEmployeesDataGridViewTextBoxColumn,
            this.nameEmployeesDataGridViewTextBoxColumn,
            this.addressEmployeesDataGridViewTextBoxColumn,
            this.phoneEmployeesDataGridViewTextBoxColumn,
            this.emailEmployeesDataGridViewTextBoxColumn,
            this.birthDateEmployeesDataGridViewTextBoxColumn,
            this.sSNEmployeesDataGridViewTextBoxColumn});
            this.gridEmployees.DataSource = this.employeesBindingSource;
            this.gridEmployees.Location = new System.Drawing.Point(8, 176);
            this.gridEmployees.Name = "gridEmployees";
            this.gridEmployees.ReadOnly = true;
            this.gridEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEmployees.Size = new System.Drawing.Size(832, 269);
            this.gridEmployees.TabIndex = 83;
            this.gridEmployees.VirtualMode = true;
            this.gridEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEmployees_CellClick);
            this.gridEmployees.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_DataBindingComplete);
            // 
            // iDEmployeesDataGridViewTextBoxColumn
            // 
            this.iDEmployeesDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.iDEmployeesDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDEmployeesDataGridViewTextBoxColumn.Name = "iDEmployeesDataGridViewTextBoxColumn";
            this.iDEmployeesDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDEmployeesDataGridViewTextBoxColumn.Width = 112;
            // 
            // nameEmployeesDataGridViewTextBoxColumn
            // 
            this.nameEmployeesDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameEmployeesDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameEmployeesDataGridViewTextBoxColumn.Name = "nameEmployeesDataGridViewTextBoxColumn";
            this.nameEmployeesDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameEmployeesDataGridViewTextBoxColumn.Width = 113;
            // 
            // addressEmployeesDataGridViewTextBoxColumn
            // 
            this.addressEmployeesDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressEmployeesDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressEmployeesDataGridViewTextBoxColumn.Name = "addressEmployeesDataGridViewTextBoxColumn";
            this.addressEmployeesDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressEmployeesDataGridViewTextBoxColumn.Width = 112;
            // 
            // phoneEmployeesDataGridViewTextBoxColumn
            // 
            this.phoneEmployeesDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneEmployeesDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneEmployeesDataGridViewTextBoxColumn.Name = "phoneEmployeesDataGridViewTextBoxColumn";
            this.phoneEmployeesDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneEmployeesDataGridViewTextBoxColumn.Width = 113;
            // 
            // emailEmployeesDataGridViewTextBoxColumn
            // 
            this.emailEmployeesDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailEmployeesDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailEmployeesDataGridViewTextBoxColumn.Name = "emailEmployeesDataGridViewTextBoxColumn";
            this.emailEmployeesDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailEmployeesDataGridViewTextBoxColumn.Width = 112;
            // 
            // birthDateEmployeesDataGridViewTextBoxColumn
            // 
            this.birthDateEmployeesDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateEmployeesDataGridViewTextBoxColumn.HeaderText = "Birth Date";
            this.birthDateEmployeesDataGridViewTextBoxColumn.Name = "birthDateEmployeesDataGridViewTextBoxColumn";
            this.birthDateEmployeesDataGridViewTextBoxColumn.ReadOnly = true;
            this.birthDateEmployeesDataGridViewTextBoxColumn.Width = 113;
            // 
            // sSNEmployeesDataGridViewTextBoxColumn
            // 
            this.sSNEmployeesDataGridViewTextBoxColumn.DataPropertyName = "SSN";
            this.sSNEmployeesDataGridViewTextBoxColumn.HeaderText = "SSN";
            this.sSNEmployeesDataGridViewTextBoxColumn.Name = "sSNEmployeesDataGridViewTextBoxColumn";
            this.sSNEmployeesDataGridViewTextBoxColumn.ReadOnly = true;
            this.sSNEmployeesDataGridViewTextBoxColumn.Width = 114;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.MiniSpecialistDataSet;
            // 
            // labelEmployeeID
            // 
            this.labelEmployeeID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEmployeeID.AutoSize = true;
            this.labelEmployeeID.ForeColor = System.Drawing.Color.White;
            this.labelEmployeeID.Location = new System.Drawing.Point(191, 56);
            this.labelEmployeeID.Name = "labelEmployeeID";
            this.labelEmployeeID.Size = new System.Drawing.Size(18, 13);
            this.labelEmployeeID.TabIndex = 82;
            this.labelEmployeeID.Text = "ID";
            // 
            // textEmployeeIDEmployee
            // 
            this.textEmployeeIDEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textEmployeeIDEmployee.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textEmployeeIDEmployee.Location = new System.Drawing.Point(258, 53);
            this.textEmployeeIDEmployee.Name = "textEmployeeIDEmployee";
            this.textEmployeeIDEmployee.ReadOnly = true;
            this.textEmployeeIDEmployee.Size = new System.Drawing.Size(131, 20);
            this.textEmployeeIDEmployee.TabIndex = 70;
            // 
            // buttonSaveEmployee
            // 
            this.buttonSaveEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSaveEmployee.Location = new System.Drawing.Point(305, 143);
            this.buttonSaveEmployee.Name = "buttonSaveEmployee";
            this.buttonSaveEmployee.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveEmployee.TabIndex = 69;
            this.buttonSaveEmployee.Text = "Save";
            this.buttonSaveEmployee.UseVisualStyleBackColor = true;
            this.buttonSaveEmployee.Click += new System.EventHandler(this.buttonSaveEmployee_Click);
            // 
            // textSSNEmployee
            // 
            this.textSSNEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textSSNEmployee.Location = new System.Drawing.Point(258, 111);
            this.textSSNEmployee.MaxLength = 14;
            this.textSSNEmployee.Name = "textSSNEmployee";
            this.textSSNEmployee.Size = new System.Drawing.Size(131, 20);
            this.textSSNEmployee.TabIndex = 73;
            // 
            // labelEmployeeSSN
            // 
            this.labelEmployeeSSN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEmployeeSSN.AutoSize = true;
            this.labelEmployeeSSN.ForeColor = System.Drawing.Color.White;
            this.labelEmployeeSSN.Location = new System.Drawing.Point(191, 114);
            this.labelEmployeeSSN.Name = "labelEmployeeSSN";
            this.labelEmployeeSSN.Size = new System.Drawing.Size(26, 13);
            this.labelEmployeeSSN.TabIndex = 80;
            this.labelEmployeeSSN.Text = "SSN";
            // 
            // labelEmployeePhone
            // 
            this.labelEmployeePhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEmployeePhone.AutoSize = true;
            this.labelEmployeePhone.ForeColor = System.Drawing.Color.White;
            this.labelEmployeePhone.Location = new System.Drawing.Point(191, 85);
            this.labelEmployeePhone.Name = "labelEmployeePhone";
            this.labelEmployeePhone.Size = new System.Drawing.Size(37, 13);
            this.labelEmployeePhone.TabIndex = 79;
            this.labelEmployeePhone.Text = "Phone";
            // 
            // labelEmployeeEmail
            // 
            this.labelEmployeeEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEmployeeEmail.AutoSize = true;
            this.labelEmployeeEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmployeeEmail.Location = new System.Drawing.Point(433, 85);
            this.labelEmployeeEmail.Name = "labelEmployeeEmail";
            this.labelEmployeeEmail.Size = new System.Drawing.Size(31, 13);
            this.labelEmployeeEmail.TabIndex = 78;
            this.labelEmployeeEmail.Text = "Email";
            // 
            // textEmailEmployee
            // 
            this.textEmailEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textEmailEmployee.Location = new System.Drawing.Point(526, 82);
            this.textEmailEmployee.MaxLength = 50;
            this.textEmailEmployee.Name = "textEmailEmployee";
            this.textEmailEmployee.Size = new System.Drawing.Size(131, 20);
            this.textEmailEmployee.TabIndex = 68;
            // 
            // textPhoneEmployee
            // 
            this.textPhoneEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textPhoneEmployee.Location = new System.Drawing.Point(258, 82);
            this.textPhoneEmployee.MaxLength = 11;
            this.textPhoneEmployee.Name = "textPhoneEmployee";
            this.textPhoneEmployee.Size = new System.Drawing.Size(131, 20);
            this.textPhoneEmployee.TabIndex = 71;
            this.textPhoneEmployee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_All_Numbers_KeyPress);
            // 
            // labelEmployeeName
            // 
            this.labelEmployeeName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEmployeeName.AutoSize = true;
            this.labelEmployeeName.ForeColor = System.Drawing.Color.White;
            this.labelEmployeeName.Location = new System.Drawing.Point(191, 24);
            this.labelEmployeeName.Name = "labelEmployeeName";
            this.labelEmployeeName.Size = new System.Drawing.Size(34, 13);
            this.labelEmployeeName.TabIndex = 77;
            this.labelEmployeeName.Text = "Name";
            // 
            // labelEmployeeBirthDate
            // 
            this.labelEmployeeBirthDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEmployeeBirthDate.AutoSize = true;
            this.labelEmployeeBirthDate.ForeColor = System.Drawing.Color.White;
            this.labelEmployeeBirthDate.Location = new System.Drawing.Point(432, 114);
            this.labelEmployeeBirthDate.Name = "labelEmployeeBirthDate";
            this.labelEmployeeBirthDate.Size = new System.Drawing.Size(55, 13);
            this.labelEmployeeBirthDate.TabIndex = 76;
            this.labelEmployeeBirthDate.Text = "Birth Date";
            // 
            // labelEmployeeAddress
            // 
            this.labelEmployeeAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEmployeeAddress.AutoSize = true;
            this.labelEmployeeAddress.ForeColor = System.Drawing.Color.White;
            this.labelEmployeeAddress.Location = new System.Drawing.Point(432, 56);
            this.labelEmployeeAddress.Name = "labelEmployeeAddress";
            this.labelEmployeeAddress.Size = new System.Drawing.Size(46, 13);
            this.labelEmployeeAddress.TabIndex = 75;
            this.labelEmployeeAddress.Text = "Address";
            // 
            // dateBirthDateEmployee
            // 
            this.dateBirthDateEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateBirthDateEmployee.CustomFormat = "";
            this.dateBirthDateEmployee.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBirthDateEmployee.Location = new System.Drawing.Point(525, 110);
            this.dateBirthDateEmployee.Name = "dateBirthDateEmployee";
            this.dateBirthDateEmployee.Size = new System.Drawing.Size(131, 20);
            this.dateBirthDateEmployee.TabIndex = 74;
            this.dateBirthDateEmployee.Value = new System.DateTime(2012, 12, 4, 0, 0, 0, 0);
            // 
            // textAddressEmployee
            // 
            this.textAddressEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textAddressEmployee.Location = new System.Drawing.Point(525, 53);
            this.textAddressEmployee.MaxLength = 60;
            this.textAddressEmployee.Name = "textAddressEmployee";
            this.textAddressEmployee.Size = new System.Drawing.Size(131, 20);
            this.textAddressEmployee.TabIndex = 72;
            // 
            // tabAttendance
            // 
            this.tabAttendance.BackColor = System.Drawing.SystemColors.Highlight;
            this.tabAttendance.Controls.Add(this.gridAttendance);
            this.tabAttendance.Controls.Add(this.buttonEmplloyeeSignAttendance);
            this.tabAttendance.Controls.Add(this.labelAttendanceTime);
            this.tabAttendance.Controls.Add(this.labelEmployeeIDAttendance);
            this.tabAttendance.Controls.Add(this.labelEmployeeNameAttendance);
            this.tabAttendance.Controls.Add(this.textEmployeeIDAttendance);
            this.tabAttendance.Controls.Add(this.comboEmployeeNamesAttendance);
            this.tabAttendance.Location = new System.Drawing.Point(4, 22);
            this.tabAttendance.Name = "tabAttendance";
            this.tabAttendance.Size = new System.Drawing.Size(848, 453);
            this.tabAttendance.TabIndex = 6;
            this.tabAttendance.Text = "Attendance";
            this.tabAttendance.Enter += new System.EventHandler(this.tabAttendance_Enter);
            // 
            // gridAttendance
            // 
            this.gridAttendance.AllowUserToAddRows = false;
            this.gridAttendance.AllowUserToDeleteRows = false;
            this.gridAttendance.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gridAttendance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridAttendance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridAttendance.BackgroundColor = System.Drawing.Color.LightGray;
            this.gridAttendance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridAttendance.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.gridAttendance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridAttendance.Location = new System.Drawing.Point(8, 146);
            this.gridAttendance.MultiSelect = false;
            this.gridAttendance.Name = "gridAttendance";
            this.gridAttendance.ReadOnly = true;
            this.gridAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAttendance.Size = new System.Drawing.Size(832, 299);
            this.gridAttendance.TabIndex = 57;
            this.gridAttendance.VirtualMode = true;
            this.gridAttendance.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_DataBindingComplete);
            // 
            // buttonEmplloyeeSignAttendance
            // 
            this.buttonEmplloyeeSignAttendance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEmplloyeeSignAttendance.Location = new System.Drawing.Point(387, 102);
            this.buttonEmplloyeeSignAttendance.Name = "buttonEmplloyeeSignAttendance";
            this.buttonEmplloyeeSignAttendance.Size = new System.Drawing.Size(75, 23);
            this.buttonEmplloyeeSignAttendance.TabIndex = 6;
            this.buttonEmplloyeeSignAttendance.Text = "OK";
            this.buttonEmplloyeeSignAttendance.UseVisualStyleBackColor = true;
            this.buttonEmplloyeeSignAttendance.Click += new System.EventHandler(this.buttonEmplloyeeSignAttendance_Click);
            // 
            // labelAttendanceTime
            // 
            this.labelAttendanceTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAttendanceTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAttendanceTime.ForeColor = System.Drawing.Color.White;
            this.labelAttendanceTime.Location = new System.Drawing.Point(118, 15);
            this.labelAttendanceTime.Name = "labelAttendanceTime";
            this.labelAttendanceTime.Size = new System.Drawing.Size(612, 25);
            this.labelAttendanceTime.TabIndex = 5;
            this.labelAttendanceTime.Text = "Time";
            this.labelAttendanceTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEmployeeIDAttendance
            // 
            this.labelEmployeeIDAttendance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEmployeeIDAttendance.AutoSize = true;
            this.labelEmployeeIDAttendance.ForeColor = System.Drawing.Color.White;
            this.labelEmployeeIDAttendance.Location = new System.Drawing.Point(303, 52);
            this.labelEmployeeIDAttendance.Name = "labelEmployeeIDAttendance";
            this.labelEmployeeIDAttendance.Size = new System.Drawing.Size(18, 13);
            this.labelEmployeeIDAttendance.TabIndex = 3;
            this.labelEmployeeIDAttendance.Text = "ID";
            // 
            // labelEmployeeNameAttendance
            // 
            this.labelEmployeeNameAttendance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEmployeeNameAttendance.AutoSize = true;
            this.labelEmployeeNameAttendance.ForeColor = System.Drawing.Color.White;
            this.labelEmployeeNameAttendance.Location = new System.Drawing.Point(303, 78);
            this.labelEmployeeNameAttendance.Name = "labelEmployeeNameAttendance";
            this.labelEmployeeNameAttendance.Size = new System.Drawing.Size(34, 13);
            this.labelEmployeeNameAttendance.TabIndex = 2;
            this.labelEmployeeNameAttendance.Text = "Name";
            // 
            // textEmployeeIDAttendance
            // 
            this.textEmployeeIDAttendance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textEmployeeIDAttendance.Location = new System.Drawing.Point(343, 49);
            this.textEmployeeIDAttendance.Name = "textEmployeeIDAttendance";
            this.textEmployeeIDAttendance.Size = new System.Drawing.Size(202, 20);
            this.textEmployeeIDAttendance.TabIndex = 1;
            this.textEmployeeIDAttendance.TextChanged += new System.EventHandler(this.textEmployeeIDAttendance_TextChanged);
            this.textEmployeeIDAttendance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_All_Numbers_KeyPress);
            // 
            // comboEmployeeNamesAttendance
            // 
            this.comboEmployeeNamesAttendance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboEmployeeNamesAttendance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEmployeeNamesAttendance.FormattingEnabled = true;
            this.comboEmployeeNamesAttendance.Location = new System.Drawing.Point(343, 75);
            this.comboEmployeeNamesAttendance.Name = "comboEmployeeNamesAttendance";
            this.comboEmployeeNamesAttendance.Size = new System.Drawing.Size(202, 21);
            this.comboEmployeeNamesAttendance.TabIndex = 0;
            this.comboEmployeeNamesAttendance.SelectedIndexChanged += new System.EventHandler(this.comboEmployeeNamesAttendance_SelectedIndexChanged);
            // 
            // mainMenu
            // 
            this.mainMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miniSpecialistMenu});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mainMenu.Size = new System.Drawing.Size(856, 24);
            this.mainMenu.TabIndex = 3;
            this.mainMenu.Text = "mainMenu";
            // 
            // miniSpecialistMenu
            // 
            this.miniSpecialistMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debugMenu,
            this.exitMenu});
            this.miniSpecialistMenu.Name = "miniSpecialistMenu";
            this.miniSpecialistMenu.Size = new System.Drawing.Size(92, 20);
            this.miniSpecialistMenu.Text = "MiniSpecialist";
            // 
            // debugMenu
            // 
            this.debugMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataAtOnceMenu,
            this.checkAvailableStockMenu,
            this.logMenu,
            this.disableDBMenu,
            this.resetSettingsMenu,
            this.restartMenu});
            this.debugMenu.Name = "debugMenu";
            this.debugMenu.Size = new System.Drawing.Size(109, 22);
            this.debugMenu.Text = "Debug";
            // 
            // dataAtOnceMenu
            // 
            this.dataAtOnceMenu.Name = "dataAtOnceMenu";
            this.dataAtOnceMenu.Size = new System.Drawing.Size(190, 22);
            this.dataAtOnceMenu.Text = "Data @ Once";
            this.dataAtOnceMenu.Click += new System.EventHandler(this.dataAtOnceMenu_Click);
            // 
            // checkAvailableStockMenu
            // 
            this.checkAvailableStockMenu.Name = "checkAvailableStockMenu";
            this.checkAvailableStockMenu.Size = new System.Drawing.Size(190, 22);
            this.checkAvailableStockMenu.Text = "Check Available Stock";
            this.checkAvailableStockMenu.Click += new System.EventHandler(this.checkAvailableStockMenu_Click);
            // 
            // logMenu
            // 
            this.logMenu.Name = "logMenu";
            this.logMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.logMenu.Size = new System.Drawing.Size(190, 22);
            this.logMenu.Text = "Log";
            this.logMenu.Click += new System.EventHandler(this.logOpenMenu_Click);
            // 
            // disableDBMenu
            // 
            this.disableDBMenu.Name = "disableDBMenu";
            this.disableDBMenu.Size = new System.Drawing.Size(190, 22);
            this.disableDBMenu.Text = "Disable DB";
            this.disableDBMenu.Click += new System.EventHandler(this.disableDBMenu_Click);
            // 
            // resetSettingsMenu
            // 
            this.resetSettingsMenu.Name = "resetSettingsMenu";
            this.resetSettingsMenu.Size = new System.Drawing.Size(190, 22);
            this.resetSettingsMenu.Text = "Reset Settings";
            this.resetSettingsMenu.Click += new System.EventHandler(this.resetSettingsMenu_Click);
            // 
            // restartMenu
            // 
            this.restartMenu.Name = "restartMenu";
            this.restartMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.restartMenu.Size = new System.Drawing.Size(190, 22);
            this.restartMenu.Text = "Restart";
            this.restartMenu.Click += new System.EventHandler(this.RestartMenu_Click);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(109, 22);
            this.exitMenu.Text = "Exit";
            this.exitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // bg
            // 
            this.bg.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bg_DoWork);
            this.bg.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bg_RunWorkerCompleted);
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // overviewBindingSource
            // 
            this.overviewBindingSource.DataMember = "Overview";
            this.overviewBindingSource.DataSource = this.MiniSpecialistDataSet;
            // 
            // overviewTableAdapter
            // 
            this.overviewTableAdapter.ClearBeforeFill = true;
            // 
            // store_InTableAdapter
            // 
            this.store_InTableAdapter.ClearBeforeFill = true;
            // 
            // store_OutTableAdapter
            // 
            this.store_OutTableAdapter.ClearBeforeFill = true;
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // buttonPrintReports
            // 
            this.buttonPrintReports.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPrintReports.Location = new System.Drawing.Point(499, 21);
            this.buttonPrintReports.Name = "buttonPrintReports";
            this.buttonPrintReports.Size = new System.Drawing.Size(75, 23);
            this.buttonPrintReports.TabIndex = 86;
            this.buttonPrintReports.Text = "Print";
            this.buttonPrintReports.UseVisualStyleBackColor = true;
            this.buttonPrintReports.Click += new System.EventHandler(this.buttonPrintReports_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(856, 503);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.mainMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniSpecialist";
            this.Deactivate += new System.EventHandler(this.MiniSpecialist_Deactivate);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorEmpty)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tabStock.ResumeLayout(false);
            this.tabStock.PerformLayout();
            this.tabPurchase.ResumeLayout(false);
            this.tabPurchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeInBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiniSpecialistDataSet)).EndInit();
            this.tabSales.ResumeLayout(false);
            this.tabSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeOutBindingSource)).EndInit();
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearch)).EndInit();
            this.tabReports.ResumeLayout(false);
            this.tabReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReports)).EndInit();
            this.tabEmployees.ResumeLayout(false);
            this.tabEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.tabAttendance.ResumeLayout(false);
            this.tabAttendance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAttendance)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overviewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelItemsStock;
        private System.Windows.Forms.ComboBox comboItemsStock;
        private System.Windows.Forms.Button buttonDeleteStock;
        private System.Windows.Forms.Button buttonSaveStock;
        private System.Windows.Forms.Label labelNameStock;
        private System.Windows.Forms.Label labelPriceStock;
        private System.Windows.Forms.TextBox textNameStock;
        private System.Windows.Forms.TextBox textPriceStock;
        private System.Windows.Forms.Label labelItemIDStock;
        private System.Windows.Forms.TextBox textItemIDStock;
        private System.Windows.Forms.Button buttonUpdateStock;
        private System.Windows.Forms.ErrorProvider errorEmpty;
        private System.Windows.Forms.Label labelMoveIDPurchase;
        private System.Windows.Forms.TextBox textMoveIDPurchase;
        private System.Windows.Forms.ComboBox comboTypePurchase;
        private System.Windows.Forms.Label labelTypePurchase;
        private System.Windows.Forms.Button buttonSavePurchase;
        private System.Windows.Forms.TextBox textTotalPurchase;
        private System.Windows.Forms.Label labelTotalPurchase;
        private System.Windows.Forms.Label labelQuantityPurchase;
        private System.Windows.Forms.Label labelPricePurchase;
        private System.Windows.Forms.TextBox textQuantityPurchase;
        private System.Windows.Forms.TextBox textPricePurchase;
        private System.Windows.Forms.Label labelItemPurchase;
        private System.Windows.Forms.ComboBox comboItemsPurchase;
        private System.Windows.Forms.Label labelDatePurchase;
        private System.Windows.Forms.Label labelItemIDPurchase;
        private System.Windows.Forms.DateTimePicker datePurchase;
        private System.Windows.Forms.TextBox textItemIDPurchase;
        private System.Windows.Forms.Label labelMoveIDSales;
        private System.Windows.Forms.TextBox textMoveIDSales;
        private System.Windows.Forms.ComboBox comboTypeSales;
        private System.Windows.Forms.Label labelTypeSales;
        private System.Windows.Forms.Button buttonSaveSales;
        private System.Windows.Forms.TextBox textTotalSales;
        private System.Windows.Forms.Label labelTotalSales;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelPriceSales;
        private System.Windows.Forms.TextBox textQuantitySales;
        private System.Windows.Forms.TextBox textPriceSales;
        private System.Windows.Forms.Label labelItemsSales;
        private System.Windows.Forms.ComboBox comboItemsSales;
        private System.Windows.Forms.Label labelDateSales;
        private System.Windows.Forms.Label labelItemIDSales;
        private System.Windows.Forms.DateTimePicker dateSales;
        private System.Windows.Forms.TextBox textItemIDSales;
        private System.Windows.Forms.Button buttonDeleteAllStock;
        private System.Windows.Forms.DataGridView gridPurchase;
        private System.Windows.Forms.Button buttonNewStock;
        private System.Windows.Forms.DataGridView gridSales;
        private System.Windows.Forms.Button buttonDeletePurchase;
        private System.Windows.Forms.Button buttonDeleteSales;
        private System.Windows.Forms.Button buttonNewPurchase;
        private System.Windows.Forms.Button buttonNewSales;
        private TabControl tabMain;
        private TabPage tabStock;
        private TabPage tabPurchase;
        private TabPage tabSales;
        private TabPage tabSearch;
        private Button buttonSearch;
        private DataGridView gridSearch;
        private TextBox textSearchKeyword;
        private Button buttonUpdatePurchase;
        private Button buttonUpdateSales;
        private MenuStrip mainMenu;
        private ToolStripMenuItem miniSpecialistMenu;
        private ToolStripMenuItem exitMenu;
        private TabPage tabReports;
        private DataGridView gridReports;
        private Label labelSearchMovesPurchase;
        private ComboBox comboSearchMovesPurchase;
        private Label labelSearchMovesSales;
        private ComboBox comboSearchMovesSales;
        private MiniSpecialist.MiniSpecialistDataSet MiniSpecialistDataSet;
        private ComboBox comboSearchTables;
        private Label labelSearchIn;
        private Label labelSearchBy;
        private ComboBox comboSearchColumns;
        private RadioButton radioSearchByMovesDate;
        private Label labelSearchDateTo;
        private DateTimePicker dateSearchMovesTo;
        private DateTimePicker dateSearchMovesFrom;
        private Label labelSearchDateFrom;
        private RadioButton radioSearchByKeyword;
        private ToolStripMenuItem logMenu;
        private ToolStripMenuItem debugMenu;
        private ToolStripMenuItem restartMenu;
        private ToolStripMenuItem disableDBMenu;
        private Button buttonDeleteAllPurchase;
        private Button buttonDeleteAllSales;
        private ComboBox comboReports;
        private ToolStripMenuItem resetSettingsMenu;
        private ToolStripMenuItem checkAvailableStockMenu;
        private TabPage tabEmployees;
        private Button buttonDeleteAllEmployee;
        private Button buttonUpdateEmployee;
        private Button buttonNewEmployee;
        private Button buttonDeleteEmployee;
        private DataGridView gridEmployees;
        private Label labelEmployeeID;
        private TextBox textEmployeeIDEmployee;
        private Button buttonSaveEmployee;
        private TextBox textSSNEmployee;
        private Label labelEmployeeSSN;
        private Label labelEmployeePhone;
        private Label labelEmployeeEmail;
        private TextBox textEmailEmployee;
        private TextBox textPhoneEmployee;
        private Label labelEmployeeName;
        private Label labelEmployeeBirthDate;
        private Label labelEmployeeAddress;
        private DateTimePicker dateBirthDateEmployee;
        private TextBox textAddressEmployee;
        private TabPage tabAttendance;
        private TextBox textNameEmployee;
        private BindingSource employeesBindingSource;
        private MiniSpecialist.MiniSpecialistDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private BindingSource overviewBindingSource;
        private MiniSpecialist.MiniSpecialistDataSetTableAdapters.OverviewTableAdapter overviewTableAdapter;
        private BindingSource storeInBindingSource;
        private MiniSpecialist.MiniSpecialistDataSetTableAdapters.Store_InTableAdapter store_InTableAdapter;
        private BindingSource storeOutBindingSource;
        private MiniSpecialist.MiniSpecialistDataSetTableAdapters.Store_OutTableAdapter store_OutTableAdapter;
        private DataGridViewTextBoxColumn iDPurchaseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn itemIDPurchaseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn itemNamePurchaseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pricePurchaseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityPurchaseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPurchaseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn moveIDPurchaseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn moveTypePurchaseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn moveDatePurchaseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDSalesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn itemIDSalesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn itemNameSalesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceSalesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantitySalesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalSalesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn moveIDSalesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn moveTypeSalesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn moveDateSalesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDEmployeesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameEmployeesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressEmployeesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneEmployeesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailEmployeesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthDateEmployeesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sSNEmployeesDataGridViewTextBoxColumn;
        private System.ComponentModel.BackgroundWorker bg;
        private ToolStripMenuItem dataAtOnceMenu;
        private Button buttonEmplloyeeSignAttendance;
        private Label labelAttendanceTime;
        private Label labelEmployeeIDAttendance;
        private Label labelEmployeeNameAttendance;
        private TextBox textEmployeeIDAttendance;
        private ComboBox comboEmployeeNamesAttendance;
        private DataGridView gridAttendance;
        private Label label1;
        private Timer timerTime;
        private Button buttonPrintReports;
    }
}