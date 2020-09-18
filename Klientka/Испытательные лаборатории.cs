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
    public partial class Испытательные_лаборатории : Form
    {
        public Испытательные_лаборатории()
        {
            InitializeComponent();
        }

        private void испытательные_лабораторииBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.испытательные_лабораторииBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automobPredpDataSet);

        }

        private void Испытательные_лаборатории_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automobPredpDataSet.Испытательные_лаборатории". При необходимости она может быть перемещена или удалена.
            this.испытательные_лабораторииTableAdapter.Fill(this.automobPredpDataSet.Испытательные_лаборатории);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            испытательные_лабораторииBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.испытательные_лабораторииBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automobPredpDataSet);
            испытательные_лабораторииBindingSource.MoveLast();
            испытательные_лабораторииDataGridView.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (испытательные_лабораторииDataGridView.RowCount > 1)
            {
                испытательные_лабораторииBindingSource.RemoveCurrent();
                this.Validate();
                испытательные_лабораторииBindingSource.EndEdit();
            }
            else
            {
                MessageBox.Show("Нечего удалять!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            испытательные_лабораторииBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            испытательные_лабораторииBindingSource.MovePrevious();
        }
    }
}
