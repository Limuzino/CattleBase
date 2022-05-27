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

namespace CattleBase
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        UC.UCDoctors1 uCDoctors1 = new UC.UCDoctors1();
        UC.UCAnimals1 uCAnimals1 = new UC.UCAnimals1();

        static string connStr = "server=chuc.caseum.ru;port=33333;user=st_2_19_23;database=is_2_19_st23_KURS;password=12072300;";
        MySqlConnection conn = new MySqlConnection(connStr);
        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.Hide();
            Forms.LoginForm loginForm = new Forms.LoginForm();
            loginForm.ShowDialog();
            if (Auth.auth)
            {
                this.Show();;
            }
            else
            {
                this.Close();
            }
            label1.Text = "Здравствуйте " + Auth.auth_fio + "!";
        }

        private void menubutton_Click(object sender, EventArgs e)
        {
            addbutton.Visible = false;
            changebutton.Visible = false;
            deletebutton.Visible = false;
            ucAnimals11.Visible = false;
            ucDoctors11.Visible = false;
        }

        private void animalbutton_Click(object sender, EventArgs e)
        {
            addbutton.Visible = true;
            changebutton.Visible = true;
            deletebutton.Visible = true;
            ucAnimals11.Visible = true;
            ucDoctors11.Visible = false;
        }

        private void doctorbutton_Click(object sender, EventArgs e)
        {
            addbutton.Visible = false;
            changebutton.Visible = false;
            deletebutton.Visible = false;
            ucAnimals11.Visible = false;
            ucDoctors11.Visible = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            Forms.Redact_Form redact_Form = new Forms.Redact_Form();
            redact_Form.ShowDialog();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = $"DELETE FROM animal WHERE id='" + uCAnimals1.id_selected_rowsA + "'";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Удаление успешо!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                uCAnimals1.reload_list();
            }
        }
    }
}
