using AydinUniversityProject.Business.ManagerFolder.BaseManagers.ManagerBases;
using AydinUniversityProject.Business.RepositoryFolder;
using AydinUniversityProject.Data.POCOs;

namespace AydinUniversityProject.Business.ManagerFolder.Managers.ForumOpsManagers
{
    public class PostManager : BaseManager
    {
        readonly IRepository<Post> postRepository;

        public PostManager()
        {
            postRepository = base.GetRepository<Post>();
        }

        public Post GetPost(int ID)
        {
            return postRepository.GetByID(ID);
        }

        public void AddPost(Post post)
        {
            postRepository.Add(post);
        }

        public void DeletePost(Post post)
        {
            postRepository.Delete(post);
        }

        public void UpdatePost(Post post)
        {
            postRepository.Update(post);
        }

    }
}
