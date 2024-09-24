using HotCat.BLL.ViewModels.AppUserViewModels;
using HotCat.Model.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotCatCafe.MVC.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class AppUserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public AppUserController(UserManager<AppUser> userManager) 
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            //29.05 
            
            var users = _userManager.Users.Select(x => new AppUserListViewModel
            {
                ID = x.Id.ToString(),
                Gender = x.Gender,
                BirthDate = x.BirthDate,
                EmailConfirmed = x.EmailConfirmed,
                Email = x.Email,
                PhoneNumber = x.PhoneNumber,
                Username = x.UserName,
                Address = x.Address
            }).ToList();
            return View(users);
        }

        //public IActionResult Details(string id)
        //{
        //    return View();
        //}

        public IActionResult AddToRole(string id, string roleName)
        {
            return View();
        }

        public IActionResult ForgotPassword(int id)
        {
            return View();
        }

        public async Task<IActionResult> Update(string id)
        {
            AppUser user = await _userManager.FindByIdAsync(id);

            if (user != null)
            {

                AppUserListViewModel appUserListView = new AppUserListViewModel
                {
                    ID = user.Id.ToString(),
                    Username = user.UserName,
                    BirthDate = user.BirthDate,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber,
                    EmailConfirmed = user.EmailConfirmed,
                    Address = user.Address

                };
                return View(appUserListView);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Update(AppUserListViewModel updated)
        {
            AppUser user = new AppUser
            {
                Id = Guid.Parse(updated.ID),
                UserName = updated.Username,
                BirthDate = updated.BirthDate,
                Email = updated.Email,
                PhoneNumber = updated.PhoneNumber,
                EmailConfirmed = updated.EmailConfirmed,
                Address = updated.Address,
                Gender = updated.Gender,
            };
            //todo: Update metodu içerisinde rol güncelleme işlemi de dahil edilecek.
            var result = await _userManager.UpdateAsync(user);

            return View();
        }

        public IActionResult DeleteUser(string id)
        {
            return View();
        }
    }
}
