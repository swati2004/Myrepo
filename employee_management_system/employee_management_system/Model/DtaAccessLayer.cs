#region namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using employee_management_system;
using employee_management_system.Model;
#endregion

namespace employee_management_system
{ 
   public class DataAccessLayer
    {
        #region variable
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        int num;
        object obj;
        DataSet ds;
        DataTable dt;

        #endregion

        #region Fun for open connection
        public void OpenConnection()
        {
            if (con == null)
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
                // sqlConnection.Open();
            }
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        #endregion
        #region fun for datareader
        public SqlDataReader FunSQLDataReader(string query)
        {
            OpenConnection();
            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();
            return dr;
        }
        #endregion
        #region fun for close connection
        public void CloseConnection()
        {
            con.Close();
        }
        #endregion

        #region fun for executeNonQuery
        public int funexecutenonQuery(string command)
        {
            OpenConnection();
            cmd = new SqlCommand(command, con);
            num = cmd.ExecuteNonQuery();
            CloseConnection();
            return num;

        }
        #endregion
        #region fun for datascalar
        public object fundatascaler(string command)
        {
            OpenConnection();
            cmd = new SqlCommand(command, con);
            obj = cmd.ExecuteScalar();
            CloseConnection();
            return obj;

        }
        #endregion
        #region fun for dataset
        public DataSet fundataset(string command)
        {
            OpenConnection();
            cmd = new SqlCommand(command, con);
            da = new SqlDataAdapter();
            ds = new DataSet();
            da.Fill(ds);
            CloseConnection();
            return ds;

        }
        #endregion
        #region fun for datatable
        public DataTable fundataTable(string command)
        {
            OpenConnection();
            cmd = new SqlCommand(command, con);
            da = new SqlDataAdapter();
            dt = new DataTable();
            da.Fill(dt);
            CloseConnection();
            return dt;

        }
        #endregion


        }



    }


















