using AydinUniversityProject.Business.RepositoryFolder;
using AydinUniversityProject.Data.POCOs;
using System.Collections.Generic;

namespace AydinUniversityProject.Business.ManagerFolder.Managers.ForumOpsManagers
{
    public class PostManager
    {
        readonly IRepository<Post> postRepository;

        public PostManager(IRepository<Post> repo)
        {
            postRepository = repo;
        }

        public Post GetPost(int ID)
        {
            return postRepository.GetByID(ID);
        }

        public List<Post> GetAllPostsOfStudent(int studentID)
        {
            return postRepository.GetBy(w => w.SentFeed.ID == studentID);
        }

        

        public List<Post> GetAllPosts()
        {
            return postRepository.GetAll();
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
            //postRepository.Update(post);
        }

    }
}
