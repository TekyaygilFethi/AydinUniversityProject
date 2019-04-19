using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace AydinUniversityProject.Admin.Views.EducationView{
    public partial class EducationView : XtraUserControl {
        public EducationView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<AydinUniversityProject.Admin.ViewModels.EducationViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                educationViewBindingSource, x => x.Entity, x => x.Update());
						#region Notes Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(NotesGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.EducationNotesDetails.SelectedEntity,
                    args => args.Row as AydinUniversityProject.Data.POCOs.Note,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(NotesGridView, "RowClick")
						 .EventToCommand(
						     x => x.EducationNotesDetails.Edit(null), x => x.EducationNotesDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			NotesGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    NotesPopUpMenu.ShowPopup(NotesGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the EducationNotesDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(NotesGridControl, g => g.DataSource, x => x.EducationNotesDetails.Entities);
			
														fluentAPI.BindCommand(bbiNotesNew, x => x.EducationNotesDetails.New());
																													fluentAPI.BindCommand(bbiNotesEdit,x => x.EducationNotesDetails.Edit(null), x=>x.EducationNotesDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiNotesDelete,x => x.EducationNotesDetails.Delete(null), x=>x.EducationNotesDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiNotesRefresh, x => x.EducationNotesDetails.Refresh());
																	#endregion
									// Binding for Lesson LookUp editor
			fluentAPI.SetBinding(LessonLookUpEdit.Properties, p => p.DataSource, x => x.LookUpLessons.Entities);
						// Binding for Student LookUp editor
			fluentAPI.SetBinding(StudentLookUpEdit.Properties, p => p.DataSource, x => x.LookUpStudents.Entities);
									fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[0]), x => x.Save());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[1]), x => x.SaveAndClose());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[2]), x => x.SaveAndNew());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[3]), x => x.Reset());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[4]), x => x.Delete());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelCloseButton.Buttons[0]), x => x.Close());	
       }
    }
}
