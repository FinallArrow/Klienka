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
    public partial class Категории_изделия : Form
    {
        public Категории_изделия()
        {
            InitializeComponent();
        }

        private void категории_изделияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.категории_изделияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automobPredpDataSet);

        }

        private void Категории_изделия_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automobPredpDataSet.Категории_изделия". При необходимости она может быть перемещена или удалена.
            this.категории_изделияTableAdapter.Fill(this.automobPredpDataSet.Категории_изделия);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            категории_изделияBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.категории_изделияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automobPredpDataSet);
            категории_изделияBindingSource.MoveLast();
            категории_изделияDataGridView.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (категории_изделияDataGridView.RowCount > 1)
            {
                категории_изделияBindingSource.RemoveCurrent();
                this.Validate();
                категории_изделияBindingSource.EndEdit();
            }
            else
            {
                MessageBox.Show("Нечего удалять!!!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            категории_изделияBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            категории_изделияBindingSource.MovePrevious();
        }
    }
}
