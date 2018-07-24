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
    public partial class Form2 : Form
    {
        public string sql;
        public int categoryIndex;

        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'todoDataSet1.categorylist' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.categorylistTableAdapter.Fill(this.todoDataSet1.categorylist);
            //dateTimePickerの表記変更
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";


        }

        private void button1_Click(object sender, EventArgs e)  //カテゴリ追加
        {
            Form3 frm3 = new Form3();
            if (frm3.ShowDialog() == DialogResult.OK)
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = "Data Source=localhost; Initial Catalog = todo; UserID=root; Password=1234; Integrated Security = True";
                connection.Open();

                MySqlCommand command = new MySqlCommand();

                command.CommandText = frm3.sql;
                command.Connection = connection;

                MySqlDataReader dataReader = command.ExecuteReader();
                connection.Close();
                this.categorylistTableAdapter.Fill(this.todoDataSet1.categorylist);

            }

        }

        private void button2_Click(object sender, EventArgs e)  //新規Todo追加OK
        {
            //コネクション
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = "Data Source=localhost; Initial Catalog = todo; UserID=root;Password=1234;Integrated Security=True";
            connection.Open();

            MySqlCommand command = new MySqlCommand();
            command.CommandText = "select * from todolist";
            command.Connection = connection;


            DialogResult result = MessageBox.Show("新規ToDo「" + textBox1.Text + "」を追加しますか？");

            if (result == DialogResult.OK)
            {
                //sql = "insert into todo(Title, list, Prm, Deadline, Category)values('" + textBox1.Text + "','" + textBox2.Text + "'," + comboBox2 + ",'" + dateTimePicker1 + "','" + comboBox1.Text + "')";
                //sql = "insert into todo(Title, list, Prm, Deadline, Category)values('予約','チケット予約',4,2018/07/03,'イベント')";

                sql = "insert into todolist(Title, list, Prm, Deadline, Category)values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + comboBox2.Text + "', '" + dateTimePicker1.Text + "', '" + comboBox1.Text + "')";


                categoryIndex = comboBox1.SelectedIndex;
                MessageBox.Show("更新しました");

            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("キャンセルしました");
            }

            command.ExecuteNonQuery();
            connection.Close();

        }

    }
}
