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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = "server=localhost;user id=root;password=1234;database=todo";
            connection.Open();

            MySqlCommand command = new MySqlCommand();
            command.CommandText = "select * from todo";
            command.Connection = connection;

            //MySqlDataReader dataReader = command.ExecuteReader();
            connection.Close();

        }

        private void todolistBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.todolistBindingSource.EndEdit();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'todoDataSet.todolist' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.todolistTableAdapter.Fill(this.todoDataSet.todolist);

                    //チェックボックスの追加
                    /*DataGridViewCheckBoxColumn Check = new DataGridViewCheckBoxColumn();
                    dataGridView1.Columns.Insert(0, Check);
                    Check.HeaderText = "達成";
                    Check.Width = 40;*/
                    //DGV列幅自動調整
                    //dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                    //Deadline列のフォーマット変更
                    //this.dataGridView1.Columns[3].DefaultCellStyle.Format = "yyyy/MM/dd";
                    //((System.Windows.Forms.DataGridViewTextBoxColumn)dataGridView1.Columns[3]).MaxInputLength = 10;

            //DGV行全体select
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //DGV編集不可
            dataGridView1.ReadOnly = true;
        
            //DGV編集ボタン追加
            DataGridViewButtonColumn column = new DataGridViewButtonColumn();
            column.Name = "Todo編集";
            column.UseColumnTextForButtonValue = true;
            column.Text = "編集";
            dataGridView1.Columns.Add(column);

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)  //新規ToDo追加
        {
            Form2 frm2 = new Form2();
            if (frm2.ShowDialog() == DialogResult.OK)
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = "Data Source=localhost; Initial Catalog = todo; UserID=root; Password=1234; Integrated Security = True";

                MySqlCommand command = new MySqlCommand();

                command.CommandText = frm2.sql;
                command.Connection = connection;

                connection.Open();
                command.ExecuteNonQuery();

                connection.Close();
                this.todolistTableAdapter.Fill(this.todoDataSet.todolist);


            }
        }

        private void button2_Click(object sender, EventArgs e)  //ToDo達成
        {
            string[] dgv = new string[5];
            string deadline;
            string sql, asql;
            
            //sql = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //MessageBox.Show(sql);


            
            //String dgv = dataGridView1.CurrentRow.Cells[0].Value;
            DialogResult resurt = MessageBox.Show("ToDo「" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "」を達成しますか？", "ToDo達成", MessageBoxButtons.OKCancel);

            //行番号＝row
            int row = dataGridView1.CurrentCell.RowIndex;

            if(resurt == DialogResult.OK)
            {
                for(int cell = 0; cell < dataGridView1.ColumnCount; cell++)
                {
                    dgv[cell] = dataGridView1.Rows[row].Cells[cell].Value.ToString();
                }
                //
                deadline = dgv[3].Substring(0, 10);

                //達成SQL文
                sql = "delete from todolist where Title='" + dgv[0] +"' and list='" + dgv[1] + "'and Prm=" + dgv[2] + " and Deadline='" + deadline + "' and Category='" + dgv[4] + "';";

                //コネクション
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = "Data Source=localhost; Initial Catalog = todo; UserID=root; Password=1234; Integrated Security = True";

                MySqlCommand command = new MySqlCommand();

                command.CommandText = sql;
                command.Connection = connection;

                connection.Open();
                command.ExecuteNonQuery();      //SQL実行

                connection.Close();


                DialogResult acvResult = MessageBox.Show("達成しました！");
                if(acvResult == DialogResult.OK)
                {
                    //達成済みTodoに追加
                    DateTime nowdt = DateTime.Today;

                    //達成済み追加文
                    asql = "insert into atodo(Title, list, Prm, acvDate, Category)values('" + dgv[0] + "', '" + dgv[1] + "', '" + dgv[2] + "', '" + nowdt + "', '" + dgv[4] + "');";

                    //コネクション
                    MySqlConnection ACconnection = new MySqlConnection();
                    ACconnection.ConnectionString = "Data Source=localhost; Initial Catalog = achieved; UserID=root; Password=1234; Integrated Security = True";

                    MySqlCommand ACcommand = new MySqlCommand();

                    ACcommand.CommandText = asql;
                    ACcommand.Connection = ACconnection;

                    ACconnection.Open();
                    ACcommand.ExecuteNonQuery();      //SQL実行

                    ACconnection.Close();


                    MessageBox.Show("達成追加しました！");

                }
                this.todolistTableAdapter.Fill(this.todoDataSet.todolist);
            }

        }

        //達成済Todo確認
        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form5 f5 = new Form5();
            Form2 f2 = new Form2();


            string[] dgv = new string[5];
            string sqlu;


            //行番号
            int row = e.RowIndex;

            if(e.ColumnIndex == 5)
            {
                for (int cell = 0; cell < 5; cell++)
                {
                    dgv[cell] = dataGridView1.Rows[row].Cells[cell].Value.ToString();

                }

                f5.textBox1.Text = dgv[0];
                f5.textBox2.Text = dgv[1];
                f5.comboBox2.Text = dgv[2];
                f5.dateTimePicker1.Text = dgv[3].Substring(0, 10);

                //f5.comboBox1.SelectedIndex = 2;
                


                f5.Show();


            }
        }
    }
}
