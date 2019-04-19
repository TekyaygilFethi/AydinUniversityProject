using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.ViewModel;
using AydinUniversityProject.Admin.AydinUniversityProjectContextDataModel;

namespace AydinUniversityProject.Admin.ViewModels {
    /// <summary>
    /// Represents the root POCO view model for the AydinUniversityProjectContext data model.
    /// </summary>
    public partial class AydinUniversityProjectContextViewModel : DocumentsViewModel<AydinUniversityProjectContextModuleDescription, IAydinUniversityProjectContextUnitOfWork> {

		const string TablesGroup = "Tables";

		const string ViewsGroup = "Views";
		INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }
	
        /// <summary>
        /// Creates a new instance of AydinUniversityProjectContextViewModel as a POCO view model.
        /// </summary>
        public static AydinUniversityProjectContextViewModel Create() {
            return ViewModelSource.Create(() => new AydinUniversityProjectContextViewModel());
        }

		
        /// <summary>
        /// Initializes a new instance of the AydinUniversityProjectContextViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the AydinUniversityProjectContextViewModel type without the POCO proxy factory.
        /// </summary>
        protected AydinUniversityProjectContextViewModel()
		    : base(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }

        protected override AydinUniversityProjectContextModuleDescription[] CreateModules() {
			return new AydinUniversityProjectContextModuleDescription[] {
                new AydinUniversityProjectContextModuleDescription( "Connections", "ConnectionCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Connections)),
                new AydinUniversityProjectContextModuleDescription( "Screen Share Requests", "ScreenShareRequestCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.ScreenShareRequests)),
                new AydinUniversityProjectContextModuleDescription( "Users", "UserCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Users)),
                new AydinUniversityProjectContextModuleDescription( "Favourite Feeds", "FavouriteFeedsCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.FavouriteFeeds)),
                new AydinUniversityProjectContextModuleDescription( "Posts", "PostCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Posts)),
                new AydinUniversityProjectContextModuleDescription( "Sent Feeds", "SentFeedsCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.SentFeeds)),
                new AydinUniversityProjectContextModuleDescription( "Topics", "TopicCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Topics)),
                new AydinUniversityProjectContextModuleDescription( "Lessons", "LessonCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Lessons)),
                new AydinUniversityProjectContextModuleDescription( "Educations", "EducationCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Educations)),
                new AydinUniversityProjectContextModuleDescription( "Notes", "NoteCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Notes)),
                new AydinUniversityProjectContextModuleDescription( "Students", "StudentCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Students)),
                new AydinUniversityProjectContextModuleDescription( "Periods", "PeriodCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Periods)),
                new AydinUniversityProjectContextModuleDescription( "Friend Relationships", "FriendRelationshipCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.FriendRelationships)),
                new AydinUniversityProjectContextModuleDescription( "Friend Requests", "FriendRequestCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.FriendRequests)),
                new AydinUniversityProjectContextModuleDescription( "Messages", "MessageCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Messages)),
                new AydinUniversityProjectContextModuleDescription( "Reviews", "ReviewCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Reviews)),
                new AydinUniversityProjectContextModuleDescription( "Contacts", "ContactCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Contacts)),
			};
        }
                		protected override void OnActiveModuleChanged(AydinUniversityProjectContextModuleDescription oldModule) {
            if(ActiveModule != null && NavigationService != null) {
                NavigationService.ClearNavigationHistory();
            }
            base.OnActiveModuleChanged(oldModule);
        }
	}

    public partial class AydinUniversityProjectContextModuleDescription : ModuleDescription<AydinUniversityProjectContextModuleDescription> {
        public AydinUniversityProjectContextModuleDescription(string title, string documentType, string group, Func<AydinUniversityProjectContextModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory) {
        }
    }
}