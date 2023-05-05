using Microsoft.AspNetCore.Mvc;
using LABCOMPRAS22.Models;




namespace LABCOMPRAS22.Controllers
{
    public class DespesasController : Controller
    {
        public IActionResult Index()
        {
            List<Despesa> despesas = repositorio.Despesas; 
            return View(despesas);
        }
        [HttpGet]
        public IActionResult NovaDespesa()
        {
           
            return View();
        }
      
        [HttpPost]
        public IActionResult NovaDespesa(Despesa novaDespesa)
        {
            if (ModelState.IsValid)
            {
                repositorio.AdicionarDespesa(novaDespesa);
                return View("DespesasConfirmadas", novaDespesa);
            }
            else { return View(); }
            }
    }
}
