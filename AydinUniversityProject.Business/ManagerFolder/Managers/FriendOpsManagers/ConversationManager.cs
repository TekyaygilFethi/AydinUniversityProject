using AydinUniversityProject.Business.ManagerFolder.BaseManagers.ManagerBases;
using AydinUniversityProject.Business.RepositoryFolder;
using AydinUniversityProject.Data.POCOs;

namespace AydinUniversityProject.Business.ManagerFolder.Managers.FriendOpsManagers
{
    public class ConversationManager : BaseManager
    {
        IRepository<Conversation> conversationRepository;

        public ConversationManager()
        {
            conversationRepository = base.GetRepository<Conversation>();
        }

        public void AddConversation(Conversation conversation)
        {
            conversationRepository.Add(conversation);
        }

        public void EditConversation(Conversation conversation)
        {
            conversationRepository.Update(conversation);
        }

        public Conversation GetConversation(int ID)
        {
            return conversationRepository.GetByID(ID);
        }

        public void DeleteConversation(Conversation conversation)
        {
            conversationRepository.Delete(conversation);
        }
    }
}
