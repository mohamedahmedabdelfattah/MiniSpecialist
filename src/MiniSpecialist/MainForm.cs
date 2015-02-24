using System;
using System.IO;
using System.Windows.Forms;
using NLog;

namespace MiniSpecialist
{
    public partial class MainForm : Form
    {

        #region Constructor

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Global Variables

        private static Logger logger = LogManager.GetLogger("MainForm");

        private BusinessLayer businessLayer = new BusinessLayer();

        /// <summary>
        /// timer Init, log msgs and streamReader to open log file
        /// </summary>
        string msg = "", newMsg = "";
        MessageBoxIcon ico;
        private StreamReader streamReader;
        private FileStream fileStream;

        enum tabs
        {
            Stock,
            Purchase,
            Sale,
            Search,
            Reports,
            Employees,
            Attendance
        };

        #endregion

        #region Form

        private void MainForm_Load(object sender, EventArgs e)
        {
            Logging("Application Initialized");

            logInitilization();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.DisableDB)
            {
                disableDBMenu.Checked = true;

                Logging("[WARN] DisableDB isOn");
            }

            if (Properties.Settings.Default.DataAtOnce)
            {
                dataAtOnceMenu.Checked = true;

                CheckForIllegalCrossThreadCalls = false;

                if (!disableDBMenu.Checked)
                {
                    Logging("[INFO] Data @ Once isOn");

                    bg.RunWorkerAsync();
                }
                else
                    Logging("[WARN] Can't retrieve data, disableDB isOn");
            }
            else
            {
                GetItems(tabs.Stock);

                textNameStock.Focus();

                Logging("[INFO] Data @ Once isOff");
            }
        }

        private void MiniSpecialist_Deactivate(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logging("Application Terminated");
        }

        #endregion

        #region Menu

        private void dataAtOnceMenu_Click(object sender, EventArgs e)
        {
            if (dataAtOnceMenu.Checked)
            {
                Properties.Settings.Default.DataAtOnce = false;

                dataAtOnceMenu.Checked = false;

                Logging("[INFO] Data @ Once isOff");
            }
            else
            {
                Properties.Settings.Default.DataAtOnce = true;

                dataAtOnceMenu.Checked = true;

                Logging("[INFO] Data @ Once isOn");
            }

            Properties.Settings.Default.Save();
        }

        private void checkAvailableStockMenu_Click(object sender, EventArgs e)
        {
            if (checkAvailableStockMenu.Checked)
            {
                checkAvailableStockMenu.Checked = false;

                businessLayer.CHECK_FOR_STOCK_BEFORE_SALE = false;

                Logging("[INFO] CHECK_FOR_STOCK_BEFORE_SALE isOff");
            }
            else
            {
                checkAvailableStockMenu.Checked = true;

                businessLayer.CHECK_FOR_STOCK_BEFORE_SALE = true;

                Logging("[INFO] CHECK_FOR_STOCK_BEFORE_SALE isON");
            }
        }

