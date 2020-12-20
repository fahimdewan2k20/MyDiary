using MyDiary.Business_Logic_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDiary.Presentation_Layer
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if(passwordTextBox.Text == confirmPasswordBox.Text)
            {
                PersonService ps = new PersonService();
                int result = ps.AddNewPerson(nameTextBox.Text, passwordTextBox.Text);
                if (result > 0)
                {
                    MessageBox.Show("You have successfully created your account ...");
                    LoginForm lf = new LoginForm();
                    lf.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("password doesn't match");
                passwordTextBox.Text = "";
                confirmPasswordBox.Text = "";
            }
        }
    }
}
