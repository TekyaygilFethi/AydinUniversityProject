using AydinUniversityProject.Business.RepositoryFolder;
using AydinUniversityProject.Data.POCOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AydinUniversityProject.Business.ManagerFolder.Managers.ScreenShareOpsManagers
{
    public class ReviewManager
    {
        IRepository<Review> reviewRepository;

        public ReviewManager(IRepository<Review> repo)
        {
            reviewRepository = repo;
        }

        public void AddReview(Review review)
        {
            reviewRepository.Add(review);
        }

        public Review GetReview(int ID)
        {
            return reviewRepository.GetByID(ID);
        }

        public void DeleteReview(Review review)
        {
            reviewRepository.Delete(review);
        }

        public List<Review> GetReviewBy(Expression<Func<Review, bool>> expression)
        {
            return reviewRepository.GetBy(expression);
        }
    }
}

