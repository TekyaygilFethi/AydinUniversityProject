using AydinUniversityProject.Business.ManagerFolder.BaseManagers.ComplexManagersBases;
using AydinUniversityProject.Business.ManagerFolder.Managers.EducationOpsManagers;
using AydinUniversityProject.Business.ManagerFolder.Managers.ForumOpsManagers;
using AydinUniversityProject.Business.ManagerFolder.Managers.UserOpsManagers;
using AydinUniversityProject.Business.UnitOfWorkFolder;
using AydinUniversityProject.Data.Business;
using AydinUniversityProject.Data.Business.ForumComplexManager;
using AydinUniversityProject.Data.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AydinUniversityProject.Business.ManagerFolder.ComplexManagers.ForumOpsComplexManagers
{
    public class ForumComplexManager : BaseComplexManager
    {
        TopicManager topicManager;
        PostManager postManager;
        LessonManager lessonManager;
        UserManager userManager;
        SentFeedManager sentFeedManager;
        FavouriteFeedManager favFeedManager;

        IUnitOfWork uow;

        public ForumComplexManager()
        {
            uow = new UnitOfWork(new Database.Context.AydinUniversityProjectContext());

            topicManager = uow.GetManager<TopicManager, Topic>();
            postManager = uow.GetManager<PostManager, Post>();
            lessonManager = uow.GetManager<LessonManager, Lesson>();
            userManager = uow.GetManager<UserManager, User>();
            sentFeedManager = uow.GetManager<SentFeedManager, SentFeeds>();
            favFeedManager = uow.GetManager<FavouriteFeedManager, FavouriteFeeds>();
        }


        public List<Post> TopicPosts(int ID)
        {
            return topicManager.GetTopic(ID).Posts;
        }

        public List<Topic> LessonTopics(int ID)
        {
            return GetLesson(ID).Topics;
        }

        public Topic GetTopic(int ID)
        {
            return topicManager.GetTopic(ID);
        }

        public Lesson GetLesson(int ID)
        {
            return lessonManager.GetLesson(ID);
        }

        public List<Topic> GetAllTopics()
        {
            return topicManager.GetAllTopics();
        }

        public List<Lesson> GetAllLessons()
        {
            return lessonManager.GetAllLessons();
        }

        public TransactionObject CreateNewTopic(NewTopicFormData ntfd)
        {
            TransactionObject response = new TransactionObject();

            try
            {
                Lesson selectedLesson = lessonManager.GetLesson(ntfd.LessonID);
                User currentUser = userManager.GetUser(ntfd.UserID);

                Topic newTopic = new Topic();
                newTopic.Name = ntfd.TopicName;
                newTopic.Lesson = selectedLesson;
                selectedLesson.Topics.Add(newTopic);

                Post post = new Post();
                post.Topic = newTopic;
                newTopic.Posts.Add(post);

                post.Content = ntfd.Content;
                post.PostDate = DateTime.Now;

                post.Lesson = selectedLesson;
                selectedLesson.Posts.Add(post);

                SentFeeds sf = currentUser.SentFeeds;

                if (sf == null)
                {
                    sf = new SentFeeds();
                    sf.User = currentUser;
                    currentUser.SentFeeds = sf;

                }
                sf.SentTopics.Add(newTopic);
                newTopic.SentFeed = sf;

                sf.SentPosts.Add(post);
                post.SentFeed = sf;

                if (sf == null)
                    sentFeedManager.AddSentFeed(sf);


                topicManager.AddTopic(newTopic);
                postManager.AddPost(post);
                uow.Save();
                response.IsSuccess = true;
                response.Explanation = newTopic.ID.ToString();
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Explanation = base.GetExceptionMessage(ex);
            }
            return response;
        }

        public TransactionObject ToggleFavTopic(int ID, int userID)
        {
            TransactionObject response = new TransactionObject();
            try
            {
                Topic favTopic = topicManager.GetTopic(ID);
                User currentUser = userManager.GetUser(userID);

                FavouriteFeeds ff = currentUser.FavouriteFeeds;
                if (ff == null)
                {
                    ff = new FavouriteFeeds();
                    ff.User = currentUser;
                    currentUser.FavouriteFeeds = ff;
                    favFeedManager.AddFavouriteFeed(ff);
                }

                if (CheckExistence<Topic>(ff.FavouriteTopics, favTopic))
                {
                    ff.FavouriteTopics.Remove(favTopic);
                    favTopic.FavouriteFeeds.Remove(ff);
                    favTopic.FavouritedCount--;
                }
                else
                {
                    ff.FavouriteTopics.Add(favTopic);
                    favTopic.FavouriteFeeds.Add(ff);
                    favTopic.FavouritedCount++;
                }
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

        public TransactionObject ToggleFavPost(int ID, int userID)
        {
            TransactionObject response = new TransactionObject();
            try
            {
                Post favPost = postManager.GetPost(ID);
                User currentUser = userManager.GetUser(userID);

                FavouriteFeeds ff = currentUser.FavouriteFeeds;
                if (ff == null)
                {
                    ff = new FavouriteFeeds();
                    ff.User = currentUser;
                    currentUser.FavouriteFeeds = ff;
                    favFeedManager.AddFavouriteFeed(ff);
                }

                if (CheckExistence(ff.FavouritePosts, favPost))
                {
                    ff.FavouritePosts.Remove(favPost);
                    favPost.FavouriteFeeds.Remove(ff);
                    favPost.FavouritedCount--;
                }
                else
                {
                    ff.FavouritePosts.Add(favPost);
                    favPost.FavouriteFeeds.Add(ff);
                    favPost.FavouritedCount++;
                }
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

        public bool CheckExistence<T>(List<T> list, T item) where T : class
        {
            return list.Contains(item);
        }

        public TransactionObject DeleteTopic(int ID)
        {
            TransactionObject response = new TransactionObject();

            try
            {
                topicManager.DeleteTopic(ID);

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

        public TransactionObject GetTopicCountOfStudent(int studentID)
        {
            TransactionObject response = new TransactionObject();
            try
            {
                response.Explanation = topicManager.GetAllTopicsOfStudent(studentID).Count().ToString();
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Explanation = base.GetExceptionMessage(ex);
            }
            return response;
        }

        public TransactionObject GetPostCountOfStudent(int studentID)
        {
            TransactionObject response = new TransactionObject();
            try
            {
                response.Explanation = postManager.GetAllPostsOfStudent(studentID).Count().ToString();
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Explanation = base.GetExceptionMessage(ex);
            }
            return response;
        }

        public TransactionObject GetFavTopicCountOfStudent(int studentID)
        {
            TransactionObject response = new TransactionObject();
            try
            {
                response.Explanation = userManager.GetUser(studentID)?.FavouriteFeeds?.FavouriteTopics.Count().ToString();
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Explanation = base.GetExceptionMessage(ex);
            }
            return response;
        }

        public TransactionObject GetFavPostCountOfStudent(int studentID)
        {
            TransactionObject response = new TransactionObject();
            try
            {
                response.Explanation = userManager.GetUser(studentID)?.FavouriteFeeds?.FavouritePosts.Count().ToString();
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Explanation = base.GetExceptionMessage(ex);
            }
            return response;
        }

        public TransactionObject SendPost(int topicID, int userID, string postContent)
        {
            TransactionObject response = new TransactionObject();
            try
            {
                Topic currentTopic = topicManager.GetTopic(topicID);
                User currentUser = userManager.GetUser(userID);

                SentFeeds sf = currentUser.SentFeeds;

                if (sf == null)
                {
                    sf = new SentFeeds();
                    sf.User = currentUser;
                    currentUser.SentFeeds = sf;
                    sentFeedManager.AddSentFeed(sf);
                }
                Post newPost = new Post();
                newPost.Topic = currentTopic;
                newPost.PostDate = DateTime.Now;
                newPost.Content = postContent;
                newPost.SentFeed = sf;
                newPost.Lesson = currentTopic.Lesson;
                currentTopic.Lesson.Posts.Add(newPost);

                currentTopic.Posts.Add(newPost);
                currentUser.SentFeeds.SentPosts.Add(newPost);

                postManager.AddPost(newPost);
                uow.Save();


                response.IsSuccess = true;
            }catch(Exception ex)
            {
                response.IsSuccess = false;
                response.Explanation = ex.Message;
            }
            
            return response;
        }
    }
}
