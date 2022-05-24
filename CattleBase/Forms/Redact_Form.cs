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

namespace CattleBase.Forms
{
    public partial class Redact_Form : Form
    {
        static string connStr = "server=chuc.caseum.ru;port=33333;user=st_2_19_23;database=is_2_19_st23_KURS;password=12072300;";
        MySqlConnection conn = new MySqlConnection(connStr);
        private MySqlDataAdapter MyDA = new MySqlDataAdapter();
        private BindingSource bSource = new BindingSource();
        private DataSet ds = new DataSet();
        private DataTable table = new DataTable();
        string id_selected_type="0";
        string id_selected_gender = "0";
        string id_selected_status = "0";

        public Redact_Form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            UC.UCAnimals1 uCAnimals1 = new UC.UCAnimals1();
            uCAnimals1.reload_list();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Вы не ввели уникальный номер");
                return;
            }
            else if (String.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Вы не выбрали тип");
                return;
            }
            else if (String.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("Вы не выбрали пол");
                return;
            }
            else if (String.IsNullOrEmpty(comboBox3.Text))
            {
                MessageBox.Show("Вы не выбрали состояние");
                return;
            }

            //Молочная
            //Мясная
            //Комбинированная
            switch (comboBox1.Text)
            {
                case "Молочная":
                    id_selected_type = "1";
                    break;
                case "Мясная":
                    id_selected_type = "2";
                    break;
                case "Комбинированная":
                    id_selected_type = "3";
                    break;
            }
            //Бык
            //Корова
            //Телёнок
            switch (comboBox2.Text)
            {
                case "Бык":
                    id_selected_gender = "1";
                    break;
                case "Корова":
                    id_selected_gender = "2";
                    break;
                case "Телёнок":
                    id_selected_gender = "3";
                    break;
            }
            //Жив
            //Мёртв
            //Болен
            switch (comboBox3.Text)
            {
                case "Жив":
                    id_selected_status = "1";
                    break;
                case "Мёртв":
                    id_selected_status = "2";
                    break;
                case "Болен":
                    id_selected_status = "3";
                    break;
            }
            string animal_uniq_number = textBox1.Text;

            string sql = $"INSERT INTO animal (animal_uniq_number, animal_type_id, animal_gender_id, animal_status_id) " +
                $"VALUES ({animal_uniq_number} ,{id_selected_type}, {id_selected_gender}, {id_selected_status});";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Запись добавлена!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
