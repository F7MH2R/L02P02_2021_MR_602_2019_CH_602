using Microsoft.AspNetCore.Mvc;

namespace L02P02_2021_MR_602_2019_CH_602.Controllers
{
    public class LibrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
