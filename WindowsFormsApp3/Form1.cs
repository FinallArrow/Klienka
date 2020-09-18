using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        int role;
        public Form1(int _r)
        {
            InitializeComponent();
            role = _r;
            switch(role)
            {
                case 1:
                    button1.Visible = true;
                    break;
                case 2:
                    button1.Visible = true;
                    button2.Visible = true;
                    button4.Visible = true;
                    button5.Visible = true;
                    button6.Visible = true;
                    button7.Visible = true;
                    button8.Visible = true;
                    button9.Visible = true;
                    button10.Visible = true;
                    button12.Visible = false;
                    button13.Visible = true;
                    button14.Visible = true;
                    button15.Visible = true;
                    button16.Visible = true;
                    button17.Visible = true;
                    button18.Visible = true;
                    button19.Visible = true;
                    break;
                case 3:
                    button1.Visible = true;
                    button2.Visible = false;

                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    button8.Visible = false;
                    button9.Visible = false;
                    button10.Visible = false;
                    button12.Visible = false;
                    button13.Visible = false;
                    button14.Visible = false;
                    button15.Visible = false;
                    button16.Visible = false;
                    button17.Visible = false;
                    button18.Visible = false;
                    button19.Visible = false;
                    button20.Visible = false;
                    button21.Visible = false;
                    break;

                default:
                    break;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lekarstva a = new Lekarstva();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tip_Lekarstva a = new Tip_Lekarstva();
            a.Show();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Yslovia_hronenya a = new Yslovia_hronenya();
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Zayavka a = new Zayavka();
            a.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Zakazi_Lecarstv a = new Zakazi_Lecarstv();
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Kryticheskaya_norma a = new Kryticheskaya_norma();
            a.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Diagnoz a = new Diagnoz();
            a.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Vrach a = new Vrach();
            a.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Vidacha_Lecarstv a = new Vidacha_Lecarstv();
            a.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Vid_diagnoza a = new Vid_diagnoza();
            a.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Statistika_medicomentov a = new Statistika_medicomentov();
            a.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Spravochniky_zakazov a = new Spravochniky_zakazov();
            a.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Spravochnik_tehnologiy a = new Spravochnik_tehnologiy();
            a.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Sposob_Prigotovlenya a = new Sposob_Prigotovlenya();
            a.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Sotrydniky a = new Sotrydniky();
            a.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Sklad a = new Sklad();
            a.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Regystratyra a = new Regystratyra();
            a.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Recept a = new Recept();
            a.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Pacient a = new Pacient();
            a.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Ingridienty a = new Ingridienty();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Izgotovlenie_lekarstv a = new Izgotovlenie_lekarstv();
            a.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Filtracia_lekarstv a = new Filtracia_lekarstv();
            a.Show();
        }
    }
}
