using System.Collections.Generic;

namespace SiteHeroisMarvel.Models
{
    public class Personagem
    {
        public string ID { get; set; }
        public List<string> Historias { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string UrlImagem { get; set; }
        public string UrlWiki { get; set; }
    }
}