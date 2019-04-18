using AydinUniversityProject.Business.ManagerFolder.BaseManagers.ComplexManagersBases;
using AydinUniversityProject.Business.ManagerFolder.Managers.UserOpsManagers;
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
        public AccountComplexManager()
        {
            userManager = base.GetManager<UserManager>();
            stdManager = base.GetManager<StudentManager>();
        }

        public TransactionObject CreateAccount(CreateAccountFormData newAccountInfo)
        {
            TransactionObject response = new TransactionObject();

            if (userManager.IsUserExists(newAccountInfo.Username))
            {
                try
                {
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

                    newUser.Student = newStudent;
                    newStudent.User = newUser;

                    userManager.AddUser(newUser);
                    stdManager.AddStudent(newStudent);

                    var saveResponse = Save();

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

        public LoginResponseObject Login(string username, string password)
        {
            TransactionObject loginResponse = userManager.CheckCreedientals(username, password);
            LoginResponseObject response = new LoginResponseObject
            {
                TransactionObject = loginResponse
            };

            if (loginResponse.IsSuccess)
            {
                User currentUser = userManager.GetUserByUsername(username);
                SetOnlineStatus(userManager.GetUser(currentUser.ID), true);
                Save();
                response.Student = currentUser.Student;
            }
            return response;
        }

        public User SetOnlineStatus(User user, bool IsOnline)
        {
            user.IsOnline = IsOnline;
            base.Save();
            return user;
        }

        public TransactionObject LogOff(int ID)
        {
            TransactionObject response = new TransactionObject();

            try
            {
                SetOnlineStatus(userManager.GetUser(ID), false);
                Save();
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
    }
}
