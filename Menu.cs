using System;
using System.Windows.Forms;

namespace IS_1_20_ShargorodskiiDE_U
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            zadanie1 Zad1 = new zadanie1();
            Zad1.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            zadanie2 Zad2 = new zadanie2();
            Zad2.ShowDialog();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            zadanie3 Zad3 = new zadanie3();
            Zad3.ShowDialog();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            zadanie4 Zad4 = new zadanie4();
            Zad4.ShowDialog();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            zadanie5 Zad5 = new zadanie5();
            Zad5.ShowDialog();
        }
    }

}
