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
    public partial class Поставщик : Form
    {
        public Поставщик()
        {
            InitializeComponent();
        }

        private void поставщикBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.поставщикBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automobPredpDataSet);

        }

        private void Поставщик_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automobPredpDataSet.Поставщик". При необходимости она может быть перемещена или удалена.
            this.поставщикTableAdapter.Fill(this.automobPredpDataSet.Поставщик);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            поставщикBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Validate();
            поставщикBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.automobPredpDataSet);
            поставщикBindingSource.MoveLast();
            поставщикDataGridView.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (поставщикDataGridView.RowCount > 1)
            {
                поставщикBindingSource.RemoveCurrent();
                Validate();
                поставщикBindingSource.EndEdit();
            }
            else
            {
                MessageBox.Show("Нечего удалять!!!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            поставщикBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            поставщикBindingSource.MovePrevious();
        }
    }
}
