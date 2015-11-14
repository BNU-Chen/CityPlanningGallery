using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;
using System.Xml.Serialization;

namespace CityPlanningGallery
{
    public class clsAccessDatabase
    {
        // Set Access connection and select strings.
            // The path to BugTypes.MDB must be changed if you build 
            // the sample from the command line:

        public static OleDbConnection GetConnection(){

            string mdbPath = clsConfig.AccessDatabasePath;
            string strAccessConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+mdbPath;

            
 
            // Create the dataset and add the Categories table to it:
            OleDbConnection myAccessConn = null;
            try
            {
                  myAccessConn = new OleDbConnection(strAccessConn);
            }
            catch(Exception ex)
            {
                  Console.WriteLine("Error: Failed to create a database connection. \n{0}", ex.Message);
                  return myAccessConn;
            }
            return myAccessConn;
 
        }
        /// <summary>
        /// 获取数据库所有数据表
        /// </summary>
        /// <returns>所有数据表的DataTable</returns>
        public static DataTable GetDatabaseSchema()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TABLE_CATALOG", System.Type.GetType("System.String"));
            dt.Columns.Add("TABLE_SCHEMA", System.Type.GetType("System.String"));
            dt.Columns.Add("TABLE_NAME", System.Type.GetType("System.String"));
            dt.Columns.Add("TABLE_TYPE", System.Type.GetType("System.String"));


            OleDbConnection myAccessConn = GetConnection();

            try
            {

                myAccessConn.Open();
                dt = myAccessConn.GetSchema("TABLES");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Failed to retrieve the required data from the DataBase.\n{0}", ex.Message);
                return dt;
            }
            finally
            {
                myAccessConn.Close();
            }
            return dt;
        }

        /// <summary>
        /// 由表名称获取表数据
        /// </summary>
        /// <param name="tableName">表名称</param>
        /// <returns>表数据</returns>
        public static DataTable GetDataByTableName(string tableName)
        {
            DataTable dt = new DataTable();
            string strAccessSelect = "SELECT * FROM " + tableName;

            OleDbConnection myAccessConn = GetConnection();
            DataSet myDataSet = new DataSet();        
            try
            {
                OleDbCommand myAccessCommand = new OleDbCommand(strAccessSelect, myAccessConn);
                OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(myAccessCommand);
                if (myAccessConn != null)
                {
                    myAccessConn.Open();
                    myDataAdapter.Fill(myDataSet, "TableData");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Failed to retrieve the required data from the DataBase.\n{0}", ex.Message);
                return dt;
            }
            finally
            {
                myAccessConn.Close();
            }
            if (myDataSet.Tables.Count > 0)
            {
                dt = myDataSet.Tables[0];
            }
            return dt;
        }
    }
}
