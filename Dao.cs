using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace StudentManagementByCSharp
{
    class Dao
    {
        public MySqlConnection connect()
        {  

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=student_management_db";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);                  
            databaseConnection.Open();
            return databaseConnection;

        }

        public MySqlCommand command(string sql)
        {
            
            MySqlCommand commandDatabase = new MySqlCommand(sql, connect());
            return commandDatabase;
            
        }
        public int Execute(string sql)
        {
            return command(sql).ExecuteNonQuery();
        }
        public int Execute(string sql, IEnumerable<MySqlParameter> pp)
        {
            var cmd = command(sql);

            foreach (var item in pp)
            {
                cmd.Parameters.Add(item);
            }
            return cmd.ExecuteNonQuery();
        }

        public MySqlDataReader read(string sql)
        {
            return command(sql).ExecuteReader();
        }

        public MySqlDataReader read(string sql, IEnumerable<MySqlParameter> pp)
        {
            var cmd = command(sql);

            foreach (var item in pp)
            {
                cmd.Parameters.Add(item);
              }

            return cmd.ExecuteReader();
        }
    }
}
