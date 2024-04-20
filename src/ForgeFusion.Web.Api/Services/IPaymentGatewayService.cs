using ForgeFusion.Web.Api.Services.PaymentGatewayService;

namespace ForgeFusion.Web.Models.Services
{
    public interface IPaymentGatewayService
    {
        Task<PreAuthPaymentResult> PreAuthPaymentAsync(PreAuthPaymentRequest request);
        Task<CapturePaymentResult> CapturePaymentAsync(CapturePaymentRequest request);
    }
}
