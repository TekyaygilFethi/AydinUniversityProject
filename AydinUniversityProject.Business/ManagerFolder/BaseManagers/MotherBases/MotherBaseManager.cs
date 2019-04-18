using AydinUniversityProject.Business.UnitOfWorkFolder;

namespace AydinUniversityProject.Business.ManagerFolder.BaseManagers.MotherBases
{
    public class MotherBaseManager
    {
        private static UnitOfWork uow = new UnitOfWork();

        public UnitOfWork Context
        {
            get
            {
                return uow;
            }

        }

    }
}
