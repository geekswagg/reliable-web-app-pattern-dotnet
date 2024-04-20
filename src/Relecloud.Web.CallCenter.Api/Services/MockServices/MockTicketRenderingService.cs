using ForgeFusion.Web.Api.Services.TicketManagementService;

namespace ForgeFusion.Web.Api.Services.MockServices
{
    public class MockTicketRenderingService : ITicketRenderingService
    {
        public Task CreateTicketImageAsync(int ticketId)
        {
            return Task.CompletedTask;
        }
    }
}
