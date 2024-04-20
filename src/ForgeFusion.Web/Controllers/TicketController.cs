using ForgeFusion.Web.Infrastructure;
using ForgeFusion.Web.Models.Entities.Ticketing;
using ForgeFusion.Web.Models.Services;
using ForgeFusion.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ForgeFusion.Web.Controllers
{
    [Authorize]
    public class TicketController : Controller
    {
        #region Fields

        private readonly ILogger<TicketController> logger;
        private readonly IConcertContextService concertService;

        #endregion

        #region Constructors

        public TicketController(IConcertContextService concertService, ILogger<TicketController> logger)
        {
            this.concertService = concertService;
            this.logger = logger;
        }

        #endregion

        #region Index

        public async Task<IActionResult> Index(int currentPage)
        {
            try
            {
                var userId = this.User.GetUniqueId();
                var pagedResultModel = await this.concertService.GetAllTicketsAsync(userId, currentPage * TicketViewModel.DefaultPageSize, TicketViewModel.DefaultPageSize);

                return View(new TicketViewModel
                {
                    CurrentPage = currentPage,
                    TotalCount = pagedResultModel?.TotalCount ?? 0,
                    Tickets = pagedResultModel?.PageOfData ?? new List<Ticket>()
                });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Unable to retrieve upcoming concerts");
                return View();
            }
        }

        #endregion
    }
}