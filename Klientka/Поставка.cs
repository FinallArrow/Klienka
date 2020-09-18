using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klientka
{
    public partial class Поставка : Form
    {
        public Поставка()
        {
            InitializeComponent();
        }

        private void поставкаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.поставкаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automobPredpDataSet);

        }

        private void Поставка_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automobPredpDataSet.Поставка". При необходимости она может быть перемещена или удалена.
            this.поставкаTableAdapter.Fill(this.automobPredpDataSet.Поставка);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            поставкаBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Validate();
            поставкаBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.automobPredpDataSet);
            поставкаBindingSource.MoveLast();
            поставкаDataGridView.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (поставкаDataGridView.RowCount > 1)
            {
                поставкаBindingSource.RemoveCurrent();
                Validate();
                поставкаBindingSource.EndEdit();
            }
            else
            {
                MessageBox.Show("Нечего удалять!!!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            поставкаBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            поставкаBindingSource.MovePrevious();
        }
    }
}
