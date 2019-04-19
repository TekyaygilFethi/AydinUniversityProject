namespace AydinUniversityProject.Admin.Views.ScreenShareRequestView {
    partial class ScreenShareRequestView {
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
									this.NewConnectionLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.NewConnectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
						this.RequesterLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.RequesterBindingSource = new System.Windows.Forms.BindingSource(this.components);
						this.RequestToLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.RequestToBindingSource = new System.Windows.Forms.BindingSource(this.components);
			 
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
			this.screenShareRequestViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.screenShareRequestViewBindingSource.DataSource = typeof(AydinUniversityProject.Data.POCOs.ScreenShareRequest);
			this.dataLayoutControl1.DataSource = screenShareRequestViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
           	parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
									//
			//NewConnectionLookUpEdit
			//
			this.NewConnectionBindingSource.DataSource = typeof(AydinUniversityProject.Data.POCOs.Connection);
			this.NewConnectionLookUpEdit.Properties.ValueMember = "ID"; 
			this.NewConnectionLookUpEdit.Properties.DisplayMember = "ConnectionName";
			this.NewConnectionLookUpEdit.Properties.DataSource = this.NewConnectionBindingSource;
			this.NewConnectionLookUpEdit.Name = "NewConnectionLookUpEdit";
			this.NewConnectionLookUpEdit.DataBindings.Add("EditValue", screenShareRequestViewBindingSource, "NewConnectionID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters NewConnectionLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            NewConnectionLookUpEditRetrieveFieldParameters.FieldName = "NewConnectionID";
            NewConnectionLookUpEditRetrieveFieldParameters.ControlForField = this.NewConnectionLookUpEdit;
			parameters.CustomListParameters.Add(NewConnectionLookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters NewConnectionLookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    NewConnectionLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "NewConnection";
		    NewConnectionLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(NewConnectionLookUpEditRetrieveFieldParameters_NotGenerate);
						//
			//RequesterLookUpEdit
			//
			this.RequesterBindingSource.DataSource = typeof(AydinUniversityProject.Data.POCOs.User);
			this.RequesterLookUpEdit.Properties.ValueMember = "ID"; 
			this.RequesterLookUpEdit.Properties.DisplayMember = "Username";
			this.RequesterLookUpEdit.Properties.DataSource = this.RequesterBindingSource;
			this.RequesterLookUpEdit.Name = "RequesterLookUpEdit";
			this.RequesterLookUpEdit.DataBindings.Add("EditValue", screenShareRequestViewBindingSource, "RequesterID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters RequesterLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            RequesterLookUpEditRetrieveFieldParameters.FieldName = "RequesterID";
            RequesterLookUpEditRetrieveFieldParameters.ControlForField = this.RequesterLookUpEdit;
			parameters.CustomListParameters.Add(RequesterLookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters RequesterLookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    RequesterLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "Requester";
		    RequesterLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(RequesterLookUpEditRetrieveFieldParameters_NotGenerate);
						//
			//RequestToLookUpEdit
			//
			this.RequestToBindingSource.DataSource = typeof(AydinUniversityProject.Data.POCOs.User);
			this.RequestToLookUpEdit.Properties.ValueMember = "ID"; 
			this.RequestToLookUpEdit.Properties.DisplayMember = "Username";
			this.RequestToLookUpEdit.Properties.DataSource = this.RequestToBindingSource;
			this.RequestToLookUpEdit.Name = "RequestToLookUpEdit";
			this.RequestToLookUpEdit.DataBindings.Add("EditValue", screenShareRequestViewBindingSource, "RequestToID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters RequestToLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            RequestToLookUpEditRetrieveFieldParameters.FieldName = "RequestToID";
            RequestToLookUpEditRetrieveFieldParameters.ControlForField = this.RequestToLookUpEdit;
			parameters.CustomListParameters.Add(RequestToLookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters RequestToLookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    RequestToLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "RequestTo";
		    RequestToLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(RequestToLookUpEditRetrieveFieldParameters_NotGenerate);
			 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(AydinUniversityProject.Admin.ViewModels.ScreenShareRequestViewModel);
			// 
            // labelControl
            // 
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.Name = "labelControl";
            this.labelControl.Text = "ScreenShareRequest - Element View";
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
			//
			//ScreenShareRequestView
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
            this.Name = "ScreenShareRequestView";
						this.ResumeLayout(false);
		}
		
        #endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCloseButton;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
		private DevExpress.XtraEditors.LabelControl labelControl;
		private System.Windows.Forms.BindingSource screenShareRequestViewBindingSource;
						private DevExpress.XtraEditors.GridLookUpEdit NewConnectionLookUpEdit;
		private System.Windows.Forms.BindingSource NewConnectionBindingSource;
				private DevExpress.XtraEditors.GridLookUpEdit RequesterLookUpEdit;
		private System.Windows.Forms.BindingSource RequesterBindingSource;
				private DevExpress.XtraEditors.GridLookUpEdit RequestToLookUpEdit;
		private System.Windows.Forms.BindingSource RequestToBindingSource;
		 
	}
}
