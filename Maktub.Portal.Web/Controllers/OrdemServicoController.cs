using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Maktub.Portal.Web.Controllers
{
    public class OrdemServicoController : Controller
    {
        // GET: /<controller>/
        public IActionResult OrdemServico()
        {
            return View();
        }
        public IActionResult FormOrdemServico()
        {
            return View();
        }
        public IActionResult Movimentacao()
        {
            return View();
        }
        public IActionResult FormMovimentacao()
        {
            return View();
        }
        public IActionResult Adiantamento()
        {
            return View();
        }
        public IActionResult FormAdiantamento()
        {
            return View();
        }
    }
}
