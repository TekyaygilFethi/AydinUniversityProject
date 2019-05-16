
using AydinUniversityProject.Business.ManagerFolder.ComplexManagers.ScreenShareOpsComplexManagers;
using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace TeachLearnDesktop
{
    public partial class ConnectionNameForm : Form
    {
        int currentUserID = -1;
        int lessonID = 0;
        ScreenShareOpsComplexManager screenShareManager;

        public ConnectionNameForm(int currentUserID,int lessonID)
        {
            InitializeComponent();

            btnSubmitConnectionName.Enabled = false;
            connectionNameTextBox.Enabled = false;

            this.lessonID = lessonID;
            this.currentUserID = currentUserID;

            screenShareManager = new ScreenShareOpsComplexManager();
        }

        private void ConnectionNameForm_Load(object sender, EventArgs e)
        {
            connectionRequestTimer.Start();
        }

        private void connectionRequestTimer_Tick(object sender, EventArgs e)
        {
            connectionRequestTimer.Stop();
            
                int connID = screenShareManager.ControlConnectionForCreation(currentUserID, lessonID/*, Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].ToString(),categoryID*/); //kontrol et varsa katıl yoksa create et
                if (connID != -1)
                {
                    DesktopApplicationForm daf = new DesktopApplicationForm(currentUserID, connectionNameTextBox.Text, connID, lessonID);
                    daf.Show();

                }
                else
                {
                    if (screenShareManager.HasConnection(currentUserID))
                    {
                        btnSubmitConnectionName.Enabled = true;
                        connectionNameTextBox.Enabled = true;

                        connectionRequestTimer.Start();
                    }
                    else
                    {
                        connectionRequestTimer.Start();
                    }
                }
            
        }

        private void btnSubmitConnectionName_Click(object sender, EventArgs e)
        {
            DesktopApplicationForm daf = new DesktopApplicationForm(currentUserID, connectionNameTextBox.Text, 0, lessonID);
            daf.Show();
            this.Hide();
        }

        private void ConnectionNameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (string.Equals((sender as Button).Name, @"CloseButton"))
            //{ 
            //    screenShareManager.LogOff(currentUserID);                
            //}
        }
    }
}
