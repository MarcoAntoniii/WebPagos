using Business;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebPagos.Models;

namespace WebPagos.Controllers
{
    public class HomeController : Controller
    {
        private readonly B_Pago b_pago;

        public HomeController(B_Pago b_pag)
        {
            b_pago = b_pag;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Procesar(string Cliente, decimal Monto, string Metodo)
        {
            try
            {
                E_Pago pago =  b_pago.Procesar(Metodo, Cliente, Monto);
                return View("Index", pago);
            }
            catch (ArgumentException ex)
            {
                TempData["Error"] = ex.Message;
                return View("Index");
            }
        }
    }
}
