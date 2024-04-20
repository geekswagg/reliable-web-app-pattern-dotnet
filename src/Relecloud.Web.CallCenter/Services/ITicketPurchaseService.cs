using ForgeFusion.Web.Models.TicketManagement;

namespace ForgeFusion.Web.Services
{
    public interface ITicketPurchaseService
    {
        Task<PurchaseTicketsResult> PurchaseTicketAsync(PurchaseTicketsRequest request);
    }
}