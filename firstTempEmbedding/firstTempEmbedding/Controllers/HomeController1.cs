using firstTempEmbedding.Models;
using Microsoft.AspNetCore.Mvc;

namespace firstTempEmbedding.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
       
}
