using ForgeFusion.Web.Models.TicketManagement;

namespace ForgeFusion.Web.Api.Services.TicketManagementService
{
    public interface ITicketManagementService
    {
        Task<CountAvailableTicketsResult> CountAvailableTicketsAsync(int concertId);
        Task<HaveTicketsBeenSoldResult> HaveTicketsBeenSoldAsync(int concertId);
        Task<ReserveTicketsResult> ReserveTicketsAsync(int concertId, string userId, int numberOfTickets, int customerId);
    }
}
