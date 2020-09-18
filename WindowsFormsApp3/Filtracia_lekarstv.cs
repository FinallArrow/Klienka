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
    public partial class Filtracia_lekarstv : Form
    {
        public Filtracia_lekarstv()
        {
            InitializeComponent();
        }

        private void фильтрация_лекарствBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.фильтрация_лекарствBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.аптекаDataSet1);

        }

        private void Filtracia_lekarstv_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet1.Фильтрация_лекарств". При необходимости она может быть перемещена или удалена.
            this.фильтрация_лекарствTableAdapter.Fill(this.аптекаDataSet1.Фильтрация_лекарств);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            фильтрация_лекарствBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            фильтрация_лекарствBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            фильтрация_лекарствBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (фильтрация_лекарствDataGridView.RowCount > 1)
            {
                фильтрация_лекарствBindingSource.RemoveCurrent();
                this.Validate();
                this.фильтрация_лекарствBindingSource.EndEdit();
            }
            else
            {
                string message = "Строки отсутсвуют";
                DialogResult result = MessageBox.Show(message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.фильтрация_лекарствTableAdapter.Update(this.аптекаDataSet1.Фильтрация_лекарств);
        }
    }
}
