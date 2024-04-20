using ForgeFusion.Web.Models.TicketManagement.Payment;

namespace ForgeFusion.Web.Api.Services.PaymentGatewayService
{
    public class PreAuthPaymentRequest
    {
        public double Amount { get; set; }
        public PaymentDetails? PaymentDetails { get; set; }
        public IDictionary<int, int>? Tickets { get; set; }
    }
}
