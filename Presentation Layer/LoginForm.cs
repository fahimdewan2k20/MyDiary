using MyDiary.Business_Logic_layer;
using MyDiary.Presentation_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDiary
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string personName = nameTextBox.Text;
            string password = passwordTextBox.Text;

            if(personName == "" || password == "")
            {
                MessageBox.Show("person name or password cannot be empty");
            }
            else
            {
                PersonService ps = new PersonService();
                if(ps.LoginValidation(personName, password))
                {
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("username or password doesn't match");
                }
            }
            
        }

        private void createDiaryBtn_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }
    }
}
