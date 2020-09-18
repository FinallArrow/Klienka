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
    public partial class Spravochnik_tehnologiy : Form
    {
        public Spravochnik_tehnologiy()
        {
            InitializeComponent();
        }

        private void справочник_технологийBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.справочник_технологийBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.аптекаDataSet1);

        }

        private void Spravochnik_tehnologiy_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet1.Технологии". При необходимости она может быть перемещена или удалена.
            this.технологииTableAdapter.Fill(this.аптекаDataSet1.Технологии);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet1.Способ_приготовления". При необходимости она может быть перемещена или удалена.
            this.способ_приготовленияTableAdapter.Fill(this.аптекаDataSet1.Способ_приготовления);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet1.Справочник_технологий". При необходимости она может быть перемещена или удалена.
            this.справочник_технологийTableAdapter1.Fill(this.аптекаDataSet1.Справочник_технологий);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet.Справочник_технологий". При необходимости она может быть перемещена или удалена.
            this.справочник_технологийTableAdapter.Fill(this.аптекаDataSet.Справочник_технологий);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            справочник_технологийBindingSource1.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            справочник_технологийBindingSource1.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            справочник_технологийBindingSource1.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (справочник_технологийDataGridView.RowCount > 1)
            {
                справочник_технологийBindingSource1.RemoveCurrent();
                this.Validate();
                this.справочник_технологийBindingSource1.EndEdit();
            }
            else
            {
                string message = "Строки отсутсвуют";
                DialogResult result = MessageBox.Show(message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.справочник_технологийTableAdapter1.Update(this.аптекаDataSet1.Справочник_технологий);
        }
    }
}
