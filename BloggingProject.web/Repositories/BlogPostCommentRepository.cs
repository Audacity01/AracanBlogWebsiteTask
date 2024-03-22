using BloggingProject.web.Models.Domain;
using BloggingProject.web.Data;
using Microsoft.EntityFrameworkCore;

namespace Blog.Web.Repositories;

public class BlogPostCommentRepository : IBlogPostCommentRepository
{
    private readonly BlogDbContext _blogDbContext;

    public BlogPostCommentRepository(BlogDbContext blogDbContext)
    {
        _blogDbContext = blogDbContext;
    }
    public async Task<BlogPostComment> AddAsync(BlogPostComment blogPostComment)
    {
        await _blogDbContext.BlogPostComment.AddAsync(blogPostComment);
        await _blogDbContext.SaveChangesAsync();
        return blogPostComment;
    }

    public async Task<IEnumerable<BlogPostComment>> GetCommentsByBlogIdAsync(Guid blogPostId)
    {
        return await _blogDbContext.BlogPostComment.Where(x =>
            x.BlogPostId == blogPostId).ToListAsync();

    }
}