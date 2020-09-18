using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Sposob_Prigotovlenya : Form
    {
        public Sposob_Prigotovlenya()
        {
            InitializeComponent();
        }

        private void способ_приготовленияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.способ_приготовленияBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.аптекаDataSet1);

        }

        private void Sposob_Prigotovlenya_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet1.Способ_приготовления". При необходимости она может быть перемещена или удалена.
            this.способ_приготовленияTableAdapter1.Fill(this.аптекаDataSet1.Способ_приготовления);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet.Способ_приготовления". При необходимости она может быть перемещена или удалена.
            this.способ_приготовленияTableAdapter.Fill(this.аптекаDataSet.Способ_приготовления);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            способ_приготовленияBindingSource1.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            способ_приготовленияBindingSource1.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            способ_приготовленияBindingSource1.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (способ_приготовленияDataGridView.RowCount > 1)
            {
                способ_приготовленияBindingSource1.RemoveCurrent();
                this.Validate();
                this.способ_приготовленияBindingSource1.EndEdit();
            }
            else
            {
                string message = "Строки отсутсвуют";
                DialogResult result = MessageBox.Show(message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.способ_приготовленияTableAdapter1.Update(this.аптекаDataSet1.Способ_приготовления);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
