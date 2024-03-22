﻿using BloggingProject.web.Data;
using BloggingProject.web.Models.Domain;
using BloggingProject.web.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Blog.Web.Repositories;

public class BlogPostLikeRepository : IBlogPostLikeRepository
{
    private readonly BlogDbContext _blogDbContext;

    public BlogPostLikeRepository(BlogDbContext blogDbContext)
    {
        _blogDbContext = blogDbContext;
    }
    public async Task<int> GetTotalLikes(Guid blogPostId)
    {
        return await _blogDbContext.BlogPostLike
            .CountAsync(x => x.BlogPostId == blogPostId);
    }

    public async Task<BlogPostLike> AddLikeForBlog(BlogPostLike blogPostLike)
    {
        await _blogDbContext.BlogPostLike.AddAsync(blogPostLike);
        await _blogDbContext.SaveChangesAsync();
        return blogPostLike;
    }

    public async Task<IEnumerable<BlogPostLike>> GetLikesForBlog(Guid blogPostId)
    {
        return await _blogDbContext.BlogPostLike.Where(x => x.BlogPostId == blogPostId)
            .ToListAsync();
    }
}