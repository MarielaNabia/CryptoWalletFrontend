using Microsoft.AspNetCore.Mvc;

namespace CryptoWalletFrontend.Controllers
{
    public class CriptoController : Controller
    {
        private readonly IHttpClientFactory _httpClient;
        public CriptoController(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient;
        }
        public IActionResult Cripto()
        {
            return View();
        }
    }
}
