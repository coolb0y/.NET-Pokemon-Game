using webapi.models;

namespace webapi.Interfaces
{
    public interface IReviewerRepository 
    {
        ICollection<Reviewer> GetReviewers();
        Reviewer GetReviewer(int reviewId);
        ICollection<Review> GetReviewsByReviewer(int reviewId);
        bool ReviewerExists(int reviewerId);
    }
}
