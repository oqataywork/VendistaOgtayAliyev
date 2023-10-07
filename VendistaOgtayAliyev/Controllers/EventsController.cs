using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VendistaOgtayAliyev.Models;
using DataApiService;

namespace VendistaOgtayAliyev.Controllers
{
    public class EventsController : BaseController
    {
        private readonly ILogger<EventsController> _logger;
        private IDataManager _dataManager;

        public EventsController(ILogger<EventsController> logger, IDataManager dataManager)
        {
            _logger = logger;
            _dataManager = dataManager;
            _dataManager.Auth("user2", "password2");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
