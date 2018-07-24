using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoList01
{
    public partial class Form3 : Form
    {
        public string sql;

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("カテゴリに\r\n" + textBox1.Text + "\r\nを追加しますか？");

            sql = "insert into categorylist(Category)values('" + textBox1.Text + "')";
            MessageBox.Show("追加しました。");

        }
    }
}
