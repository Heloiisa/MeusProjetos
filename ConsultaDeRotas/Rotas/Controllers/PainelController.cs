using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Rotas.Controllers
{
     
    public class PainelController : Controller
    {
        public IActionResult Tela1()
        {
            return View();
        }
    }
}