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
    public partial class Оборудование : Form
    {
        public Оборудование()
        {
            InitializeComponent();
        }

        private void оборудованиеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.оборудованиеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automobPredpDataSet);

        }

        private void Оборудование_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automobPredpDataSet.Оборудование". При необходимости она может быть перемещена или удалена.
            this.оборудованиеTableAdapter.Fill(this.automobPredpDataSet.Оборудование);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            оборудованиеBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Validate();
            оборудованиеBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.automobPredpDataSet);
            оборудованиеBindingSource.MoveLast();
            оборудованиеDataGridView.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (оборудованиеDataGridView.RowCount > 1)
            {
                оборудованиеBindingSource.RemoveCurrent();
                Validate();
                оборудованиеBindingSource.EndEdit();
            }
            else
            {
                MessageBox.Show("Нечего удалять!!!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            оборудованиеBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            оборудованиеBindingSource.MovePrevious();
        }
    }
}
