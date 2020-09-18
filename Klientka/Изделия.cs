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
    public partial class Изделия : Form
    {
        public Изделия()
        {
            InitializeComponent();
        }

        private void изделияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.изделияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automobPredpDataSet);

        }

        private void Изделия_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automobPredpDataSet.Работы". При необходимости она может быть перемещена или удалена.
            this.работыTableAdapter.Fill(this.automobPredpDataSet.Работы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automobPredpDataSet.Испытательные_лаборатории". При необходимости она может быть перемещена или удалена.
            this.испытательные_лабораторииTableAdapter.Fill(this.automobPredpDataSet.Испытательные_лаборатории);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automobPredpDataSet.Изделия". При необходимости она может быть перемещена или удалена.
            this.изделияTableAdapter.Fill(this.automobPredpDataSet.Изделия);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            изделияBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.изделияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automobPredpDataSet);
            изделияBindingSource.MoveLast();
            изделияDataGridView.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (изделияDataGridView.RowCount > 1)
            {
                изделияBindingSource.RemoveCurrent();
                this.Validate();
                this.изделияBindingSource.EndEdit();
            }
            else
            {
                MessageBox.Show("Нечего удалять!!!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            изделияBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            изделияBindingSource.MovePrevious();
        }

        private void ИзделияDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
