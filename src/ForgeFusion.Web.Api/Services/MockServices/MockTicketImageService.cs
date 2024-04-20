using ForgeFusion.Web.Api.Services.TicketManagementService;

namespace ForgeFusion.Web.Api.Services.MockServices
{
    public class MockTicketImageService : ITicketImageService
    {
        public Task<Stream> GetTicketImagesAsync(string imageName)
        {
            return Task.FromResult(Stream.Null);
        }
    }
}