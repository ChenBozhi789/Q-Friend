using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MyQQ
{
    internal class DataOperator
    {
        // Database connection String
        private static string ConnString = @"Data Source=OMEN; Database=MyQQ;Integrated Security=True";
        // The actual connection object
        public static SqlConnection connection = new SqlConnection(ConnString);

        // 获取查询结果的第一行第一列的值。
        public int ExecSQL(string sql)
        {
            // "sql" means the query will be executed
            // "connection" means database connection object
            SqlCommand cmd = new SqlCommand(sql, connection);

            // If database state is closed, open database connecttion
            if (connection.State == ConnectionState.Closed)
                connection.Open();

            // Execute Query
            // ExecuteScalar type of return is object, so convert to Int and store it in num
            // 使用 cmd.ExecuteScalar() 方法执行 SQL 查询，并获取查询结果的第一行第一列的值。
            int num = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();
            return num;
        }

        public int ExecSQLResult(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql,connection);
            if (connection.State == ConnectionState.Closed)
                connection.Open();

            // 用于执行一个 SQL 语句，该语句对数据库执行 INSERT, UPDATE, DELETE 操作，或其他不返回结果集的 SQL 语句（如创建表、修改表结构等）。
            // ExecuteNonQuery 方法返回一个整数，表示受影响的行数
            int result = cmd.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        public DataSet GetDataSet(string sql)
        {
            // SqlDataAdapter：用于填充 DataSet 和更新数据源的数据适配器。
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, connection);
            // DataSet：一个内存中的数据缓存，类似于一个数据库，它包含一个或多个表。
            DataSet ds = new DataSet();
            sqlda.Fill(ds);
            return ds;
        }
    }
}
