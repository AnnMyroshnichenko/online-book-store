using BookStore.Models;
using BookStore.DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using BookStore.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc.Rendering;
using BookStore.Models.ViewModels;

namespace BookStoreApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            List<Product> productList = _unitOfWork.Product.GetAll().ToList();
            return View(productList);
        }

        public IActionResult Create()
        {
            ProductVM productVM = new()
            {
                CategoryList = _unitOfWork.Category.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                Product = new Product()

            };
            return View(productVM);
        }

        [HttpPost]
        public IActionResult Create(ProductVM productVM) 
        {
            if(ModelState.IsValid)
            {
                _unitOfWork.Product.Add(productVM.Product);
                _unitOfWork.Save();
                TempData["success"] = "Product created succesfully";
                return RedirectToAction("Index");
            }
            return View(productVM);
        }

        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }

            Product product = _unitOfWork.Product.Get(c => c.Id == id);

            if(product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        { 
            if (ModelState.IsValid)
            {
                _unitOfWork.Product.Update(product);
                _unitOfWork.Save();
                TempData["success"] = "Product updated succesfully";
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

            Product product = _unitOfWork.Product.Get(c => c.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Product? product = _unitOfWork.Product.Get(c => c.Id == id);
            if (product == null) 
            {
                return NotFound();
            }
            _unitOfWork.Product.Delete(product);
            _unitOfWork.Save();
            TempData["success"] = "Product deleted succesfully";
            return RedirectToAction("Index");
        }
    }
}
