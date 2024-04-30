using firstTempEmbedding.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace firstTempEmbedding.Controllers
{
    public class ServiceController : Controller
    {
        private readonly MvctestContext _context;
        public ServiceController(MvctestContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Services.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Service serv)
        {
            if (ModelState.IsValid)
            {
                _context.Add(serv);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(serv);

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var data = _context.Services.Find(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(int id, Service vs)
        {
            if (ModelState.IsValid)
            {

                _context.Update(vs);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
        //[HttpGet]
        //public IActionResult Delete(int id)
        //{
        //    var data = _context.Services.Find(id);
        //    return View(data);
        //}
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var data = _context.Services.Find(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Delete(int id, Service vs)
        {
            if (ModelState.IsValid)
            {
                _context.Remove(vs);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var data = _context.Services.Find(id);
            return View(data);
        }
    }

}
