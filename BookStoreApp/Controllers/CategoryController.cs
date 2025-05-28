using BookStoreApp.Data;
using BookStoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApp.Controllers
{
    public class CategoryController : Controller
    {

        private readonly AppDbContext _db;
        public CategoryController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Category> categoryList = _db.Categories.ToList();
            return View(categoryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category) 
        {
            if (category.Name == category.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Name", "The Display Order cannot exactly match the Name");
            }

            if(ModelState.IsValid)
            {
                _db.Categories.Add(category);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }

            Category category = _db.Categories.FirstOrDefault(c => c.Id == id);

            if(category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        { 
            if (ModelState.IsValid)
            {
                _db.Categories.Update(category);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

    public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Category category = _db.Categories.FirstOrDefault(c => c.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Category? category = _db.Categories.FirstOrDefault(c => c.Id == id);
            if (category == null) 
            {
                return NotFound();
            }
            _db.Categories.Remove(category);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
