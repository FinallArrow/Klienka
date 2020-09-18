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
    public partial class Regystratyra : Form
    {
        public Regystratyra()
        {
            InitializeComponent();
        }

        private void регистратураBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.регистратураBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.аптекаDataSet1);

        }

        private void Regystratyra_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet1.Заказы_лекарств". При необходимости она может быть перемещена или удалена.
            this.заказы_лекарствTableAdapter.Fill(this.аптекаDataSet1.Заказы_лекарств);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet1.Ингридиенты". При необходимости она может быть перемещена или удалена.
            this.ингридиентыTableAdapter1.Fill(this.аптекаDataSet1.Ингридиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet1.Выдача_лекарства". При необходимости она может быть перемещена или удалена.
            this.выдача_лекарстваTableAdapter1.Fill(this.аптекаDataSet1.Выдача_лекарства);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet1.Рецепт". При необходимости она может быть перемещена или удалена.
            this.рецептTableAdapter1.Fill(this.аптекаDataSet1.Рецепт);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet1.Регистратура". При необходимости она может быть перемещена или удалена.
            this.регистратураTableAdapter1.Fill(this.аптекаDataSet1.Регистратура);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet.Ингридиенты". При необходимости она может быть перемещена или удалена.
            this.ингридиентыTableAdapter.Fill(this.аптекаDataSet.Ингридиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet.Рецепт". При необходимости она может быть перемещена или удалена.
            this.рецептTableAdapter.Fill(this.аптекаDataSet.Рецепт);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet.Выдача_лекарства". При необходимости она может быть перемещена или удалена.
            this.выдача_лекарстваTableAdapter.Fill(this.аптекаDataSet.Выдача_лекарства);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet.Лекарства". При необходимости она может быть перемещена или удалена.
            this.лекарстваTableAdapter.Fill(this.аптекаDataSet.Лекарства);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet.Регистратура". При необходимости она может быть перемещена или удалена.
            this.регистратураTableAdapter.Fill(this.аптекаDataSet.Регистратура);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            регистратураBindingSource1.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            регистратураBindingSource1.AddNew();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (регистратураDataGridView.RowCount > 1)
            {
                регистратураBindingSource1.RemoveCurrent();
                this.Validate();
                this.регистратураBindingSource1.EndEdit();
            }
            else
            {
                string message = "Строки отсутсвуют";
                DialogResult result = MessageBox.Show(message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
            {
            this.регистратураTableAdapter1.Update(this.аптекаDataSet1.Регистратура);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            регистратураBindingSource1.MoveNext();
        }

        private void регистратураDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

