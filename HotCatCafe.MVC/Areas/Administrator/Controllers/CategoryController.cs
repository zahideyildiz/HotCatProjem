using HotCat.BLL.Repositories.Abstracts;
using HotCat.BLL.ViewModels.CategoryViewModels;
using HotCat.Model.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotCatCafe.MVC.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    //[Authorize]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;

        public CategoryController(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }

        public IActionResult Index()
        {
            var categories = _categoryService
                .GetAllCategories()
                .OrderByDescending(x => x.CreatedDate) //oluşturma tarihine göre çoktan aza doğru sırala
                .Select(x => new CategoryListViewModel
                {
                    Id = x.ID,
                    CategoryName = x.CategoryName,
                    Description = x.Description,
                    IsActive = x.IsActive,
                    Status = x.Status
                }).ToList();

            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryViewModel categoryViewModel)
        {
            if(ModelState.IsValid)
            {
                Category category = new Category
                {
                    CategoryName = categoryViewModel.CategoryName,
                    Description = categoryViewModel.Description,
                };

                string result = await _categoryService.CreateCategory(category);
                TempData["Result"] = result;
                return RedirectToAction("Index" , "Home");
                
            }
            else
            {
                return View(categoryViewModel);
            }
        }

        public IActionResult Update(int id)
        {
            var category = _categoryService.GetCategoryById(id);
            CategoryListViewModel categoryListViewModel = new CategoryListViewModel
            {
                CategoryName = category.CategoryName,
                Description = category.Description,
                IsActive = category.IsActive,
                Status = category.Status
            };

            if (categoryListViewModel != null)
            {
                return View(categoryListViewModel);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]

        public async Task<IActionResult> Update(CategoryListViewModel category)
        {
            if (ModelState.IsValid)
            {
                Category categoryUpdated = new Category
                {
                    ID = category.Id,
                    CategoryName = category.CategoryName,
                    Description = category.Description,
                    IsActive = category.IsActive,
                    Status = category.Status
                };

                var result = await _categoryService.UpdateCategory(categoryUpdated);
                TempData["Result"] = result;
                return RedirectToAction("Index");
            }
            else
            {
                return View(category);
            }
            
        }

        //todo : 27 mayıs ilk ders kayıtından details ekle
    }
}
