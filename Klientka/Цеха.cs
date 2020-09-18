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
    public partial class Цеха : Form
    {
        public Цеха()
        {
            InitializeComponent();
        }

        private void цехаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.цехаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automobPredpDataSet);

        }

        private void Цеха_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automobPredpDataSet.Цеха". При необходимости она может быть перемещена или удалена.
            this.цехаTableAdapter.Fill(this.automobPredpDataSet.Цеха);

        }
    }
}
