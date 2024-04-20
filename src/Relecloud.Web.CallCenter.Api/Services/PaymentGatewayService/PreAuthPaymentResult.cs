using ForgeFusion.Web.Models.Services;

namespace ForgeFusion.Web.Api.Services.PaymentGatewayService
{
    public partial class PreAuthPaymentResult : IServiceProviderResult
    {
        public string HoldCode { get; set; } = string.Empty;
        public PreAuthPaymentResultStatus Status { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;
    }
}
