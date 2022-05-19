using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ChapeauDAL
{
    public abstract class BaseDao
    {
<<<<<<< HEAD
        private SqlDataAdapter adapter;
        private SqlConnection conn;

        public BaseDao()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SomerenDatabase"].ConnectionString);
            adapter = new SqlDataAdapter();
=======
        private SqlDataAdapter _adapter;
        private SqlConnection _conn;

        public BaseDao()
        {
            _conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ChapeauDatabase"].ConnectionString);
            _adapter = new SqlDataAdapter();
>>>>>>> 8568e1683575d6f53c231608ed3c40b7da1e2191
        }

        protected SqlConnection OpenConnection()
        {
            try
            {
<<<<<<< HEAD
                if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                {
                    conn.Open();
=======
                if (_conn.State == ConnectionState.Closed || _conn.State == ConnectionState.Broken)
                {
                    _conn.Open();
>>>>>>> 8568e1683575d6f53c231608ed3c40b7da1e2191
                }
            }
            catch (Exception e)
            {
<<<<<<< HEAD
                //Print.ErrorLog(e);
                throw;
            }
            return conn;
=======
                Console.WriteLine(e);
                throw;
            }
            return _conn;
>>>>>>> 8568e1683575d6f53c231608ed3c40b7da1e2191
        }

        private void CloseConnection()
        {
<<<<<<< HEAD
            conn.Close();
=======
            _conn.Close();
>>>>>>> 8568e1683575d6f53c231608ed3c40b7da1e2191
        }

        /* For Insert/Update/Delete Queries with transaction */
        protected void ExecuteEditTranQuery(string query, SqlParameter[] sqlParameters, SqlTransaction sqlTransaction)
        {
<<<<<<< HEAD
            SqlCommand command = new SqlCommand(query, conn, sqlTransaction);
            try
            {
                command.Parameters.AddRange(sqlParameters);
                adapter.InsertCommand = command;
=======
            SqlCommand command = new SqlCommand(query, _conn, sqlTransaction);
            try
            {
                command.Parameters.AddRange(sqlParameters);
                _adapter.InsertCommand = command;
>>>>>>> 8568e1683575d6f53c231608ed3c40b7da1e2191
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
<<<<<<< HEAD
                //Print.ErrorLog(e);
=======
                Console.WriteLine(e);
>>>>>>> 8568e1683575d6f53c231608ed3c40b7da1e2191
                throw;
            }
        }

        /* For Insert/Update/Delete Queries */
        protected void ExecuteEditQuery(string query, SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
<<<<<<< HEAD
                adapter.InsertCommand = command;
=======
                _adapter.InsertCommand = command;
>>>>>>> 8568e1683575d6f53c231608ed3c40b7da1e2191
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
<<<<<<< HEAD
                // Print.ErrorLog(e);
=======
                Console.WriteLine(e);
>>>>>>> 8568e1683575d6f53c231608ed3c40b7da1e2191
                throw;
            }
            finally
            {
                CloseConnection();
            }
        }

        /* For Select Queries */
        protected DataTable ExecuteSelectQuery(string query, params SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();
            DataTable dataTable;
            DataSet dataSet = new DataSet();

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                command.ExecuteNonQuery();
<<<<<<< HEAD
                adapter.SelectCommand = command;
                adapter.Fill(dataSet);
=======
                _adapter.SelectCommand = command;
                _adapter.Fill(dataSet);
>>>>>>> 8568e1683575d6f53c231608ed3c40b7da1e2191
                dataTable = dataSet.Tables[0];
            }
            catch (SqlException e)
            {
<<<<<<< HEAD
                //Print.ErrorLog(e);
=======
                Console.WriteLine(e);
                return null;
>>>>>>> 8568e1683575d6f53c231608ed3c40b7da1e2191
                throw;
            }
            finally
            {
                CloseConnection();
            }
            return dataTable;
        }
    }
}
