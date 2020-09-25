using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16laboratory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double k = 0.02;
        Random rnd = new Random();
        double price;
        int i;
        double money, euro;
        double q = 0.04;
        double ov = 0.2;
        double t = 0.1;

      

     
        private void button1_Calculate_Click(object sender, EventArgs e)
        {
            i = 1;
            money = 1000;
            euro = 0;
            chart1.Series[0].Points.Clear();
            chart1.ChartAreas[0].AxisX.Maximum = 10;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            price = (double)inputPrice.Value;
            chart1.Series[0].Points.AddXY(0, price);
            timer1.Start();
        }

        private void button2_Buy_Click(object sender, EventArgs e)
        {
            if (money > price)
            {
                money -= price;
                euro++;
                text_box_money.Text = money.ToString("0.00");
                text_box_euro.Text = euro.ToString("0.00");
            }
        }

        private void button3_Sell_Click(object sender, EventArgs e)
        {
            if (euro > 0)
            {
                euro--;
                money += price;
                text_box_money.Text = money.ToString("0.00");
                text_box_euro.Text = euro.ToString("0.00");
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            double a = Math.Exp(t * (q - ov * ov * 0.5));
            double b = ov * Math.Sqrt(t);
            price = price * a * Math.Exp(b * (rnd.NextDouble() - 0.5));
            //t += 2;
            //price = price * (1 + k * (rnd.NextDouble() - 0.5));
            chart1.Series[0].Points.AddXY(i, price);
            i++;
            if (i > 8)//сдвиг графика
            {
                chart1.ChartAreas[0].AxisX.Minimum = i - 8;
                chart1.ChartAreas[0].AxisX.Maximum = i + 2;
            }
            if (i - 1 == MaxDays.Value)//закончились игровые дни
                timer1.Stop();
            text_box_money.Text = money.ToString("0.00");
            text_box_euro.Text = euro.ToString("0.00");
            Days.Text = (i - 1).ToString();
        }
    }
}
