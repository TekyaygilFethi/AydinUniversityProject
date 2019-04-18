using AydinUniversityProject.Business.ManagerFolder.BaseManagers.ManagerBases;
using AydinUniversityProject.Business.RepositoryFolder;
using AydinUniversityProject.Data.POCOs;

namespace AydinUniversityProject.Business.ManagerFolder.Managers.ScreenShareOpsManagers
{
    public class ConnectionManager : BaseManager
    {
        IRepository<Connection> connectionRepository;

        public ConnectionManager()
        {
            connectionRepository = base.GetRepository<Connection>();
        }

        public void AddConnection(Connection connection)
        {
            connectionRepository.Add(connection);
        }

        public void EditConnection(Connection connection)
        {
            connectionRepository.Update(connection);
        }

        public Connection GetConnection(int ID)
        {
            return connectionRepository.GetByID(ID);
        }

        public void DeleteConnection(Connection connection)
        {
            connectionRepository.Delete(connection);
        }
    }
}
