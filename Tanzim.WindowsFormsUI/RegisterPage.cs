using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tanzim.Business.Abstract;
using Tanzim.Business.DependencyResolvers.Ninject;
using Tanzim.Entities.Concrete;

namespace Tanzim.WindowsFormsUI
{
    public partial class Register : Form
    {
        private IUserService _userService;
        public Register()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();
        }

        private void registerRegisterBtn_Click(object sender, EventArgs e)
        {
            if (registerPasswordTxtbx.Text==registerPasswordAgainTxtbx.Text)
            {
                try
                {
                    switch (_userService.SignUp(new User
                    {
                        Name = registerNameTxtbx.Text,
                        Surname = registerSurnameTxtbx.Text,
                        Email = registerMailTxtbx.Text,
                        Password = registerPasswordTxtbx.Text
                    }))
                    {
                        case "Added":
                            MessageBox.Show("User added succesfully! Please login to proceed.");
                            LoginPage loginPage=new LoginPage();
                            this.Hide();
                            loginPage.ShowDialog();
                            this.Close();
                            break;
                        case "AlreadyExists":
                            MessageBox.Show("Email already exits! Please use another one.");

                            break;
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);

                }
            }
            else
            {
                MessageBox.Show("Passwords are not matched!");
            }

            
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        

        private void registerPasswordAgainChcbx_CheckedChanged(object sender, EventArgs e)
        {
            //checkBox işaretli ise
            if (registerPasswordAgainChcbx.Checked)
            {
                //karakteri göster.
                registerPasswordAgainTxtbx.PasswordChar = '\0';
                registerPasswordTxtbx.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                registerPasswordAgainTxtbx.PasswordChar = '*';
                registerPasswordTxtbx.PasswordChar = '*';
            }
        }

        private void btnGoToLoginPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginPage=new LoginPage();
            loginPage.ShowDialog();
            this.Close();
        }
    }
}
