namespace AydinUniversityProject.Admin.Views.TopicView {
    partial class TopicView {
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
						this.PostsGridControl = new DevExpress.XtraGrid.GridControl();
			this.PostsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.PostsBarManager = new DevExpress.XtraBars.BarManager();
			this.PostsBar = new DevExpress.XtraBars.Bar();
			this.PostsXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.PostsPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiPostsNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiPostsEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiPostsDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiPostsRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.PostsBarManager)).BeginInit();
									this.LessonLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.LessonBindingSource = new System.Windows.Forms.BindingSource(this.components);
						this.SentFeedLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.SentFeedBindingSource = new System.Windows.Forms.BindingSource(this.components);
			 
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
			this.topicViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.topicViewBindingSource.DataSource = typeof(AydinUniversityProject.Data.POCOs.Topic);
			this.dataLayoutControl1.DataSource = topicViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
           	parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
						//
			//PostsGridControl
			//
			this.PostsGridControl.MainView = this.PostsGridView;
			this.PostsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PostsGridControl.Name = "PostsGridControl";
            this.PostsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.PostsGridView});
			//
			//PostsGridView
			//
            this.PostsGridView.GridControl = this.PostsGridControl;
            this.PostsGridView.Name = "PostsGridView";
            this.PostsGridView.OptionsBehavior.Editable = false;
            this.PostsGridView.OptionsBehavior.ReadOnly = true;
			this.PostsGridView.OptionsView.ShowGroupPanel = false;
			//
			//PostsPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters PostsPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters TopicPostsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            TopicPostsChildPopulateColumnParameters_NotVisible.FieldName = "Topic";
		    TopicPostsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			PostsPopulateColumnsParameters.CustomColumnParameters.Add(TopicPostsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters SentFeedPostsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            SentFeedPostsChildPopulateColumnParameters_NotVisible.FieldName = "SentFeed";
		    SentFeedPostsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			PostsPopulateColumnsParameters.CustomColumnParameters.Add(SentFeedPostsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters FavouriteFeedPostsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            FavouriteFeedPostsChildPopulateColumnParameters_NotVisible.FieldName = "FavouriteFeed";
		    FavouriteFeedPostsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			PostsPopulateColumnsParameters.CustomColumnParameters.Add(FavouriteFeedPostsChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PostsPostsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PostsPostsChildPopulateColumnParameters.FieldName = "PostsPosts";
            PostsPostsChildPopulateColumnParameters.Path = "Posts.Content";
			PostsPopulateColumnsParameters.CustomColumnParameters.Add(PostsPostsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters FavouriteFeedsPostsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            FavouriteFeedsPostsChildPopulateColumnParameters.FieldName = "FavouriteFeedsPosts";
            FavouriteFeedsPostsChildPopulateColumnParameters.Path = "FavouriteFeeds.ID";
			PostsPopulateColumnsParameters.CustomColumnParameters.Add(FavouriteFeedsPostsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters LessonPostsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            LessonPostsChildPopulateColumnParameters.FieldName = "LessonPosts";
            LessonPostsChildPopulateColumnParameters.Path = "Lesson.Name";
			PostsPopulateColumnsParameters.CustomColumnParameters.Add(LessonPostsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters SentFeedPostsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            SentFeedPostsChildPopulateColumnParameters.FieldName = "SentFeedPosts";
            SentFeedPostsChildPopulateColumnParameters.Path = "SentFeed.ID";
			PostsPopulateColumnsParameters.CustomColumnParameters.Add(SentFeedPostsChildPopulateColumnParameters);
			 
		    this.PostsGridView.PopulateColumns(typeof(AydinUniversityProject.Data.POCOs.Post),PostsPopulateColumnsParameters);
			//
			//PostsBindingSource
			//
			System.Windows.Forms.BindingSource PostsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			PostsBindingSource.DataSource = typeof(AydinUniversityProject.Data.POCOs.Post);
            this.PostsGridControl.DataSource = PostsBindingSource;
			//
			//PostsXtraUserControl
			//
            this.PostsXtraUserControl.Controls.Add(PostsGridControl);
			this.PostsXtraUserControl.Name = "PostsXtraUserControl";
			this.PostsXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//PostsNew
			//
			this.bbiPostsNew.Caption = "New";
			this.bbiPostsNew.Name = "bbiPostsNew";
			this.bbiPostsNew.ImageUri.Uri = "New";
			this.bbiPostsNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.PostsBarManager.Items.Add(this.bbiPostsNew);
			this.PostsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPostsNew));
			this.PostsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPostsNew));
						//
			//PostsEdit
			//
			this.bbiPostsEdit.Caption = "Edit";
			this.bbiPostsEdit.Name = "bbiPostsEdit";
			this.bbiPostsEdit.ImageUri.Uri = "Edit";
			this.bbiPostsEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.PostsBarManager.Items.Add(this.bbiPostsEdit);
			this.PostsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPostsEdit));
			this.PostsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPostsEdit));
						//
			//PostsDelete
			//
			this.bbiPostsDelete.Caption = "Delete";
			this.bbiPostsDelete.Name = "bbiPostsDelete";
			this.bbiPostsDelete.ImageUri.Uri = "Delete";
			this.bbiPostsDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.PostsBarManager.Items.Add(this.bbiPostsDelete);
			this.PostsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPostsDelete));
			this.PostsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPostsDelete));
						//
			//PostsRefresh
			//
			this.bbiPostsRefresh.Caption = "Refresh";
			this.bbiPostsRefresh.Name = "bbiPostsRefresh";
			this.bbiPostsRefresh.ImageUri.Uri = "Refresh";
			this.bbiPostsRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.PostsBarManager.Items.Add(this.bbiPostsRefresh);
			this.PostsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPostsRefresh));
			this.PostsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPostsRefresh));
						//
			//PostsBar
			//
			this.PostsBar.BarName = "Posts";
            this.PostsBar.DockCol = 0;
            this.PostsBar.DockRow = 0;
            this.PostsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.PostsBar.OptionsBar.AllowQuickCustomization = false;
            this.PostsBar.OptionsBar.DrawDragBorder = false;
            this.PostsBar.Text = "Posts";
			//
			//PostsBarManager
			//
			this.PostsBarManager.AllowCustomization = false;
            this.PostsBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.PostsBar});
            this.PostsBarManager.Form = PostsXtraUserControl;
            this.PostsBarManager.MainMenu = this.PostsBar;
			// 
            // PostsPopUpMenu
            // 
            this.PostsPopUpMenu.Manager = this.PostsBarManager;
            this.PostsPopUpMenu.Name = "PostsPopUpMenu";
			//
			//PostsRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters PostsRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            PostsRetriveFieldParameters.FieldName = "Posts";
            PostsRetriveFieldParameters.ControlForField = PostsXtraUserControl;
			PostsRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(PostsRetriveFieldParameters);
									//
			//LessonLookUpEdit
			//
			this.LessonBindingSource.DataSource = typeof(AydinUniversityProject.Data.POCOs.Lesson);
			this.LessonLookUpEdit.Properties.ValueMember = "ID"; 
			this.LessonLookUpEdit.Properties.DisplayMember = "Name";
			this.LessonLookUpEdit.Properties.DataSource = this.LessonBindingSource;
			this.LessonLookUpEdit.Name = "LessonLookUpEdit";
			this.LessonLookUpEdit.DataBindings.Add("EditValue", topicViewBindingSource, "LessonID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters LessonLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            LessonLookUpEditRetrieveFieldParameters.FieldName = "LessonID";
            LessonLookUpEditRetrieveFieldParameters.ControlForField = this.LessonLookUpEdit;
			parameters.CustomListParameters.Add(LessonLookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters LessonLookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    LessonLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "Lesson";
		    LessonLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(LessonLookUpEditRetrieveFieldParameters_NotGenerate);
						//
			//SentFeedLookUpEdit
			//
			this.SentFeedBindingSource.DataSource = typeof(AydinUniversityProject.Data.POCOs.SentFeeds);
			this.SentFeedLookUpEdit.Properties.ValueMember = "ID"; 
			this.SentFeedLookUpEdit.Properties.DisplayMember = "ID";
			this.SentFeedLookUpEdit.Properties.DataSource = this.SentFeedBindingSource;
			this.SentFeedLookUpEdit.Name = "SentFeedLookUpEdit";
			this.SentFeedLookUpEdit.DataBindings.Add("EditValue", topicViewBindingSource, "SentFeedID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters SentFeedLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            SentFeedLookUpEditRetrieveFieldParameters.FieldName = "SentFeedID";
            SentFeedLookUpEditRetrieveFieldParameters.ControlForField = this.SentFeedLookUpEdit;
			parameters.CustomListParameters.Add(SentFeedLookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters SentFeedLookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    SentFeedLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "SentFeed";
		    SentFeedLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(SentFeedLookUpEditRetrieveFieldParameters_NotGenerate);
			 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(AydinUniversityProject.Admin.ViewModels.TopicViewModel);
			// 
            // labelControl
            // 
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.Name = "labelControl";
            this.labelControl.Text = "Topic - Element View";
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
			//
			//TopicView
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
            this.Name = "TopicView";
						((System.ComponentModel.ISupportInitialize)(this.PostsBarManager)).EndInit();
						this.ResumeLayout(false);
		}
		
        #endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCloseButton;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
		private DevExpress.XtraEditors.LabelControl labelControl;
		private System.Windows.Forms.BindingSource topicViewBindingSource;
				private DevExpress.XtraGrid.GridControl PostsGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView PostsGridView;
		private DevExpress.XtraBars.BarManager PostsBarManager;
		private DevExpress.XtraBars.Bar PostsBar;
		private DevExpress.XtraEditors.XtraUserControl PostsXtraUserControl;
		private DevExpress.XtraBars.PopupMenu PostsPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiPostsNew;
				private DevExpress.XtraBars.BarButtonItem bbiPostsEdit;
				private DevExpress.XtraBars.BarButtonItem bbiPostsDelete;
				private DevExpress.XtraBars.BarButtonItem bbiPostsRefresh;
								private DevExpress.XtraEditors.GridLookUpEdit LessonLookUpEdit;
		private System.Windows.Forms.BindingSource LessonBindingSource;
				private DevExpress.XtraEditors.GridLookUpEdit SentFeedLookUpEdit;
		private System.Windows.Forms.BindingSource SentFeedBindingSource;
		 
	}
}
