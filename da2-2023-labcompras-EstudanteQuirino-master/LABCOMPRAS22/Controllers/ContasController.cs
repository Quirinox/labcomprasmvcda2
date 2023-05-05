using LABCOMPRAS22.Models;
using Microsoft.AspNetCore.Mvc;

namespace LABCOMPRAS22.Controllers
{
    public class ContasController : Controller
    {
        public IActionResult Index()
        {
            List<Conta> contas = repositorio.contas;
            return View(contas);
        }
        [HttpGet]
        public IActionResult NovaConta()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NovaConta (Conta novaConta)
        {
            
            if(ModelState.IsValid)
            {
                repositorio.AdicionarConta(novaConta);
                return View("ContaConfirmada", novaConta);
            }
            else
            { 
            return View();
            }
           
        }


    }
}
