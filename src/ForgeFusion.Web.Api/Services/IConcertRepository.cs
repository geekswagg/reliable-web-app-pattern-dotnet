using ForgeFusion.Web.Models.Entities.Ticketing;
using ForgeFusion.Web.Models.Entities.TraderEntities;
using ForgeFusion.Web.Models.Services;

namespace ForgeFusion.Web.Api.Services
{
    public interface IConcertRepository : IConcertContextService
    {
        public void Initialize();
        Task<CreateResult> CreateCustomerAsync(Customer newCustomer);
        Task<Customer?> GetCustomerByEmailAsync(string email);
    }
}
