using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace MyApp.Namespace.Directivos
{
    public class ListModelDirectivo : PageModel
    {
        private readonly IRepositorioDirectivo _repo;
        public IEnumerable<Directivo> directivos { get; set;}
        
        public ListModelDirectivo(IRepositorioDirectivo repositorioDirectivo)
        {
            _repo = repositorioDirectivo;
        }
        public void OnGet()
        {
            directivos = _repo.GetAllDirectivo();
        }
    }
}
