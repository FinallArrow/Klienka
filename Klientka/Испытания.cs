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
    public partial class Испытания : Form
    {
        public Испытания()
        {
            InitializeComponent();
        }

        private void испытанияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.испытанияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automobPredpDataSet);

        }

        private void Испытания_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automobPredpDataSet.Испытательные_лаборатории". При необходимости она может быть перемещена или удалена.
            this.испытательные_лабораторииTableAdapter.Fill(this.automobPredpDataSet.Испытательные_лаборатории);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automobPredpDataSet.Испытания". При необходимости она может быть перемещена или удалена.
            this.испытанияTableAdapter.Fill(this.automobPredpDataSet.Испытания);

        }

        private void ИспытанияDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
