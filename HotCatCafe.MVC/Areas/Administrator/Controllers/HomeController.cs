using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotCatCafe.MVC.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin")] //yetkiye tabi anlamına geliyor. servislerde UseAuthorization() olması lazım yoksa çalışmaz
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
