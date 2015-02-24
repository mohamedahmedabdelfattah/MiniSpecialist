using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using NLog;

namespace MiniSpecialist
{
    public class DataAccessLayer
    {

        #region Global Variables

        private static Logger logger = LogManager.GetLogger("DataAccessLayer");

        private int rowsAffected = -1;

        #region SQL Attributes

        private static string connection = Properties.Settings.Default.ConnectionString;

        private static SqlConnection sqlconnection = new SqlConnection(connection);

        private SqlCommand command = new SqlCommand("", sqlconnection);

        private SqlDataReader reader = null;

        private DataTable dtable = new DataTable();

        #endregion

        #endregion

        #region Methods

        public string Connection
        {
            get { return Connection; }
            set { this.Connection = value; }
        }

        public void Clear()
        {
            if (dtable != null)
                dtable = new DataTable();
        }

        #endregion

        #region No Return Execution

        public void Exec(string query)
        {
            SqlConnection disableDBConnection = new SqlConnection("Data Source=.;Integrated Security=True;Connect Timeout=10;");

            SqlCommand disableDBCommand = new SqlCommand(query, sqlconnection);

            try
            {
                disableDBCommand.Connection = disableDBConnection;

                disableDBCommand.CommandType = CommandType.Text;

                disableDBConnection.Open();

                disableDBCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                logger.LogException(LogLevel.Error, "[Method:Exec] " + ex.Message, ex);

                throw;
            }
            finally
            {
                disableDBConnection.Close();
            }
        }

        #endregion

        #region Select

        public string AvailableStock(int itemID)
        {
            string result = null;

            command.CommandText = "_CanSell";

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ItemID", itemID);

            try
            {
                sqlconnection.Open();

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    result = reader["Credit"].ToString();
                }

                return result;
            }
            catch (Exception ex)
            {
                logger.LogException(LogLevel.Error, "[Method:AvailableStock] " + ex.Message, ex);

                throw;
            }
            finally
            {
                command.Parameters.Clear();

                reader.Close();

                sqlconnection.Close();
            }
        }

        public string[] Get(string query, string column)
        {
            var resultlist = new ArrayList();

            command.CommandText = query;

            command.CommandType = CommandType.Text;

            try
            {
                sqlconnection.Open();

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    resultlist.Add(reader[column].ToString());
                }

                resultlist.TrimToSize();

                string[] result = new string[resultlist.Count];

                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = (string)resultlist[i];
                }

