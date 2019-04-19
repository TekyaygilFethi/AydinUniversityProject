using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace AydinUniversityProject.Admin.Views.ConnectionView{
    public partial class ConnectionView : XtraUserControl {
        public ConnectionView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<AydinUniversityProject.Admin.ViewModels.ConnectionViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                connectionViewBindingSource, x => x.Entity, x => x.Update());
						#region BaseRequests Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(BaseRequestsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.ConnectionBaseRequestsDetails.SelectedEntity,
                    args => args.Row as AydinUniversityProject.Data.POCOs.ScreenShareRequest,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(BaseRequestsGridView, "RowClick")
						 .EventToCommand(
						     x => x.ConnectionBaseRequestsDetails.Edit(null), x => x.ConnectionBaseRequestsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			BaseRequestsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    BaseRequestsPopUpMenu.ShowPopup(BaseRequestsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the ConnectionBaseRequestsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(BaseRequestsGridControl, g => g.DataSource, x => x.ConnectionBaseRequestsDetails.Entities);
			
														fluentAPI.BindCommand(bbiBaseRequestsNew, x => x.ConnectionBaseRequestsDetails.New());
																													fluentAPI.BindCommand(bbiBaseRequestsEdit,x => x.ConnectionBaseRequestsDetails.Edit(null), x=>x.ConnectionBaseRequestsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiBaseRequestsDelete,x => x.ConnectionBaseRequestsDetails.Delete(null), x=>x.ConnectionBaseRequestsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiBaseRequestsRefresh, x => x.ConnectionBaseRequestsDetails.Refresh());
																	#endregion
						#region Reviews Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(ReviewsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.ConnectionReviewsDetails.SelectedEntity,
                    args => args.Row as AydinUniversityProject.Data.POCOs.Review,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(ReviewsGridView, "RowClick")
						 .EventToCommand(
						     x => x.ConnectionReviewsDetails.Edit(null), x => x.ConnectionReviewsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			ReviewsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    ReviewsPopUpMenu.ShowPopup(ReviewsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the ConnectionReviewsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(ReviewsGridControl, g => g.DataSource, x => x.ConnectionReviewsDetails.Entities);
			
														fluentAPI.BindCommand(bbiReviewsNew, x => x.ConnectionReviewsDetails.New());
																													fluentAPI.BindCommand(bbiReviewsEdit,x => x.ConnectionReviewsDetails.Edit(null), x=>x.ConnectionReviewsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiReviewsDelete,x => x.ConnectionReviewsDetails.Delete(null), x=>x.ConnectionReviewsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiReviewsRefresh, x => x.ConnectionReviewsDetails.Refresh());
																	#endregion
									// Binding for Lesson LookUp editor
			fluentAPI.SetBinding(LessonLookUpEdit.Properties, p => p.DataSource, x => x.LookUpLessons.Entities);
						// Binding for Sharer LookUp editor
			fluentAPI.SetBinding(SharerLookUpEdit.Properties, p => p.DataSource, x => x.LookUpUsers.Entities);
						// Binding for Viewer LookUp editor
			fluentAPI.SetBinding(ViewerLookUpEdit.Properties, p => p.DataSource, x => x.LookUpUsers.Entities);
									fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[0]), x => x.Save());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[1]), x => x.SaveAndClose());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[2]), x => x.SaveAndNew());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[3]), x => x.Reset());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[4]), x => x.Delete());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelCloseButton.Buttons[0]), x => x.Close());	
       }
    }
}
