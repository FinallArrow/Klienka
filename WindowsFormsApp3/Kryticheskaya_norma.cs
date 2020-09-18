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
    public partial class Kryticheskaya_norma : Form
    {
        public Kryticheskaya_norma()
        {
            InitializeComponent();
        }

        private void критическая_нормаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.критическая_нормаBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.аптекаDataSet1);

        }

        private void Kryticheskaya_norma_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet1.Лекарства". При необходимости она может быть перемещена или удалена.
            this.лекарстваTableAdapter.Fill(this.аптекаDataSet1.Лекарства);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet1.Критическая_норма". При необходимости она может быть перемещена или удалена.
            this.критическая_нормаTableAdapter1.Fill(this.аптекаDataSet1.Критическая_норма);


            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet.Критическая_норма". При необходимости она может быть перемещена или удалена.
            this.критическая_нормаTableAdapter.Fill(this.аптекаDataSet.Критическая_норма);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            критическая_нормаBindingSource1.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (критическая_нормаDataGridView.RowCount > 1)
            {
                критическая_нормаBindingSource1.RemoveCurrent();
                this.Validate();
                this.критическая_нормаBindingSource1.EndEdit();
            }
            else
            {
                string message = "Строки отсутсвуют";
                DialogResult result = MessageBox.Show(message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.критическая_нормаTableAdapter1.Update(this.аптекаDataSet1.Критическая_норма);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            критическая_нормаBindingSource1.MoveNext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            критическая_нормаBindingSource1.MovePrevious();
        }
    }
}
