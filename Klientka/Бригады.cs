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
    public partial class Бригады : Form
    {
        public Бригады()
        {
            InitializeComponent();
        }

        private void бригадыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.бригадыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automobPredpDataSet);

        }

        private void Бригады_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automobPredpDataSet.Бригады". При необходимости она может быть перемещена или удалена.
            this.бригадыTableAdapter.Fill(this.automobPredpDataSet.Бригады);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            бригадыBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.бригадыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automobPredpDataSet);
            бригадыBindingSource.MoveLast();
            бригадыDataGridView.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (бригадыDataGridView.RowCount > 1)
            {
                бригадыBindingSource.RemoveCurrent();
                this.Validate();
                this.бригадыBindingSource.EndEdit();
            }
            else
            {
                MessageBox.Show("Нечего удалять!!!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            бригадыBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            бригадыBindingSource.MovePrevious();
        }
    }
}
