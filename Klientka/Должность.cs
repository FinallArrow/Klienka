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
    public partial class Должность : Form
    {
        public Должность()
        {
            InitializeComponent();
        }

        private void должностьBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.должностьBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automobPredpDataSet);

        }

        private void Должность_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automobPredpDataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this.automobPredpDataSet.Должность);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            должностьBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.должностьBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automobPredpDataSet);
            должностьBindingSource.MoveLast();
            должностьDataGridView.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (должностьDataGridView.RowCount > 1)
            {
                должностьBindingSource.RemoveCurrent();
                this.Validate();
                this.должностьBindingSource.EndEdit();
            }
            else
            {
                MessageBox.Show("Нечего удалять!!!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            должностьBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            должностьBindingSource.MovePrevious();
        }
    }
}
