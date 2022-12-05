using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;

namespace IS_1_20_ShargorodskiiDE_U
{
    public partial class zadanie3 : Form
    {
        public zadanie3()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        string connStr = "server=chuc.caseum.ru;port=33333;user=st_1_20_31;database=is_1_20_st31_KURS;password=14639122;";
        MySqlConnection conn;

        private void zadanie3_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(connStr);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
            }
            catch
            {
                MessageBox.Show("Ошибка при подключении к базе данных!");
            }
            finally
            {
                MessageBox.Show("Подключение прошло успешно!");
                conn.Close();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                
                MySqlCommand command = new MySqlCommand($"SELECT id_catalog, title_weapon, category_weapon, price_weapon " +
                    $"FROM T_catalog INNER JOIN login_password ON T_catalog.id_catalog;", conn);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int grid = guna2DataGridView1.Rows.Add();
                    guna2DataGridView1.Rows[grid].Cells[0].Value = reader[0].ToString();
                    guna2DataGridView1.Rows[grid].Cells[1].Value = reader[1].ToString();
                    guna2DataGridView1.Rows[grid].Cells[2].Value = reader[2].ToString();
                    guna2DataGridView1.Rows[grid].Cells[3].Value = reader[3].ToString();
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
            string id = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string title = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string category = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string price = guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            MessageBox.Show($" ID: {id} \n Название: {title} \n Категория: {category} \n Цена: {price}");
        }
    }
}
