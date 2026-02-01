using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using WebUI.Areas.Admin.Models;
using Newtonsoft.Json;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class RapidApiMovieController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<RapidApiMovieViewModel> rapidApiMovies = new List<RapidApiMovieViewModel>();
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
                    Headers =
                    {
                        { "x-rapidapi-key", "c8e3a0412amsh928c4ac4714d776p1b2542jsne008c40e5697" },
                        { "x-rapidapi-host", "imdb-top-100-movies1.p.rapidapi.com" },
                    },
                };
                using (var response = await client.SendAsync(request))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var body = await response.Content.ReadAsStringAsync();
                        rapidApiMovies = JsonConvert.DeserializeObject<List<RapidApiMovieViewModel>>(body);
                    }
                    else
                    {
                        var errorContent = await response.Content.ReadAsStringAsync();
                        ViewBag.Error = $"API Error: {response.StatusCode} - {errorContent}";
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = $"System Error: {ex.Message}";
            }
            return View(rapidApiMovies);
        }
    }
}