namespace AydinUniversityProject.Admin.Views.StudentView {
    partial class StudentView {
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
						this.EducationsGridControl = new DevExpress.XtraGrid.GridControl();
			this.EducationsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.EducationsBarManager = new DevExpress.XtraBars.BarManager();
			this.EducationsBar = new DevExpress.XtraBars.Bar();
			this.EducationsXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.EducationsPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiEducationsNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiEducationsEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiEducationsDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiEducationsRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.EducationsBarManager)).BeginInit();
									this.PeriodLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.PeriodBindingSource = new System.Windows.Forms.BindingSource(this.components);
						this.UserLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.UserBindingSource = new System.Windows.Forms.BindingSource(this.components);
			 
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
			this.studentViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.studentViewBindingSource.DataSource = typeof(AydinUniversityProject.Data.POCOs.Student);
			this.dataLayoutControl1.DataSource = studentViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
           	parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
						//
			//EducationsGridControl
			//
			this.EducationsGridControl.MainView = this.EducationsGridView;
			this.EducationsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EducationsGridControl.Name = "EducationsGridControl";
            this.EducationsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.EducationsGridView});
			//
			//EducationsGridView
			//
            this.EducationsGridView.GridControl = this.EducationsGridControl;
            this.EducationsGridView.Name = "EducationsGridView";
            this.EducationsGridView.OptionsBehavior.Editable = false;
            this.EducationsGridView.OptionsBehavior.ReadOnly = true;
			this.EducationsGridView.OptionsView.ShowGroupPanel = false;
			//
			//EducationsPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters EducationsPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters StudentEducationsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            StudentEducationsChildPopulateColumnParameters_NotVisible.FieldName = "Student";
		    StudentEducationsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			EducationsPopulateColumnsParameters.CustomColumnParameters.Add(StudentEducationsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters LessonEducationsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            LessonEducationsChildPopulateColumnParameters_NotVisible.FieldName = "Lesson";
		    LessonEducationsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			EducationsPopulateColumnsParameters.CustomColumnParameters.Add(LessonEducationsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters NotesEducationsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            NotesEducationsChildPopulateColumnParameters_NotVisible.FieldName = "Notes";
		    NotesEducationsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			EducationsPopulateColumnsParameters.CustomColumnParameters.Add(NotesEducationsChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters EducationsEducationsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            EducationsEducationsChildPopulateColumnParameters.FieldName = "EducationsEducations";
            EducationsEducationsChildPopulateColumnParameters.Path = "Educations.ID";
			EducationsPopulateColumnsParameters.CustomColumnParameters.Add(EducationsEducationsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PeriodEducationsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PeriodEducationsChildPopulateColumnParameters.FieldName = "PeriodEducations";
            PeriodEducationsChildPopulateColumnParameters.Path = "Period.ID";
			EducationsPopulateColumnsParameters.CustomColumnParameters.Add(PeriodEducationsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters UserEducationsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            UserEducationsChildPopulateColumnParameters.FieldName = "UserEducations";
            UserEducationsChildPopulateColumnParameters.Path = "User.Username";
			EducationsPopulateColumnsParameters.CustomColumnParameters.Add(UserEducationsChildPopulateColumnParameters);
			 
		    this.EducationsGridView.PopulateColumns(typeof(AydinUniversityProject.Data.POCOs.Education),EducationsPopulateColumnsParameters);
			//
			//EducationsBindingSource
			//
			System.Windows.Forms.BindingSource EducationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			EducationsBindingSource.DataSource = typeof(AydinUniversityProject.Data.POCOs.Education);
            this.EducationsGridControl.DataSource = EducationsBindingSource;
			//
			//EducationsXtraUserControl
			//
            this.EducationsXtraUserControl.Controls.Add(EducationsGridControl);
			this.EducationsXtraUserControl.Name = "EducationsXtraUserControl";
			this.EducationsXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//EducationsNew
			//
			this.bbiEducationsNew.Caption = "New";
			this.bbiEducationsNew.Name = "bbiEducationsNew";
			this.bbiEducationsNew.ImageUri.Uri = "New";
			this.bbiEducationsNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.EducationsBarManager.Items.Add(this.bbiEducationsNew);
			this.EducationsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEducationsNew));
			this.EducationsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEducationsNew));
						//
			//EducationsEdit
			//
			this.bbiEducationsEdit.Caption = "Edit";
			this.bbiEducationsEdit.Name = "bbiEducationsEdit";
			this.bbiEducationsEdit.ImageUri.Uri = "Edit";
			this.bbiEducationsEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.EducationsBarManager.Items.Add(this.bbiEducationsEdit);
			this.EducationsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEducationsEdit));
			this.EducationsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEducationsEdit));
						//
			//EducationsDelete
			//
			this.bbiEducationsDelete.Caption = "Delete";
			this.bbiEducationsDelete.Name = "bbiEducationsDelete";
			this.bbiEducationsDelete.ImageUri.Uri = "Delete";
			this.bbiEducationsDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.EducationsBarManager.Items.Add(this.bbiEducationsDelete);
			this.EducationsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEducationsDelete));
			this.EducationsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEducationsDelete));
						//
			//EducationsRefresh
			//
			this.bbiEducationsRefresh.Caption = "Refresh";
			this.bbiEducationsRefresh.Name = "bbiEducationsRefresh";
			this.bbiEducationsRefresh.ImageUri.Uri = "Refresh";
			this.bbiEducationsRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.EducationsBarManager.Items.Add(this.bbiEducationsRefresh);
			this.EducationsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEducationsRefresh));
			this.EducationsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEducationsRefresh));
						//
			//EducationsBar
			//
			this.EducationsBar.BarName = "Educations";
            this.EducationsBar.DockCol = 0;
            this.EducationsBar.DockRow = 0;
            this.EducationsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.EducationsBar.OptionsBar.AllowQuickCustomization = false;
            this.EducationsBar.OptionsBar.DrawDragBorder = false;
            this.EducationsBar.Text = "Educations";
			//
			//EducationsBarManager
			//
			this.EducationsBarManager.AllowCustomization = false;
            this.EducationsBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.EducationsBar});
            this.EducationsBarManager.Form = EducationsXtraUserControl;
            this.EducationsBarManager.MainMenu = this.EducationsBar;
			// 
            // EducationsPopUpMenu
            // 
            this.EducationsPopUpMenu.Manager = this.EducationsBarManager;
            this.EducationsPopUpMenu.Name = "EducationsPopUpMenu";
			//
			//EducationsRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters EducationsRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            EducationsRetriveFieldParameters.FieldName = "Educations";
            EducationsRetriveFieldParameters.ControlForField = EducationsXtraUserControl;
			EducationsRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(EducationsRetriveFieldParameters);
									//
			//PeriodLookUpEdit
			//
			this.PeriodBindingSource.DataSource = typeof(AydinUniversityProject.Data.POCOs.Period);
			this.PeriodLookUpEdit.Properties.ValueMember = "ID"; 
			this.PeriodLookUpEdit.Properties.DisplayMember = "ID";
			this.PeriodLookUpEdit.Properties.DataSource = this.PeriodBindingSource;
			this.PeriodLookUpEdit.Name = "PeriodLookUpEdit";
			this.PeriodLookUpEdit.DataBindings.Add("EditValue", studentViewBindingSource, "PeriodID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters PeriodLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            PeriodLookUpEditRetrieveFieldParameters.FieldName = "PeriodID";
            PeriodLookUpEditRetrieveFieldParameters.ControlForField = this.PeriodLookUpEdit;
			parameters.CustomListParameters.Add(PeriodLookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters PeriodLookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    PeriodLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "Period";
		    PeriodLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(PeriodLookUpEditRetrieveFieldParameters_NotGenerate);
						//
			//UserLookUpEdit
			//
			this.UserBindingSource.DataSource = typeof(AydinUniversityProject.Data.POCOs.User);
			this.UserLookUpEdit.Properties.ValueMember = "ID"; 
			this.UserLookUpEdit.Properties.DisplayMember = "Username";
			this.UserLookUpEdit.Properties.DataSource = this.UserBindingSource;
			this.UserLookUpEdit.Name = "UserLookUpEdit";
			this.UserLookUpEdit.DataBindings.Add("EditValue", studentViewBindingSource, "ID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters UserLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            UserLookUpEditRetrieveFieldParameters.FieldName = "ID";
            UserLookUpEditRetrieveFieldParameters.ControlForField = this.UserLookUpEdit;
			parameters.CustomListParameters.Add(UserLookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters UserLookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    UserLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "User";
		    UserLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(UserLookUpEditRetrieveFieldParameters_NotGenerate);
			 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(AydinUniversityProject.Admin.ViewModels.StudentViewModel);
			// 
            // labelControl
            // 
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.Name = "labelControl";
            this.labelControl.Text = "Student - Element View";
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
			//
			//StudentView
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
            this.Name = "StudentView";
						((System.ComponentModel.ISupportInitialize)(this.EducationsBarManager)).EndInit();
						this.ResumeLayout(false);
		}
		
        #endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCloseButton;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
		private DevExpress.XtraEditors.LabelControl labelControl;
		private System.Windows.Forms.BindingSource studentViewBindingSource;
				private DevExpress.XtraGrid.GridControl EducationsGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView EducationsGridView;
		private DevExpress.XtraBars.BarManager EducationsBarManager;
		private DevExpress.XtraBars.Bar EducationsBar;
		private DevExpress.XtraEditors.XtraUserControl EducationsXtraUserControl;
		private DevExpress.XtraBars.PopupMenu EducationsPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiEducationsNew;
				private DevExpress.XtraBars.BarButtonItem bbiEducationsEdit;
				private DevExpress.XtraBars.BarButtonItem bbiEducationsDelete;
				private DevExpress.XtraBars.BarButtonItem bbiEducationsRefresh;
								private DevExpress.XtraEditors.GridLookUpEdit PeriodLookUpEdit;
		private System.Windows.Forms.BindingSource PeriodBindingSource;
				private DevExpress.XtraEditors.GridLookUpEdit UserLookUpEdit;
		private System.Windows.Forms.BindingSource UserBindingSource;
		 
	}
}
