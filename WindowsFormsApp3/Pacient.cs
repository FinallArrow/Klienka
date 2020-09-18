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
    public partial class Pacient : Form
    {
        public Pacient()
        {
            InitializeComponent();
        }

        private void пациентBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пациентBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.аптекаDataSet1);

        }

        private void Pacient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet1.Диагноз". При необходимости она может быть перемещена или удалена.
            this.диагнозTableAdapter.Fill(this.аптекаDataSet1.Диагноз);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet1.Пациент". При необходимости она может быть перемещена или удалена.
            this.пациентTableAdapter1.Fill(this.аптекаDataSet1.Пациент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet.Пациент". При необходимости она может быть перемещена или удалена.
            this.пациентTableAdapter.Fill(this.аптекаDataSet.Пациент);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            пациентBindingSource1.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (пациентDataGridView.RowCount > 1)
            {
                пациентBindingSource1.RemoveCurrent();
                this.Validate();
                this.пациентBindingSource1.EndEdit();
            }
            else
            {
                string message = "Строки отсутсвуют";
                DialogResult result = MessageBox.Show(message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            пациентBindingSource1.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            пациентBindingSource1.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.пациентTableAdapter1.Update(this.аптекаDataSet1.Пациент);
        }
    }
}
