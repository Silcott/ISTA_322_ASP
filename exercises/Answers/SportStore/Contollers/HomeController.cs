using Microsoft.AspNetCore.Mvc;
namespace SportsStore.Controllers
{
    //action method
    public class HomeController : Controller
    {
        public IActionResult Index() 
        { 
            return View(); 
        }
    }
}