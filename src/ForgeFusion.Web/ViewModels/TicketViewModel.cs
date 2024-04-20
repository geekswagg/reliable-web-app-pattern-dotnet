using ForgeFusion.Web.Models.Entities.Ticketing;

namespace ForgeFusion.Web.ViewModels
{
    public class TicketViewModel
    {
        public const int DefaultPageSize = 5;

        public int TotalCount { get; set; }
        public int CurrentPage { get; set; }

        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
