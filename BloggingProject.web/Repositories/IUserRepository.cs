using Microsoft.AspNetCore.Identity;

namespace BloggingProject.web.Repositories
{
    public interface IUserRepository
    {
    Task<IEnumerable<IdentityUser>> GetAll();
        
    }
}
