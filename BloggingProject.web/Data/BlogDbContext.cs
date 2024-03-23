using BloggingProject.web.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BloggingProject.web.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<BlogPostComment> BlogPostComment { get; set; }
        public DbSet<BlogPostLike> BlogPostLike { get; set; }
    }
}
