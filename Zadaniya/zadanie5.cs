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
using ConnectDB;

namespace IS_1_20_ShargorodskiiDE_U
{
    public partial class zadanie5 : Form
    {
        public zadanie5()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        string connStr = "server=chuc.caseum.ru;port=33333;user=st_1_20_31;database=is_1_20_st31_KURS;password=14639122;";
        MySqlConnection conn;

        private void zadanie5_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(connStr);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlCommand command = new MySqlCommand($"INSERT INTO t_Uchebka_Shargorodskii (`fioStud`, `datetimeStud`) VALUES (@fio, @datetime);", conn);

                command.Parameters.Add("@fio", MySqlDbType.VarChar).Value = fio.Text;
                command.Parameters.Add("@datetime", MySqlDbType.VarChar).Value = datetime.Text;

                conn.Open();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Запись добавлена");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка добавления");
            }
            finally
            {
                conn.Close();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand command = new MySqlCommand($"SELECT * FROM t_Uchebka_Shargorodskii;", conn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int grid = guna2DataGridView1.Rows.Add();
                guna2DataGridView1.Rows[grid].Cells[0].Value = reader[0].ToString();
                guna2DataGridView1.Rows[grid].Cells[1].Value = reader[1].ToString();
                guna2DataGridView1.Rows[grid].Cells[2].Value = DateTime.Parse(reader[2].ToString());
            }

            reader.Close();
        }
    }
}
