﻿using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace AydinUniversityProject.Admin.Views.StudentView{
    public partial class StudentView : XtraUserControl {
        public StudentView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<AydinUniversityProject.Admin.ViewModels.StudentViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                studentViewBindingSource, x => x.Entity, x => x.Update());
						#region Educations Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(EducationsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.StudentEducationsDetails.SelectedEntity,
                    args => args.Row as AydinUniversityProject.Data.POCOs.Education,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(EducationsGridView, "RowClick")
						 .EventToCommand(
						     x => x.StudentEducationsDetails.Edit(null), x => x.StudentEducationsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			EducationsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    EducationsPopUpMenu.ShowPopup(EducationsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the StudentEducationsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(EducationsGridControl, g => g.DataSource, x => x.StudentEducationsDetails.Entities);
			
														fluentAPI.BindCommand(bbiEducationsNew, x => x.StudentEducationsDetails.New());
																													fluentAPI.BindCommand(bbiEducationsEdit,x => x.StudentEducationsDetails.Edit(null), x=>x.StudentEducationsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiEducationsDelete,x => x.StudentEducationsDetails.Delete(null), x=>x.StudentEducationsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiEducationsRefresh, x => x.StudentEducationsDetails.Refresh());
																	#endregion
									// Binding for Period LookUp editor
			fluentAPI.SetBinding(PeriodLookUpEdit.Properties, p => p.DataSource, x => x.LookUpPeriods.Entities);
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
