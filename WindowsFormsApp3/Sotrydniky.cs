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
    public partial class Sotrydniky : Form
    {
        public Sotrydniky()
        {
            InitializeComponent();
        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.аптекаDataSet1);

        }

        private void Sotrydniky_Load(object sender, EventArgs e)
        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet1.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter1.Fill(this.аптекаDataSet1.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.аптекаDataSet.Сотрудники);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource1.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (сотрудникиDataGridView.RowCount > 1)
            {
                сотрудникиBindingSource1.RemoveCurrent();
                this.Validate();
                this.сотрудникиBindingSource1.EndEdit();
            }
            else
            {
                string message = "Строки отсутсвуют";
                DialogResult result = MessageBox.Show(message);
            }
        }
          private void button2_Click(object sender, EventArgs e)
            {
                сотрудникиBindingSource1.MoveNext();
            }

        private void button4_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource1.AddNew();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.сотрудникиTableAdapter1.Update(this.аптекаDataSet1.Сотрудники);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
