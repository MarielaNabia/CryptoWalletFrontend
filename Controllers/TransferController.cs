using CryptoWalletFrontend.Data.Base;
using CryptoWalletFrontend.ViewModels;
using Data.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace CryptoWalletFrontend.Controllers
{
    public class TransferController : Controller
    {
        private readonly IHttpClientFactory _httpClient;
        public TransferController(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient;
        }
        public IActionResult Transfers(TransferViewModel transfer)
        {
            var token = HttpContext.Session.GetString("Token");
            var baseApi = new BaseApi(_httpClient);
            var trans = baseApi.PostToApi("Operation/transfer", transfer, token);
            return View("~/Views/Transfer/Transfer.cshtml");
        }
    }
}
