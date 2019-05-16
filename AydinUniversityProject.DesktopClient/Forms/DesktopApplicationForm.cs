
using AydinUniversityProject.Business.ManagerFolder.ComplexManagers.ScreenShareOpsComplexManagers;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TeachLearnDesktop
{
    public partial class DesktopApplicationForm : Form
    {
        private int connectionID;
        private int requestID;
        private int currentUserID = 0;
        private string connectionName;
        private int lessonID = 0;
        private string tag;
        ScreenShareOpsComplexManager screenShareManager;

        public DesktopApplicationForm(int currentUserID, string connectionName, int connectionID, int lessonID)
        {
            InitializeComponent();

            this.currentUserID = currentUserID;
            this.connectionName = connectionName;
            this.connectionID = connectionID;
            this.lessonID = lessonID;
            screenShareManager = new ScreenShareOpsComplexManager();
        }

        public DesktopApplicationForm(int requestConnectionID, int currentUserID, string type)
        {
            InitializeComponent();
            screenShareManager = new ScreenShareOpsComplexManager();
            if (type == "Request")
            {
                requestID = requestConnectionID;
                this.currentUserID = currentUserID;
                requestedConnectionTimer.Start();
            }
            else
            {
                connectionID = requestConnectionID;
                this.currentUserID = currentUserID;
                connectAcceptedConnectionTimer.Start();
            }
        }



        private void DesktopApplicationForm_Load(object sender, EventArgs e)
        {
            //myIP = new WebClient().DownloadString("http://icanhazip.com");
        }

        private void DesktopApplicationForm_Shown(object sender, EventArgs e)
        {
            string startupPath = Directory.GetCurrentDirectory();


            //backgroundImage.Image = Image.FromFile(startupPath + "\\images\\matrix.gif");
            connectionCheckerTimer.Start();

        }

        private void DesktopApplicationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (string.Equals((sender as Button).Name, @"CloseButton"))
            //{
            //    screenShareManager.LogOff(currentUserID);

            //}
        }

        private void connectionCheckerTimer_Tick(object sender, EventArgs e)
        {
            connectionCheckerTimer.Stop();
            connectionID = connectionID != 0 ? connectionID : screenShareManager.ControlConnectionForCreation(currentUserID, lessonID); //var olan bir connection varsa ona katlılmaya çalış

            //string myIP = Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].ToString();

            if (connectionID != -1)
            {
                openForm();
            }
            else
            {
                connectionID = screenShareManager.CreateConnection(currentUserID, connectionName, lessonID);//yeni connection oluştur ve başka bir kullanıcı bekle
                secondConnectionCheckerTimer.Start();
            }
        }


        private void secondConnectionCheckerTimer_Tick(object sender, EventArgs e)
        {
            secondConnectionCheckerTimer.Stop();
            string Tag = screenShareManager.GetTag(currentUserID, connectionID);

            if (screenShareManager.ControlConnectionForJoin(Tag, connectionID))
            {
                openForm();

            }
            else
            {
                secondConnectionCheckerTimer.Start();
            }


        }

        private void openForm()
        {
                string userTag = screenShareManager.GetTag(currentUserID, connectionID);

                switch (userTag)
                {
                    case "Viewer":
                        this.Hide();
                        ViewerForm vf = new ViewerForm(connectionID, currentUserID);
                        vf.FormClosed += (s, args) => this.Close();
                        vf.Show();

                        break;

                    case "Sharer":
                        SharerForm sf = new SharerForm(connectionID, currentUserID);
                        sf.Show();
                        //this.Close();
                        break;

                    default:
                        lblException.Text = "ERROR! Please try again!";
                        break;
                }
            
        }

        private void requestedConnectionTimer_Tick(object sender, EventArgs e)
        {
            requestedConnectionTimer.Stop();
            if (connectionID != -1)
            {
                connectionID = screenShareManager.CreateScreenShareConnection(requestID, currentUserID);
                openForm();
            }
            else
            {
                requestedConnectionTimer.Start();

            }
        }

        private void connectAcceptedConnectionTimer_Tick(object sender, EventArgs e)
        {
            connectAcceptedConnectionTimer.Stop();
            openForm();

        }
    }
}
