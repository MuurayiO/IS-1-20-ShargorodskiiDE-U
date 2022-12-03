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
                MessageBox.Show($"Цена: {price}, Год выпуска: {date}, Артикул: {article}");
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
                MessageBox.Show($"Цена: {price}, Год выпуска: {date}, Артикул: {article}, " +
                    $"Количество Оборотов: {turns}, Интерфейс: {interfaceA}, Объем: {size}");
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
                MessageBox.Show($"Цена: {price}, Год выпуска: {date}, Артикул: {article}, Частота GPU: {freqGPU}, " +
                    $"Производитель: {brand}, Объем памяти: {sizeMemory} гб");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            

            double price = Convert.ToDouble(guna2TextBox1.Text);
            int date = Convert.ToInt32(guna2TextBox2.Text);
            string article = guna2TextBox3.Text;
            int turns = Convert.ToInt32(guna2TextBox4.Text);
            string interfaceA = guna2TextBox5.Text;
            int size = Convert.ToInt32(guna2TextBox6.Text);

            hdd = new HardDisk(price, date, article, turns, interfaceA, size);

        }
    }
}
