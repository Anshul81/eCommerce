using eCommerce.Data;
using eCommerce.DataAccess.IRepository;
using eCommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitofwork;
        public CategoryController(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable <Category> category = _unitofwork.Category.GetAll();
            return View(category);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
                _unitofwork.Category.Add(category);
                _unitofwork.Save();
                return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var category = _unitofwork.Category.GetFirstOrDefault(x => x.CategoryId == id);
            return View(category);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if(id==null || id == 0)
            {
                return NotFound();
            }
            var category = _unitofwork.Category.GetFirstOrDefault(x => x.CategoryId == id);
            return View(category);
        }
        [HttpPost]
        public IActionResult Edit(Category category)
        {
            _unitofwork.Category.Update(category);
            _unitofwork.Save();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var category = _unitofwork.Category.GetFirstOrDefault(x => x.CategoryId == id);
            return View(category);
        }
        [HttpPost]
        public IActionResult Delete(Category category)
        {
            _unitofwork.Category.Remove(category);
            _unitofwork.Save();
            return RedirectToAction("Index");
        }

    }
}
