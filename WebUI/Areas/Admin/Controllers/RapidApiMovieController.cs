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
                    RequestUri = new Uri("https://imdb-top-100-movies1.p.rapidapi.com/"),
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
                        ViewBag.Error = "API is currently down. Showing cached/mock data instead.";
                        rapidApiMovies = new List<RapidApiMovieViewModel>
                        {
                            new RapidApiMovieViewModel { rank = 1, title = "The Shawshank Redemption (Mock)", rating = "9.3", year = 1994, trailer = "https://www.youtube.com/watch?v=6hB3S9bIaco" },
                            new RapidApiMovieViewModel { rank = 2, title = "The Godfather (Mock)", rating = "9.2", year = 1972, trailer = "https://www.youtube.com/watch?v=sY1S34973zA" },
                            new RapidApiMovieViewModel { rank = 3, title = "The Dark Knight (Mock)", rating = "9.0", year = 2008, trailer = "https://www.youtube.com/watch?v=EXeTwQWrcwY" },
                            new RapidApiMovieViewModel { rank = 4, title = "Schindler's List (Mock)", rating = "8.9", year = 1993, trailer = "https://www.youtube.com/watch?v=gG22XNhtnoY" },
                            new RapidApiMovieViewModel { rank = 5, title = "Pulp Fiction (Mock)", rating = "8.9", year = 1994, trailer = "https://www.youtube.com/watch?v=s7EdQ4FqbhY" }
                        };
                    }
                }
            }
            catch (Exception)
            {
                ViewBag.Error = "API is currently down. Showing cached/mock data instead.";
                rapidApiMovies = new List<RapidApiMovieViewModel>
                {
                    new RapidApiMovieViewModel { rank = 1, title = "The Shawshank Redemption (Mock)", rating = "9.3", year = 1994, trailer = "https://www.youtube.com/watch?v=6hB3S9bIaco" },
                    new RapidApiMovieViewModel { rank = 2, title = "The Godfather (Mock)", rating = "9.2", year = 1972, trailer = "https://www.youtube.com/watch?v=sY1S34973zA" },
                    new RapidApiMovieViewModel { rank = 3, title = "The Dark Knight (Mock)", rating = "9.0", year = 2008, trailer = "https://www.youtube.com/watch?v=EXeTwQWrcwY" },
                    new RapidApiMovieViewModel { rank = 4, title = "Schindler's List (Mock)", rating = "8.9", year = 1993, trailer = "https://www.youtube.com/watch?v=gG22XNhtnoY" },
                    new RapidApiMovieViewModel { rank = 5, title = "Pulp Fiction (Mock)", rating = "8.9", year = 1994, trailer = "https://www.youtube.com/watch?v=s7EdQ4FqbhY" }
                };
            }
            return View(rapidApiMovies);
        }
    }
}