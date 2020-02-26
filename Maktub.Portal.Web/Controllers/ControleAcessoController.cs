using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Maktub.Portal.Web.Controllers
{
    public class ControleAcessoController : Controller
    {
        public IActionResult Usuario()
        {
            return View();
        }
    }
}