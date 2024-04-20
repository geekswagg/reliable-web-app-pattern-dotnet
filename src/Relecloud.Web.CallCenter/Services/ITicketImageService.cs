namespace ForgeFusion.Web.Services;

public interface ITicketImageService
{
    Task<Stream> GetTicketImagesAsync(string imageName);
}