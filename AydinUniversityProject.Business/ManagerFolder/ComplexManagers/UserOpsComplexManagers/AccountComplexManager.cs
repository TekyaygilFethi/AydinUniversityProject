using AydinUniversityProject.Business.ManagerFolder.BaseManagers.ComplexManagersBases;
using AydinUniversityProject.Business.ManagerFolder.Managers.EducationOpsManagers;
using AydinUniversityProject.Business.ManagerFolder.Managers.FriendOpsManagers;
using AydinUniversityProject.Business.ManagerFolder.Managers.UserOpsManagers;
using AydinUniversityProject.Business.UnitOfWorkFolder;
using AydinUniversityProject.Data.Business;
using AydinUniversityProject.Data.Business.AccountComplexManagerData;
using AydinUniversityProject.Data.POCOs;
using System;
using System.Collections.Generic;

namespace AydinUniversityProject.Business.ComplexManagers.UserOpsComplexManagers
{
    public class AccountComplexManager : BaseComplexManager
    {
        UserManager userManager;
        StudentManager stdManager;
        PeriodManager prdManager;
        FriendRelationshipManager frManager;
        IUnitOfWork uow;
        
        public AccountComplexManager()
        {
            uow = new UnitOfWork(new Database.Context.AydinUniversityProjectContext());
            userManager = uow.GetManager<UserManager,User>();
            stdManager = uow.GetManager<StudentManager,Student>();
            prdManager = uow.GetManager<PeriodManager, Period>();
            frManager = uow.GetManager<FriendRelationshipManager, FriendRelationship>();
        }

        public TransactionObject CreateAccount(CreateAccountFormData newAccountInfo)
        {
            TransactionObject response = new TransactionObject();

            if (userManager.IsUserExists(newAccountInfo.Username))
            {
                try
                {
                    Period period = prdManager.GetPeriod(newAccountInfo.Year,newAccountInfo.Term);
                                                         
                    User newUser = new User();
                    Student newStudent = new Student();

                    newUser.Username = newAccountInfo.Username;
                    newUser.CreationDate = DateTime.Now;
                    newUser.Password = SecurityFolder.Security.GetEncryptedPassword(newAccountInfo.Password);
                    newUser.ProfilePhoto = newAccountInfo.ProfilePhoto;
                    newUser.Email = newAccountInfo.Email;
                    
                    newStudent.Name = newAccountInfo.Name;
                    newStudent.Surname = newAccountInfo.Surname;
                    newStudent.Birthday = new DateTime(1996, 1, 1);
                    newStudent.Period = period;

                    period.Students.Add(newStudent);

                    newUser.Student = newStudent;
                    newStudent.User = newUser;

                    userManager.AddUser(newUser);
                    stdManager.AddStudent(newStudent);


                    FriendRelationship fr = new FriendRelationship();
                    newUser.FriendRelationship = fr;

                    frManager.AddFriendRelationship(fr);


                    var saveResponse = uow.Save();

                    if (saveResponse.IsSuccess)
                    {
                        response.IsSuccess = true;
                    }
                    else
                    {
                        response.IsSuccess = false;
                        response.Explanation = saveResponse.Explanation;
                    }
                }
                catch (Exception ex)
                {
                    response.IsSuccess = false;
                    response.Explanation = base.GetExceptionMessage(ex);
                }
            }
            else
            {
                response.IsSuccess = false;
                response.Explanation = "This username is exists! Please try valid username...";
            }
            return response;
        }

        public LoginResponseObject Login(LoginFormData lgn)
        {
            TransactionObject loginResponse = userManager.CheckCreedientals(lgn.Username, lgn.Password);
            LoginResponseObject response = new LoginResponseObject
            {
                TransactionObject = loginResponse
            };

            if (loginResponse.IsSuccess)
            {
                User currentUser = userManager.GetUserByUsername(lgn.Username);
                SetOnlineStatus(userManager.GetUser(currentUser.ID), true);
                uow.Save();
                response.ID = currentUser.ID;
            }
            return response;
        }

        public User SetOnlineStatus(User user, bool IsOnline)
        {
            user.IsOnline = IsOnline;
            uow.Save();
            return user;
        }

        public TransactionObject LogOff(int ID)
        {
            TransactionObject response = new TransactionObject();

            try
            {
                SetOnlineStatus(userManager.GetUser(ID), false);
                uow.Save();
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Explanation = base.GetExceptionMessage(ex);
            }

            return response;
        }

        public TransactionObject ToggleAdmin(int ID)
        {
            TransactionObject response = new TransactionObject();

            try
            {
                User user = userManager.GetUser(ID);

                if (user.IsAdmin)
                    user.IsAdmin = false;
                else
                    user.IsAdmin = true;

                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Explanation = base.GetExceptionMessage(ex);
            }

            return response;
        }

        public List<User> GetAllUsers()
        {
            return userManager.GetAllUsers();
        }

        public Student GetStudent(int ID)
        {
            return stdManager.GetStudent(ID);
        }

        public User GetUser(int ID)
        {
            return userManager.GetUser(ID);
        }

        public List<string> GetAllUsernames()
        {
            return userManager.GetAllUsernames();
        }

        public int GetUserIDByUsername(string username)
        {
            return userManager.GetUserIDByUsername(username);
        }
    }
}
