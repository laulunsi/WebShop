using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WebShop_
{
    class DB
    {
        private static SqlConnection dbCon;

        public static SqlConnection getConnection(string DBName, string uName, string uPassword)
        {
            dbCon = new SqlConnection("server=.;database=" + DBName + ";uid=" + uName + ";pwd=" + uPassword);
            dbCon.Open();
            return dbCon;
        }

        public static int executeUpdate(string updateSql)
        {
            Console.WriteLine(updateSql);
            int affectedRows = 0;
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.Connection = dbCon;
            sqlCom.CommandType = CommandType.Text;
            sqlCom.CommandText = updateSql;
            //执行非查询类的语句和存储过程就用ExecuteNonQuery******************
            affectedRows = sqlCom.ExecuteNonQuery();//执行SQL语句
            return affectedRows;
        }

        public static DataSet executeQuerry(string querrySql)
        {

            //SqlCommand sqlCom = new SqlCommand();
            //sqlCom.Connection = dbCon;
            //sqlCom.CommandType = CommandType.Text;
            //sqlCom.CommandText = querrySql;
            //执行查询类的语句和存储过程就用ExecuteReader**********************
            //SqlDataReader dr = sqlCom.ExecuteReader();//执行SQL语句
            //return dr;

            SqlDataAdapter dataAdapter = new SqlDataAdapter(querrySql, dbCon);
            DataSet searchResult = new DataSet();
            dataAdapter.Fill(searchResult);
            return searchResult;

        }

        public static SqlDataReader executeQuerry1(string querrySql)
        {
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.Connection = dbCon;
            sqlCom.CommandType = CommandType.Text;
            sqlCom.CommandText = querrySql;
            //执行查询类的语句和存储过程就用ExecuteReader**********************
            SqlDataReader dr = sqlCom.ExecuteReader();//执行SQL语句
            return dr;

        }

        public static void releaseConnection()
        {
            dbCon.Close();
        }
    }
}
