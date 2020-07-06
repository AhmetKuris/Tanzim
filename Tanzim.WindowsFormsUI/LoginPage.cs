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
    public partial class LoginPage : Form
    {
        private IUserService _userService;
        private ICategoryService _categoryService;
        
        public LoginPage()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        
        private void LoginPage_Load(object sender, EventArgs e)
        {
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                switch (_userService.Login(new User
                {
                    Email = userMailTxtbx.Text,
                    Password = userPasswordTxtbx.Text
                }))

                {
                    case "True":
                        this.Hide();
                        
                        this.Hide();
                        HomePage homePage  = new HomePage();
                        homePage.ShowDialog();
                        this.Close();
                        

                        break;
                    case "FalsePassword":
                        MessageBox.Show("Wrong password! Please try again.");
                        break;
                    case "FalseUser":
                        MessageBox.Show("Couldn't find the user. Please sign up.");
                        break;

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void singUpBtn_Click(object sender, EventArgs e)
        {
            Tanzim.WindowsFormsUI.Register registerPage=new Register();
            this.Hide();
            registerPage.ShowDialog();
            this.Close();
        }

        private void showPasswordChcbx_CheckedChanged(object sender, EventArgs e)
        {
            //checkBox işaretli ise
                if (showPasswordChcbx.Checked)
                {
                    //karakteri göster.
                    userPasswordTxtbx.PasswordChar = '\0';
                }
                //değilse karakterlerin yerine * koy.
                else
                {
                    userPasswordTxtbx.PasswordChar = '*';
                }
        }
    }
}
