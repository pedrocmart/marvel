using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using SiteHeroisMarvel.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;

namespace SiteHeroisMarvel
{
    public class APIMarvelClient
    {
        private HttpClient _client;
        private IConfiguration _configuration;

        public APIMarvelClient(
            HttpClient client, IConfiguration configuration)
        {
            _client = client;
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            _configuration = configuration;
        }

        public List<Personagem> ObterDadosPersonagens(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                nome = "%";
            }

            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            string ts = DateTime.Now.Ticks.ToString();
            string publicKey = _configuration.GetSection("MarvelComicsAPI:PublicKey").Value;
            string hash = GerarHash(ts, publicKey, _configuration.GetSection("MarvelComicsAPI:PrivateKey").Value);

            string url = _configuration.GetSection("MarvelComicsAPI:BaseURL").Value + $"characters?ts={ts}&apikey={publicKey}&hash={hash}&" + $"nameStartsWith={nome}";

            HttpResponseMessage response = _client.GetAsync(url).Result;

            response.EnsureSuccessStatusCode();
            string conteudo =
                response.Content.ReadAsStringAsync().Result;

            dynamic resultado = JsonConvert.DeserializeObject(conteudo);

            List<Personagem> listPersonagem = new List<Personagem>();

            foreach (var item in resultado.data.results)
            {
                Personagem personagem = new Personagem();
                personagem.Nome = item.name;
                personagem.Descricao = item.description;
                personagem.UrlImagem = item.thumbnail.path + "." + item.thumbnail.extension;
                personagem.UrlWiki = item.urls[1].url;
                personagem.ID = item.id;

                personagem.Historias = new List<string>();
                foreach (var historia in item.stories.items)
                {
                    personagem.Historias.Add(historia.name.ToString());
                }

                listPersonagem.Add(personagem);
            }

            return listPersonagem;
        }

        private string GerarHash(string ts, string publicKey, string privateKey)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(ts + privateKey + publicKey);
            var gerador = MD5.Create();
            byte[] bytesHash = gerador.ComputeHash(bytes);
            return BitConverter.ToString(bytesHash).ToLower().Replace("-", String.Empty);
        }

        public PesquisasRealizadas RetornaPesquisasRealizadas()
        {
            PesquisasRealizadas pesquisas = new PesquisasRealizadas();
            pesquisas.Pesquisas = new List<string>();
            using (StreamReader sr = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + @"Pesquisas\pesquisas.txt"))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    pesquisas.Pesquisas.Add(s);
                }
            }

            return pesquisas;
        }
    }
}