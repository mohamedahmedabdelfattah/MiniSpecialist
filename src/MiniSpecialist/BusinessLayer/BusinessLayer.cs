using System;
using System.Data;
using NLog;

namespace MiniSpecialist
{
    public class BusinessLayer
    {

        #region Global Variables

        private static Logger logger = LogManager.GetLogger("BusinessLayer");

        public bool CHECK_FOR_STOCK_BEFORE_SALE;

        private DataAccessLayer data = new DataAccessLayer();

        #endregion

        #region Methods

        #region General

        public bool IsName(char c)
        {
            if (char.IsLetter(c))
                return true;
            else
                return false;
        }

        public bool IsNumber(char c)
        {
            if (Char.IsNumber(c))
                return true;
            else
                return false;
        }

        public bool IsEmail(string txt)
        {
            if (txt.Contains("@") && txt.Contains("."))
                return true;
            else
                return false;
        }

        public float AvailableStock(int itemID)
        {
            string result = data.AvailableStock(itemID);

            if (result != null)
                return float.Parse(result);
            else
                return 0;
        }

        #endregion

        #region Data

        public void DisableDB(bool disableDB)
        {
            if (disableDB)
                data.Exec("ALTER DATABASE MiniSpecialist SET ONLINE");
            else
                data.Exec("ALTER DATABASE MiniSpecialist SET OFFLINE WITH ROLLBACK IMMEDIATE");
        }

        public string dataConnection
        {
            get { return data.Connection; }
            set { data.Connection = value; }
        }

        public string[] GetItems()
        {
            return data.Get("SELECT Name FROM Items", "Name");
        }

        public string[] GetEmployees()
        {
            return data.Get("SELECT Name FROM Employees", "Name");
        }

        public string GetItemID(string itemName)
        {
            return data.GetValue("SELECT ID FROM Items WHERE Name = '" + itemName + "'", "ID");
        }

        public string GetEmployeeID(string employeeName)
        {
            return data.GetValue("SELECT EmployeeID FROM Employees WHERE Name = '" + employeeName + "'", "EmployeeID");
        }

        public string GetItemIDNew()
        {
            int NumberOfItems = int.Parse(data.GetValue("SELECT COUNT(ID) As ID FROM Items", "ID"));

            if (NumberOfItems > 0)
                return (int.Parse(data.GetValue("SELECT MAX(ID) As ID FROM Items", "ID")) + 1).ToString();
            else
                return "1";
        }

        public string GetMoveIDNew(string operation)
        {
            switch (operation)
            {
                case "Purchase":
                    operation = "In";
                    break;

                case "Sale":
                    operation = "Out";
                    break;
            }

            int newMoveID = 1;

            int.TryParse(data.GetValue("SELECT MAX(Move_ID) As Move_ID FROM Store_" + operation, "Move_ID"), out newMoveID);

            if (newMoveID != -1)
                newMoveID++;

            return newMoveID.ToString();
        }

        public string GetEmployeeIDNew()
        {
            int newEmployeeID = 1;

            int.TryParse(data.GetValue("SELECT MAX(EmployeeID) As EmployeeID FROM Employees", "EmployeeID"), out newEmployeeID);

            if (newEmployeeID != -1)
                newEmployeeID++;

            return newEmployeeID.ToString();
        }

        public string GetItemPrice(string itemName)
        {
            return data.GetValue(" SELECT Price FROM Items WHERE Name = '" + itemName + "'", "Price");
        }

        public string GetEmployeeNameByID(int employeeID)
        {
            return data.GetValue("SELECT Name FROM Employees WHERE EmployeeID = " + employeeID, "Name");
        }

        public string[] GetAllReports()
        {
            return data.Get("SELECT name FROM MiniSpecialist.sys.procedures WHERE name like '%report%'", "name");
        }

        public DataTable GetReportByName(string reportName)
        {
            return data.GetReport(reportName);
        }

        public DataTable Search(string query)
        {
            return data.Search(query);
        }

        #endregion

        #endregion

        #region DataAccess

        public void Exec(string query)
        {
            data.Exec(query);
        }

        public string GetValue(string query, string column)
        {
            return data.GetValue(query, column);
        }

        public string[] Get(string query, string column)
        {
            return data.Get(query, column);
        }

        public bool AddItem(int id, string name, string price)
        {
            return data.AddItem(id, name, price);
        }

        public bool UpdateItem(int id, string newName, string newprice)
        {
            return data.UpdateItem(id, newName, newprice);
        }

        public bool AddMoves(string operation, int id, string name, float price, string quantity, string total, int moveID, string type, DateTime date)
        {
            return data.AddMoves(operation, id, name, price, quantity, total, moveID, type, date);
        }

        public bool UpdateMoves(string operation, int id, int newItemID, string newName, float newPrice, string newQuantity, string newTotal, string newType)
        {
            return data.UpdateMoves(operation, id, newItemID, newName, newPrice, newQuantity, newTotal, newType);
        }

        public bool Delete(string keyValue, string operation)
        {
            return data.Delete(keyValue, operation);
        }

        public bool AddEmployee(string name, string address, string phone, string email, DateTime date, string ssn)
        {
            return data.AddEmployee(name, address, phone, email, date, ssn);
        }

        public bool UpdateEmployee(int employeeID, string newname, string newaddress, string newphone, string newemail, DateTime newdate, string newssn)
        {
            return data.UpdateEmployee(employeeID, newname, newaddress, newphone, newemail, newdate, newssn);
        }

        #endregion

        public bool SignEmployee(string employeeID, string date, string time)
        {
            return data.SignEmployee(employeeID, date, time);
        }
    }
}