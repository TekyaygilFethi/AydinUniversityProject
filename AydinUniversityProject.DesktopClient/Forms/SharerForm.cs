
using AydinUniversityProject.Business.ManagerFolder.ComplexManagers.ScreenShareOpsComplexManagers;
using System;
using System.Windows.Forms;
using TeachLearnDesktop.Sharer;

namespace TeachLearnDesktop
{
    public partial class SharerForm : Form
    {
        SharerClass _sharer = new SharerClass();
        private int connectionID;
        private int currentUserID;
        ScreenShareOpsComplexManager screenShareManager;

        public SharerForm(int connectionID,int currentUserID)
        {
            InitializeComponent();
            this.connectionID = connectionID;
            this.currentUserID = currentUserID;
            screenShareManager = new ScreenShareOpsComplexManager();
        }

        private void SharerForm_Load(object sender, EventArgs e)
        {
            _sharer.OpenShare();
            
            screenShareManager.SaveInvitationString(connectionID, _sharer.ReturnInvitationString());
            screenShareManager.SetConnectionStarted(connectionID);
            
            LogTextBox.Text += "Presentation Started. Your Desktop is being shared." + Environment.NewLine;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            _sharer.CloseShare();

            CloseConnection();

            LogTextBox.Text += "Presentation Stopped." + Environment.NewLine;
        }

        private void SharerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseConnection();
            //if (string.Equals((sender as Button).Name, @"CloseButton"))
            //{
            //    screenShareManager.LogOff(currentUserID);
                
            //}
        }

        private void CloseConnection()
        {
            screenShareManager.Disconnect(currentUserID, connectionID);
            
        }

    }
}