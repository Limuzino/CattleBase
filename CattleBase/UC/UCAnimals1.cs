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

namespace CattleBase.UC
{
    public partial class UCAnimals1 : UserControl
    {
        static string connStr = "server=chuc.caseum.ru;port=33333;user=st_2_19_23;database=is_2_19_st23_KURS;password=12072300;";
        MySqlConnection conn = new MySqlConnection(connStr);
        private MySqlDataAdapter MyDA = new MySqlDataAdapter();
        private BindingSource bSource = new BindingSource();
        private DataSet ds = new DataSet();
        private DataTable table = new DataTable();
        //string id_selected_rows = "0";
        public UCAnimals1()
        {
            InitializeComponent();
        }

        public void GetListUsers()
        {
            string sql = "SELECT * FROM animal;";
            conn.Open();
            MyDA.SelectCommand = new MySqlCommand(sql, conn);
            MyDA.Fill(table);
            bSource.DataSource = table;
            dataGridView1.DataSource = bSource;
            conn.Close();
        }

        private void UCAnimals1_Load(object sender, EventArgs e)
        {

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[3].Visible = true;
            dataGridView1.Columns[4].Visible = true;
            dataGridView1.Columns[5].Visible = true;
            dataGridView1.Columns[6].Visible = true;

            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
            dataGridView1.Columns[6].ReadOnly = true;

            dataGridView1.RowHeadersVisible = false;

            dataGridView1.ColumnHeadersVisible = true;

            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns[1].HeaderText = "Порядковый номер";
            dataGridView1.Columns[2].HeaderText = "Функция";
            dataGridView1.Columns[3].HeaderText = "Пол";
            dataGridView1.Columns[4].HeaderText = "Состояние";
            dataGridView1.Columns[5].HeaderText = "Возраст";
            dataGridView1.Columns[6].HeaderText = "Номер стада";

            
        }
    }
}
