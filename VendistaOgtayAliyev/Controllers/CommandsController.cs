using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VendistaOgtayAliyev.Models;
using DataApiService;
using System.Data;

namespace VendistaOgtayAliyev.Controllers
{
    public class CommandsController : BaseController
    {
        private readonly ILogger<CommandsController> _logger;
        private IDataManager _dataManager;

        public CommandsController(ILogger<CommandsController> logger, IDataManager dataManager)
        {
            _logger = logger;
            _dataManager = dataManager;
            _dataManager.Auth("user2", "password2");
        }

        public async Task<IActionResult> Index()
        {
            var commandTypes = await _dataManager.GetCommandTypes("commands/types");

            var resultList = commandTypes.ToList();
            ViewData["CommandTypes"] = resultList;

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
