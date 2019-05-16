using RDPCOMAPILib;
//using AxRDPCOMAPILib;
using System;

namespace TeachLearnDesktop.Viewer
{
    public class ViewerClass
    {
        public void ReturnConnectionObject(RDPViewer RDPViewer)
        {
            //ConnectionObject _conObject = new ConnectionObject() { ConnectionString = "", Name = "", Password = "" };

            //string _outputJSON = JsonConvert.SerializeObject(_conObject);


            // return _outputJSON;
            string ConnectionString = "";
            if (ConnectionString != null)
            {
                try
                {

                    RDPViewer.Connect(ConnectionString, "Viewer1", "Password");
                }
                catch (Exception ex)
                {
                    //LogTextBox.Text += ("Error in Connecting. Error Info: " + ex.ToString() + Environment.NewLine);
                }
            }
        }

        public void Disconnect(RDPViewer pRdpViewer)
        {
            pRdpViewer.Disconnect();
        }
        
        private void OnConnectionEstablished(object sender, EventArgs e)
        {
            //LogTextBox.Text += "Connection Established" + Environment.NewLine;
        }

        //private void OnError(object sender, _IRDPSessionEvents_OnErrorEvent e)
        //{
        //    int ErrorCode = (int)e.errorInfo;
        //    //LogTextBox.Text += ("Error 0x" + ErrorCode.ToString("X") + Environment.NewLine);
        //}

        //private void OnConnectionTerminated(object sender, _IRDPSessionEvents_OnConnectionTerminatedEvent e)
        //{
        //    //LogTextBox.Text += "Connection Terminated. Reason: " + e.discReason + Environment.NewLine;
        //}
        
        private void OnConnectionFailed(object sender, EventArgs e)
        {
            //LogTextBox.Text += "Connection Failed." + Environment.NewLine;
        }



    }
}
