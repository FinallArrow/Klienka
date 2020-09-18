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
    public partial class Отдел : Form
    {
        public Отдел()
        {
            InitializeComponent();
        }

        private void отделBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.отделBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automobPredpDataSet);

        }

        private void Отдел_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automobPredpDataSet.Отдел". При необходимости она может быть перемещена или удалена.
            this.отделTableAdapter.Fill(this.automobPredpDataSet.Отдел);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            отделBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Validate();
            отделBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.automobPredpDataSet);
            отделBindingSource.MoveLast();
            отделDataGridView.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (отделDataGridView.RowCount > 1)
            {
                отделBindingSource.RemoveCurrent();
                Validate();
                отделBindingSource.EndEdit();
            }
            else
            {
                MessageBox.Show("Нечего удалять!!!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            отделBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            отделBindingSource.MovePrevious();
        }
    }
}
