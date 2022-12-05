using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectDB;
using MySql.Data.MySqlClient;

namespace IS_1_20_ShargorodskiiDE_U
{
    public partial class zadanie4 : Form
    {
        public zadanie4()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        string connStr = "server=chuc.caseum.ru;port=33333;user=st_1_20_31;database=is_1_20_st31_KURS;password=14639122;";
        MySqlConnection conn;

        private void zadanie4_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(connStr);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                MySqlCommand command = new MySqlCommand($"SELECT Fio, Date_of_Birth FROM t_datatime;", conn);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int grid = guna2DataGridView1.Rows.Add();
                    guna2DataGridView1.Rows[grid].Cells[0].Value = reader[0].ToString();
                    guna2DataGridView1.Rows[grid].Cells[1].Value = reader[1].ToString();
                }
                reader.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка получения данных");
            }
            finally
            {
                conn.Close();
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = guna2DataGridView1.SelectedCells[0].RowIndex + 1;

                conn.Open();

                string sql = $"SELECT photoUrl FROM t_datatime WHERE Id = {id}";

                MySqlCommand command = new MySqlCommand(sql, conn);

                string picture = command.ExecuteScalar().ToString();

                guna2PictureBox1.ImageLocation = $"{picture}";

            }

            catch
            {
                MessageBox.Show("Ошибка при получении данных!");
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
