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
    public partial class Приём_на_работу : Form
    {
        public Приём_на_работу()
        {
            InitializeComponent();
        }

        private void приём_на_работуBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.приём_на_работуBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automobPredpDataSet);

        }

        private void Приём_на_работу_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automobPredpDataSet.Приём_на_работу". При необходимости она может быть перемещена или удалена.
            this.приём_на_работуTableAdapter.Fill(this.automobPredpDataSet.Приём_на_работу);

        }
    }
}
