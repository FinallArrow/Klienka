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
    public partial class Spravochniky_zakazov : Form
    {
        public Spravochniky_zakazov()
        {
            InitializeComponent();
        }

        private void справочник_заказовBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.справочник_заказовBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.аптекаDataSet1);

        }

        private void Spravochniky_zakazov_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet1.Лекарства". При необходимости она может быть перемещена или удалена.
            this.лекарстваTableAdapter1.Fill(this.аптекаDataSet1.Лекарства);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet1.Справочник_заказов". При необходимости она может быть перемещена или удалена.
            this.справочник_заказовTableAdapter1.Fill(this.аптекаDataSet1.Справочник_заказов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet.Лекарства". При необходимости она может быть перемещена или удалена.
            this.лекарстваTableAdapter.Fill(this.аптекаDataSet.Лекарства);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet.Справочник_заказов". При необходимости она может быть перемещена или удалена.
            this.справочник_заказовTableAdapter.Fill(this.аптекаDataSet.Справочник_заказов);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            справочник_заказовBindingSource1.MovePrevious();
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            справочник_заказовBindingSource1.AddNew();


        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (справочник_заказовDataGridView.RowCount > 1)
            {
                справочник_заказовBindingSource1.RemoveCurrent();
                this.Validate();
                this.справочник_заказовBindingSource1.EndEdit();
            }
            else
            {
                string message = "Строки отсутсвуют";
                DialogResult result = MessageBox.Show(message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.справочник_заказовTableAdapter1.Update(this.аптекаDataSet1.Справочник_заказов);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            справочник_заказовBindingSource1.MoveNext();
        }
    }
}
