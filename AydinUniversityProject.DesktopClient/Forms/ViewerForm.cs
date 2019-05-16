
using AydinUniversityProject.Business.ManagerFolder.ComplexManagers.ScreenShareOpsComplexManagers;
using System;
using System.Windows.Forms;
using TeachLearnDesktop.Viewer;

namespace TeachLearnDesktop
{
    public partial class ViewerForm : Form
    {
        ViewerClass _viewer = new ViewerClass();

        private int connectionID;
        private int currentUserID;
        private string InvitationString;
        ScreenShareOpsComplexManager screenShareManager;
        //DarrenLee.LiveStream.Audio.Receiver audioReceiver = new DarrenLee.LiveStream.Audio.Receiver();
        //DarrenLee.LiveStream.Audio.Sender audioSender = new DarrenLee.LiveStream.Audio.Sender();

        public ViewerForm(int connectionID, int currentUserID)
        {
            InitializeComponent();
            this.panel3.AutoSize = true;
            this.connectionID = connectionID;
            this.currentUserID = currentUserID;
            screenShareManager = new ScreenShareOpsComplexManager();
        }

        private void ViewerForm_Load(object sender, EventArgs e)
        {
            this.panel3.AutoSize = true;
            getInvitationStringTimer.Start();
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            pRdpViewer.Disconnect();
            CloseConnection();
        }

        private void CloseConnection()
        {

            screenShareManager.Disconnect(currentUserID, connectionID);
            //audioSender.Disconnect();

        }

        private void ViewerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseConnection();

            //if (string.Equals((sender as Button).Name, @"CloseButton"))
            //{

            //    screenShareManager.LogOff(currentUserID);

            //}
        }

        private void getInvitationStringTimer_Tick(object sender, EventArgs e)
        {
            getInvitationStringTimer.Stop();

            var response = screenShareManager.GetInvitationString(connectionID);

            if (response.IsSuccess)
                InvitationString = response.Explanation;
            else
                throw new Exception(response.Explanation);

            if (String.IsNullOrEmpty(InvitationString))
            {
                getInvitationStringTimer.Start();
            }
            else
            {
                pRdpViewer.Connect(InvitationString, "Viewer1", "Password");
            }
        }


    }
}