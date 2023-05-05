using Microsoft.AspNetCore.Mvc;

namespace LABCOMPRAS22.Models
{
    public class testeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult teste()
        {
            return View();
        }
        [HttpPost]
        public IActionResult teste(teste newteste)
        { 
            
            return View("TesteConfirmado", newteste); }
    }
}