        private void logOpenMenu_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Application.StartupPath + "\\" + Application.ProductName + ".log");
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void disableDBMenu_Click(object sender, EventArgs e)
        {
            if (disableDBMenu.Checked)
            {
                businessLayer.DisableDB(true);

                Properties.Settings.Default.DisableDB = false;

                disableDBMenu.Checked = false;

                Logging("[INFO] DisableDB isOff");
            }
            else
            {
                businessLayer.DisableDB(false);

                Properties.Settings.Default.DisableDB = true;

                disableDBMenu.Checked = true;

                Logging("[WARN] DisableDB isOn");
            }

            Properties.Settings.Default.Save();
        }

        private void resetSettingsMenu_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();

            Properties.Settings.Default.Save();

            dataAtOnceMenu.Checked = Properties.Settings.Default.DataAtOnce;
            disableDBMenu.Checked = Properties.Settings.Default.DisableDB;

            Logging("[INFO] Settings Reset Completed");
        }

        private void RestartMenu_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Methods

        private void Clear(TabPage tab)
        {
            if (tab == tabStock)
            {
                Clear(textNameStock, textPriceStock, textItemIDStock);

                comboItemsStock.Items.Clear();

                comboItemsStock.SelectedIndex = -1;

                textItemIDStock.Text = businessLayer.GetItemIDNew();
            }

            if (tab == tabSales)
            {
                Clear(textItemIDSales, textQuantitySales, textTotalSales, textPriceSales);

                comboItemsPurchase.Items.Clear();

                gridSales.ClearSelection();

                comboItemsSales.SelectedIndex = -1;
                comboTypeSales.SelectedIndex = -1;

                comboSearchMovesSales.Items.Add("All");
                comboSearchMovesSales.SelectedIndex = 0;

                textMoveIDSales.Text = businessLayer.GetMoveIDNew("Sale");
            }

            if (tab == tabPurchase)
            {
                Clear(textItemIDPurchase, textQuantityPurchase, textTotalPurchase, textPricePurchase);

                comboItemsSales.Items.Clear();

                gridPurchase.ClearSelection();

                comboItemsPurchase.SelectedIndex = -1;
                comboTypePurchase.SelectedIndex = -1;

                comboSearchMovesPurchase.Items.Add("All");
                comboSearchMovesPurchase.SelectedIndex = 0;

                textMoveIDPurchase.Text = businessLayer.GetMoveIDNew("Purchase");
            }

            if (tab == tabSearch)
            {
                textSearchKeyword.Text = "";

                gridSearch.DataSource = null;

                comboSearchColumns.Enabled = false;

                comboSearchTables.SelectedIndex = -1;
            }

            if (tab == tabReports)
            {
                comboReports.Items.Clear();

                gridReports.DataSource = null;

                comboReports.SelectedIndex = -1;
            }

            if (tab == tabEmployees)
            {
                Clear(textNameEmployee, textAddressEmployee, textPhoneEmployee, textEmailEmployee, textSSNEmployee);

                gridEmployees.ClearSelection();

                textEmployeeIDEmployee.Text = businessLayer.GetEmployeeIDNew();
            }

            if (tab == tabAttendance)
            {
                Clear(textEmployeeIDAttendance);

                comboEmployeeNamesAttendance.Items.Clear();

                gridAttendance.ClearSelection();

                comboEmployeeNamesAttendance.SelectedIndex = -1;
            }

            errorEmpty.Clear();
        }

        private void Clear(params TextBox[] texts)
        {
            foreach (TextBox txt in texts)
            {
                txt.Text = "";
            }
        }

        private void GetItems(tabs operation)
        {
            switch (operation)
            {
                case tabs.Stock:
                    {
                        comboItemsStock.Items.Clear();

                        object[] items = businessLayer.GetItems();

                        if (items.Length == 0)
                        {
                            textItemIDStock.Text = "1";

                            comboItemsStock.Enabled = false;
                        }
                        else
                        {
                            comboItemsStock.Enabled = true;

                            comboItemsStock.Items.AddRange(items);

                            textItemIDStock.Text = businessLayer.GetItemIDNew();
                        }

                        break;
                    }

                case tabs.Purchase:
                    {
                        comboItemsPurchase.Items.Clear();

                        textMoveIDPurchase.Text = businessLayer.GetMoveIDNew("Purchase");

                        comboItemsPurchase.Items.AddRange(businessLayer.GetItems());

                        break;
                    }

                case tabs.Sale:
                    {
                        comboItemsSales.Items.Clear();

                        textMoveIDSales.Text = businessLayer.GetMoveIDNew("Sale");

                        comboItemsSales.Items.AddRange(businessLayer.GetItems());

                        break;
                    }

                case tabs.Reports:
                    {
                        comboReports.Items.Clear();

                        comboReports.Items.AddRange(businessLayer.GetAllReports());

                        break;
                    }

                case tabs.Attendance:
                    {
                        comboEmployeeNamesAttendance.Items.Clear();

                        comboEmployeeNamesAttendance.Items.AddRange(businessLayer.GetEmployees());

                        break;
                    }
            }
        }

        private void FillData(tabs operation, DataGridView grid)
        {
            // try catch to encapsulate miniSpecialistDataSet
            try
            {
                ComboBox combo = new ComboBox();
                int specialIDColumnIndex = -1;

                if (operation == tabs.Sale)
                {
                    combo = comboSearchMovesSales;

                    specialIDColumnIndex = grid.Columns.IndexOf(moveIDSalesDataGridViewTextBoxColumn);

                    if (combo.SelectedIndex == 0)
                        store_OutTableAdapter.Fill(MiniSpecialistDataSet.Store_Out);
                    else
                        store_OutTableAdapter.FillByMoveID(MiniSpecialistDataSet.Store_Out, combo.SelectedIndex);
                }

                if (operation == tabs.Purchase)
                {
                    combo = comboSearchMovesPurchase;

                    specialIDColumnIndex = grid.Columns.IndexOf(moveIDPurchaseDataGridViewTextBoxColumn);

                    if (combo.SelectedIndex == 0)
                        store_InTableAdapter.Fill(MiniSpecialistDataSet.Store_In);
                    else
                        store_InTableAdapter.FillByMoveID(MiniSpecialistDataSet.Store_In, combo.SelectedIndex);
                }

                if (operation == tabs.Employees)
                {
                    employeesTableAdapter.Fill(MiniSpecialistDataSet.Employees);
                }

                if (operation == tabs.Purchase || operation == tabs.Sale)
                {
                    for (int i = 0; i < grid.Rows.Count; i++)
                    {
                        if (!combo.Items.Contains(grid[specialIDColumnIndex, i].Value.ToString()))
                            combo.Items.Add(grid[specialIDColumnIndex, i].Value.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Logging("[ERROR] [Method:GetMoves] " + ex.Message + ex.ToString());
            }
        }

        #endregion

        #region tabStock

        private void tabStock_Enter(object sender, EventArgs e)
        {
            Clear(tabStock);

            textNameStock.Focus();

            GetItems(tabs.Stock);
        }

        private void buttonNewStock_Click(object sender, EventArgs e)
        {
            Clear(tabStock);
        }

        private void buttonSaveStock_Click(object sender, EventArgs e)
        {
            errorEmpty.Clear();

            foreach (string s in comboItemsStock.Items)
            {
                if (textNameStock.Text.Equals(s, StringComparison.OrdinalIgnoreCase))
                {
                    errorEmpty.SetError(buttonSaveStock, "Item already exists");
                    return;
                }
            }

            if (textNameStock.Text == "")
            {
                errorEmpty.SetError(textNameStock, "Item Name can't be empty");
                return;
            }

            if (textPriceStock.Text == "")
            {
                errorEmpty.SetError(textPriceStock, "Item Price can't be empty");
                return;
            }

            errorEmpty.Clear();

            if (businessLayer.AddItem(int.Parse(textItemIDStock.Text), textNameStock.Text, Math.Round(float.Parse(textPriceStock.Text), 2).ToString()))
            {
                Clear(textNameStock, textPriceStock, textItemIDStock);

                comboItemsStock.Text = "";

                textNameStock.Focus();

                GetItems(tabs.Stock);
            }
        }

        private void buttonUpdateStock_Click(object sender, EventArgs e)
        {
            errorEmpty.Clear();

            if (comboItemsStock.Items.Count != 0)
            {
                if (comboItemsStock.SelectedIndex == -1)
                {
                    errorEmpty.SetError(comboItemsStock, "Select an Item first");
                    return;
                }

                if (textNameStock.Text == "")
                {
                    errorEmpty.SetError(textNameStock, "Item Name can't be empty");
                    return;
                }

                if (textPriceStock.Text == "")
                {
                    errorEmpty.SetError(textPriceStock, "Item Price can't be empty");
                    return;
                }

                errorEmpty.Clear();

                if (businessLayer.UpdateItem(int.Parse(textItemIDStock.Text), textNameStock.Text, Math.Round(float.Parse(textPriceStock.Text), 2).ToString()))
                {
                    Clear(textNameStock, textPriceStock);

                    GetItems(tabs.Stock);
                }
            }
        }

        private void buttonDeleteStock_Click(object sender, EventArgs e)
        {
            errorEmpty.Clear();

            if (comboItemsStock.Items.Count != 0)
            {
                if (comboItemsStock.Text != "")
                {
                    if (businessLayer.Delete(comboItemsStock.SelectedItem.ToString(), ""))
                    {
                        Clear(textNameStock, textPriceStock, textItemIDStock);

                        comboItemsStock.SelectedIndex = -1;

                        GetItems(tabs.Stock);
                    }
                }
                else
                    errorEmpty.SetError(comboItemsStock, "Select an Item first");
            }
        }

        private void buttonDeleteAllStock_Click(object sender, EventArgs e)
        {
            errorEmpty.Clear();

            if (comboItemsStock.Items.Count != 0)
            {
                if (MessageBox.Show(this, "Delete All Stock Items?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    foreach (string s in comboItemsStock.Items)
                    {
                        businessLayer.Delete(s, "");
                    }

                    Clear(textNameStock, textPriceStock, textItemIDStock);

                    comboItemsStock.Items.Clear();

                    comboItemsStock.Enabled = false;

                    textItemIDStock.Text = businessLayer.GetItemIDNew();
                }
            }
        }

        private void text_All_Stock_TextChanged(object sender, EventArgs e)
        {
            errorEmpty.Clear();
        }

        #endregion

        #region tabPurchase

        private void tabPurchase_Enter(object sender, EventArgs e)
        {
            Clear(tabPurchase);

            GetItems(tabs.Purchase);

            FillData(tabs.Purchase, gridPurchase);
        }

        private void buttonNewPurchase_Click(object sender, EventArgs e)
        {
            Clear(tabPurchase);
        }

        private void buttonSavePurchase_Click(object sender, EventArgs e)
        {
            errorEmpty.Clear();

            if (comboItemsPurchase.Text == "")
            {
                errorEmpty.SetError(comboItemsPurchase, "Item Name can't be empty");
                return;
            }

            if (textQuantityPurchase.Text == "")
            {
                errorEmpty.SetError(textQuantityPurchase, "Quantity can't be empty");
                return;
            }

            if (comboTypePurchase.Text == "")
            {
                errorEmpty.SetError(comboTypePurchase, "Type can't be empty");
                return;
            }

            errorEmpty.Clear();

            if (businessLayer.AddMoves("In", int.Parse(textItemIDPurchase.Text), comboItemsPurchase.SelectedItem.ToString(), float.Parse(textPricePurchase.Text), Math.Round(float.Parse(textQuantityPurchase.Text), 2).ToString(), textTotalPurchase.Text, int.Parse(textMoveIDPurchase.Text), comboTypePurchase.SelectedItem.ToString(), datePurchase.Value))
            {
                Clear(tabPurchase);

                FillData(tabs.Purchase, gridPurchase);
            }
        }

        private void buttonUpdatePurchase_Click(object sender, EventArgs e)
        {
            errorEmpty.Clear();

            if (gridPurchase.Rows.GetRowCount(DataGridViewElementStates.Selected) != 0)
            {
                if (textQuantityPurchase.Text == "")
                {
                    errorEmpty.SetError(textQuantityPurchase, "Quantity can't be empty");
                    return;
                }

                if (businessLayer.UpdateMoves("In", int.Parse(gridPurchase[0, gridPurchase.Rows.IndexOf(gridPurchase.SelectedRows[0])].Value.ToString()), int.Parse(textItemIDPurchase.Text), comboItemsPurchase.SelectedItem.ToString(), float.Parse(textPricePurchase.Text), Math.Round(float.Parse(textQuantityPurchase.Text), 2).ToString(), textTotalPurchase.Text, comboTypePurchase.SelectedItem.ToString()))
                {
                    Clear(tabPurchase);

                    FillData(tabs.Purchase, gridPurchase);
                }
            }
            else
                errorEmpty.SetError(buttonUpdatePurchase, "Select an Item first");
        }

        private void buttonDeletePurchase_Click(object sender, EventArgs e)
        {
            errorEmpty.Clear();

            if (gridPurchase.Rows.GetRowCount(DataGridViewElementStates.Selected) == 0)
            {
                errorEmpty.SetError(buttonDeletePurchase, "Select an Item first");
                return;
            }

            errorEmpty.Clear();

            int RowIndex = gridPurchase.Rows.IndexOf(gridPurchase.SelectedRows[0]);

            if (businessLayer.Delete(gridPurchase[0, RowIndex].Value.ToString(), "Purchase"))
            {
                Clear(tabPurchase);

                FillData(tabs.Purchase, gridPurchase);
            }
        }

        private void buttonDeleteAllPurchase_Click(object sender, EventArgs e)
        {
            errorEmpty.Clear();

            if (gridPurchase.Rows.Count != 0)
            {
                if (MessageBox.Show(this, "Delete All Purchase Moves?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    for (int i = 0; i < gridPurchase.Rows.Count; i++)
                    {
                        businessLayer.Delete(gridPurchase[0, i].Value.ToString(), "Purchase");
                    }
                }

                Clear(tabPurchase);

                FillData(tabs.Purchase, gridPurchase);
            }
        }

        private void gridPurchase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int RowIndex = gridPurchase.Rows.IndexOf(gridPurchase.SelectedRows[0]);
                textItemIDPurchase.Text = gridPurchase[1, RowIndex].Value.ToString();
                comboItemsPurchase.SelectedItem = gridPurchase[2, RowIndex].Value.ToString();
                textPricePurchase.Text = gridPurchase[3, RowIndex].Value.ToString();
                textQuantityPurchase.Text = gridPurchase[4, RowIndex].Value.ToString();
                textTotalPurchase.Text = gridPurchase[5, RowIndex].Value.ToString();
                textMoveIDPurchase.Text = gridPurchase[6, RowIndex].Value.ToString();
                comboTypePurchase.Text = gridPurchase[7, RowIndex].Value.ToString();
                datePurchase.Value = (DateTime)gridPurchase[8, RowIndex].Value;
            }
        }

        #endregion

        #region tabSales

        private void tabSales_Enter(object sender, EventArgs e)
        {
            Clear(tabSales);

            GetItems(tabs.Sale);

            FillData(tabs.Sale, gridSales);
        }

        private void buttonNewSales_Click(object sender, EventArgs e)
        {
            Clear(tabSales);
        }

        private void buttonSaveSales_Click(object sender, EventArgs e)
        {
            errorEmpty.Clear();

            if (comboItemsSales.Text == "")
            {
                errorEmpty.SetError(comboItemsSales, "Item Name can't be empty");
                return;
            }

            if (textQuantitySales.Text == "")
            {
                errorEmpty.SetError(textQuantitySales, "Quantity can't be empty");
                return;
            }

            if (comboTypeSales.Text == "")
            {
                errorEmpty.SetError(comboTypeSales, "Type can't be empty");
                return;
            }

            errorEmpty.Clear();

            if (businessLayer.CHECK_FOR_STOCK_BEFORE_SALE)
            {
                if (float.Parse(textQuantitySales.Text) > businessLayer.AvailableStock(int.Parse(textItemIDSales.Text)))
                {
                    MessageBox.Show(this, "You have " + businessLayer.AvailableStock(int.Parse(textItemIDSales.Text)).ToString() + " units of " + comboItemsSales.SelectedItem.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (businessLayer.AddMoves("Out", int.Parse(textItemIDSales.Text), comboItemsSales.SelectedItem.ToString(), float.Parse(textPriceSales.Text), Math.Round(float.Parse(textQuantitySales.Text), 2).ToString(), textTotalSales.Text, int.Parse(textMoveIDSales.Text), comboTypeSales.SelectedItem.ToString(), dateSales.Value))
            {
                Clear(tabSales);

                FillData(tabs.Sale, gridSales);
            }
        }

        private void buttonUpdateSales_Click(object sender, EventArgs e)
        {
            errorEmpty.Clear();

            if (gridSales.Rows.GetRowCount(DataGridViewElementStates.Selected) != 0)
            {
                if (textQuantitySales.Text == "")
                {
                    errorEmpty.SetError(textQuantitySales, "Quantity can't be empty");
                    return;
                }

                if (businessLayer.CHECK_FOR_STOCK_BEFORE_SALE)
                {
                    if (float.Parse(textQuantitySales.Text) > businessLayer.AvailableStock(int.Parse(textItemIDSales.Text)) + float.Parse(gridSales[4, gridSales.Rows.IndexOf(gridSales.SelectedRows[0])].Value.ToString()))
                    {
                        MessageBox.Show(this, "You have " + businessLayer.AvailableStock(int.Parse(textItemIDSales.Text)).ToString() + " units of " + comboItemsSales.SelectedItem.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (businessLayer.UpdateMoves("Out", int.Parse(gridSales[0, gridSales.Rows.IndexOf(gridSales.SelectedRows[0])].Value.ToString()), int.Parse(textItemIDSales.Text), comboItemsSales.SelectedItem.ToString(), float.Parse(textPriceSales.Text), Math.Round(float.Parse(textQuantitySales.Text), 2).ToString(), textTotalSales.Text, comboTypeSales.SelectedItem.ToString()))
                {
                    Clear(tabSales);

                    FillData(tabs.Sale, gridSales);
                }
            }
            else
                errorEmpty.SetError(buttonUpdateSales, "Select an Item first");
        }

        private void buttonDeleteSales_Click(object sender, EventArgs e)
        {
            errorEmpty.Clear();

            if (gridSales.Rows.GetRowCount(DataGridViewElementStates.Selected) == 0)
            {
                errorEmpty.SetError(buttonDeleteSales, "Select an Item first");
                return;
            }

            errorEmpty.Clear();

            int RowIndex = gridSales.Rows.IndexOf(gridSales.SelectedRows[0]);

            if (businessLayer.Delete(gridSales[0, RowIndex].Value.ToString(), "Sale"))
            {
                Clear(tabSales);

                FillData(tabs.Sale, gridSales);
            }
        }

        private void buttonDeleteAllSales_Click(object sender, EventArgs e)
        {
            errorEmpty.Clear();

            if (gridSales.Rows.Count != 0)
            {
                if (MessageBox.Show(this, "Delete All Sales Moves?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    for (int i = 0; i < gridSales.Rows.Count; i++)
                    {
                        businessLayer.Delete(gridSales[0, i].Value.ToString(), "Sale");
                    }

                    Clear(tabSales);

                    FillData(tabs.Sale, gridSales);
                }
            }
        }

        private void gridSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int RowIndex = gridSales.Rows.IndexOf(gridSales.SelectedRows[0]);
                textItemIDSales.Text = gridSales[1, RowIndex].Value.ToString();
                comboItemsSales.SelectedItem = gridSales[2, RowIndex].Value.ToString();
                textPriceSales.Text = gridSales[3, RowIndex].Value.ToString();
                textQuantitySales.Text = gridSales[4, RowIndex].Value.ToString();
                textTotalSales.Text = gridSales[5, RowIndex].Value.ToString();
                textMoveIDSales.Text = gridSales[6, RowIndex].Value.ToString();
                comboTypeSales.Text = gridSales[7, RowIndex].Value.ToString();
                dateSales.Value = (DateTime)gridSales[8, RowIndex].Value;
            }
        }

        #endregion

        #region tabSearch

        private void tabSearch_Enter(object sender, EventArgs e)
        {
            Clear(tabSearch);

            if (!radioSearchByKeyword.Checked && !radioSearchByMovesDate.Checked)
                buttonSearch.Enabled = false;
        }

        private void textSearchKeyword_TextChanged(object sender, EventArgs e)
        {
            if (textSearchKeyword.Text == "" || comboSearchTables.SelectedIndex == -1)
                buttonSearch.Enabled = false;
            else
                buttonSearch.Enabled = true;
        }

        private void comboSearchTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboSearchColumns.Items.Clear();

            if (textSearchKeyword.Text == "")
                buttonSearch.Enabled = false;
            else
                buttonSearch.Enabled = true;

            if (comboSearchTables.SelectedIndex > -1)
            {
                if (comboSearchTables.SelectedItem.ToString() == "Items")
                {
                    string[] strItems = new string[] { "ID", "Name", "Price" };
                    comboSearchColumns.Items.AddRange(strItems);
                }
                else
                {
                    if (comboSearchTables.SelectedItem.ToString() == "Employees")
                    {
                        string[] strEmployees = new string[] { "EmployeeID", "Name", "Address", "Phone", "Email", "BirthDate", "SSN" };
                        comboSearchColumns.Items.AddRange(strEmployees);
                    }
                    else
                    {
                        if (comboSearchTables.SelectedItem.ToString() == "Store_In" || comboSearchTables.SelectedItem.ToString() == "Store_Out")
                        {
                            string[] strStore = new string[] { "ID", "Item_ID", "Move_ID", "Item_Name", "Price", "Quantity", "Total", "Move_Type", "Move_Date" };
                            comboSearchColumns.Items.AddRange(strStore);
                        }
                        else
                            throw new NotImplementedException();
                    }
                }
            }
            else
                buttonSearch.Enabled = false;

            comboSearchColumns.Enabled = true;
        }

        private void radioSearchByKeyword_CheckedChanged(object sender, EventArgs e)
        {
            if (textSearchKeyword.Text == "" || comboSearchTables.SelectedIndex == -1)
                buttonSearch.Enabled = false;
            else
                buttonSearch.Enabled = true;

            if (radioSearchByKeyword.Checked)
            {
                radioSearchByMovesDate.Checked = false;
                textSearchKeyword.Enabled = true;
                comboSearchTables.Enabled = true;

                comboSearchTables.Items.Clear();
                string[] tables = businessLayer.Get("SELECT name FROM MiniSpecialist.sys.tables WHERE lob_data_space_id =0", "name");
                comboSearchTables.Items.AddRange(tables);
            }
            else
            {
                radioSearchByMovesDate.Checked = true;
                textSearchKeyword.Enabled = false;
                comboSearchTables.Enabled = false;
            }
        }

        private void radioSearchByMovesDate_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSearchByMovesDate.Checked)
            {
                radioSearchByKeyword.Checked = false;
                dateSearchMovesFrom.Enabled = true;
                dateSearchMovesTo.Enabled = true;
                buttonSearch.Enabled = true;
            }
            else
            {
                radioSearchByKeyword.Checked = true;
                dateSearchMovesFrom.Enabled = false;
                dateSearchMovesTo.Enabled = false;
                buttonSearch.Enabled = false;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // try catch used to encapsulate miniSpecialistDataSet
            try
            {
                if (radioSearchByMovesDate.Checked)
                {
                    MiniSpecialistDataSet.OverviewDataTable mdtable = new MiniSpecialistDataSet.OverviewDataTable();

                    overviewTableAdapter.FillByMovesDate(mdtable, dateSearchMovesFrom.Value, dateSearchMovesTo.Value);

                    gridSearch.DataSource = mdtable;
                }
                else
                {
                    string searchQuery = null;

                    int SearchtextToNumber = 0;

                    int.TryParse(textSearchKeyword.Text, out SearchtextToNumber);

                    if (comboSearchColumns.SelectedIndex == -1)
                    {
                        if (comboSearchTables.SelectedItem.ToString() == "Items")
                            searchQuery = "SELECT * FROM Items WHERE Name LIKE '%" + textSearchKeyword.Text + "%' OR ID LIKE " + SearchtextToNumber + " OR Price LIKE " + SearchtextToNumber;
                        else if (comboSearchTables.SelectedItem.ToString() == "Store_In")
                            searchQuery = "SELECT * FROM Store_In WHERE Item_ID LIKE '%" + SearchtextToNumber + "%' OR Item_Name LIKE '%" + textSearchKeyword.Text + "%' OR Move_ID LIKE '%" + SearchtextToNumber + "%'";
                        else if (comboSearchTables.SelectedItem.ToString() == "Store_Out")
                            searchQuery = "SELECT * FROM Store_Out WHERE Item_ID LIKE '%" + SearchtextToNumber + "%' OR Item_Name LIKE '%" + textSearchKeyword.Text + "%' OR Move_ID LIKE '%" + SearchtextToNumber + "%'";
                        else if (comboSearchTables.SelectedItem.ToString() == "Employees")
                            searchQuery = "SELECT * FROM Employees WHERE EmployeeID LIKE '%" + SearchtextToNumber + "%' OR Name LIKE '%" + textSearchKeyword.Text + "%' OR SSN LIKE '%" + SearchtextToNumber + "%'";
                    }
                    else
                        searchQuery = "SELECT * FROM " + comboSearchTables.SelectedItem.ToString() + " WHERE " + comboSearchColumns.SelectedItem.ToString() + " LIKE '%" + textSearchKeyword.Text + "%'";

                    if (textSearchKeyword.Text != "")
                        gridSearch.DataSource = businessLayer.Search(searchQuery); ;
                }
            }
            catch (Exception ex)
            {
                Logging("[ERROR][" + sender.ToString() + "] " + ex.Message + ex.ToString());
            }
        }

        #endregion

        #region tabReports

        private void tabReports_Enter(object sender, EventArgs e)
        {
            Clear(tabReports);

            comboReports.Focus();

            GetItems(tabs.Reports);
        }

        private void buttonPrintReports_Click(object sender, EventArgs e)
        {
            new ReportsForm().Show();
        }

        private void comboReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridReports.DataSource = null;

            if (comboReports.SelectedIndex > -1)
            {
                try
                {
                    gridReports.DataSource = businessLayer.GetReportByName(comboReports.SelectedItem.ToString());
                }
                catch (Exception ex)
                {
                    Logging("[ERROR] [" + sender.ToString() + "] " + ex.Message + ex.ToString());
                }
            }
        }

        #endregion

        #region tabEmployees

        private void tabEmployees_Enter(object sender, EventArgs e)
        {
            Clear(tabEmployees);

            FillData(tabs.Employees, gridEmployees);
        }

        private void buttonNewEmployee_Click(object sender, EventArgs e)
        {
            Clear(tabEmployees);
        }

        private void buttonSaveEmployee_Click(object sender, EventArgs e)
        {
            errorEmpty.Clear();

            if (textNameEmployee.Text == "")
            {
                errorEmpty.SetError(textNameEmployee, "Employee Name can't be empty");
                return;
            }

            if (textEmailEmployee.Text != "")
            {
                if (!businessLayer.IsEmail(textEmailEmployee.Text))
                {
                    errorEmpty.SetError(textEmailEmployee, "Syntax error");
                    return;
                }
            }

            errorEmpty.Clear();

            if (businessLayer.AddEmployee(textNameEmployee.Text, textAddressEmployee.Text, textPhoneEmployee.Text, textEmailEmployee.Text, dateBirthDateEmployee.Value, textSSNEmployee.Text))
            {
                Clear(tabEmployees);

                FillData(tabs.Employees, gridEmployees);
            }
        }

        private void buttonUpdateEmployee_Click(object sender, EventArgs e)
        {
            errorEmpty.Clear();

            if (gridEmployees.Rows.GetRowCount(DataGridViewElementStates.Selected) != 0)
            {
                if (textNameEmployee.Text == "")
                {
                    errorEmpty.SetError(textNameEmployee, "Name can't be empty");
                    return;
                }

                if (businessLayer.UpdateEmployee(int.Parse(gridEmployees[0, gridEmployees.Rows.IndexOf(gridEmployees.SelectedRows[0])].Value.ToString()), textNameEmployee.Text, textAddressEmployee.Text, textPhoneEmployee.Text, textEmailEmployee.Text, dateBirthDateEmployee.Value, textSSNEmployee.Text))
                {
                    Clear(tabEmployees);

                    FillData(tabs.Employees, gridEmployees);
                }
            }
            else
                errorEmpty.SetError(buttonUpdateEmployee, "Select an Employee first");
        }

        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {
            errorEmpty.Clear();

            if (gridEmployees.Rows.GetRowCount(DataGridViewElementStates.Selected) == 0)
            {
                errorEmpty.SetError(buttonDeleteEmployee, "Select an Employee first");
                return;
            }

            int RowIndex = gridEmployees.Rows.IndexOf(gridEmployees.SelectedRows[0]);

            if (businessLayer.Delete(gridEmployees[0, RowIndex].Value.ToString(), "Employee"))
            {
                Clear(tabEmployees);

                FillData(tabs.Employees, gridEmployees);
            }
        }

        private void buttonDeleteAllEmployee_Click(object sender, EventArgs e)
        {
            errorEmpty.Clear();

            if (gridEmployees.Rows.Count != 0)
            {
                if (MessageBox.Show(this, "Delete All Employees?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    for (int i = 0; i < gridEmployees.Rows.Count; i++)
                    {
                        businessLayer.Delete(gridEmployees[0, i].Value.ToString(), "Employee");
                    }

                    Clear(tabEmployees);

                    FillData(tabs.Employees, gridEmployees);
                }
            }
        }

        private void gridEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int RowIndex = gridEmployees.Rows.IndexOf(gridEmployees.SelectedRows[0]);
                textNameEmployee.Text = gridEmployees[1, RowIndex].Value.ToString();
                textEmployeeIDEmployee.Text = gridEmployees[0, RowIndex].Value.ToString();
                textAddressEmployee.Text = gridEmployees[2, RowIndex].Value.ToString();
                textPhoneEmployee.Text = gridEmployees[3, RowIndex].Value.ToString();
                textEmailEmployee.Text = gridEmployees[4, RowIndex].Value.ToString();
                dateBirthDateEmployee.Value = (DateTime)gridEmployees[5, RowIndex].Value;
                textSSNEmployee.Text = gridEmployees[6, RowIndex].Value.ToString();
            }
        }

        #endregion

        #region tabAttendance

        private void tabAttendance_Enter(object sender, EventArgs e)
        {
            Clear(tabAttendance);

            GetItems(tabs.Attendance);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            labelAttendanceTime.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
        }

        private void textEmployeeIDAttendance_TextChanged(object sender, EventArgs e)
        {
            errorEmpty.Clear();

            if (textEmployeeIDAttendance.Text.Length > 0)
            {
                comboEmployeeNamesAttendance.SelectedItem = businessLayer.GetEmployeeNameByID(int.Parse(textEmployeeIDAttendance.Text));

                if (comboEmployeeNamesAttendance.SelectedIndex == -1)
                    errorEmpty.SetError(textEmployeeIDAttendance, "Employee doesn't exist");
            }
            else
                comboEmployeeNamesAttendance.SelectedIndex = -1;
        }

        private void comboEmployeeNamesAttendance_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorEmpty.Clear();

            if (comboEmployeeNamesAttendance.SelectedIndex > -1)
            {
                textEmployeeIDAttendance.Text = businessLayer.GetEmployeeID(comboEmployeeNamesAttendance.SelectedItem.ToString());
            }
        }

        private void buttonEmplloyeeSignAttendance_Click(object sender, EventArgs e)
        {
            // For testing only
            errorEmpty.Clear();

            if (comboEmployeeNamesAttendance.SelectedItem == null || textEmployeeIDAttendance.Text == "")
            {
                errorEmpty.SetError(comboEmployeeNamesAttendance, "Select an employee first or manually enter an ID");
                return;
            }

            if (businessLayer.SignEmployee(textEmployeeIDAttendance.Text, DateTime.Now.ToLongDateString(), DateTime.Now.ToShortTimeString()))
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        /// <summary>
        /// Shared Events between tabs
        /// </summary>
        #region MultiUse

        private void comboItems_All_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorEmpty.Clear();

            if (((ComboBox)sender).SelectedIndex > -1)
            {
                switch (((ComboBox)sender).Name)
                {
                    case "comboItemsStock":
                        {
                            textNameStock.Text = comboItemsStock.SelectedItem.ToString();

                            textItemIDStock.Text = businessLayer.GetItemID(comboItemsStock.SelectedItem.ToString());

                            textPriceStock.Text = businessLayer.GetItemPrice(comboItemsStock.SelectedItem.ToString());

                            break;
                        }

                    case "comboItemsPurchase":
                        {
                            textItemIDPurchase.Text = businessLayer.GetItemID(comboItemsPurchase.SelectedItem.ToString());

                            textPricePurchase.Text = businessLayer.GetItemPrice(comboItemsPurchase.SelectedItem.ToString());

                            float resultPurchase = 0;

                            float.TryParse(textQuantityPurchase.Text, out resultPurchase);

                            if (textQuantityPurchase.Text != "" && comboItemsPurchase.SelectedIndex != -1 && resultPurchase != 0)
                                textTotalPurchase.Text = (float.Parse(textPricePurchase.Text) * float.Parse(textQuantityPurchase.Text)).ToString();

                            break;
                        }

                    case "comboItemsSales":
                        {
                            textItemIDSales.Text = businessLayer.GetItemID(comboItemsSales.SelectedItem.ToString());

                            textPriceSales.Text = businessLayer.GetItemPrice(comboItemsSales.SelectedItem.ToString());

                            float resultSales = 0;

                            float.TryParse(textQuantitySales.Text, out resultSales);

                            if (textQuantitySales.Text != "" && comboItemsSales.SelectedIndex != -1 && resultSales != 0)
                                textTotalSales.Text = (float.Parse(textPriceSales.Text) * float.Parse(textQuantitySales.Text)).ToString();

                            break;
                        }
                }
            }
        }

        private void comboFindByID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMain.SelectedTab == tabPurchase)
                FillData(tabs.Purchase, gridPurchase);
            else
            {
                if (tabMain.SelectedTab == tabSales)
                    FillData(tabs.Sale, gridSales);
                else
                    FillData(tabs.Employees, gridEmployees);
            }
        }

        private void text_All_Quantity_TextChanged(object sender, EventArgs e)
        {
            errorEmpty.Clear();

            TextBox quantity = (TextBox)sender;

            if (quantity.Text != "")
            {
                string quantityValue = quantity.Text;

                if (textQuantityPurchase.Text.Contains("."))
                {
                    if ((quantity.Text.IndexOf('.') + 2) <= quantity.Text.Length)
                        quantityValue = quantity.Text.Substring(0, quantity.Text.IndexOf('.') + 3);
                    else if ((quantity.Text.IndexOf('.') + 1) <= quantity.Text.Length)
                        quantityValue = quantity.Text.Substring(0, quantity.Text.IndexOf('.') + 2);
                    else
                        quantityValue = quantity.Text.Substring(0, quantity.Text.IndexOf('.'));
                }
                else
                    quantityValue = quantity.Text;

                float totalResult = 0;

                float.TryParse(quantityValue, out totalResult);

                if (totalResult != 0)
                {
                    if (quantity == textQuantityPurchase)
                    {
                        if (textPricePurchase.Text != "")
                            textTotalPurchase.Text = (float.Parse(textPricePurchase.Text) * float.Parse(quantityValue)).ToString();
                        else
                            textTotalPurchase.Text = "";
                    }
                    else
                    {
                        if (textPriceSales.Text != "")
                            textTotalSales.Text = (float.Parse(textPriceSales.Text) * float.Parse(quantityValue)).ToString();
                        else
                            textTotalSales.Text = "";
                    }
                }
            }
        }

        private void text_All_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorEmpty.Clear();

            // Backspace ASCII code = 8
            // Space ASCII code = 32
            if (e.KeyChar != 8 && e.KeyChar != 32)
            {
                if (!businessLayer.IsName(e.KeyChar))
                {
                    errorEmpty.SetError(((TextBox)sender), "Letters Only");
                    e.Handled = true;
                }
            }
            else
            {
                if (((TextBox)sender).Text.Length == 0)
                {
                    errorEmpty.SetError(((TextBox)sender), "Can`t start with a Space");
                    e.Handled = true;
                }
            }
        }

        private void text_All_Numbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorEmpty.Clear();

            // Backspace ASCII code = 8
            if (e.KeyChar != 8)
            {
                if (((TextBox)sender).Text.Length == 0 && (e.KeyChar == '.' || e.KeyChar == '0'))
                {
                    errorEmpty.SetError(((TextBox)sender), "Can`t start with zero or dot");
                    e.Handled = true;
                }
                else
                {
                    if (!businessLayer.IsNumber(e.KeyChar))
                    {
                        if (e.KeyChar != '.')
                        {
                            errorEmpty.SetError(((TextBox)sender), "Numbers Only");
                            e.Handled = true;
                        }
                        else
                        {
                            if (((TextBox)sender).Text.Contains("."))
                            {
                                errorEmpty.SetError(((TextBox)sender), "Can't use multiple dots");
                                e.Handled = true;
                            }
                        }
                    }
                }
            }
        }

        private void grid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ((DataGridView)sender).ClearSelection();
        }

        #endregion

        /// <summary>
        /// Implementation of Data@Once
        /// </summary>
        #region Background Data Load

        private void bg_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            GetItems(tabs.Stock);
            GetItems(tabs.Purchase);
            GetItems(tabs.Sale);
            GetItems(tabs.Reports);
            GetItems(tabs.Attendance);

            FillData(tabs.Purchase, gridPurchase);
            FillData(tabs.Sale, gridSales);
            FillData(tabs.Employees, gridEmployees);
        }

        private void bg_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = true;
        }

        #endregion

        #region Logging

        private void logInitilization()
        {
            fileStream = new FileStream(Application.StartupPath + "\\" + Application.ProductName + ".log", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            streamReader = new StreamReader(fileStream);

            timerTime.Tick += new EventHandler(timer_Tick);
        }

        /// <summary>
        /// Logging to MiniSpecialist.log
        /// </summary>
        public void Logging(string logMsg)
        {
            if (logMsg.StartsWith("[INFO]"))
                logger.Info(logMsg.Substring(7) + Environment.NewLine);
            else if (logMsg.StartsWith("[WARN]"))
                logger.Warn(logMsg.Substring(7) + Environment.NewLine);
            else if (logMsg.StartsWith("[ERROR]"))
                logger.Error(logMsg.Substring(7) + Environment.NewLine);
            else
                logger.Trace(logMsg + Environment.NewLine);
        }

        /// <summary>
        /// timer_tick to view log
        /// </summary>
        private void timer_Tick(object sender, EventArgs e)
        {
            newMsg = streamReader.ReadToEnd().TrimEnd();

            if (msg != newMsg && !newMsg.Contains("Application Initialized"))
            {
                if (newMsg.Contains("TRACE"))
                    ico = MessageBoxIcon.Exclamation;
                else if (newMsg.Contains("INFO"))
                    ico = MessageBoxIcon.Information;
                else if (newMsg.Contains("WARN"))
                    ico = MessageBoxIcon.Warning;
                else if (newMsg.Contains("ERROR"))
                    ico = MessageBoxIcon.Error;
                else ico = MessageBoxIcon.Hand;

                MessageBox.Show(newMsg, "log", MessageBoxButtons.OK, ico);

                msg = newMsg;
            }
        }

        #endregion

    }
}