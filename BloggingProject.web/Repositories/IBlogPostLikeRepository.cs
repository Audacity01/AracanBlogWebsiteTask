using BloggingProject.web.Models.Domain;

namespace BloggingProject.web.Repositories;

public interface IBlogPostLikeRepository
{
    Task<int> GetTotalLikes(Guid blogPostId);
    Task<BlogPostLike> AddLikeForBlog(BlogPostLike blogPostLike);
    Task<IEnumerable<BlogPostLike>> GetLikesForBlog(Guid blogPostId);
}