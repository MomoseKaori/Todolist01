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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

            // TODO: このコード行はデータを 'todoDataSet1.categorylist' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.categorylistTableAdapter.Fill(this.todoDataSet1.categorylist);

        }
    }
}
