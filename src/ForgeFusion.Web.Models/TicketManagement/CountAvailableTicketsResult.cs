using ForgeFusion.Web.Models.Services;

namespace ForgeFusion.Web.Models.TicketManagement
{
    public class CountAvailableTicketsResult : IServiceProviderResult
    {
        public int CountOfAvailableTickets { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;
    }
}
