using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CattleBase.Forms
{
    public partial class LoginForm : Form
    {

        static string connStr = "server=chuc.caseum.ru;port=33333;user=st_2_19_23;database=is_2_19_st23_KURS;password=12072300;";
        MySqlConnection conn = new MySqlConnection(connStr);

        static string sha256(string randomString)
        {
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }

        public void GetUserInfo(string login_user)
        {
            conn.Open();
            string sql = $"SELECT * FROM log_pass WHERE login='{login_user}'";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Auth.auth_login = reader[1].ToString();
                Auth.auth_fio = reader[3].ToString();
            }
            reader.Close();
            conn.Close();
        }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM log_pass WHERE login = @un and password = @up";
            conn.Open();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@un", MySqlDbType.VarChar, 25);
            command.Parameters.Add("@up", MySqlDbType.VarChar, 25);
            command.Parameters["@un"].Value = textBox1.Text;
            command.Parameters["@up"].Value = sha256(textBox2.Text);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            conn.Close();
            if (table.Rows.Count > 0)
            {
                Auth.auth = true;
                GetUserInfo(textBox1.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверные данные авторизации!");
            }
        }
    }
}
