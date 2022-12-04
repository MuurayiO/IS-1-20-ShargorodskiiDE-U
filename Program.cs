using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_1_20_ShargorodskiiDE_U
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
        class сonnection
        {
            public MySqlConnection connDD()
            {              
                string connStr = "server=chuc.caseum.ru;port=33333;user=st_1_20_2;database=is_1_20_st2_KURS;password=14639122;";
                MySqlConnection conn = new MySqlConnection(connStr);
                return conn;
            }
        }
    }
}
