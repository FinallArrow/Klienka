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
    public partial class Lekarstva : Form
    {
        public Lekarstva()
        {
            InitializeComponent();
        }

        private void лекарстваBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.лекарстваBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.аптекаDataSet1);

        }

        private void Lekarstva_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet1.Изготовление_лекарств". При необходимости она может быть перемещена или удалена.
            this.изготовление_лекарствTableAdapter.Fill(this.аптекаDataSet1.Изготовление_лекарств);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet1.Условия_хранения". При необходимости она может быть перемещена или удалена.
            this.условия_храненияTableAdapter.Fill(this.аптекаDataSet1.Условия_хранения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet1.Статистика_Медикаментов". При необходимости она может быть перемещена или удалена.
            this.статистика_МедикаментовTableAdapter.Fill(this.аптекаDataSet1.Статистика_Медикаментов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet1.Тип_лекарства". При необходимости она может быть перемещена или удалена.
            this.тип_лекарстваTableAdapter1.Fill(this.аптекаDataSet1.Тип_лекарства);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet1.Лекарства". При необходимости она может быть перемещена или удалена.
            this.лекарстваTableAdapter1.Fill(this.аптекаDataSet1.Лекарства);
            this.тип_лекарстваTableAdapter.Fill(this.аптекаDataSet.Тип_лекарства);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet.Лекарства". При необходимости она может быть перемещена или удалена.
            this.лекарстваTableAdapter.Fill(this.аптекаDataSet.Лекарства);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            лекарстваBindingSource1.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            лекарстваBindingSource1.MoveNext();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (лекарстваDataGridView.RowCount > 1)
            {
                лекарстваBindingSource1.RemoveCurrent();
                this.Validate();
                this.лекарстваBindingSource1.EndEdit();
            }
            else
            {
                string message = "НЕТ ОБЪЕКТА ДЛЯ УДАЛЕНИЯ";
                DialogResult result = MessageBox.Show(message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            лекарстваBindingSource1.AddNew();

        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.лекарстваTableAdapter1.Update(this.аптекаDataSet1.Лекарства);
        }
    }
}
