using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace AydinUniversityProject.Admin.Views.TopicView{
    public partial class TopicView : XtraUserControl {
        public TopicView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<AydinUniversityProject.Admin.ViewModels.TopicViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                topicViewBindingSource, x => x.Entity, x => x.Update());
						#region Posts Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(PostsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.TopicPostsDetails.SelectedEntity,
                    args => args.Row as AydinUniversityProject.Data.POCOs.Post,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(PostsGridView, "RowClick")
						 .EventToCommand(
						     x => x.TopicPostsDetails.Edit(null), x => x.TopicPostsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			PostsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    PostsPopUpMenu.ShowPopup(PostsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the TopicPostsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(PostsGridControl, g => g.DataSource, x => x.TopicPostsDetails.Entities);
			
														fluentAPI.BindCommand(bbiPostsNew, x => x.TopicPostsDetails.New());
																													fluentAPI.BindCommand(bbiPostsEdit,x => x.TopicPostsDetails.Edit(null), x=>x.TopicPostsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiPostsDelete,x => x.TopicPostsDetails.Delete(null), x=>x.TopicPostsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiPostsRefresh, x => x.TopicPostsDetails.Refresh());
																	#endregion
									// Binding for Lesson LookUp editor
			fluentAPI.SetBinding(LessonLookUpEdit.Properties, p => p.DataSource, x => x.LookUpLessons.Entities);
						// Binding for SentFeed LookUp editor
			fluentAPI.SetBinding(SentFeedLookUpEdit.Properties, p => p.DataSource, x => x.LookUpSentFeeds.Entities);
									fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[0]), x => x.Save());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[1]), x => x.SaveAndClose());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[2]), x => x.SaveAndNew());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[3]), x => x.Reset());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[4]), x => x.Delete());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelCloseButton.Buttons[0]), x => x.Close());	
       }
    }
}
