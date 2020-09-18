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
    public partial class Тип_изделия : Form
    {
        public Тип_изделия()
        {
            InitializeComponent();
        }

        private void тип_изделияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.тип_изделияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automobPredpDataSet);

        }

        private void Тип_изделия_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automobPredpDataSet.Тип_изделия". При необходимости она может быть перемещена или удалена.
            this.тип_изделияTableAdapter.Fill(this.automobPredpDataSet.Тип_изделия);

        }
    }
}
