using BloggingProject.web.Data;
using BloggingProject.web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BloggingProject.web.Repositories;

public class BlogPostCommentRepository : IBlogPostCommentRepository
{
    private readonly BlogDbContext _dbContext;

    public BlogPostCommentRepository(BlogDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<BlogPostComment> AddAsync(BlogPostComment blogPostComment)
    {
        await _dbContext.BlogPostComment.AddAsync(blogPostComment);
        await _dbContext.SaveChangesAsync();
        return blogPostComment;
    }

    public async Task<IEnumerable<BlogPostComment>> GetCommentsByBlogIdAsync(Guid blogPostId)
    {
        return await _dbContext.BlogPostComment.Where(x =>
            x.BlogPostId == blogPostId).ToListAsync();

    }
}
