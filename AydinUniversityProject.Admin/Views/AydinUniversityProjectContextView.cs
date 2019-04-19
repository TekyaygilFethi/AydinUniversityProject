using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DevExpress.Utils.MVVM.Services;
using DevExpress.Utils.MVVM;
using DevExpress.XtraBars.Navigation;

namespace AydinUniversityProject.Admin.Views.AydinUniversityProjectContextView{
    public partial class AydinUniversityProjectContextView : XtraUserControl {
        public AydinUniversityProjectContextView() {
		     InitializeComponent();
			 if(!mvvmContext.IsDesignMode)
                InitializeNavigation();
        }
        void InitializeNavigation() {
			DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware();
            DevExpress.XtraEditors.WindowsFormsSettings.EnableFormSkins();
            DevExpress.XtraEditors.WindowsFormsSettings.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            DevExpress.XtraEditors.WindowsFormsSettings.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.True;
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2013");
            float fontSize = 10f;
            DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = new System.Drawing.Font("Segoe UI", fontSize);
            DevExpress.XtraEditors.WindowsFormsSettings.DefaultMenuFont = new System.Drawing.Font("Segoe UI", fontSize);

			tileBar.SelectionColorMode = SelectionColorMode.UseItemBackColor;
            mvvmContext.RegisterService(DocumentManagerService.Create(navigationFrame));
            DevExpress.Utils.MVVM.MVVMContext.RegisterFlyoutDialogService();
            // We want to use buttons in Ribbon to show the specific modules
            var fluentAPI = mvvmContext.OfType<AydinUniversityProject.Admin.ViewModels.AydinUniversityProjectContextViewModel>();
						tileBar.SelectedItem = tileBarItemConnectionCollectionView;

			            fluentAPI.BindCommand(tileBarItemConnectionCollectionView, (x, m) => x.Show(m), x => x.Modules[0]);
			            fluentAPI.BindCommand(tileBarItemScreenShareRequestCollectionView, (x, m) => x.Show(m), x => x.Modules[1]);
			            fluentAPI.BindCommand(tileBarItemUserCollectionView, (x, m) => x.Show(m), x => x.Modules[2]);
			            fluentAPI.BindCommand(tileBarItemFavouriteFeedsCollectionView, (x, m) => x.Show(m), x => x.Modules[3]);
			            fluentAPI.BindCommand(tileBarItemPostCollectionView, (x, m) => x.Show(m), x => x.Modules[4]);
			            fluentAPI.BindCommand(tileBarItemSentFeedsCollectionView, (x, m) => x.Show(m), x => x.Modules[5]);
			            fluentAPI.BindCommand(tileBarItemTopicCollectionView, (x, m) => x.Show(m), x => x.Modules[6]);
			            fluentAPI.BindCommand(tileBarItemLessonCollectionView, (x, m) => x.Show(m), x => x.Modules[7]);
			            fluentAPI.BindCommand(tileBarItemEducationCollectionView, (x, m) => x.Show(m), x => x.Modules[8]);
			            fluentAPI.BindCommand(tileBarItemNoteCollectionView, (x, m) => x.Show(m), x => x.Modules[9]);
			            fluentAPI.BindCommand(tileBarItemStudentCollectionView, (x, m) => x.Show(m), x => x.Modules[10]);
			            fluentAPI.BindCommand(tileBarItemPeriodCollectionView, (x, m) => x.Show(m), x => x.Modules[11]);
			            fluentAPI.BindCommand(tileBarItemFriendRelationshipCollectionView, (x, m) => x.Show(m), x => x.Modules[12]);
			            fluentAPI.BindCommand(tileBarItemFriendRequestCollectionView, (x, m) => x.Show(m), x => x.Modules[13]);
			            fluentAPI.BindCommand(tileBarItemMessageCollectionView, (x, m) => x.Show(m), x => x.Modules[14]);
			            fluentAPI.BindCommand(tileBarItemReviewCollectionView, (x, m) => x.Show(m), x => x.Modules[15]);
			            fluentAPI.BindCommand(tileBarItemContactCollectionView, (x, m) => x.Show(m), x => x.Modules[16]);
						            // We want show the default module when our UserControl is loaded
            fluentAPI.WithEvent<EventArgs>(this, "Load")
                .EventToCommand(x => x.OnLoaded(null), x => x.DefaultModule);
		
        }
    }
}
