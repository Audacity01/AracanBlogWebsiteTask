﻿using BloggingProject.web.Models.Domain;

namespace Blog.Web.Repositories;

public interface IBlogPostCommentRepository
{
    Task<BlogPostComment> AddAsync(BlogPostComment blogPostComment);
    Task<IEnumerable<BlogPostComment>> GetCommentsByBlogIdAsync(Guid blogPostId);  
}