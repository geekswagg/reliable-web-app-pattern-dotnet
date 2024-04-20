using ForgeFusion.Web.Models.Services;

namespace ForgeFusion.Web.Models.TicketManagement
{
    public class HaveTicketsBeenSoldResult : IServiceProviderResult
    {
        public bool HaveTicketsBeenSold { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;
    }
}
