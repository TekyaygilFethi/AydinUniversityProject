using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace AydinUniversityProject.Admin.Views.PeriodView{
    public partial class PeriodView : XtraUserControl {
        public PeriodView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<AydinUniversityProject.Admin.ViewModels.PeriodViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                periodViewBindingSource, x => x.Entity, x => x.Update());
						#region Lessons Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(LessonsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.PeriodLessonsDetails.SelectedEntity,
                    args => args.Row as AydinUniversityProject.Data.POCOs.Lesson,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(LessonsGridView, "RowClick")
						 .EventToCommand(
						     x => x.PeriodLessonsDetails.Edit(null), x => x.PeriodLessonsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			LessonsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    LessonsPopUpMenu.ShowPopup(LessonsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the PeriodLessonsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(LessonsGridControl, g => g.DataSource, x => x.PeriodLessonsDetails.Entities);
			
														fluentAPI.BindCommand(bbiLessonsNew, x => x.PeriodLessonsDetails.New());
																													fluentAPI.BindCommand(bbiLessonsEdit,x => x.PeriodLessonsDetails.Edit(null), x=>x.PeriodLessonsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiLessonsDelete,x => x.PeriodLessonsDetails.Delete(null), x=>x.PeriodLessonsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiLessonsRefresh, x => x.PeriodLessonsDetails.Refresh());
																	#endregion
						#region Students Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(StudentsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.PeriodStudentsDetails.SelectedEntity,
                    args => args.Row as AydinUniversityProject.Data.POCOs.Student,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(StudentsGridView, "RowClick")
						 .EventToCommand(
						     x => x.PeriodStudentsDetails.Edit(null), x => x.PeriodStudentsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			StudentsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    StudentsPopUpMenu.ShowPopup(StudentsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the PeriodStudentsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(StudentsGridControl, g => g.DataSource, x => x.PeriodStudentsDetails.Entities);
			
														fluentAPI.BindCommand(bbiStudentsNew, x => x.PeriodStudentsDetails.New());
																													fluentAPI.BindCommand(bbiStudentsEdit,x => x.PeriodStudentsDetails.Edit(null), x=>x.PeriodStudentsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiStudentsDelete,x => x.PeriodStudentsDetails.Delete(null), x=>x.PeriodStudentsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiStudentsRefresh, x => x.PeriodStudentsDetails.Refresh());
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
