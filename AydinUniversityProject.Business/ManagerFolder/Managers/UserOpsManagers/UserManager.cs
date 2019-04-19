using AydinUniversityProject.Business.ManagerFolder.BaseManagers.ManagerBases;
using AydinUniversityProject.Business.RepositoryFolder;
using AydinUniversityProject.Data.Business;
using AydinUniversityProject.Data.POCOs;
using System.Collections.Generic;
using System.Linq;

namespace AydinUniversityProject.Business.ManagerFolder.Managers.UserOpsManagers
{
    public class UserManager
    {
        IRepository<User> userRepository;

        public UserManager(IRepository<User> repo)
        {
            userRepository = repo;
        }

        public void AddUser(User user)
        {
            userRepository.Add(user);
        }

        public TransactionObject CheckCreedientals(string username, string password)
        {
            TransactionObject response = new TransactionObject();
            User user = userRepository.SingleGetBy(w => w.Username == username);

            if (user == null)
            {
                response.IsSuccess = false;
                response.Explanation = "Username is invalid!";
            }
            else
            {
                if (SecurityFolder.Security.VerifyPassword(user.Password, password))
                    response.IsSuccess = true;

                else
                {
                    response.IsSuccess = false;
                    response.Explanation = "Password is invalid!";
                }
            }
            return response;
        }

        public User GetUser(int userID)
        {
            return userRepository.GetByID(userID);
        }

        public User GetUserByUsername(string username)
        {
            return userRepository.SingleGetBy(w=>w.Username==username);
        }

        public int GetUserIDByUsername(string username)
        {
            return userRepository.SingleGetBy(w => w.Username == username).ID;
        }

        public bool IsUserExists(string username)
        {
            return userRepository.SingleGetBy(w => w.Username == username) == null;
        }

        public List<User> GetAllUsers()
        {
            return userRepository.GetAll();
        }

        public List<string> GetAllUsernames()
        {
            return userRepository.GetAll().Select(s => s.Username).ToList();
        }
    }
}
