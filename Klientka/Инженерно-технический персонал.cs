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
    public partial class Инженерно_технический_персонал : Form
    {
        public Инженерно_технический_персонал()
        {
            InitializeComponent();
        }

        private void инженерно_технический_персоналBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.инженерно_технический_персоналBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automobPredpDataSet);

        }

        private void Инженерно_технический_персонал_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automobPredpDataSet.Работники". При необходимости она может быть перемещена или удалена.
            this.работникиTableAdapter.Fill(this.automobPredpDataSet.Работники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automobPredpDataSet._Инженерно_технический_персонал". При необходимости она может быть перемещена или удалена.
            this.инженерно_технический_персоналTableAdapter.Fill(this.automobPredpDataSet._Инженерно_технический_персонал);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            инженерно_технический_персоналBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.инженерно_технический_персоналBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automobPredpDataSet);
            инженерно_технический_персоналBindingSource.MoveLast();
            инженерно_технический_персоналDataGridView.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (инженерно_технический_персоналDataGridView.RowCount > 1)
            {
                инженерно_технический_персоналBindingSource.RemoveCurrent();
                this.Validate();
                инженерно_технический_персоналBindingSource.EndEdit();
            }
            else
            {
                MessageBox.Show("Нечего удалять!!!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            инженерно_технический_персоналBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            инженерно_технический_персоналBindingSource.MovePrevious();
        }
    }
}
