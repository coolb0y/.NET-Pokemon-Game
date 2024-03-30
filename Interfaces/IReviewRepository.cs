using webapi.models;

namespace webapi.Interfaces
{
    public interface IReviewRepository
    {
        ICollection<Review> GetReviews();
        Review GetReview(int reviewId);
        ICollection<Review> GetReviewsOfAPokemon(int pokeid);
        bool ReviewExists(int reviewId);

    }
}
