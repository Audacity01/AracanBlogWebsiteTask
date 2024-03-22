using Microsoft.AspNetCore.Mvc;

namespace BloggingProject.web.Controllers
{
    public class AdminTagsController : Controller 
    { 

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
