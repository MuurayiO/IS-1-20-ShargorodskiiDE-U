using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConnectDB
{
    public class connectDB
    {
        string strConn;
        MySqlConnection conn;

        public MySqlConnection Connection()
        {
            conn = new MySqlConnection(strConn);
            return conn;
        }
        public string ReturnConn()
        {
            return strConn;

        }
        public connectDB(string connect)
        {
            strConn = connect;
        }
    }
}
