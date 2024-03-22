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

    public BlogsController(IBlogPostRepository blogPostRepository, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
    {
        _blogPostRepository = blogPostRepository;
        _signInManager = signInManager;
        _userManager = userManager;
    }

    //like repo
    //comment repo

    [HttpGet]
    public async Task<IActionResult> Index(string urlHandle)
    {
        //like logic
        var blogPost = await _blogPostRepository.GetByUrlHandleAsync(urlHandle);
        var blogPostLikeViewModel = new BlogDetailsViewModel();

        if(blogPost != null )
        {
            if (_signInManager.IsSignedIn(User))
            {

            }
        }
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(BlogDetailsViewModel blogDetailsViewModel)
    {
        return Forbid();
    }
}
