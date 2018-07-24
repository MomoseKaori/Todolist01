using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace TodoList01
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'achievedDataSet.atodo' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.atodoTableAdapter.Fill(this.achievedDataSet.atodo);
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = "server=localhost;user id=root;password=1234;database=achieved";
            connection.Open();

            MySqlCommand command = new MySqlCommand();
            command.CommandText = "select * from achieved";
            command.Connection = connection;

            //MySqlDataReader dataReader = command.ExecuteReader();
            connection.Close();


            //DGV編集
            dataGridViewAchieved.ReadOnly = true;
            dataGridViewAchieved.AllowUserToAddRows = false;

        }
    }
}
