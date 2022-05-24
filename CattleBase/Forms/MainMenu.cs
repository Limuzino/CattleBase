using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CattleBase
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

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
            UC.UCAnimals1 uCAnimals1 = new UC.UCAnimals1();
            uCAnimals1.reload_list();
        }

        private void doctorbutton_Click(object sender, EventArgs e)
        {
            addbutton.Visible = true;
            changebutton.Visible = true;
            deletebutton.Visible = true;
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
    }
}
