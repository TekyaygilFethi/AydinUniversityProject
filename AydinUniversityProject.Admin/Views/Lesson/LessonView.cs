using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace AydinUniversityProject.Admin.Views.LessonView{
    public partial class LessonView : XtraUserControl {
        public LessonView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<AydinUniversityProject.Admin.ViewModels.LessonViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                lessonViewBindingSource, x => x.Entity, x => x.Update());
						#region Connections Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(ConnectionsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.LessonConnectionsDetails.SelectedEntity,
                    args => args.Row as AydinUniversityProject.Data.POCOs.Connection,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(ConnectionsGridView, "RowClick")
						 .EventToCommand(
						     x => x.LessonConnectionsDetails.Edit(null), x => x.LessonConnectionsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			ConnectionsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    ConnectionsPopUpMenu.ShowPopup(ConnectionsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the LessonConnectionsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(ConnectionsGridControl, g => g.DataSource, x => x.LessonConnectionsDetails.Entities);
			
														fluentAPI.BindCommand(bbiConnectionsNew, x => x.LessonConnectionsDetails.New());
																													fluentAPI.BindCommand(bbiConnectionsEdit,x => x.LessonConnectionsDetails.Edit(null), x=>x.LessonConnectionsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiConnectionsDelete,x => x.LessonConnectionsDetails.Delete(null), x=>x.LessonConnectionsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiConnectionsRefresh, x => x.LessonConnectionsDetails.Refresh());
																	#endregion
						#region Topics Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(TopicsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.LessonTopicsDetails.SelectedEntity,
                    args => args.Row as AydinUniversityProject.Data.POCOs.Topic,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(TopicsGridView, "RowClick")
						 .EventToCommand(
						     x => x.LessonTopicsDetails.Edit(null), x => x.LessonTopicsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			TopicsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    TopicsPopUpMenu.ShowPopup(TopicsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the LessonTopicsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(TopicsGridControl, g => g.DataSource, x => x.LessonTopicsDetails.Entities);
			
														fluentAPI.BindCommand(bbiTopicsNew, x => x.LessonTopicsDetails.New());
																													fluentAPI.BindCommand(bbiTopicsEdit,x => x.LessonTopicsDetails.Edit(null), x=>x.LessonTopicsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiTopicsDelete,x => x.LessonTopicsDetails.Delete(null), x=>x.LessonTopicsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiTopicsRefresh, x => x.LessonTopicsDetails.Refresh());
																	#endregion
						#region Educations Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(EducationsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.LessonEducationsDetails.SelectedEntity,
                    args => args.Row as AydinUniversityProject.Data.POCOs.Education,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(EducationsGridView, "RowClick")
						 .EventToCommand(
						     x => x.LessonEducationsDetails.Edit(null), x => x.LessonEducationsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			EducationsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    EducationsPopUpMenu.ShowPopup(EducationsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the LessonEducationsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(EducationsGridControl, g => g.DataSource, x => x.LessonEducationsDetails.Entities);
			
														fluentAPI.BindCommand(bbiEducationsNew, x => x.LessonEducationsDetails.New());
																													fluentAPI.BindCommand(bbiEducationsEdit,x => x.LessonEducationsDetails.Edit(null), x=>x.LessonEducationsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiEducationsDelete,x => x.LessonEducationsDetails.Delete(null), x=>x.LessonEducationsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiEducationsRefresh, x => x.LessonEducationsDetails.Refresh());
																	#endregion
									// Binding for Period LookUp editor
			fluentAPI.SetBinding(PeriodLookUpEdit.Properties, p => p.DataSource, x => x.LookUpPeriods.Entities);
									fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[0]), x => x.Save());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[1]), x => x.SaveAndClose());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[2]), x => x.SaveAndNew());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[3]), x => x.Reset());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[4]), x => x.Delete());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelCloseButton.Buttons[0]), x => x.Close());	
       }
    }
}
