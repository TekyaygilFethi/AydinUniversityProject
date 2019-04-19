namespace AydinUniversityProject.Admin.Views.EducationView {
    partial class EducationView {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
		 #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
			this.windowsUIButtonPanelCloseButton = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.windowsUIButtonPanelMain = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
			this.labelControl = new DevExpress.XtraEditors.LabelControl();
						this.NotesGridControl = new DevExpress.XtraGrid.GridControl();
			this.NotesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.NotesBarManager = new DevExpress.XtraBars.BarManager();
			this.NotesBar = new DevExpress.XtraBars.Bar();
			this.NotesXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.NotesPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiNotesNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiNotesEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiNotesDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiNotesRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.NotesBarManager)).BeginInit();
									this.LessonLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.LessonBindingSource = new System.Windows.Forms.BindingSource(this.components);
						this.StudentLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.StudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
			 
			this.SuspendLayout();
			// 
            // windowsUIButtonPanelCloseButton
            // 
            this.windowsUIButtonPanelCloseButton.ButtonInterval = 0;
            this.windowsUIButtonPanelCloseButton.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("", null, "Backward;Size32x32;GrayScaled")});
            this.windowsUIButtonPanelCloseButton.ContentAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.windowsUIButtonPanelCloseButton.Dock = System.Windows.Forms.DockStyle.Left;
			this.windowsUIButtonPanelCloseButton.ForeColor = System.Drawing.Color.Gray;
            this.windowsUIButtonPanelCloseButton.MaximumSize = new System.Drawing.Size(45, 0);
            this.windowsUIButtonPanelCloseButton.MinimumSize = new System.Drawing.Size(45, 0);
            this.windowsUIButtonPanelCloseButton.Name = "windowsUIButtonPanelCloseButton";
            this.windowsUIButtonPanelCloseButton.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.windowsUIButtonPanelCloseButton.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.windowsUIButtonPanelCloseButton.Text = "windowsUIButtonPanel1";
			// 
            // windowsUIButtonPanelMain
            // 
			this.windowsUIButtonPanelMain.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.FontSizeDelta = -1;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseBackColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Normal.FontSizeDelta = -1;
            this.windowsUIButtonPanelMain.AppearanceButton.Normal.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.FontSizeDelta = -1;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseBackColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseForeColor = true;
            this.windowsUIButtonPanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.windowsUIButtonPanelMain.EnableImageTransparency = true;
            this.windowsUIButtonPanelMain.ForeColor = System.Drawing.Color.White;
            this.windowsUIButtonPanelMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.windowsUIButtonPanelMain.Name = "windowsUIButtonPanelMain";
            this.windowsUIButtonPanelMain.Text = "windowsUIButtonPanelMain";
			this.windowsUIButtonPanelMain.MinimumSize = new System.Drawing.Size(60, 60);
			this.windowsUIButtonPanelMain.MaximumSize = new System.Drawing.Size(0, 60);
            this.windowsUIButtonPanelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.windowsUIButtonPanelMain.UseButtonBackgroundImages = false;
						this.windowsUIButtonPanelMain.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Save", null, "Save;Size32x32;GrayScaled"));
						this.windowsUIButtonPanelMain.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Save And Close", null, "SaveAndClose;Size32x32;GrayScaled"));
						this.windowsUIButtonPanelMain.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Save And New", null, "SaveAndNew;Size32x32;GrayScaled"));
						this.windowsUIButtonPanelMain.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Reset Changes", null, "Reset;Size32x32;GrayScaled"));
						this.windowsUIButtonPanelMain.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Delete", null, "Edit/Delete;Size32x32;GrayScaled"));
						// 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.TextVisible = false;
			// 
            // dataLayoutControl1item.CommandPropertyName
            // 
            this.dataLayoutControl1.AllowCustomization = false;
			this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataLayoutControl1.Root = this.layoutControlGroup1;
			this.educationViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.educationViewBindingSource.DataSource = typeof(AydinUniversityProject.Data.POCOs.Education);
			this.dataLayoutControl1.DataSource = educationViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
           	parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
						//
			//NotesGridControl
			//
			this.NotesGridControl.MainView = this.NotesGridView;
			this.NotesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotesGridControl.Name = "NotesGridControl";
            this.NotesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.NotesGridView});
			//
			//NotesGridView
			//
            this.NotesGridView.GridControl = this.NotesGridControl;
            this.NotesGridView.Name = "NotesGridView";
            this.NotesGridView.OptionsBehavior.Editable = false;
            this.NotesGridView.OptionsBehavior.ReadOnly = true;
			this.NotesGridView.OptionsView.ShowGroupPanel = false;
			//
			//NotesPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters NotesPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters EducationNotesChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            EducationNotesChildPopulateColumnParameters_NotVisible.FieldName = "Education";
		    EducationNotesChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			NotesPopulateColumnsParameters.CustomColumnParameters.Add(EducationNotesChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters LessonNotesChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            LessonNotesChildPopulateColumnParameters.FieldName = "LessonNotes";
            LessonNotesChildPopulateColumnParameters.Path = "Lesson.Name";
			NotesPopulateColumnsParameters.CustomColumnParameters.Add(LessonNotesChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters StudentNotesChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            StudentNotesChildPopulateColumnParameters.FieldName = "StudentNotes";
            StudentNotesChildPopulateColumnParameters.Path = "Student.Name";
			NotesPopulateColumnsParameters.CustomColumnParameters.Add(StudentNotesChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters NotesNotesChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            NotesNotesChildPopulateColumnParameters.FieldName = "NotesNotes";
            NotesNotesChildPopulateColumnParameters.Path = "Notes.Description";
			NotesPopulateColumnsParameters.CustomColumnParameters.Add(NotesNotesChildPopulateColumnParameters);
			 
		    this.NotesGridView.PopulateColumns(typeof(AydinUniversityProject.Data.POCOs.Note),NotesPopulateColumnsParameters);
			//
			//NotesBindingSource
			//
			System.Windows.Forms.BindingSource NotesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			NotesBindingSource.DataSource = typeof(AydinUniversityProject.Data.POCOs.Note);
            this.NotesGridControl.DataSource = NotesBindingSource;
			//
			//NotesXtraUserControl
			//
            this.NotesXtraUserControl.Controls.Add(NotesGridControl);
			this.NotesXtraUserControl.Name = "NotesXtraUserControl";
			this.NotesXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//NotesNew
			//
			this.bbiNotesNew.Caption = "New";
			this.bbiNotesNew.Name = "bbiNotesNew";
			this.bbiNotesNew.ImageUri.Uri = "New";
			this.bbiNotesNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.NotesBarManager.Items.Add(this.bbiNotesNew);
			this.NotesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiNotesNew));
			this.NotesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiNotesNew));
						//
			//NotesEdit
			//
			this.bbiNotesEdit.Caption = "Edit";
			this.bbiNotesEdit.Name = "bbiNotesEdit";
			this.bbiNotesEdit.ImageUri.Uri = "Edit";
			this.bbiNotesEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.NotesBarManager.Items.Add(this.bbiNotesEdit);
			this.NotesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiNotesEdit));
			this.NotesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiNotesEdit));
						//
			//NotesDelete
			//
			this.bbiNotesDelete.Caption = "Delete";
			this.bbiNotesDelete.Name = "bbiNotesDelete";
			this.bbiNotesDelete.ImageUri.Uri = "Delete";
			this.bbiNotesDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.NotesBarManager.Items.Add(this.bbiNotesDelete);
			this.NotesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiNotesDelete));
			this.NotesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiNotesDelete));
						//
			//NotesRefresh
			//
			this.bbiNotesRefresh.Caption = "Refresh";
			this.bbiNotesRefresh.Name = "bbiNotesRefresh";
			this.bbiNotesRefresh.ImageUri.Uri = "Refresh";
			this.bbiNotesRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.NotesBarManager.Items.Add(this.bbiNotesRefresh);
			this.NotesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiNotesRefresh));
			this.NotesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiNotesRefresh));
						//
			//NotesBar
			//
			this.NotesBar.BarName = "Notes";
            this.NotesBar.DockCol = 0;
            this.NotesBar.DockRow = 0;
            this.NotesBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.NotesBar.OptionsBar.AllowQuickCustomization = false;
            this.NotesBar.OptionsBar.DrawDragBorder = false;
            this.NotesBar.Text = "Notes";
			//
			//NotesBarManager
			//
			this.NotesBarManager.AllowCustomization = false;
            this.NotesBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.NotesBar});
            this.NotesBarManager.Form = NotesXtraUserControl;
            this.NotesBarManager.MainMenu = this.NotesBar;
			// 
            // NotesPopUpMenu
            // 
            this.NotesPopUpMenu.Manager = this.NotesBarManager;
            this.NotesPopUpMenu.Name = "NotesPopUpMenu";
			//
			//NotesRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters NotesRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            NotesRetriveFieldParameters.FieldName = "Notes";
            NotesRetriveFieldParameters.ControlForField = NotesXtraUserControl;
			NotesRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(NotesRetriveFieldParameters);
									//
			//LessonLookUpEdit
			//
			this.LessonBindingSource.DataSource = typeof(AydinUniversityProject.Data.POCOs.Lesson);
			this.LessonLookUpEdit.Properties.ValueMember = "ID"; 
			this.LessonLookUpEdit.Properties.DisplayMember = "Name";
			this.LessonLookUpEdit.Properties.DataSource = this.LessonBindingSource;
			this.LessonLookUpEdit.Name = "LessonLookUpEdit";
			this.LessonLookUpEdit.DataBindings.Add("EditValue", educationViewBindingSource, "LessonID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters LessonLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            LessonLookUpEditRetrieveFieldParameters.FieldName = "LessonID";
            LessonLookUpEditRetrieveFieldParameters.ControlForField = this.LessonLookUpEdit;
			parameters.CustomListParameters.Add(LessonLookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters LessonLookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    LessonLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "Lesson";
		    LessonLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(LessonLookUpEditRetrieveFieldParameters_NotGenerate);
						//
			//StudentLookUpEdit
			//
			this.StudentBindingSource.DataSource = typeof(AydinUniversityProject.Data.POCOs.Student);
			this.StudentLookUpEdit.Properties.ValueMember = "ID"; 
			this.StudentLookUpEdit.Properties.DisplayMember = "Name";
			this.StudentLookUpEdit.Properties.DataSource = this.StudentBindingSource;
			this.StudentLookUpEdit.Name = "StudentLookUpEdit";
			this.StudentLookUpEdit.DataBindings.Add("EditValue", educationViewBindingSource, "StudentID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters StudentLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            StudentLookUpEditRetrieveFieldParameters.FieldName = "StudentID";
            StudentLookUpEditRetrieveFieldParameters.ControlForField = this.StudentLookUpEdit;
			parameters.CustomListParameters.Add(StudentLookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters StudentLookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    StudentLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "Student";
		    StudentLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(StudentLookUpEditRetrieveFieldParameters_NotGenerate);
			 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(AydinUniversityProject.Admin.ViewModels.EducationViewModel);
			// 
            // labelControl
            // 
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.Name = "labelControl";
            this.labelControl.Text = "Education - Element View";
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
			//
			//EducationView
			//
			this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
			this.Controls.Add(this.labelControl);
            this.Controls.Add(this.windowsUIButtonPanelCloseButton);
            this.Controls.Add(this.windowsUIButtonPanelMain);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "EducationView";
						((System.ComponentModel.ISupportInitialize)(this.NotesBarManager)).EndInit();
						this.ResumeLayout(false);
		}
		
        #endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCloseButton;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
		private DevExpress.XtraEditors.LabelControl labelControl;
		private System.Windows.Forms.BindingSource educationViewBindingSource;
				private DevExpress.XtraGrid.GridControl NotesGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView NotesGridView;
		private DevExpress.XtraBars.BarManager NotesBarManager;
		private DevExpress.XtraBars.Bar NotesBar;
		private DevExpress.XtraEditors.XtraUserControl NotesXtraUserControl;
		private DevExpress.XtraBars.PopupMenu NotesPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiNotesNew;
				private DevExpress.XtraBars.BarButtonItem bbiNotesEdit;
				private DevExpress.XtraBars.BarButtonItem bbiNotesDelete;
				private DevExpress.XtraBars.BarButtonItem bbiNotesRefresh;
								private DevExpress.XtraEditors.GridLookUpEdit LessonLookUpEdit;
		private System.Windows.Forms.BindingSource LessonBindingSource;
				private DevExpress.XtraEditors.GridLookUpEdit StudentLookUpEdit;
		private System.Windows.Forms.BindingSource StudentBindingSource;
		 
	}
}
