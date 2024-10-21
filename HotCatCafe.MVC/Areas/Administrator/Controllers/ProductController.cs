using HotCat.BLL.Repositories.Abstracts;
using HotCat.BLL.ViewModels.CategoryViewModels;
using HotCat.BLL.ViewModels.ProductViewModels;
using HotCat.Model.Entities;
using HotCatCafe.Common.ImageHelpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HotCatCafe.MVC.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    //[Authorize]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {

            var products = _productService.GetAllProducts().Select(x=> new ProductViewModel
            {
                ProductId = x.ID,
                ProductName = x.ProductName,
                UnitPrice = x.UnitPrice,
                UnitsInStock = x.UnitsInStock,
                CategoryId = x.CategoryId,
                Status = (HotCat.Model.Enums.DataStatus)x.Status,
                ImagePath = x.ImagePath
            }).ToList();    

            return View(products);
        }

        public IActionResult Create()
        {
            
            //ViewBag nesne olan her şeyi bünyesinde saklayabiliyor
            ViewBag.CategoryListItem = _categoryService.GetAllCategories().Select(x => new CategoryViewModel
            {
                CategoryName = x.CategoryName,
                Description = x.Description,
                Id = x.ID

            }).Select(s => new SelectListItem
            {
                Text=s.CategoryName,
                Value = s.Id.ToString()
            });

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductViewModel productViewModel, IFormFile productImage) 
        {
            if(ModelState.IsValid)
            {
                var ImageEditResult = ImageHelper.Upload(productImage.FileName);

                if(ImageEditResult == "0")
                {
                    TempData["Error"] = "Görsel izin verilen formatta değil!";
                    return View();  
                }
                else
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\products", ImageEditResult);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        productImage.CopyToAsync(stream);
                    }


                    Product product = new Product
                    {
                        ID = productViewModel.ProductId,
                        ProductName = productViewModel.ProductName,
                        UnitPrice = productViewModel.UnitPrice,
                        UnitsInStock = productViewModel.UnitsInStock,
                        CategoryId = productViewModel.CategoryId,
                        Status = productViewModel.Status,
                        ImagePath = ImageEditResult
                    };

                    var result = await _productService.CreateProductAsync(product);

                    return RedirectToAction("Index");
                }
            }
            else
            {
                return View(productViewModel);
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            
            try
            {
                var product = await _productService.GetProductByIdAsync(id);
                if (product == null) 
                {
                    return NotFound();
                }
                var productViewModel = new ProductViewModel
                {
                    ProductId = product.ID,
                    ProductName = product.ProductName,
                    ImagePath = product.ImagePath,
                    IsActive = product.IsActive,
                    Status = product.Status
                };
                return View(productViewModel);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]

        public async Task<IActionResult> Delete(ProductViewModel productViewModel)
        {
            var deleted = _productService.GetProductByIdAsync(productViewModel.ProductId);

            try
            {
                await _productService.DeleteProductAsync(await deleted);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = "Ürünü silerken bir hata meydana geldi:" + ex.Message;
                return View("Delete", deleted);
            }
        }

        public async Task<IActionResult> Details(int id)
        {
            var product = await _productService.GetProductByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            var productViewModel = new ProductViewModel
            {
              ProductId = product.ID,
              ProductName = product.ProductName,
              UnitPrice = product.UnitPrice,
              UnitsInStock = product.UnitsInStock,
              Status = (HotCat.Model.Enums.DataStatus)product.Status,
              IsActive =product.IsActive
            };
            return View(productViewModel);
        }

        public IActionResult Active()
        {
            var products = _productService.GetActiveProducts().OrderByDescending(x => x.ID).Select(x => new ProductViewModel
            {
                ProductId = x.ID,
                ProductName = x.ProductName,
                UnitPrice = x.UnitPrice,
                UnitsInStock = x.UnitsInStock,
                IsActive=x.IsActive,
                Status = (HotCat.Model.Enums.DataStatus)x.Status
            }).ToList();
            return View(products);
        }

        public IActionResult Passive()
        {
            var products = _productService.GetPassiveProducts().OrderBy(x => x.ID).Select(x => new ProductViewModel
            {
                ProductId = x.ID,
                ProductName = x.ProductName,
                UnitPrice = x.UnitPrice,
                UnitsInStock = x.UnitsInStock,
                IsActive = x.IsActive,
                Status = (HotCat.Model.Enums.DataStatus)x.Status
            }).ToList();
            return View(products);
        }

        public async Task<IActionResult> Update(int id)
        {
            var updated = await _productService.GetProductByIdAsync(id);

            if(updated != null)
            {
                return View(updated);
            }
            return RedirectToAction("Index", "Home");
            
        }

        [HttpPost]

        public async Task<IActionResult> Update(Product product)
        {
            if (ModelState.IsValid)
            {
                product.Category = _categoryService.GetCategoryById(product.ID);

                string result = await _productService.UpdateProductAsync(product);

                TempData["result"] = result;

                return RedirectToAction("Index", "Product");
            }
            else
            {
                return View(product);
            }


        }




    }
}
