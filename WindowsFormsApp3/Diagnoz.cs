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
    public partial class Diagnoz : Form
    {
        public Diagnoz()
        {
            InitializeComponent();
        }

        private void диагнозBindingNavigatorSaveItem_Click1(object sender, EventArgs e)
        {
            this.Validate();
            this.диагнозBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.аптекаDataSet1);

        }

        private void Diagnoz_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet1.Вид_диагноза". При необходимости она может быть перемещена или удалена.
            this.вид_диагнозаTableAdapter.Fill(this.аптекаDataSet1.Вид_диагноза);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet1.Диагноз". При необходимости она может быть перемещена или удалена.
            this.диагнозTableAdapter1.Fill(this.аптекаDataSet1.Диагноз);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet.Диагноз". При необходимости она может быть перемещена или удалена.
            this.диагнозTableAdapter.Fill(this.аптекаDataSet.Диагноз);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            диагнозBindingSource1.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            диагнозBindingSource1.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            диагнозBindingSource1.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (диагнозDataGridView.RowCount > 1)
            {
                диагнозBindingSource1.RemoveCurrent();
                this.Validate();
                this.диагнозBindingSource1.EndEdit();
            }
            else
            {
                string message = "Строки отсутсвуют";
                DialogResult result = MessageBox.Show(message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.диагнозTableAdapter1.Update(this.аптекаDataSet1.Диагноз);

        }

        private void диагнозDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
