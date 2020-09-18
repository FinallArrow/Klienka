using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klientka
{
    public partial class Form1 : Form
    {
        public Form1(int role)
            
        {
            InitializeComponent();

            switch (role)
            {

                case 1:
                    button1.Enabled = (true);
                    button2.Enabled = (true);
                    button3.Enabled = (true);
                    button4.Enabled = (true);
                    button5.Enabled = (true);
                    button6.Enabled = (true);
                    button7.Enabled = (true);
                    button8.Enabled = (true);
                    button9.Enabled = (true);
                    button10.Enabled = (true);
                    button11.Enabled = (true);
                    button12.Enabled = (true);
                    button13.Enabled = (true);
                    button14.Enabled = (true);
                    button15.Enabled = (true);
                    button16.Enabled = (true);
                    button17.Enabled = (true);
                    button18.Enabled = (true);
                    button19.Enabled = (true);
                    button20.Enabled = (true);
                    break;
                case 2:
                    button20.Enabled = (true);
                    button14.Enabled = (true);
                    button10.Enabled = (true);
                    button5.Enabled = (true);
                    button13.Enabled = (true);
                    button2.Enabled = (true);
                    button1.Enabled = (true);
                    break;
                case 3:
                    button19.Enabled = (true);
                    button16.Enabled = (true);
                    button9.Enabled = (true);
                    button11.Enabled = (true);
                    button8.Enabled = (true);
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Бригады n = new Бригады();
            n.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Должность n = new Должность();
            n.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Изделия n = new Изделия();
            n.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Инженерно_технический_персонал n = new Инженерно_технический_персонал();
            n.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Испытания n = new Испытания();
            n.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Испытательные_лаборатории n = new Испытательные_лаборатории();
            n.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Категории_изделия n = new Категории_изделия();
            n.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Назначение_в_бригаду n = new Назначение_в_бригаду();
            n.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Оборудование n = new Оборудование();
            n.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Отдел n = new Отдел();
            n.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Поставка n = new Поставка();
            n.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Поставщик n = new Поставщик();
            n.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Приём_на_работу n = new Приём_на_работу();
            n.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Продажа n = new Продажа();
            n.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Работники n = new Работники();
            n.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Работы n = new Работы();
            n.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Склад n = new Склад();
            n.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Тип_изделия n = new Тип_изделия();
            n.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Участки n = new Участки();
            n.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Цеха n = new Цеха();
            n.Show();
        }
    }
}
