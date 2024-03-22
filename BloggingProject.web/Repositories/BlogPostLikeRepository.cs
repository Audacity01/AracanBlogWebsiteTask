using BloggingProject.web.Data;
using BloggingProject.web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BloggingProject.web.Repositories
{
    public class BlogPostLikeRepository : IBlogPostLikeRepository
    {
        private readonly BlogDbContext _dbContext;

        public BlogPostLikeRepository(BlogDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<BlogPostLike> AddLikeForBlog(BlogPostLike blogPostLike)
        {
            await _dbContext.BlogPostLike.AddAsync(blogPostLike);
            await _dbContext.SaveChangesAsync();
            return blogPostLike;
        }

        public async Task<IEnumerable<BlogPostLike>> GetLikesForBlog(Guid blogPostId)
        {
            return await _dbContext.BlogPostLike.Where(x => x.BlogPostId == blogPostId)
                .ToListAsync();
        }

        public async Task<int> GetTotalLikes(Guid blogPostId)
        {
            return await _dbContext.BlogPostLike
            .CountAsync(x => x.BlogPostId == blogPostId);
        }
    }
}
