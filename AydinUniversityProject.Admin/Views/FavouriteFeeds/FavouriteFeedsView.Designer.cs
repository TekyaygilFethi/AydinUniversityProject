namespace AydinUniversityProject.Admin.Views.FavouriteFeedsView {
    partial class FavouriteFeedsView {
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
						this.FavouritePostsGridControl = new DevExpress.XtraGrid.GridControl();
			this.FavouritePostsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.FavouritePostsBarManager = new DevExpress.XtraBars.BarManager();
			this.FavouritePostsBar = new DevExpress.XtraBars.Bar();
			this.FavouritePostsXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.FavouritePostsPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiFavouritePostsNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiFavouritePostsEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiFavouritePostsDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiFavouritePostsRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.FavouritePostsBarManager)).BeginInit();
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
			this.favouriteFeedsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.favouriteFeedsViewBindingSource.DataSource = typeof(AydinUniversityProject.Data.POCOs.FavouriteFeeds);
			this.dataLayoutControl1.DataSource = favouriteFeedsViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
           	parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
						//
			//FavouritePostsGridControl
			//
			this.FavouritePostsGridControl.MainView = this.FavouritePostsGridView;
			this.FavouritePostsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FavouritePostsGridControl.Name = "FavouritePostsGridControl";
            this.FavouritePostsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.FavouritePostsGridView});
			//
			//FavouritePostsGridView
			//
            this.FavouritePostsGridView.GridControl = this.FavouritePostsGridControl;
            this.FavouritePostsGridView.Name = "FavouritePostsGridView";
            this.FavouritePostsGridView.OptionsBehavior.Editable = false;
            this.FavouritePostsGridView.OptionsBehavior.ReadOnly = true;
			this.FavouritePostsGridView.OptionsView.ShowGroupPanel = false;
			//
			//FavouritePostsPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters FavouritePostsPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters TopicFavouritePostsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            TopicFavouritePostsChildPopulateColumnParameters_NotVisible.FieldName = "Topic";
		    TopicFavouritePostsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			FavouritePostsPopulateColumnsParameters.CustomColumnParameters.Add(TopicFavouritePostsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters SentFeedFavouritePostsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            SentFeedFavouritePostsChildPopulateColumnParameters_NotVisible.FieldName = "SentFeed";
		    SentFeedFavouritePostsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			FavouritePostsPopulateColumnsParameters.CustomColumnParameters.Add(SentFeedFavouritePostsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters FavouriteFeedFavouritePostsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            FavouriteFeedFavouritePostsChildPopulateColumnParameters_NotVisible.FieldName = "FavouriteFeed";
		    FavouriteFeedFavouritePostsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			FavouritePostsPopulateColumnsParameters.CustomColumnParameters.Add(FavouriteFeedFavouritePostsChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters FavouriteTopicsFavouritePostsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            FavouriteTopicsFavouritePostsChildPopulateColumnParameters.FieldName = "FavouriteTopicsFavouritePosts";
            FavouriteTopicsFavouritePostsChildPopulateColumnParameters.Path = "FavouriteTopics.Name";
			FavouritePostsPopulateColumnsParameters.CustomColumnParameters.Add(FavouriteTopicsFavouritePostsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters UserFavouritePostsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            UserFavouritePostsChildPopulateColumnParameters.FieldName = "UserFavouritePosts";
            UserFavouritePostsChildPopulateColumnParameters.Path = "User.Username";
			FavouritePostsPopulateColumnsParameters.CustomColumnParameters.Add(UserFavouritePostsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters FavouritePostsFavouritePostsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            FavouritePostsFavouritePostsChildPopulateColumnParameters.FieldName = "FavouritePostsFavouritePosts";
            FavouritePostsFavouritePostsChildPopulateColumnParameters.Path = "FavouritePosts.Content";
			FavouritePostsPopulateColumnsParameters.CustomColumnParameters.Add(FavouritePostsFavouritePostsChildPopulateColumnParameters);
			 
		    this.FavouritePostsGridView.PopulateColumns(typeof(AydinUniversityProject.Data.POCOs.Post),FavouritePostsPopulateColumnsParameters);
			//
			//FavouritePostsBindingSource
			//
			System.Windows.Forms.BindingSource FavouritePostsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			FavouritePostsBindingSource.DataSource = typeof(AydinUniversityProject.Data.POCOs.Post);
            this.FavouritePostsGridControl.DataSource = FavouritePostsBindingSource;
			//
			//FavouritePostsXtraUserControl
			//
            this.FavouritePostsXtraUserControl.Controls.Add(FavouritePostsGridControl);
			this.FavouritePostsXtraUserControl.Name = "FavouritePostsXtraUserControl";
			this.FavouritePostsXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//FavouritePostsNew
			//
			this.bbiFavouritePostsNew.Caption = "New";
			this.bbiFavouritePostsNew.Name = "bbiFavouritePostsNew";
			this.bbiFavouritePostsNew.ImageUri.Uri = "New";
			this.bbiFavouritePostsNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.FavouritePostsBarManager.Items.Add(this.bbiFavouritePostsNew);
			this.FavouritePostsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiFavouritePostsNew));
			this.FavouritePostsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiFavouritePostsNew));
						//
			//FavouritePostsEdit
			//
			this.bbiFavouritePostsEdit.Caption = "Edit";
			this.bbiFavouritePostsEdit.Name = "bbiFavouritePostsEdit";
			this.bbiFavouritePostsEdit.ImageUri.Uri = "Edit";
			this.bbiFavouritePostsEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.FavouritePostsBarManager.Items.Add(this.bbiFavouritePostsEdit);
			this.FavouritePostsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiFavouritePostsEdit));
			this.FavouritePostsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiFavouritePostsEdit));
						//
			//FavouritePostsDelete
			//
			this.bbiFavouritePostsDelete.Caption = "Delete";
			this.bbiFavouritePostsDelete.Name = "bbiFavouritePostsDelete";
			this.bbiFavouritePostsDelete.ImageUri.Uri = "Delete";
			this.bbiFavouritePostsDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.FavouritePostsBarManager.Items.Add(this.bbiFavouritePostsDelete);
			this.FavouritePostsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiFavouritePostsDelete));
			this.FavouritePostsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiFavouritePostsDelete));
						//
			//FavouritePostsRefresh
			//
			this.bbiFavouritePostsRefresh.Caption = "Refresh";
			this.bbiFavouritePostsRefresh.Name = "bbiFavouritePostsRefresh";
			this.bbiFavouritePostsRefresh.ImageUri.Uri = "Refresh";
			this.bbiFavouritePostsRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.FavouritePostsBarManager.Items.Add(this.bbiFavouritePostsRefresh);
			this.FavouritePostsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiFavouritePostsRefresh));
			this.FavouritePostsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiFavouritePostsRefresh));
						//
			//FavouritePostsBar
			//
			this.FavouritePostsBar.BarName = "FavouritePosts";
            this.FavouritePostsBar.DockCol = 0;
            this.FavouritePostsBar.DockRow = 0;
            this.FavouritePostsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.FavouritePostsBar.OptionsBar.AllowQuickCustomization = false;
            this.FavouritePostsBar.OptionsBar.DrawDragBorder = false;
            this.FavouritePostsBar.Text = "FavouritePosts";
			//
			//FavouritePostsBarManager
			//
			this.FavouritePostsBarManager.AllowCustomization = false;
            this.FavouritePostsBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.FavouritePostsBar});
            this.FavouritePostsBarManager.Form = FavouritePostsXtraUserControl;
            this.FavouritePostsBarManager.MainMenu = this.FavouritePostsBar;
			// 
            // FavouritePostsPopUpMenu
            // 
            this.FavouritePostsPopUpMenu.Manager = this.FavouritePostsBarManager;
            this.FavouritePostsPopUpMenu.Name = "FavouritePostsPopUpMenu";
			//
			//FavouritePostsRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters FavouritePostsRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            FavouritePostsRetriveFieldParameters.FieldName = "FavouritePosts";
            FavouritePostsRetriveFieldParameters.ControlForField = FavouritePostsXtraUserControl;
			FavouritePostsRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(FavouritePostsRetriveFieldParameters);
									//
			//UserLookUpEdit
			//
			this.UserBindingSource.DataSource = typeof(AydinUniversityProject.Data.POCOs.User);
			this.UserLookUpEdit.Properties.ValueMember = "ID"; 
			this.UserLookUpEdit.Properties.DisplayMember = "Username";
			this.UserLookUpEdit.Properties.DataSource = this.UserBindingSource;
			this.UserLookUpEdit.Name = "UserLookUpEdit";
			this.UserLookUpEdit.DataBindings.Add("EditValue", favouriteFeedsViewBindingSource, "ID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
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
            this.mvvmContext.ViewModelType = typeof(AydinUniversityProject.Admin.ViewModels.FavouriteFeedsViewModel);
			// 
            // labelControl
            // 
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.Name = "labelControl";
            this.labelControl.Text = "FavouriteFeeds - Element View";
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
			//
			//FavouriteFeedsView
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
            this.Name = "FavouriteFeedsView";
						((System.ComponentModel.ISupportInitialize)(this.FavouritePostsBarManager)).EndInit();
						this.ResumeLayout(false);
		}
		
        #endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCloseButton;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
		private DevExpress.XtraEditors.LabelControl labelControl;
		private System.Windows.Forms.BindingSource favouriteFeedsViewBindingSource;
				private DevExpress.XtraGrid.GridControl FavouritePostsGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView FavouritePostsGridView;
		private DevExpress.XtraBars.BarManager FavouritePostsBarManager;
		private DevExpress.XtraBars.Bar FavouritePostsBar;
		private DevExpress.XtraEditors.XtraUserControl FavouritePostsXtraUserControl;
		private DevExpress.XtraBars.PopupMenu FavouritePostsPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiFavouritePostsNew;
				private DevExpress.XtraBars.BarButtonItem bbiFavouritePostsEdit;
				private DevExpress.XtraBars.BarButtonItem bbiFavouritePostsDelete;
				private DevExpress.XtraBars.BarButtonItem bbiFavouritePostsRefresh;
								private DevExpress.XtraEditors.GridLookUpEdit UserLookUpEdit;
		private System.Windows.Forms.BindingSource UserBindingSource;
		 
	}
}
