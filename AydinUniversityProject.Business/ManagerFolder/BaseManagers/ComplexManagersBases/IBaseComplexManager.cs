using AydinUniversityProject.Data.Business;

namespace AydinUniversityProject.Business.ManagerFolder.BaseManagers.ComplexManagersBases
{
    public interface IBaseComplexManager
    {
        T GetManager<T>() where T : class;

        TransactionObject Save();
    }
}
