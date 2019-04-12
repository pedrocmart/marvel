using Microsoft.AspNetCore.Mvc;
using SiteHeroisMarvel.Models;
using System;
using System.Diagnostics;
using System.IO;


namespace SiteHeroisMarvel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index([FromServices]APIMarvelClient client, string nomeHeroi)
        {
            GravaPesquisa(nomeHeroi);
            return View(client.ObterDadosPersonagens(nomeHeroi));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private void GravaPesquisa(string nome)
        {
            try
            {
                using (StreamWriter sw = System.IO.File.AppendText(AppDomain.CurrentDomain.BaseDirectory + @"Pesquisas\pesquisas.txt"))
                {
                    sw.WriteLine("Pesquisa feita em " + DateTime.Now.ToString() + ": " + nome);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
