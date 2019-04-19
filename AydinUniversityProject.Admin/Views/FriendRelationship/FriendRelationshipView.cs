using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace AydinUniversityProject.Admin.Views.FriendRelationshipView{
    public partial class FriendRelationshipView : XtraUserControl {
        public FriendRelationshipView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<AydinUniversityProject.Admin.ViewModels.FriendRelationshipViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                friendRelationshipViewBindingSource, x => x.Entity, x => x.Update());
						#region Friends Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(FriendsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.FriendRelationshipFriendsDetails.SelectedEntity,
                    args => args.Row as AydinUniversityProject.Data.POCOs.User,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(FriendsGridView, "RowClick")
						 .EventToCommand(
						     x => x.FriendRelationshipFriendsDetails.Edit(null), x => x.FriendRelationshipFriendsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			FriendsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    FriendsPopUpMenu.ShowPopup(FriendsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the FriendRelationshipFriendsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(FriendsGridControl, g => g.DataSource, x => x.FriendRelationshipFriendsDetails.Entities);
			
														fluentAPI.BindCommand(bbiFriendsNew, x => x.FriendRelationshipFriendsDetails.New());
																													fluentAPI.BindCommand(bbiFriendsEdit,x => x.FriendRelationshipFriendsDetails.Edit(null), x=>x.FriendRelationshipFriendsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiFriendsDelete,x => x.FriendRelationshipFriendsDetails.Delete(null), x=>x.FriendRelationshipFriendsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiFriendsRefresh, x => x.FriendRelationshipFriendsDetails.Refresh());
																	#endregion
												fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[0]), x => x.Save());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[1]), x => x.SaveAndClose());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[2]), x => x.SaveAndNew());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[3]), x => x.Reset());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[4]), x => x.Delete());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelCloseButton.Buttons[0]), x => x.Close());	
       }
    }
}
