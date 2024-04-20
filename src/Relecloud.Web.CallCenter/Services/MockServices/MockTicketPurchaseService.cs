using ForgeFusion.Web.Models.TicketManagement;

namespace ForgeFusion.Web.Services.MockServices
{
    public class MockTicketPurchaseService : ITicketPurchaseService
    {
        public Task<PurchaseTicketsResult> PurchaseTicketAsync(PurchaseTicketsRequest request)
        {
            return Task.FromResult(new PurchaseTicketsResult
            {
                Status = PurchaseTicketsResultStatus.UnableToProcess
            });
        }
    }
}
