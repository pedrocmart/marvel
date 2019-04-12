using Microsoft.AspNetCore.Mvc;
using SiteHeroisMarvel.Models;

namespace SiteHeroisMarvel.Controllers
{
    public class PesquisasController : Controller
    {
        public IActionResult Index([FromServices]APIMarvelClient client)
        {
            PesquisasRealizadas pesquisas = client.RetornaPesquisasRealizadas();

            return View(pesquisas);
        }
    }
}