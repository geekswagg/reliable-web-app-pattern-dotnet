using ForgeFusion.Web.Api.Services;

namespace ForgeFusion.Web.Api.Infrastructure
{
    public class ApplicationInitializer
    {
        private readonly IConcertRepository concertContextService;

        public ApplicationInitializer(IConcertRepository concertContextService)
        {
            this.concertContextService = concertContextService;
        }

        public void Initialize()
        {
            // Initialize all resources at application startup.
            concertContextService.Initialize();
        }
    }
}
