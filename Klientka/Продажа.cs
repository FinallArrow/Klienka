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
    public partial class Продажа : Form
    {
        public Продажа()
        {
            InitializeComponent();
        }

        private void продажаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.продажаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automobPredpDataSet);

        }

        private void Продажа_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automobPredpDataSet.Продажа". При необходимости она может быть перемещена или удалена.
            this.продажаTableAdapter.Fill(this.automobPredpDataSet.Продажа);

        }
    }
}
