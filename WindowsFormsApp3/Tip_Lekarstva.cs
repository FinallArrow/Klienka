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
    public partial class Tip_Lekarstva : Form
    {
        public Tip_Lekarstva()
        {
            InitializeComponent();
        }

        private void тип_лекарстваBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.тип_лекарстваBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.аптекаDataSet1);

        }

        private void Tip_Lekarstva_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet1.Тип_лекарства". При необходимости она может быть перемещена или удалена.
            this.тип_лекарстваTableAdapter1.Fill(this.аптекаDataSet1.Тип_лекарства);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet.Тип_лекарства". При необходимости она может быть перемещена или удалена.
            this.тип_лекарстваTableAdapter.Fill(this.аптекаDataSet.Тип_лекарства);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            тип_лекарстваBindingSource1.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            тип_лекарстваBindingSource1.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            тип_лекарстваBindingSource1.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (тип_лекарстваDataGridView.RowCount > 1)
            {
                тип_лекарстваBindingSource1.RemoveCurrent();
                this.Validate();
                this.тип_лекарстваBindingSource1.EndEdit();
            }
            else
            {
                string message = "Строки отсутсвуют";
                DialogResult result = MessageBox.Show(message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.тип_лекарстваTableAdapter1.Update(this.аптекаDataSet1.Тип_лекарства);
        }
    }
}
