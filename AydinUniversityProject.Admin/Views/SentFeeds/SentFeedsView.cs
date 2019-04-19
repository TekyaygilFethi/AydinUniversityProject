using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace AydinUniversityProject.Admin.Views.SentFeedsView{
    public partial class SentFeedsView : XtraUserControl {
        public SentFeedsView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<AydinUniversityProject.Admin.ViewModels.SentFeedsViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                sentFeedsViewBindingSource, x => x.Entity, x => x.Update());
						#region SentPosts Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(SentPostsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.SentFeedsSentPostsDetails.SelectedEntity,
                    args => args.Row as AydinUniversityProject.Data.POCOs.Post,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(SentPostsGridView, "RowClick")
						 .EventToCommand(
						     x => x.SentFeedsSentPostsDetails.Edit(null), x => x.SentFeedsSentPostsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			SentPostsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    SentPostsPopUpMenu.ShowPopup(SentPostsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the SentFeedsSentPostsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(SentPostsGridControl, g => g.DataSource, x => x.SentFeedsSentPostsDetails.Entities);
			
														fluentAPI.BindCommand(bbiSentPostsNew, x => x.SentFeedsSentPostsDetails.New());
																													fluentAPI.BindCommand(bbiSentPostsEdit,x => x.SentFeedsSentPostsDetails.Edit(null), x=>x.SentFeedsSentPostsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiSentPostsDelete,x => x.SentFeedsSentPostsDetails.Delete(null), x=>x.SentFeedsSentPostsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiSentPostsRefresh, x => x.SentFeedsSentPostsDetails.Refresh());
																	#endregion
						#region SentTopics Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(SentTopicsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.SentFeedsSentTopicsDetails.SelectedEntity,
                    args => args.Row as AydinUniversityProject.Data.POCOs.Topic,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(SentTopicsGridView, "RowClick")
						 .EventToCommand(
						     x => x.SentFeedsSentTopicsDetails.Edit(null), x => x.SentFeedsSentTopicsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			SentTopicsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    SentTopicsPopUpMenu.ShowPopup(SentTopicsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the SentFeedsSentTopicsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(SentTopicsGridControl, g => g.DataSource, x => x.SentFeedsSentTopicsDetails.Entities);
			
														fluentAPI.BindCommand(bbiSentTopicsNew, x => x.SentFeedsSentTopicsDetails.New());
																													fluentAPI.BindCommand(bbiSentTopicsEdit,x => x.SentFeedsSentTopicsDetails.Edit(null), x=>x.SentFeedsSentTopicsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiSentTopicsDelete,x => x.SentFeedsSentTopicsDetails.Delete(null), x=>x.SentFeedsSentTopicsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiSentTopicsRefresh, x => x.SentFeedsSentTopicsDetails.Refresh());
																	#endregion
									// Binding for User LookUp editor
			fluentAPI.SetBinding(UserLookUpEdit.Properties, p => p.DataSource, x => x.LookUpUsers.Entities);
									fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[0]), x => x.Save());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[1]), x => x.SaveAndClose());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[2]), x => x.SaveAndNew());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[3]), x => x.Reset());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[4]), x => x.Delete());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelCloseButton.Buttons[0]), x => x.Close());	
       }
    }
}
