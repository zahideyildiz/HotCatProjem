using HotCat.BLL.Repositories.Abstracts;
using HotCat.BLL.ViewModels.AppUserViewModels;
using HotCat.BLL.ViewModels.ProductViewModels;
using HotCat.Model.Entities;
using HotCatCafe.Common.EmailHelpers;
using HotCatCafe.MVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Web;

namespace HotCatCafe.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;
        private readonly IOrderDetailService _orderDetailService;

        public HomeController(ILogger<HomeController> logger, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IProductService productService, IOrderService orderService, IOrderDetailService orderDetailService)
        {
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
            _productService = productService;
            _orderService = orderService;
            _orderDetailService = orderDetailService;
        }

        public IActionResult Index()
        {
            var products = _productService.GetActiveProducts()
                .OrderByDescending(x => x.CreatedDate)
                .Select(x => new ProductViewModel
                {
                    ProductId = x.ID,
                    ProductName = x.ProductName,
                    UnitPrice = x.UnitPrice,
                    UnitsInStock = x.UnitsInStock,
                    IsActive = x.IsActive,
                    Status = (HotCat.Model.Enums.DataStatus)x.Status,
                    ImagePath = x.ImagePath,
                    CategoryId = x.CategoryId

                }).ToList();

            return View(products);
        }

        //kullanıcı kayıt
        public IActionResult Register()
        {
            return View();  
        }

        [HttpPost]

        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if(ModelState.IsValid)
            {
                AppUser user = new AppUser
                {
                    Email = registerViewModel.Email,
                    UserName = registerViewModel.UserName
                };

                var result = await _userManager.CreateAsync(user, registerViewModel.ConfirmPassword);

                if (result.Succeeded)
                {
                    var emailToken = await _userManager.GenerateEmailConfirmationTokenAsync(user);

                    var encodeToken = HttpUtility.UrlEncode(emailToken);  //yüzde işaretine çevirdik

                    string confirmationLink = Url.Action("Activation", "Home", new {id = user.Id, token = encodeToken}, Request.Scheme);

                    string body = $"Merhaba {registerViewModel.UserName} kayıt olduğunuz için teşekkürler. Hesabınızı aktif hale getirmek için lütfen linke tıklayınız. {confirmationLink}";

                    
                    EmailSender.SendEmail(registerViewModel.Email, "Aktivasyon Maili", body);


                    TempData["Success"] = $"{registerViewModel.Email} adresine aktivasyon maili gönderilmiştir. Linke tıklayarak üyeliğinizi aktif hale getirebilirsiniz.";
                    
                }
                else
                {
                    TempData["Error"] = $"Bir hata meydana geldi!";
                }

                return RedirectToAction("Index");

            }
            else
            {
                return View(registerViewModel);
            }

            
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if(ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(loginViewModel.Email);

                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, loginViewModel.RememberMe, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                }
                return View();
            }
            else
            {
                return View(loginViewModel);
            }
        }

        public IActionResult Logout()
        {
            return View();
        }

        [HttpGet("activationUrl")]
        public async Task<IActionResult> Activation(string id, string token)
        {
            //kullanıcı konf işlemi
            if(id != null  && token != null)
            {
                var existsUser = await _userManager.FindByIdAsync(id);

                if (existsUser != null)
                {
                    var decodeToken = HttpUtility.UrlDecode(token); //yüzdelikleri / çeviriyoruz özüne döndürüyoruz

                    var result = await _userManager.ConfirmEmailAsync(existsUser, decodeToken);
                    if(result.Succeeded)
                    {
                        TempData["Success"] = "Hesabınız başarıyla aktif hale getirilmiştir.";
                        return RedirectToAction("Index");
                    }
                }
            }

            return View();
        }

        public IActionResult TestMail()
        {
            EmailSender.SendEmail("zahide_16_5@hotmail.com", "Test Maili", "Bu bir test mailidir.");
            return RedirectToAction("Index");
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
