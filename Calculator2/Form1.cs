using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Калькулятор : Form
    {
        public Калькулятор()
        {
            InitializeComponent();
        }

        double x = 0, y = 0, r = 0;                                     // Об'ява змінних обрахунку
        char m = 'a';                                                   // Об'ява змінної знаку

        private void Калькулятор_Load(object sender, EventArgs e)       // Стартова загрузка 
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)   // Текстова строка
        {
        }

        private void button2_Click(object sender, EventArgs e)          // Цифрові клавіші
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button17_Click(object sender, EventArgs e)         // Очищення
        {
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)         // Видалення останнього символу
        {
            if (textBox1.Text != "")
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length -1, 1 );
        }

        private void button15_Click(object sender, EventArgs e)         // Дії
        {
            try
            {
                x = Convert.ToDouble(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Введіть число!!!");
            }
            m = (sender as Button).Text[0];
            textBox1.Clear();
            if (m == '%')
            {
                r = x / 100;
                textBox1.Text = r.ToString();
            }
        }

        private void button18_Click(object sender, EventArgs e)         // Обрахунок результату
        {
            try
            {
                y = Convert.ToDouble(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Введіть число!!!");
            }
            switch (m)
            {
                case '÷':
                    if (y == 0)
                        MessageBox.Show("Неможна ділить на нуль!!!");
                    else
                        r = x / y;
                    break;
                case '×':
                    r = x * y;
                    break;
                case '-':
                    r = x - y;
                    break;
                case '+':
                    r = x + y;
                    break;
                default:
                    break;
            }
            textBox1.Text = r.ToString();
        }
    }
}