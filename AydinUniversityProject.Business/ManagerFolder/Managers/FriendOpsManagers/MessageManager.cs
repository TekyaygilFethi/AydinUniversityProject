using AydinUniversityProject.Business.ManagerFolder.BaseManagers.ManagerBases;
using AydinUniversityProject.Business.RepositoryFolder;
using AydinUniversityProject.Data.POCOs;

namespace AydinUniversityProject.Business.ManagerFolder.Managers.FriendOpsManagers
{
    public class MessageManager : BaseManager
    {
        IRepository<Message> messageRepository;

        public MessageManager()
        {
            messageRepository = base.GetRepository<Message>();
        }

        public void AddMessage(Message msg)
        {
            messageRepository.Add(msg);
        }

        public void EditMessage(Message msg)
        {
            messageRepository.Update(msg);
        }

        public Message GetMessage(int ID)
        {
            return messageRepository.GetByID(ID);
        }

        public void DeleteMessage(Message msg)
        {
            messageRepository.Delete(msg);
        }
    }
}
