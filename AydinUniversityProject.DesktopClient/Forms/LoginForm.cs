using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AydinUniversityProject.Business.ManagerFolder.ComplexManagers.ScreenShareOpsComplexManagers;
using AydinUniversityProject.Business.ComplexManagers.UserOpsComplexManagers;
using AydinUniversityProject.Data.Business.AccountComplexManagerData;

namespace TeachLearnDesktop
{
    public partial class LoginForm : Form
    {
        private int clickCount = 0;
        ScreenShareOpsComplexManager screenShareComplexManager;
        AccountComplexManager accountManager;
        public LoginForm()
        {
            InitializeComponent();
            screenShareComplexManager = new ScreenShareOpsComplexManager();
            accountManager = new AccountComplexManager();
        }
        
        
        private void btnPasswordToggle_Click(object sender, EventArgs e)
        {
            Button btnPassword = sender as Button;
            string startupPath = Directory.GetCurrentDirectory();

            if (clickCount % 2 == 0)
            {
                passwordTextBox.UseSystemPasswordChar = true;
                //btnPasswordToggle.BackgroundImage = Image.FromFile(startupPath + "\\images\\Eye-slash-01.jpg");
                clickCount++;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = false;
                //btnPasswordToggle.BackgroundImage = Image.FromFile(startupPath + "\\images\\Eye-open-01.jpg");
                clickCount = 0;
            }

        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            string startupPath = Directory.GetCurrentDirectory();

            //btnPasswordToggle.BackgroundImage = Image.FromFile(startupPath + "\\images\\Eye-open-01.jpg");

            //btnPasswordToggle.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            int currentUserID = -1;
            var loginResponse = accountManager.Login(new LoginFormData { Username = usernameTextBox.Text, Password = passwordTextBox.Text },true);
            var response = loginResponse.TransactionObject;
                //var response = accountManager.CheckCreedientals(new LoginFormData { Username=usernameTextBox.Text, Password=passwordTextBox.Text });

            currentUserID = response.IsSuccess == true ? loginResponse.ID : -1;
                
                if (currentUserID != -1)
                {
                    if (screenShareComplexManager.IsRequestExists(currentUserID))
                    {
                        this.Hide();
                        PendingConnections pc = new PendingConnections(currentUserID);
                        pc.FormClosed += (s, args) => this.Close();
                        pc.Show();
                    }
                    else
                    {
                        this.Hide();
                        CategorySelector cs = new CategorySelector(currentUserID);
                        cs.FormClosed += (s, args) => this.Close();
                        cs.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Your login creedientals are wrong!", "Login Error");
                }
            
                
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = true;
        }
    }
}