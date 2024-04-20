using ForgeFusion.Web.Api.Services.PaymentGatewayService;
using ForgeFusion.Web.Models.Services;

namespace ForgeFusion.Web.Api.Services.MockServices
{
    public class MockPaymentGatewayService : IPaymentGatewayService
    {
        public Task<CapturePaymentResult> CapturePaymentAsync(CapturePaymentRequest request)
        {
            return Task.FromResult(new CapturePaymentResult
            {
                ConfirmationNumber = Guid.NewGuid().ToString(),
                Status = CapturePaymentResultStatus.CaptureSuccessful
            });
        }

        public Task<PreAuthPaymentResult> PreAuthPaymentAsync(PreAuthPaymentRequest request)
        {
            return Task.FromResult(new PreAuthPaymentResult
            {
                HoldCode = Guid.NewGuid().ToString(),
                Status = PreAuthPaymentResultStatus.FundsOnHold
            });
        }
    }
}
