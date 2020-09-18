using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection
              ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=auth.mdb");
            OleDbDataAdapter da = new OleDbDataAdapter
                ("Select rol From Auth Where log='"+textBox1.Text+"' and pas='"+textBox2.Text+"'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                int role = Convert.ToInt32(dt.Rows[0][0]);
                Form1 f = new Form1(role);
                f.Show();
            }
            else
            {
                string message = "НЕВЕРНЫЙ!!!";
                DialogResult result = MessageBox.Show(message);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Auth_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
