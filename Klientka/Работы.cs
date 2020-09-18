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
    public partial class Работы : Form
    {
        public Работы()
        {
            InitializeComponent();
        }

        private void работыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.работыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automobPredpDataSet);

        }

        private void Работы_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automobPredpDataSet.Работы". При необходимости она может быть перемещена или удалена.
            this.работыTableAdapter.Fill(this.automobPredpDataSet.Работы);

        }
    }
}
