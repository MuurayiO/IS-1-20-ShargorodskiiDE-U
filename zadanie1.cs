using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_1_20_ShargorodskiiDE_U
{
    public partial class zadanie1 : Form
    {
        public zadanie1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        HardDisk hdd;
        GPU gpu;

        public class Device<T>
        {
            public double price;
            public int date;
            public T article;

            public Device(double price, int date, T article)
            {
                this.date = date;
                this.price = price;
                this.article = article;
            }
            public void Display()
            {
                MessageBox.Show($"Цена: {price} \n Год выпуска: {date} \n Артикул: {article}");
            }
        }
        public class HardDisk : Device<string>
        {
            public int turns;
            public string interfaceA;
            public int size;

            public HardDisk(double price, int date, string article, int turns, string interfaceA, int size) : base(price, date, article)
            {
                this.turns = turns;
                this.interfaceA = interfaceA;
                this.size = size;
            }
            public new void Display()
            {
                MessageBox.Show($" Цена: {price} \n Год выпуска: {date} \n Артикул: {article} \n " +
                    $"Количество Оборотов: {turns} \n Интерфейс: {interfaceA} \n Объем: {size}");
            }

        }
        public class GPU: Device<string>
        {
            public double freqGPU;
            public string brand;
            public int sizeMemory;

            public GPU(double price, int date, string article, double freqGPU, string brand, int sizeMemory) : base(price, date, article)
            {
                this.freqGPU = freqGPU;
                this.brand = brand;
                this.sizeMemory = sizeMemory;
            }
            public new void Display()
            {
                MessageBox.Show($" Цена: {price} \n Год выпуска: {date} \n Артикул: {article} \n Частота GPU: {freqGPU} \n " +
                    $"Производитель: {brand} \n Объем памяти: {sizeMemory} гб");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                listBox1.Items.Add($"Цена: {guna2TextBox1.Text}");
                listBox1.Items.Add($"Год выпуска: {guna2TextBox2.Text}");
                listBox1.Items.Add($"Артикул: {guna2TextBox3.Text}");
                listBox1.Items.Add($"Количество оборотов: {guna2TextBox6.Text}");
                listBox1.Items.Add($"Интерфейс: {guna2TextBox5.Text}");
                listBox1.Items.Add($"Объем: {guna2TextBox4.Text}");

                hdd = new HardDisk(Convert.ToInt32(guna2TextBox1.Text), Convert.ToInt32(guna2TextBox2.Text), guna2TextBox3.Text, 
                    Convert.ToInt32(guna2TextBox6.Text), guna2TextBox5.Text, Convert.ToInt32(guna2TextBox4.Text));

                hdd.Display();
            }
            catch
            {
                MessageBox.Show("Заполните поля");
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                listBox1.Items.Add($"Цена: {guna2TextBox1.Text}");
                listBox1.Items.Add($"Год выпуска: {guna2TextBox2.Text}");
                listBox1.Items.Add($"Артикул: {guna2TextBox3.Text}");
                listBox1.Items.Add($"Частота GPU: {guna2TextBox9.Text}");
                listBox1.Items.Add($"Производитель: {guna2TextBox8.Text}");
                listBox1.Items.Add($"Объем памяти: {guna2TextBox7.Text}");

                gpu = new GPU(Convert.ToInt32(guna2TextBox1.Text), Convert.ToInt32(guna2TextBox2.Text), guna2TextBox3.Text, 
                    Convert.ToInt32(guna2TextBox9.Text), guna2TextBox8.Text, Convert.ToInt32(guna2TextBox7.Text));

                gpu.Display();
            }
            catch
            {
                MessageBox.Show("Заполните поля");
            }
        }
    }
}
