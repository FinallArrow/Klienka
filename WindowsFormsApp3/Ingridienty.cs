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
    public partial class Ingridienty : Form
    {
        public Ingridienty()
        {
            InitializeComponent();
        }

        private void ингридиентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ингридиентыBindingSource3.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.аптекаDataSet1);

        }

        private void Ingridienty_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet1.Фильтрация_лекарств". При необходимости она может быть перемещена или удалена.
            this.фильтрация_лекарствTableAdapter.Fill(this.аптекаDataSet1.Фильтрация_лекарств);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet1.Ингридиенты". При необходимости она может быть перемещена или удалена.
            this.ингридиентыTableAdapter1.Fill(this.аптекаDataSet1.Ингридиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet.Ингридиенты". При необходимости она может быть перемещена или удалена.
            this.ингридиентыTableAdapter.Fill(this.аптекаDataSet.Ингридиенты);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ингридиентыBindingSource3.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ингридиентыDataGridView.RowCount > 1)
            {
                ингридиентыBindingSource3.RemoveCurrent();
                this.Validate();
                this.ингридиентыBindingSource3.EndEdit();
            }
            else
            {
                string message = "Строки отсутсвуют";
                DialogResult result = MessageBox.Show(message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.ингридиентыTableAdapter1.Update(this.аптекаDataSet1.Ингридиенты);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ингридиентыBindingSource3.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ингридиентыBindingSource3.MoveNext();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
