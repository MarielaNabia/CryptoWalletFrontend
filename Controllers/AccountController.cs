using CryptoWalletFrontend.Data.Base;
using CryptoWalletFrontend.Data.DTOs;
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
        public IActionResult Deposit(DepositDto depositDto)
        {
            var token = HttpContext.Session.GetString("Token");
            var baseApi = new BaseApi(_httpClient);
            var cuentas = baseApi.PostToApi("Account/Deposit", depositDto, token);
            var message = $"Se depositaron ${depositDto.Amount} con éxito.";
            return Json(new { success = true, message });
        }

        [HttpPost]
        public IActionResult Withdraw(WithdrawDto withdrawDto)
        {
            var token = HttpContext.Session.GetString("Token");
            var baseApi = new BaseApi(_httpClient);
            var cuentas = baseApi.PostToApi("Account/Withdraw", withdrawDto, token);
            var message = $"Se retiraron ${withdrawDto.Amount} con éxito.";
            return Json(new { success = true, message });
        }

        [HttpPost]
        public IActionResult Transfer(TransferDto transferDto)
        {
            var token = HttpContext.Session.GetString("Token");
            var baseApi = new BaseApi(_httpClient);
            var cuentas = baseApi.PostToApi("Operation/Transfer", transferDto, token);
            var message = $"Se transfirio de la cuenta ${transferDto.SourceIdentifier} a la cuenta ${transferDto.DestinationIdentifier} con éxito.";
            return Json(new { success = true, message });
        }

    }
}
