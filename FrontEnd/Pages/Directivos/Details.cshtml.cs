using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia;
using Dominio;

namespace MyApp.Namespace.Directivos
{
    public class DetailsModelDirectivo : PageModel
    {
        private readonly IRepositorioDirectivo repoDirectivo;
        public Directivo directivo { get; set; }

        public DetailsModelDirectivo(IRepositorioDirectivo repo)
        {
            repoDirectivo = repo;
        }

        public void OnGet(int id)
        {
            directivo =  repoDirectivo.GetDirectivo(id);
        }
    }
}
