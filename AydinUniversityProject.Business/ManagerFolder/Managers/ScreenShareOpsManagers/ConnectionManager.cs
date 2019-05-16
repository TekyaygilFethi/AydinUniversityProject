using AydinUniversityProject.Business.RepositoryFolder;
using AydinUniversityProject.Data.POCOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AydinUniversityProject.Business.ManagerFolder.Managers.ScreenShareOpsManagers
{
    public class ConnectionManager
    {
        IRepository<Connection> connectionRepository;

        public ConnectionManager(IRepository<Connection> repo)
        {
            connectionRepository = repo;
        }

        public void AddConnection(Connection connection)
        {
            connectionRepository.Add(connection);
        }

        public void EditConnection(Connection connection)
        {
            //connectionRepository.Update(connection);
        }

        public Connection GetConnection(int ID)
        {
            return connectionRepository.GetByID(ID);
        }
              

        public void DeleteConnection(Connection connection)
        {
            connectionRepository.Delete(connection);
        }

        public List<Connection> GetConnectionBy(Expression<Func<Connection, bool>> expression)
        {
            return connectionRepository.GetBy(expression);
        }
    }
}
