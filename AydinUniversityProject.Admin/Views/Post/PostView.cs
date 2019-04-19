using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace AydinUniversityProject.Admin.Views.PostView{
    public partial class PostView : XtraUserControl {
        public PostView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<AydinUniversityProject.Admin.ViewModels.PostViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                postViewBindingSource, x => x.Entity, x => x.Update());
									// Binding for FavouriteFeed LookUp editor
			fluentAPI.SetBinding(FavouriteFeedLookUpEdit.Properties, p => p.DataSource, x => x.LookUpFavouriteFeeds.Entities);
						// Binding for SentFeed LookUp editor
			fluentAPI.SetBinding(SentFeedLookUpEdit.Properties, p => p.DataSource, x => x.LookUpSentFeeds.Entities);
						// Binding for Topic LookUp editor
			fluentAPI.SetBinding(TopicLookUpEdit.Properties, p => p.DataSource, x => x.LookUpTopics.Entities);
									fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[0]), x => x.Save());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[1]), x => x.SaveAndClose());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[2]), x => x.SaveAndNew());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[3]), x => x.Reset());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[4]), x => x.Delete());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelCloseButton.Buttons[0]), x => x.Close());	
       }
    }
}
