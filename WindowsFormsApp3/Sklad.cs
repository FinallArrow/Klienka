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
    public partial class Sklad : Form
    {
        public Sklad()
        {
            InitializeComponent();
        }

        private void складBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.складBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.аптекаDataSet1);

        }

        private void Sklad_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet1.Лекарства". При необходимости она может быть перемещена или удалена.
            this.лекарстваTableAdapter.Fill(this.аптекаDataSet1.Лекарства);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet1.Склад". При необходимости она может быть перемещена или удалена.
            this.складTableAdapter1.Fill(this.аптекаDataSet1.Склад);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            складBindingSource1.MovePrevious();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            складBindingSource1.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            складBindingSource1.AddNew();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            складBindingSource1.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.складTableAdapter1.Update(this.аптекаDataSet1.Склад);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (складDataGridView.RowCount > 1)
            {
                складBindingSource1.RemoveCurrent();
                this.Validate();
                this.складBindingSource1.EndEdit();
            }
            else
            {
                string message = "Строки отсутсвуют";
                DialogResult result = MessageBox.Show(message);
            }
        }
    }
}
