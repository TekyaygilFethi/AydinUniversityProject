using AydinUniversityProject.Business.RepositoryFolder;
using AydinUniversityProject.Data.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AydinUniversityProject.Business.ManagerFolder.Managers.ScreenShareOpsManagers
{
    public class ScreenShareManager
    {
        IRepository<ScreenShareRequest> screenShareRequestRepository;

        public ScreenShareManager(IRepository<ScreenShareRequest> repo)
        {
            screenShareRequestRepository = repo;
        }

        public void AddScreenShareRequest(ScreenShareRequest screenShareRequest)
        {
            screenShareRequestRepository.Add(screenShareRequest);
        }

        
        public ScreenShareRequest GetScreenShareRequest(int ID)
        {
            return screenShareRequestRepository.GetByID(ID);
        }


        public void DeleteConnection(ScreenShareRequest connection)
        {
            screenShareRequestRepository.Delete(connection);
        }

        public List<ScreenShareRequest> GetConnectionBy(Expression<Func<ScreenShareRequest, bool>> expression)
        {
            return screenShareRequestRepository.GetBy(expression);
        }
    }
}
