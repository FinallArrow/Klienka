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
    public partial class Назначение_в_бригаду : Form
    {
        public Назначение_в_бригаду()
        {
            InitializeComponent();
        }

        private void назначение_в_бригадуBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.назначение_в_бригадуBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automobPredpDataSet);

        }

        private void Назначение_в_бригаду_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automobPredpDataSet.Назначение_в_бригаду". При необходимости она может быть перемещена или удалена.
            this.назначение_в_бригадуTableAdapter.Fill(this.automobPredpDataSet.Назначение_в_бригаду);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            назначение_в_бригадуBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.назначение_в_бригадуBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automobPredpDataSet);
            назначение_в_бригадуBindingSource.MoveLast();
            назначение_в_бригадуDataGridView.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (назначение_в_бригадуDataGridView.RowCount > 1)
            {
                назначение_в_бригадуBindingSource.RemoveCurrent();
                this.Validate();
                назначение_в_бригадуBindingSource.EndEdit();
            }
            else
            {
                MessageBox.Show("Нечего удалять!!!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            назначение_в_бригадуBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            назначение_в_бригадуBindingSource.MovePrevious();
        }
    }
}
