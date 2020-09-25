using System;
using System.Threading.Tasks;
using Hangman.Service.Client;
using Microsoft.AspNetCore.Mvc;

namespace Hangman.Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHttpClient _httpClient;

        public HomeController(IHttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<IActionResult> Index()
        {
            //var url = new Uri("http://localhost:5000/api/puzzles");
            //var result = await _httpClient.GetAsync<Contracts.Puzzle>(url);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
