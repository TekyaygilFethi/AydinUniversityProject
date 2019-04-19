namespace AydinUniversityProject.Admin.Views.FriendRelationshipView {
    partial class FriendRelationshipView {
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
						this.FriendsGridControl = new DevExpress.XtraGrid.GridControl();
			this.FriendsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.FriendsBarManager = new DevExpress.XtraBars.BarManager();
			this.FriendsBar = new DevExpress.XtraBars.Bar();
			this.FriendsXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.FriendsPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiFriendsNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiFriendsEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiFriendsDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiFriendsRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.FriendsBarManager)).BeginInit();
						 
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
			this.friendRelationshipViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.friendRelationshipViewBindingSource.DataSource = typeof(AydinUniversityProject.Data.POCOs.FriendRelationship);
			this.dataLayoutControl1.DataSource = friendRelationshipViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
           	parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
						//
			//FriendsGridControl
			//
			this.FriendsGridControl.MainView = this.FriendsGridView;
			this.FriendsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FriendsGridControl.Name = "FriendsGridControl";
            this.FriendsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.FriendsGridView});
			//
			//FriendsGridView
			//
            this.FriendsGridView.GridControl = this.FriendsGridControl;
            this.FriendsGridView.Name = "FriendsGridView";
            this.FriendsGridView.OptionsBehavior.Editable = false;
            this.FriendsGridView.OptionsBehavior.ReadOnly = true;
			this.FriendsGridView.OptionsView.ShowGroupPanel = false;
			//
			//FriendsPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters FriendsPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ConnectionsAsViewerFriendsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ConnectionsAsViewerFriendsChildPopulateColumnParameters_NotVisible.FieldName = "ConnectionsAsViewer";
		    ConnectionsAsViewerFriendsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			FriendsPopulateColumnsParameters.CustomColumnParameters.Add(ConnectionsAsViewerFriendsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ConnectionsAsSharerFriendsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ConnectionsAsSharerFriendsChildPopulateColumnParameters_NotVisible.FieldName = "ConnectionsAsSharer";
		    ConnectionsAsSharerFriendsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			FriendsPopulateColumnsParameters.CustomColumnParameters.Add(ConnectionsAsSharerFriendsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters SentMessagesFriendsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            SentMessagesFriendsChildPopulateColumnParameters_NotVisible.FieldName = "SentMessages";
		    SentMessagesFriendsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			FriendsPopulateColumnsParameters.CustomColumnParameters.Add(SentMessagesFriendsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ReceivedMessagesFriendsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ReceivedMessagesFriendsChildPopulateColumnParameters_NotVisible.FieldName = "ReceivedMessages";
		    ReceivedMessagesFriendsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			FriendsPopulateColumnsParameters.CustomColumnParameters.Add(ReceivedMessagesFriendsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters SentFeedsFriendsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            SentFeedsFriendsChildPopulateColumnParameters_NotVisible.FieldName = "SentFeeds";
		    SentFeedsFriendsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			FriendsPopulateColumnsParameters.CustomColumnParameters.Add(SentFeedsFriendsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters FavouriteFeedsFriendsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            FavouriteFeedsFriendsChildPopulateColumnParameters_NotVisible.FieldName = "FavouriteFeeds";
		    FavouriteFeedsFriendsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			FriendsPopulateColumnsParameters.CustomColumnParameters.Add(FavouriteFeedsFriendsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters StudentFriendsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            StudentFriendsChildPopulateColumnParameters_NotVisible.FieldName = "Student";
		    StudentFriendsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			FriendsPopulateColumnsParameters.CustomColumnParameters.Add(StudentFriendsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters FriendRelationshipFriendsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            FriendRelationshipFriendsChildPopulateColumnParameters_NotVisible.FieldName = "FriendRelationship";
		    FriendRelationshipFriendsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			FriendsPopulateColumnsParameters.CustomColumnParameters.Add(FriendRelationshipFriendsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ReviewsFriendsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ReviewsFriendsChildPopulateColumnParameters_NotVisible.FieldName = "Reviews";
		    ReviewsFriendsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			FriendsPopulateColumnsParameters.CustomColumnParameters.Add(ReviewsFriendsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters SentScreenShareRequestsFriendsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            SentScreenShareRequestsFriendsChildPopulateColumnParameters_NotVisible.FieldName = "SentScreenShareRequests";
		    SentScreenShareRequestsFriendsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			FriendsPopulateColumnsParameters.CustomColumnParameters.Add(SentScreenShareRequestsFriendsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ReceivedScreenShareRequestsFriendsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ReceivedScreenShareRequestsFriendsChildPopulateColumnParameters_NotVisible.FieldName = "ReceivedScreenShareRequests";
		    ReceivedScreenShareRequestsFriendsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			FriendsPopulateColumnsParameters.CustomColumnParameters.Add(ReceivedScreenShareRequestsFriendsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters SentFriendRequestsFriendsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            SentFriendRequestsFriendsChildPopulateColumnParameters_NotVisible.FieldName = "SentFriendRequests";
		    SentFriendRequestsFriendsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			FriendsPopulateColumnsParameters.CustomColumnParameters.Add(SentFriendRequestsFriendsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ReceivedFriendRequestsFriendsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ReceivedFriendRequestsFriendsChildPopulateColumnParameters_NotVisible.FieldName = "ReceivedFriendRequests";
		    ReceivedFriendRequestsFriendsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			FriendsPopulateColumnsParameters.CustomColumnParameters.Add(ReceivedFriendRequestsFriendsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters AllConnectionsFriendsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            AllConnectionsFriendsChildPopulateColumnParameters_NotVisible.FieldName = "AllConnections";
		    AllConnectionsFriendsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			FriendsPopulateColumnsParameters.CustomColumnParameters.Add(AllConnectionsFriendsChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters FriendsFriendsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            FriendsFriendsChildPopulateColumnParameters.FieldName = "FriendsFriends";
            FriendsFriendsChildPopulateColumnParameters.Path = "Friends.Username";
			FriendsPopulateColumnsParameters.CustomColumnParameters.Add(FriendsFriendsChildPopulateColumnParameters);
			 
		    this.FriendsGridView.PopulateColumns(typeof(AydinUniversityProject.Data.POCOs.User),FriendsPopulateColumnsParameters);
			//
			//FriendsBindingSource
			//
			System.Windows.Forms.BindingSource FriendsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			FriendsBindingSource.DataSource = typeof(AydinUniversityProject.Data.POCOs.User);
            this.FriendsGridControl.DataSource = FriendsBindingSource;
			//
			//FriendsXtraUserControl
			//
            this.FriendsXtraUserControl.Controls.Add(FriendsGridControl);
			this.FriendsXtraUserControl.Name = "FriendsXtraUserControl";
			this.FriendsXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//FriendsNew
			//
			this.bbiFriendsNew.Caption = "New";
			this.bbiFriendsNew.Name = "bbiFriendsNew";
			this.bbiFriendsNew.ImageUri.Uri = "New";
			this.bbiFriendsNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.FriendsBarManager.Items.Add(this.bbiFriendsNew);
			this.FriendsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiFriendsNew));
			this.FriendsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiFriendsNew));
						//
			//FriendsEdit
			//
			this.bbiFriendsEdit.Caption = "Edit";
			this.bbiFriendsEdit.Name = "bbiFriendsEdit";
			this.bbiFriendsEdit.ImageUri.Uri = "Edit";
			this.bbiFriendsEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.FriendsBarManager.Items.Add(this.bbiFriendsEdit);
			this.FriendsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiFriendsEdit));
			this.FriendsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiFriendsEdit));
						//
			//FriendsDelete
			//
			this.bbiFriendsDelete.Caption = "Delete";
			this.bbiFriendsDelete.Name = "bbiFriendsDelete";
			this.bbiFriendsDelete.ImageUri.Uri = "Delete";
			this.bbiFriendsDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.FriendsBarManager.Items.Add(this.bbiFriendsDelete);
			this.FriendsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiFriendsDelete));
			this.FriendsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiFriendsDelete));
						//
			//FriendsRefresh
			//
			this.bbiFriendsRefresh.Caption = "Refresh";
			this.bbiFriendsRefresh.Name = "bbiFriendsRefresh";
			this.bbiFriendsRefresh.ImageUri.Uri = "Refresh";
			this.bbiFriendsRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.FriendsBarManager.Items.Add(this.bbiFriendsRefresh);
			this.FriendsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiFriendsRefresh));
			this.FriendsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiFriendsRefresh));
						//
			//FriendsBar
			//
			this.FriendsBar.BarName = "Friends";
            this.FriendsBar.DockCol = 0;
            this.FriendsBar.DockRow = 0;
            this.FriendsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.FriendsBar.OptionsBar.AllowQuickCustomization = false;
            this.FriendsBar.OptionsBar.DrawDragBorder = false;
            this.FriendsBar.Text = "Friends";
			//
			//FriendsBarManager
			//
			this.FriendsBarManager.AllowCustomization = false;
            this.FriendsBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.FriendsBar});
            this.FriendsBarManager.Form = FriendsXtraUserControl;
            this.FriendsBarManager.MainMenu = this.FriendsBar;
			// 
            // FriendsPopUpMenu
            // 
            this.FriendsPopUpMenu.Manager = this.FriendsBarManager;
            this.FriendsPopUpMenu.Name = "FriendsPopUpMenu";
			//
			//FriendsRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters FriendsRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            FriendsRetriveFieldParameters.FieldName = "Friends";
            FriendsRetriveFieldParameters.ControlForField = FriendsXtraUserControl;
			FriendsRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(FriendsRetriveFieldParameters);
						 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(AydinUniversityProject.Admin.ViewModels.FriendRelationshipViewModel);
			// 
            // labelControl
            // 
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.Name = "labelControl";
            this.labelControl.Text = "FriendRelationship - Element View";
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
			//
			//FriendRelationshipView
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
            this.Name = "FriendRelationshipView";
						((System.ComponentModel.ISupportInitialize)(this.FriendsBarManager)).EndInit();
						this.ResumeLayout(false);
		}
		
        #endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCloseButton;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
		private DevExpress.XtraEditors.LabelControl labelControl;
		private System.Windows.Forms.BindingSource friendRelationshipViewBindingSource;
				private DevExpress.XtraGrid.GridControl FriendsGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView FriendsGridView;
		private DevExpress.XtraBars.BarManager FriendsBarManager;
		private DevExpress.XtraBars.Bar FriendsBar;
		private DevExpress.XtraEditors.XtraUserControl FriendsXtraUserControl;
		private DevExpress.XtraBars.PopupMenu FriendsPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiFriendsNew;
				private DevExpress.XtraBars.BarButtonItem bbiFriendsEdit;
				private DevExpress.XtraBars.BarButtonItem bbiFriendsDelete;
				private DevExpress.XtraBars.BarButtonItem bbiFriendsRefresh;
						 
	}
}
