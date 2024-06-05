using Microsoft.AspNetCore.Mvc;

namespace codefirstcrud.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
