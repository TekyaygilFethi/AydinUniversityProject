namespace AydinUniversityProject.Admin.Views.PeriodView {
    partial class PeriodView {
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
						this.LessonsGridControl = new DevExpress.XtraGrid.GridControl();
			this.LessonsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.LessonsBarManager = new DevExpress.XtraBars.BarManager();
			this.LessonsBar = new DevExpress.XtraBars.Bar();
			this.LessonsXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.LessonsPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiLessonsNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiLessonsEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiLessonsDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiLessonsRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.LessonsBarManager)).BeginInit();
						this.StudentsGridControl = new DevExpress.XtraGrid.GridControl();
			this.StudentsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.StudentsBarManager = new DevExpress.XtraBars.BarManager();
			this.StudentsBar = new DevExpress.XtraBars.Bar();
			this.StudentsXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.StudentsPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiStudentsNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiStudentsEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiStudentsDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiStudentsRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.StudentsBarManager)).BeginInit();
						 
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
			this.periodViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.periodViewBindingSource.DataSource = typeof(AydinUniversityProject.Data.POCOs.Period);
			this.dataLayoutControl1.DataSource = periodViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
           	parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
						//
			//LessonsGridControl
			//
			this.LessonsGridControl.MainView = this.LessonsGridView;
			this.LessonsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LessonsGridControl.Name = "LessonsGridControl";
            this.LessonsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.LessonsGridView});
			//
			//LessonsGridView
			//
            this.LessonsGridView.GridControl = this.LessonsGridControl;
            this.LessonsGridView.Name = "LessonsGridView";
            this.LessonsGridView.OptionsBehavior.Editable = false;
            this.LessonsGridView.OptionsBehavior.ReadOnly = true;
			this.LessonsGridView.OptionsView.ShowGroupPanel = false;
			//
			//LessonsPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters LessonsPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters EducationsLessonsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            EducationsLessonsChildPopulateColumnParameters_NotVisible.FieldName = "Educations";
		    EducationsLessonsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			LessonsPopulateColumnsParameters.CustomColumnParameters.Add(EducationsLessonsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ConnectionsLessonsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ConnectionsLessonsChildPopulateColumnParameters_NotVisible.FieldName = "Connections";
		    ConnectionsLessonsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			LessonsPopulateColumnsParameters.CustomColumnParameters.Add(ConnectionsLessonsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters TopicsLessonsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            TopicsLessonsChildPopulateColumnParameters_NotVisible.FieldName = "Topics";
		    TopicsLessonsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			LessonsPopulateColumnsParameters.CustomColumnParameters.Add(TopicsLessonsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PeriodLessonsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PeriodLessonsChildPopulateColumnParameters_NotVisible.FieldName = "Period";
		    PeriodLessonsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			LessonsPopulateColumnsParameters.CustomColumnParameters.Add(PeriodLessonsChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters LessonsLessonsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            LessonsLessonsChildPopulateColumnParameters.FieldName = "LessonsLessons";
            LessonsLessonsChildPopulateColumnParameters.Path = "Lessons.Name";
			LessonsPopulateColumnsParameters.CustomColumnParameters.Add(LessonsLessonsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters StudentsLessonsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            StudentsLessonsChildPopulateColumnParameters.FieldName = "StudentsLessons";
            StudentsLessonsChildPopulateColumnParameters.Path = "Students.Name";
			LessonsPopulateColumnsParameters.CustomColumnParameters.Add(StudentsLessonsChildPopulateColumnParameters);
			 
		    this.LessonsGridView.PopulateColumns(typeof(AydinUniversityProject.Data.POCOs.Lesson),LessonsPopulateColumnsParameters);
			//
			//LessonsBindingSource
			//
			System.Windows.Forms.BindingSource LessonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			LessonsBindingSource.DataSource = typeof(AydinUniversityProject.Data.POCOs.Lesson);
            this.LessonsGridControl.DataSource = LessonsBindingSource;
			//
			//LessonsXtraUserControl
			//
            this.LessonsXtraUserControl.Controls.Add(LessonsGridControl);
			this.LessonsXtraUserControl.Name = "LessonsXtraUserControl";
			this.LessonsXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//LessonsNew
			//
			this.bbiLessonsNew.Caption = "New";
			this.bbiLessonsNew.Name = "bbiLessonsNew";
			this.bbiLessonsNew.ImageUri.Uri = "New";
			this.bbiLessonsNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.LessonsBarManager.Items.Add(this.bbiLessonsNew);
			this.LessonsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiLessonsNew));
			this.LessonsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiLessonsNew));
						//
			//LessonsEdit
			//
			this.bbiLessonsEdit.Caption = "Edit";
			this.bbiLessonsEdit.Name = "bbiLessonsEdit";
			this.bbiLessonsEdit.ImageUri.Uri = "Edit";
			this.bbiLessonsEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.LessonsBarManager.Items.Add(this.bbiLessonsEdit);
			this.LessonsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiLessonsEdit));
			this.LessonsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiLessonsEdit));
						//
			//LessonsDelete
			//
			this.bbiLessonsDelete.Caption = "Delete";
			this.bbiLessonsDelete.Name = "bbiLessonsDelete";
			this.bbiLessonsDelete.ImageUri.Uri = "Delete";
			this.bbiLessonsDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.LessonsBarManager.Items.Add(this.bbiLessonsDelete);
			this.LessonsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiLessonsDelete));
			this.LessonsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiLessonsDelete));
						//
			//LessonsRefresh
			//
			this.bbiLessonsRefresh.Caption = "Refresh";
			this.bbiLessonsRefresh.Name = "bbiLessonsRefresh";
			this.bbiLessonsRefresh.ImageUri.Uri = "Refresh";
			this.bbiLessonsRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.LessonsBarManager.Items.Add(this.bbiLessonsRefresh);
			this.LessonsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiLessonsRefresh));
			this.LessonsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiLessonsRefresh));
						//
			//LessonsBar
			//
			this.LessonsBar.BarName = "Lessons";
            this.LessonsBar.DockCol = 0;
            this.LessonsBar.DockRow = 0;
            this.LessonsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.LessonsBar.OptionsBar.AllowQuickCustomization = false;
            this.LessonsBar.OptionsBar.DrawDragBorder = false;
            this.LessonsBar.Text = "Lessons";
			//
			//LessonsBarManager
			//
			this.LessonsBarManager.AllowCustomization = false;
            this.LessonsBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.LessonsBar});
            this.LessonsBarManager.Form = LessonsXtraUserControl;
            this.LessonsBarManager.MainMenu = this.LessonsBar;
			// 
            // LessonsPopUpMenu
            // 
            this.LessonsPopUpMenu.Manager = this.LessonsBarManager;
            this.LessonsPopUpMenu.Name = "LessonsPopUpMenu";
			//
			//LessonsRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters LessonsRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            LessonsRetriveFieldParameters.FieldName = "Lessons";
            LessonsRetriveFieldParameters.ControlForField = LessonsXtraUserControl;
			LessonsRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(LessonsRetriveFieldParameters);
						//
			//StudentsGridControl
			//
			this.StudentsGridControl.MainView = this.StudentsGridView;
			this.StudentsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentsGridControl.Name = "StudentsGridControl";
            this.StudentsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.StudentsGridView});
			//
			//StudentsGridView
			//
            this.StudentsGridView.GridControl = this.StudentsGridControl;
            this.StudentsGridView.Name = "StudentsGridView";
            this.StudentsGridView.OptionsBehavior.Editable = false;
            this.StudentsGridView.OptionsBehavior.ReadOnly = true;
			this.StudentsGridView.OptionsView.ShowGroupPanel = false;
			//
			//StudentsPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters StudentsPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters UserStudentsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            UserStudentsChildPopulateColumnParameters_NotVisible.FieldName = "User";
		    UserStudentsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			StudentsPopulateColumnsParameters.CustomColumnParameters.Add(UserStudentsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters EducationsStudentsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            EducationsStudentsChildPopulateColumnParameters_NotVisible.FieldName = "Educations";
		    EducationsStudentsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			StudentsPopulateColumnsParameters.CustomColumnParameters.Add(EducationsStudentsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PeriodStudentsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PeriodStudentsChildPopulateColumnParameters_NotVisible.FieldName = "Period";
		    PeriodStudentsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			StudentsPopulateColumnsParameters.CustomColumnParameters.Add(PeriodStudentsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters NameSurnameStudentsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            NameSurnameStudentsChildPopulateColumnParameters_NotVisible.FieldName = "NameSurname";
		    NameSurnameStudentsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			StudentsPopulateColumnsParameters.CustomColumnParameters.Add(NameSurnameStudentsChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters LessonsStudentsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            LessonsStudentsChildPopulateColumnParameters.FieldName = "LessonsStudents";
            LessonsStudentsChildPopulateColumnParameters.Path = "Lessons.Name";
			StudentsPopulateColumnsParameters.CustomColumnParameters.Add(LessonsStudentsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters StudentsStudentsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            StudentsStudentsChildPopulateColumnParameters.FieldName = "StudentsStudents";
            StudentsStudentsChildPopulateColumnParameters.Path = "Students.Name";
			StudentsPopulateColumnsParameters.CustomColumnParameters.Add(StudentsStudentsChildPopulateColumnParameters);
			 
		    this.StudentsGridView.PopulateColumns(typeof(AydinUniversityProject.Data.POCOs.Student),StudentsPopulateColumnsParameters);
			//
			//StudentsBindingSource
			//
			System.Windows.Forms.BindingSource StudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			StudentsBindingSource.DataSource = typeof(AydinUniversityProject.Data.POCOs.Student);
            this.StudentsGridControl.DataSource = StudentsBindingSource;
			//
			//StudentsXtraUserControl
			//
            this.StudentsXtraUserControl.Controls.Add(StudentsGridControl);
			this.StudentsXtraUserControl.Name = "StudentsXtraUserControl";
			this.StudentsXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//StudentsNew
			//
			this.bbiStudentsNew.Caption = "New";
			this.bbiStudentsNew.Name = "bbiStudentsNew";
			this.bbiStudentsNew.ImageUri.Uri = "New";
			this.bbiStudentsNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.StudentsBarManager.Items.Add(this.bbiStudentsNew);
			this.StudentsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiStudentsNew));
			this.StudentsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiStudentsNew));
						//
			//StudentsEdit
			//
			this.bbiStudentsEdit.Caption = "Edit";
			this.bbiStudentsEdit.Name = "bbiStudentsEdit";
			this.bbiStudentsEdit.ImageUri.Uri = "Edit";
			this.bbiStudentsEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.StudentsBarManager.Items.Add(this.bbiStudentsEdit);
			this.StudentsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiStudentsEdit));
			this.StudentsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiStudentsEdit));
						//
			//StudentsDelete
			//
			this.bbiStudentsDelete.Caption = "Delete";
			this.bbiStudentsDelete.Name = "bbiStudentsDelete";
			this.bbiStudentsDelete.ImageUri.Uri = "Delete";
			this.bbiStudentsDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.StudentsBarManager.Items.Add(this.bbiStudentsDelete);
			this.StudentsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiStudentsDelete));
			this.StudentsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiStudentsDelete));
						//
			//StudentsRefresh
			//
			this.bbiStudentsRefresh.Caption = "Refresh";
			this.bbiStudentsRefresh.Name = "bbiStudentsRefresh";
			this.bbiStudentsRefresh.ImageUri.Uri = "Refresh";
			this.bbiStudentsRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.StudentsBarManager.Items.Add(this.bbiStudentsRefresh);
			this.StudentsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiStudentsRefresh));
			this.StudentsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiStudentsRefresh));
						//
			//StudentsBar
			//
			this.StudentsBar.BarName = "Students";
            this.StudentsBar.DockCol = 0;
            this.StudentsBar.DockRow = 0;
            this.StudentsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.StudentsBar.OptionsBar.AllowQuickCustomization = false;
            this.StudentsBar.OptionsBar.DrawDragBorder = false;
            this.StudentsBar.Text = "Students";
			//
			//StudentsBarManager
			//
			this.StudentsBarManager.AllowCustomization = false;
            this.StudentsBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.StudentsBar});
            this.StudentsBarManager.Form = StudentsXtraUserControl;
            this.StudentsBarManager.MainMenu = this.StudentsBar;
			// 
            // StudentsPopUpMenu
            // 
            this.StudentsPopUpMenu.Manager = this.StudentsBarManager;
            this.StudentsPopUpMenu.Name = "StudentsPopUpMenu";
			//
			//StudentsRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters StudentsRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            StudentsRetriveFieldParameters.FieldName = "Students";
            StudentsRetriveFieldParameters.ControlForField = StudentsXtraUserControl;
			StudentsRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(StudentsRetriveFieldParameters);
						 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(AydinUniversityProject.Admin.ViewModels.PeriodViewModel);
			// 
            // labelControl
            // 
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.Name = "labelControl";
            this.labelControl.Text = "Period - Element View";
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
			//
			//PeriodView
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
            this.Name = "PeriodView";
						((System.ComponentModel.ISupportInitialize)(this.LessonsBarManager)).EndInit();
						((System.ComponentModel.ISupportInitialize)(this.StudentsBarManager)).EndInit();
						this.ResumeLayout(false);
		}
		
        #endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCloseButton;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
		private DevExpress.XtraEditors.LabelControl labelControl;
		private System.Windows.Forms.BindingSource periodViewBindingSource;
				private DevExpress.XtraGrid.GridControl LessonsGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView LessonsGridView;
		private DevExpress.XtraBars.BarManager LessonsBarManager;
		private DevExpress.XtraBars.Bar LessonsBar;
		private DevExpress.XtraEditors.XtraUserControl LessonsXtraUserControl;
		private DevExpress.XtraBars.PopupMenu LessonsPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiLessonsNew;
				private DevExpress.XtraBars.BarButtonItem bbiLessonsEdit;
				private DevExpress.XtraBars.BarButtonItem bbiLessonsDelete;
				private DevExpress.XtraBars.BarButtonItem bbiLessonsRefresh;
						private DevExpress.XtraGrid.GridControl StudentsGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView StudentsGridView;
		private DevExpress.XtraBars.BarManager StudentsBarManager;
		private DevExpress.XtraBars.Bar StudentsBar;
		private DevExpress.XtraEditors.XtraUserControl StudentsXtraUserControl;
		private DevExpress.XtraBars.PopupMenu StudentsPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiStudentsNew;
				private DevExpress.XtraBars.BarButtonItem bbiStudentsEdit;
				private DevExpress.XtraBars.BarButtonItem bbiStudentsDelete;
				private DevExpress.XtraBars.BarButtonItem bbiStudentsRefresh;
						 
	}
}
