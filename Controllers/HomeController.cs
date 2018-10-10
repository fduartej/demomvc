using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using demomvc.Models;

namespace demomvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        
        public IActionResult Student()
        {
            ViewData["Message"] = "Your Student page.";

            return View();
        }

        [HttpPost]
		public IActionResult Create(
             Student student)
		{
			
            ViewData["Message"] = "Entro a la pagina Student";

            return View("Student");
		}

        public IActionResult Calculadora()
        {
            ViewData["Message"] = "Your Calculadora page.";

            return View();
        }

        [HttpPost]
		public IActionResult Calcular(
             Calculadora calculadora)
		{
			
            if("+".Equals(calculadora.Operacion)){
                calculadora.Result = calculadora.Ope1 + calculadora.Ope2;
            }
            if("-".Equals(calculadora.Operacion)){
                calculadora.Result = calculadora.Ope1 - calculadora.Ope2;
            }
            
            ViewData["Message"] = "Resultado:"+calculadora.Result;
            return View("Calculadora",calculadora);
		}


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