                return result;
            }
            catch (Exception ex)
            {
                logger.LogException(LogLevel.Error, "[Method:Get] " + ex.Message, ex);

                throw;
            }
            finally
            {
                sqlconnection.Close();
            }
        }

        public string GetValue(string query, string column)
        {
            string result = null;

            command.CommandText = query;

            command.CommandType = CommandType.Text;

            try
            {
                sqlconnection.Open();

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    result = reader[column].ToString();
                }

                return result;
            }
            catch (Exception ex)
            {
                logger.LogException(LogLevel.Error, "[Method:GetValue] " + ex.Message, ex);

                throw;
            }
            finally
            {
                sqlconnection.Close();
            }
        }

        public DataTable GetReport(string reportName)
        {
            try
            {
                SqlDataAdapter dAdapter = new SqlDataAdapter(reportName, connection);

                Clear();

                dAdapter.Fill(dtable);

                return dtable;
            }
            catch (Exception ex)
            {
                logger.LogException(LogLevel.Error, "[Method:GetReport] " + ex.Message, ex);

                throw;
            }
        }

        public DataTable Search(string query)
        {
            try
            {
                SqlDataAdapter dAdapter = new SqlDataAdapter(query, connection);

                Clear();

                dAdapter.Fill(dtable);

                return dtable;
            }
            catch (Exception ex)
            {
                logger.LogException(LogLevel.Error, "[Method:Search] " + ex.Message, ex);

                throw;
            }
        }

        #endregion

        #region Insert

        public bool AddItem(int id, string name, string price)
        {
            command.CommandText = "_InsertItems";

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ID", id);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Price", price);

            try
            {
                sqlconnection.Open();

                rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                logger.LogException(LogLevel.Error, "[Method:AddItem] " + ex.Message, ex);

                throw;
            }
            finally
            {
                command.Parameters.Clear();

                sqlconnection.Close();
            }
        }

        public bool AddMoves(string operation, int id, string name, float price, string quantity, string total, int moveID, string type, DateTime date)
        {
            if (operation == "In")
                command.CommandText = "_InsertPurchaseMove";
            else
                command.CommandText = "_InsertSalesMove";

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ID", id);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Price", price);
            command.Parameters.AddWithValue("@Quantity", quantity);
            command.Parameters.AddWithValue("@Total", total);
            command.Parameters.AddWithValue("@MoveID", moveID);
            command.Parameters.AddWithValue("@Type", type);
            command.Parameters.AddWithValue("@Date", date);

            try
            {
                sqlconnection.Open();

                rowsAffected = command.ExecuteNonQuery();

                sqlconnection.Close();

                if (rowsAffected > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                logger.LogException(LogLevel.Error, "[Method:AddMoves] " + ex.Message, ex);

                throw;
            }
            finally
            {
                command.Parameters.Clear();

                sqlconnection.Close();
            }
        }

        public bool AddEmployee(string name, string address, string phone, string email, DateTime date, string ssn)
        {
            command.CommandText = "_InsertEmployee";

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Date", date);
            command.Parameters.AddWithValue("@SSN", ssn);

            try
            {
                sqlconnection.Open();

                rowsAffected = command.ExecuteNonQuery();

                sqlconnection.Close();

                if (rowsAffected > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                logger.LogException(LogLevel.Error, "[Method:AddEmployee] " + ex.Message, ex);

                throw;
            }
            finally
            {
                command.Parameters.Clear();

                sqlconnection.Close();
            }
        }

        #endregion

        #region Update

        public bool UpdateItem(int id, string newName, string newprice)
        {
            command.CommandText = "_UpdateItems";

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ID", id);
            command.Parameters.AddWithValue("@NewName", newName);
            command.Parameters.AddWithValue("@Price", newprice);

            try
            {
                sqlconnection.Open();

                rowsAffected = command.ExecuteNonQuery();

                sqlconnection.Close();

                if (rowsAffected > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                logger.LogException(LogLevel.Error, "[Method:UpdateItem] " + ex.Message, ex);

                throw;
            }
            finally
            {
                command.Parameters.Clear();

                sqlconnection.Close();
            }
        }

        public bool UpdateMoves(string operation, int id, int newItemID, string newName, float newPrice, string newQuantity, string newTotal, string newType)
        {
            command.CommandText = "_UpdateStore" + operation;

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ID", id);
            command.Parameters.AddWithValue("@Item_ID", newItemID);
            command.Parameters.AddWithValue("@Name", newName);
            command.Parameters.AddWithValue("@Price", newPrice);
            command.Parameters.AddWithValue("@Quantity", newQuantity);
            command.Parameters.AddWithValue("@Total", newTotal);
            command.Parameters.AddWithValue("@Type", newType);

            try
            {
                sqlconnection.Open();

                rowsAffected = command.ExecuteNonQuery();

                sqlconnection.Close();

                if (rowsAffected > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                logger.LogException(LogLevel.Error, "[Method:UpdateMoves] " + ex.Message, ex);

                throw;
            }
            finally
            {
                command.Parameters.Clear();

                sqlconnection.Close();
            }
        }

        public bool UpdateEmployee(int employeeID, string newname, string newaddress, string newphone, string newemail, DateTime newdate, string newssn)
        {
            command.CommandText = "_UpdateEmployee";

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ID", employeeID);
            command.Parameters.AddWithValue("@Name", newname);
            command.Parameters.AddWithValue("@Address", newaddress);
            command.Parameters.AddWithValue("@Phone", newphone);
            command.Parameters.AddWithValue("@Email", newemail);
            command.Parameters.AddWithValue("@Date", newdate);
            command.Parameters.AddWithValue("@SSN", newssn);

            try
            {
                sqlconnection.Open();

                rowsAffected = command.ExecuteNonQuery();

                sqlconnection.Close();

                if (rowsAffected > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                logger.LogException(LogLevel.Error, "[Method:UpdateEmployee] " + ex.Message, ex);

                throw;
            }
            finally
            {
                command.Parameters.Clear();

                sqlconnection.Close();
            }
        }

        #endregion

        #region Delete

        public bool Delete(string keyValue, string operation)
        {
            switch (operation)
            {
                case "Purchase":
                    command.CommandText = "_DeleteStore_InMoves";
                    break;

                case "Sale":
                    command.CommandText = "_DeleteStore_OutMoves";
                    break;

                case "Employee":
                    command.CommandText = "_DeleteEmployee";
                    break;

                default:
                    command.CommandText = "_DeleteItems";
                    break;
            }

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@KeyValue", keyValue);

            try
            {
                sqlconnection.Open();

                rowsAffected = command.ExecuteNonQuery();

                sqlconnection.Close();

                if (rowsAffected > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                logger.LogException(LogLevel.Error, "[Method:Delete] " + ex.Message, ex);

                throw;
            }
            finally
            {
                command.Parameters.Clear();

                sqlconnection.Close();
            }
        }

        #endregion

        public bool SignEmployee(string employeeID, string date, string time)
        {
            throw new NotImplementedException();
        }
    }
}