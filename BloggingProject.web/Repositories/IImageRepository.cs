namespace BloggingProject.web.Repositories
{
    public interface IImageRepository
    {
        Task<string> UploadAsync(IFormFile formFile);
    }
}
