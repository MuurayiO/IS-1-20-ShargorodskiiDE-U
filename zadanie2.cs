using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IS_1_20_ShargorodskiiDE_U
{
    public partial class zadanie2 : Form
    {
        public zadanie2()
        {
            InitializeComponent();
        }

        class SQL
        {
            public MySqlConnection connectionBD()
            {
                string host = "chuc.caseum.ru";
                string port = "33333";
                string user = "uchebka";
                string bd = "uchebka";
                string password = "uchebka";
                string connStr = $"server={host};port={port};user={user};database={bd};password={password};";
                MySqlConnection conn = new MySqlConnection(connStr);
                return conn;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SQL sql = new SQL();

            try
            {
                sql.connectionBD().Open();
            }
            catch
            {
                MessageBox.Show("Ошибка при подключении к базе данных!");
            }
            finally
            {
                MessageBox.Show("Подключение прошло успешно!");
                sql.connectionBD().Close();
            }
        }
    }
}
