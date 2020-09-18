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

namespace Klientka
{
    public partial class Авторизация : Form
    {
        public Авторизация()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection
               ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=AutomobPredp.mdb");
            OleDbDataAdapter da = new OleDbDataAdapter
                ("SELECT Роль FROM Авторизация WHERE Логин='" + textBox1.Text + "' and Пароль='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                int rol = Convert.ToInt32(dt.Rows[0][0]);
                Form1 f = new Form1 (rol);
                f.Show();
            }
            else
            {
                MessageBox.Show
                ("Вы ввели неправильный логин и/или пароль!\n" +
            "Пожалуйста, проверьте актуальность введенных \nвами данных и повторите попытку.",
                "Access denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void Авторизация_Load(object sender, EventArgs e)
        {

        }
    }
}
