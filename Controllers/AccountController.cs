using CryptoWalletFrontend.Data.Base;
using CryptoWalletFrontend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CryptoWalletFrontend.Controllers
{
    public class AccountController : Controller
    {
        private readonly IHttpClientFactory _httpClient;
        public AccountController(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient;
        }

        public IActionResult Cuentas()
        {
            return View();
        }
       

        [HttpPost]
        public IActionResult Deposit(double amount)
        {
            // Lógica para depositar el monto en la cuenta seleccionada.
            // Puedes manejar el resultado y mostrar un mensaje en la vista.
            var message = $"Se depositaron ${amount} con éxito.";
            return Json(new { success = true, message });
        }

        [HttpPost]
        public IActionResult Withdraw(double amount)
        {
            // Lógica para retirar el monto de la cuenta seleccionada.
            // Puedes manejar el resultado y mostrar un mensaje en la vista.
            var message = $"Se retiraron ${amount} con éxito.";
            return Json(new { success = true, message });
        }
    }
}
