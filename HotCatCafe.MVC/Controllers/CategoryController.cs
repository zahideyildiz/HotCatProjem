﻿using HotCat.BLL.Repositories.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace HotCatCafe.MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService) 
        {
            _categoryService = categoryService;
        }



        public IActionResult Index()
        {

            var categories = _categoryService.GetAllCategories();

            return View(categories);
        }
    }
}
