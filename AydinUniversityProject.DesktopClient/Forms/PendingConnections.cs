
using AydinUniversityProject.Business.ManagerFolder.ComplexManagers.ScreenShareOpsComplexManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using TeachLearnDesktop.Items;

namespace TeachLearnDesktop
{
    public partial class PendingConnections : Form
    {
        int userID = 0;
        List<RequestedConnectionItem> itemList;
        ScreenShareOpsComplexManager screenShareManager;

        public PendingConnections(int userID)
        {
            InitializeComponent();

            this.userID = userID;
            screenShareManager = new ScreenShareOpsComplexManager();
        }

        private void PendingConnections_Load(object sender, EventArgs e)
        {
            acceptedRequestTimer.Start();
            
                Dictionary<Dictionary<int, string>, Dictionary<string, string>> requestedConnsDictionary = screenShareManager.GetRequestedConnections(userID);

                itemList = new List<RequestedConnectionItem>();

                foreach (var outerDict in requestedConnsDictionary)
                {

                    RequestedConnectionItem rci = new RequestedConnectionItem();

                    rci.RequestID = outerDict.Key.FirstOrDefault().Key;
                    rci.ConnectionName = outerDict.Key.FirstOrDefault().Value;

                    rci.RequesterUsername = outerDict.Value.FirstOrDefault().Key;
                    rci.CategoryName = outerDict.Value.FirstOrDefault().Value;

                    itemList.Add(rci);
                }

                pConnectionsGridView.DataSource = itemList;
                pConnectionsGridView.Columns[0].Visible = false;

                for (int i = 0; i < itemList.Count; i++)
                {
                    DataGridViewButtonColumn newButton = new DataGridViewButtonColumn();
                    newButton.UseColumnTextForButtonValue = true;

                    newButton.Tag = itemList[i].RequestID;
                    newButton.Text = "Accept";
                    pConnectionsGridView.Columns.Add(newButton);
                }



                List<SentRequestedConnectionItem> itemList2 = new List<SentRequestedConnectionItem>();
                
                Dictionary<Dictionary<int, string>, Dictionary<string, string>> sentConnsDictionary = screenShareManager.GetSentRequestedConnections(userID);
                
                foreach (var outerDict in sentConnsDictionary)
                {
                    SentRequestedConnectionItem rci = new SentRequestedConnectionItem();

                    rci.RequestID = outerDict.Key.FirstOrDefault().Key;
                    rci.ConnectionName = outerDict.Key.FirstOrDefault().Value;

                    rci.RequesterUsername = outerDict.Value.FirstOrDefault().Key;
                    rci.CategoryName = outerDict.Value.FirstOrDefault().Value;

                    rci.IsOnline = screenShareManager.GetOnlineStatus(rci.RequesterUsername);
                    itemList2.Add(rci);
                }

                rConnectionsGridView.DataSource = itemList2;
                rConnectionsGridView.ReadOnly = true;
                rConnectionsGridView.Columns[0].Visible = false;
            
        }

        private void pConnectionsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                string requestID = senderGrid.Columns[e.ColumnIndex].Tag.ToString();
                
                    string partnerUsername = itemList[e.RowIndex].RequesterUsername;
                    if (!screenShareManager.CheckPartnerAvailability(partnerUsername))
                    {
                        MessageBox.Show("Your partner is not available at the moment! You can try again or skip this section!");
                    }
                    else
                    {
                        int reqID= screenShareManager.AcceptScreenShareRequest(int.Parse(requestID),userID);

                        this.Hide();
                        DesktopApplicationForm daf = new DesktopApplicationForm(reqID, userID,"Request");
                        daf.FormClosed += (s, args) => this.Close();
                        daf.Show();
                    }
                
            }
        }

        private void PendingConnections_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (string.Equals((sender as Button).Name, @"CloseButton"))
            //{
                screenShareManager.LogOff(userID);
                
            //}
        }

        private void acceptedRequestTimer_Tick(object sender, EventArgs e)
        {
                acceptedRequestTimer.Stop();
                int connID = screenShareManager.CheckAcceptedRequest(userID);
                if(connID != -1)
                {
                    string[] info = screenShareManager.GetAcceptedRequestInfo(connID, userID);

                    MessageBox.Show(info[1]+" has accepted your request! Connection again for the connection: "+info[0]);

                    Thread.Sleep(3000);

                    this.Hide();
                    DesktopApplicationForm daf = new DesktopApplicationForm(connID, userID, "Connection");
                    daf.FormClosed += (s, args) => this.Close();
                    daf.Show();
                }
                else
                {
                    acceptedRequestTimer.Start();
                }

            
        }

        private void btnSkipRequests_Click(object sender, EventArgs e)
        {
            this.Hide();
            CategorySelector cs = new CategorySelector(userID);
            cs.FormClosed += (s, args) => this.Close();
            cs.Show();
        }
    }
}
