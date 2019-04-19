using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace AydinUniversityProject.Admin.Views.UserView{
    public partial class UserView : XtraUserControl {
        public UserView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<AydinUniversityProject.Admin.ViewModels.UserViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                userViewBindingSource, x => x.Entity, x => x.Update());
						#region ConnectionsAsSharer Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(ConnectionsAsSharerGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UserConnectionsAsSharerDetails.SelectedEntity,
                    args => args.Row as AydinUniversityProject.Data.POCOs.Connection,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(ConnectionsAsSharerGridView, "RowClick")
						 .EventToCommand(
						     x => x.UserConnectionsAsSharerDetails.Edit(null), x => x.UserConnectionsAsSharerDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			ConnectionsAsSharerGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    ConnectionsAsSharerPopUpMenu.ShowPopup(ConnectionsAsSharerGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UserConnectionsAsSharerDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(ConnectionsAsSharerGridControl, g => g.DataSource, x => x.UserConnectionsAsSharerDetails.Entities);
			
														fluentAPI.BindCommand(bbiConnectionsAsSharerNew, x => x.UserConnectionsAsSharerDetails.New());
																													fluentAPI.BindCommand(bbiConnectionsAsSharerEdit,x => x.UserConnectionsAsSharerDetails.Edit(null), x=>x.UserConnectionsAsSharerDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiConnectionsAsSharerDelete,x => x.UserConnectionsAsSharerDetails.Delete(null), x=>x.UserConnectionsAsSharerDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiConnectionsAsSharerRefresh, x => x.UserConnectionsAsSharerDetails.Refresh());
																	#endregion
						#region ConnectionsAsViewer Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(ConnectionsAsViewerGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UserConnectionsAsViewerDetails.SelectedEntity,
                    args => args.Row as AydinUniversityProject.Data.POCOs.Connection,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(ConnectionsAsViewerGridView, "RowClick")
						 .EventToCommand(
						     x => x.UserConnectionsAsViewerDetails.Edit(null), x => x.UserConnectionsAsViewerDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			ConnectionsAsViewerGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    ConnectionsAsViewerPopUpMenu.ShowPopup(ConnectionsAsViewerGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UserConnectionsAsViewerDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(ConnectionsAsViewerGridControl, g => g.DataSource, x => x.UserConnectionsAsViewerDetails.Entities);
			
														fluentAPI.BindCommand(bbiConnectionsAsViewerNew, x => x.UserConnectionsAsViewerDetails.New());
																													fluentAPI.BindCommand(bbiConnectionsAsViewerEdit,x => x.UserConnectionsAsViewerDetails.Edit(null), x=>x.UserConnectionsAsViewerDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiConnectionsAsViewerDelete,x => x.UserConnectionsAsViewerDetails.Delete(null), x=>x.UserConnectionsAsViewerDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiConnectionsAsViewerRefresh, x => x.UserConnectionsAsViewerDetails.Refresh());
																	#endregion
						#region SentScreenShareRequests Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(SentScreenShareRequestsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UserSentScreenShareRequestsDetails.SelectedEntity,
                    args => args.Row as AydinUniversityProject.Data.POCOs.ScreenShareRequest,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(SentScreenShareRequestsGridView, "RowClick")
						 .EventToCommand(
						     x => x.UserSentScreenShareRequestsDetails.Edit(null), x => x.UserSentScreenShareRequestsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			SentScreenShareRequestsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    SentScreenShareRequestsPopUpMenu.ShowPopup(SentScreenShareRequestsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UserSentScreenShareRequestsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(SentScreenShareRequestsGridControl, g => g.DataSource, x => x.UserSentScreenShareRequestsDetails.Entities);
			
														fluentAPI.BindCommand(bbiSentScreenShareRequestsNew, x => x.UserSentScreenShareRequestsDetails.New());
																													fluentAPI.BindCommand(bbiSentScreenShareRequestsEdit,x => x.UserSentScreenShareRequestsDetails.Edit(null), x=>x.UserSentScreenShareRequestsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiSentScreenShareRequestsDelete,x => x.UserSentScreenShareRequestsDetails.Delete(null), x=>x.UserSentScreenShareRequestsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiSentScreenShareRequestsRefresh, x => x.UserSentScreenShareRequestsDetails.Refresh());
																	#endregion
						#region ReceivedScreenShareRequests Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(ReceivedScreenShareRequestsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UserReceivedScreenShareRequestsDetails.SelectedEntity,
                    args => args.Row as AydinUniversityProject.Data.POCOs.ScreenShareRequest,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(ReceivedScreenShareRequestsGridView, "RowClick")
						 .EventToCommand(
						     x => x.UserReceivedScreenShareRequestsDetails.Edit(null), x => x.UserReceivedScreenShareRequestsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			ReceivedScreenShareRequestsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    ReceivedScreenShareRequestsPopUpMenu.ShowPopup(ReceivedScreenShareRequestsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UserReceivedScreenShareRequestsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(ReceivedScreenShareRequestsGridControl, g => g.DataSource, x => x.UserReceivedScreenShareRequestsDetails.Entities);
			
														fluentAPI.BindCommand(bbiReceivedScreenShareRequestsNew, x => x.UserReceivedScreenShareRequestsDetails.New());
																													fluentAPI.BindCommand(bbiReceivedScreenShareRequestsEdit,x => x.UserReceivedScreenShareRequestsDetails.Edit(null), x=>x.UserReceivedScreenShareRequestsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiReceivedScreenShareRequestsDelete,x => x.UserReceivedScreenShareRequestsDetails.Delete(null), x=>x.UserReceivedScreenShareRequestsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiReceivedScreenShareRequestsRefresh, x => x.UserReceivedScreenShareRequestsDetails.Refresh());
																	#endregion
						#region SentFriendRequests Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(SentFriendRequestsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UserSentFriendRequestsDetails.SelectedEntity,
                    args => args.Row as AydinUniversityProject.Data.POCOs.FriendRequest,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(SentFriendRequestsGridView, "RowClick")
						 .EventToCommand(
						     x => x.UserSentFriendRequestsDetails.Edit(null), x => x.UserSentFriendRequestsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			SentFriendRequestsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    SentFriendRequestsPopUpMenu.ShowPopup(SentFriendRequestsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UserSentFriendRequestsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(SentFriendRequestsGridControl, g => g.DataSource, x => x.UserSentFriendRequestsDetails.Entities);
			
														fluentAPI.BindCommand(bbiSentFriendRequestsNew, x => x.UserSentFriendRequestsDetails.New());
																													fluentAPI.BindCommand(bbiSentFriendRequestsEdit,x => x.UserSentFriendRequestsDetails.Edit(null), x=>x.UserSentFriendRequestsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiSentFriendRequestsDelete,x => x.UserSentFriendRequestsDetails.Delete(null), x=>x.UserSentFriendRequestsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiSentFriendRequestsRefresh, x => x.UserSentFriendRequestsDetails.Refresh());
																	#endregion
						#region ReceivedFriendRequests Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(ReceivedFriendRequestsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UserReceivedFriendRequestsDetails.SelectedEntity,
                    args => args.Row as AydinUniversityProject.Data.POCOs.FriendRequest,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(ReceivedFriendRequestsGridView, "RowClick")
						 .EventToCommand(
						     x => x.UserReceivedFriendRequestsDetails.Edit(null), x => x.UserReceivedFriendRequestsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			ReceivedFriendRequestsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    ReceivedFriendRequestsPopUpMenu.ShowPopup(ReceivedFriendRequestsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UserReceivedFriendRequestsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(ReceivedFriendRequestsGridControl, g => g.DataSource, x => x.UserReceivedFriendRequestsDetails.Entities);
			
														fluentAPI.BindCommand(bbiReceivedFriendRequestsNew, x => x.UserReceivedFriendRequestsDetails.New());
																													fluentAPI.BindCommand(bbiReceivedFriendRequestsEdit,x => x.UserReceivedFriendRequestsDetails.Edit(null), x=>x.UserReceivedFriendRequestsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiReceivedFriendRequestsDelete,x => x.UserReceivedFriendRequestsDetails.Delete(null), x=>x.UserReceivedFriendRequestsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiReceivedFriendRequestsRefresh, x => x.UserReceivedFriendRequestsDetails.Refresh());
																	#endregion
						#region ReceivedMessages Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(ReceivedMessagesGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UserReceivedMessagesDetails.SelectedEntity,
                    args => args.Row as AydinUniversityProject.Data.POCOs.Message,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(ReceivedMessagesGridView, "RowClick")
						 .EventToCommand(
						     x => x.UserReceivedMessagesDetails.Edit(null), x => x.UserReceivedMessagesDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			ReceivedMessagesGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    ReceivedMessagesPopUpMenu.ShowPopup(ReceivedMessagesGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UserReceivedMessagesDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(ReceivedMessagesGridControl, g => g.DataSource, x => x.UserReceivedMessagesDetails.Entities);
			
														fluentAPI.BindCommand(bbiReceivedMessagesNew, x => x.UserReceivedMessagesDetails.New());
																													fluentAPI.BindCommand(bbiReceivedMessagesEdit,x => x.UserReceivedMessagesDetails.Edit(null), x=>x.UserReceivedMessagesDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiReceivedMessagesDelete,x => x.UserReceivedMessagesDetails.Delete(null), x=>x.UserReceivedMessagesDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiReceivedMessagesRefresh, x => x.UserReceivedMessagesDetails.Refresh());
																	#endregion
						#region SentMessages Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(SentMessagesGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UserSentMessagesDetails.SelectedEntity,
                    args => args.Row as AydinUniversityProject.Data.POCOs.Message,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(SentMessagesGridView, "RowClick")
						 .EventToCommand(
						     x => x.UserSentMessagesDetails.Edit(null), x => x.UserSentMessagesDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			SentMessagesGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    SentMessagesPopUpMenu.ShowPopup(SentMessagesGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UserSentMessagesDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(SentMessagesGridControl, g => g.DataSource, x => x.UserSentMessagesDetails.Entities);
			
														fluentAPI.BindCommand(bbiSentMessagesNew, x => x.UserSentMessagesDetails.New());
																													fluentAPI.BindCommand(bbiSentMessagesEdit,x => x.UserSentMessagesDetails.Edit(null), x=>x.UserSentMessagesDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiSentMessagesDelete,x => x.UserSentMessagesDetails.Delete(null), x=>x.UserSentMessagesDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiSentMessagesRefresh, x => x.UserSentMessagesDetails.Refresh());
																	#endregion
						#region Reviews Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(ReviewsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UserReviewsDetails.SelectedEntity,
                    args => args.Row as AydinUniversityProject.Data.POCOs.Review,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(ReviewsGridView, "RowClick")
						 .EventToCommand(
						     x => x.UserReviewsDetails.Edit(null), x => x.UserReviewsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			ReviewsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    ReviewsPopUpMenu.ShowPopup(ReviewsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UserReviewsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(ReviewsGridControl, g => g.DataSource, x => x.UserReviewsDetails.Entities);
			
														fluentAPI.BindCommand(bbiReviewsNew, x => x.UserReviewsDetails.New());
																													fluentAPI.BindCommand(bbiReviewsEdit,x => x.UserReviewsDetails.Edit(null), x=>x.UserReviewsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiReviewsDelete,x => x.UserReviewsDetails.Delete(null), x=>x.UserReviewsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiReviewsRefresh, x => x.UserReviewsDetails.Refresh());
																	#endregion
									// Binding for FriendRelationship LookUp editor
			fluentAPI.SetBinding(FriendRelationshipLookUpEdit.Properties, p => p.DataSource, x => x.LookUpFriendRelationships.Entities);
									fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[0]), x => x.Save());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[1]), x => x.SaveAndClose());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[2]), x => x.SaveAndNew());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[3]), x => x.Reset());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[4]), x => x.Delete());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelCloseButton.Buttons[0]), x => x.Close());	
       }
    }
}
