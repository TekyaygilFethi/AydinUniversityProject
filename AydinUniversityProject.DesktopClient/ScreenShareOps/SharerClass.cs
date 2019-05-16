using RDPCOMAPILib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TeachLearnDesktop;

namespace TeachLearnDesktop.Sharer
{
    public class SharerClass
    {
        protected static RDPSession m_pRdpSession = null;
        private string InvitationString;

        public void OpenShare()
        {
            try
            {
                m_pRdpSession = new RDPSession();

                m_pRdpSession.OnAttendeeConnected += new _IRDPSessionEvents_OnAttendeeConnectedEventHandler(OnAttendeeConnected);
                m_pRdpSession.OnAttendeeDisconnected += new _IRDPSessionEvents_OnAttendeeDisconnectedEventHandler(OnAttendeeDisconnected);
                m_pRdpSession.OnControlLevelChangeRequest += new _IRDPSessionEvents_OnControlLevelChangeRequestEventHandler(OnControlLevelChangeRequest);

                m_pRdpSession.Open();
                IRDPSRAPIInvitation pInvitation = m_pRdpSession.Invitations.CreateInvitation("WinPresenter", "PresentationGroup", "Password", 1);
                InvitationString = pInvitation.ConnectionString;
                
            }
            catch (Exception ex){}
        }

        public void CloseShare()
        {
            try
            {
                m_pRdpSession.Close();
                Marshal.ReleaseComObject(m_pRdpSession);
                m_pRdpSession = null;
            }
            catch (Exception ex)
            {
                //LogTextBox.Text += "Error occured while stopping presentation. Error: " + ex.ToString();
            }
        }
        
        #region EVENTS
        void OnAttendeeDisconnected(object pDisconnectInfo)
        {
            IRDPSRAPIAttendeeDisconnectInfo pDiscInfo = pDisconnectInfo as IRDPSRAPIAttendeeDisconnectInfo;
            //LogTextBox.Text += ("Attendee Disconnected: " + pDiscInfo.Attendee.RemoteName + Environment.NewLine);
        }

        void OnControlLevelChangeRequest(object pObjAttendee, CTRL_LEVEL RequestedLevel)
        {
            IRDPSRAPIAttendee pAttendee = pObjAttendee as IRDPSRAPIAttendee;
            pAttendee.ControlLevel = RequestedLevel;
        }

        private void OnAttendeeConnected(object pObjAttendee)
        {
            IRDPSRAPIAttendee pAttendee = pObjAttendee as IRDPSRAPIAttendee;
            pAttendee.ControlLevel = CTRL_LEVEL.CTRL_LEVEL_VIEW;
            //LogTextBox.Text += ("Attendee Connected: " + pAttendee.RemoteName + Environment.NewLine); DBYE YAZ
        }


        public string ReturnInvitationString()
        {
            return InvitationString;
        }
        #endregion
        
    }
}
