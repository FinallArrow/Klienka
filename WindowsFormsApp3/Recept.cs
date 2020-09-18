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
    public partial class Recept : Form
    {
        public Recept()
        {
            InitializeComponent();
        }

        private void рецептBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.рецептBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.аптекаDataSet1);

        }

        private void Recept_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet1.Пациент". При необходимости она может быть перемещена или удалена.
            this.пациентTableAdapter.Fill(this.аптекаDataSet1.Пациент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet1.Рецепт". При необходимости она может быть перемещена или удалена.
            this.рецептTableAdapter1.Fill(this.аптекаDataSet1.Рецепт);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet.Рецепт". При необходимости она может быть перемещена или удалена.
            this.рецептTableAdapter.Fill(this.аптекаDataSet.Рецепт);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            рецептBindingSource1.AddNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            рецептBindingSource1.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (рецептDataGridView.RowCount > 1)
            {
                рецептBindingSource1.RemoveCurrent();
                this.Validate();
                this.рецептBindingSource1.EndEdit();
            }
            else
            {
                string message = "Строки отсутсвуют";
                DialogResult result = MessageBox.Show(message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.рецептTableAdapter1.Update(this.аптекаDataSet1.Рецепт);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            рецептBindingSource1.MoveNext();
        }
    }
}
