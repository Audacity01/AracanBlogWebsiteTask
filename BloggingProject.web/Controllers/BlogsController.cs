using BloggingProject.web.Models.Domain;
using BloggingProject.web.Models.ViewModels;
using BloggingProject.web.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BloggingProject.web.Controllers;

public class BlogsController : Controller
{
    private readonly IBlogPostRepository _blogPostRepository;
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly UserManager<IdentityUser> _userManager;
    private readonly IBlogPostLikeRepository _blogPostLikeRepository;
    private readonly IBlogPostCommentRepository _blogPostCommentRepository;

    public BlogsController(IBlogPostRepository blogPostRepository, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, IBlogPostLikeRepository blogPostLikeRepository, IBlogPostCommentRepository blogPostCommentRepository)
    {
        _blogPostRepository = blogPostRepository;
        _signInManager = signInManager;
        _userManager = userManager;
        _blogPostLikeRepository = blogPostLikeRepository;
        _blogPostCommentRepository = blogPostCommentRepository;
    }

    [HttpGet]
    public async Task<IActionResult> Index(string urlHandle)
    {
        var liked = false;
        var blogPost = await _blogPostRepository.GetByUrlHandleAsync(urlHandle);
        var blogPostLikeViewModel = new BlogDetailsViewModel();

        if(blogPost != null )
        {
            var totalLikes = await _blogPostLikeRepository.GetTotalLikes(blogPost.Id);
            if (_signInManager.IsSignedIn(User))
            {
                //likes for the blog
                var likesForBlog = await _blogPostLikeRepository.GetLikesForBlog(blogPost.Id);
                var userId = _userManager.GetUserId(User);

                if (userId != null)
                {
                    var likeFromUser = likesForBlog.FirstOrDefault(x => x.UserId == Guid.Parse(userId));
                    liked = likeFromUser != null;
                }
            }
            //Get comments for blogPost

            var blogCommentDomainModel = await _blogPostCommentRepository.GetCommentsByBlogIdAsync(blogPost.Id);
            var blogCommentForViewModel = new List<BlogComment>();

            foreach (var blogComment in blogCommentDomainModel)
            {
                blogCommentForViewModel.Add(new BlogComment
                {
                    Description = blogComment.Description,
                    DateAdded = blogComment.DateAdded,
                    Username = (await _userManager.FindByIdAsync(blogComment.userId.ToString())).UserName
                });
            }

            blogPostLikeViewModel = new BlogDetailsViewModel
            {
                Id = blogPost.Id,
                Heading = blogPost.Heading,
                PageTitle = blogPost.PageTitle,
                Content = blogPost.Content,
                ShortDescription = blogPost.ShortDescription,
                FeaturedImageUrl = blogPost.FeaturedImageUrl,
                UrlHandle = blogPost.UrlHandle,
                PublishedDate = blogPost.PublishedDate,
                Author = blogPost.Author,
                Visible = blogPost.Visible,
                Tags = blogPost.Tags,
                TotalLikes = totalLikes,
                Liked = liked,
                Comments = blogCommentForViewModel

            };
        }
        return View(blogPostLikeViewModel);
    }

    [HttpPost]
    public async Task<IActionResult> Index(BlogDetailsViewModel blogDetailsViewModel)
    {

        if (_signInManager.IsSignedIn(User))
        {
            var domainModel = new BlogPostComment
            {
                Description = blogDetailsViewModel.CommentDescription,
                BlogPostId = blogDetailsViewModel.Id,
                userId = Guid.Parse(_userManager.GetUserId(User)),
                DateAdded = DateTime.Now
            };

            await _blogPostCommentRepository.AddAsync(domainModel);
            return RedirectToAction("Index", "Blogs",
                new { urlHandle = blogDetailsViewModel.UrlHandle });
        }
        return Forbid();
    }
}
