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
    public partial class Statistika_medicomentov : Form
    {
        public Statistika_medicomentov()
        {
            InitializeComponent();
        }

        private void статистика_МедикаментовBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.статистика_МедикаментовBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.аптекаDataSet1);

        }

        private void Statistika_medicomentov_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet1.Статистика_Медикаментов". При необходимости она может быть перемещена или удалена.
            this.статистика_МедикаментовTableAdapter1.Fill(this.аптекаDataSet1.Статистика_Медикаментов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet.Статистика_Медикаментов". При необходимости она может быть перемещена или удалена.
            this.статистика_МедикаментовTableAdapter.Fill(this.аптекаDataSet.Статистика_Медикаментов);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            статистика_МедикаментовBindingSource1.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            статистика_МедикаментовBindingSource1.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            статистика_МедикаментовBindingSource1.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (статистика_МедикаментовDataGridView.RowCount > 1)
            {
                статистика_МедикаментовBindingSource1.RemoveCurrent();
                this.Validate();
                this.статистика_МедикаментовBindingSource1.EndEdit();
            }
            else
            {
                string message = "Строки отсутсвуют";
                DialogResult result = MessageBox.Show(message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.статистика_МедикаментовTableAdapter1.Update(this.аптекаDataSet1.Статистика_Медикаментов);
        }

        private void статистика_МедикаментовDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
