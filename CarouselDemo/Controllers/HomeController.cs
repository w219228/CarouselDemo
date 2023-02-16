using CarouselDemo.DTO;
using CarouselDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CarouselDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        CarouselDTO[] CarouselDTOs=
        {
            new CarouselDTO
            {
                Caption="item1",
                Src="https://picsum.photos/1024/480/?image=1"
            },
            new CarouselDTO
            {
                Caption="item2",
                Src="https://picsum.photos/1024/480/?image=2"
            },
            new CarouselDTO
            {
                Caption="item3",
                Src="https://picsum.photos/1024/480/?image=3"
            }
        };
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Carousel()
        {
            return View();
        }
        public IActionResult GetCarousels() 
        {
            return Json(CarouselDTOs);
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