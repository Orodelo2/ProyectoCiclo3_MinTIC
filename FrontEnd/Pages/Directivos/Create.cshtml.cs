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
    public class CreateModelDirectivo : PageModel
    {
        private IRepositorioDirectivo repoDirectivo;
        public Directivo newDirectivo { get; set; }
        public CreateModelDirectivo(IRepositorioDirectivo repo)
        {
            repoDirectivo = repo;
        }
        public void OnGet(Directivo Directivo)
        {

        }
        public void OnPost(Directivo newDirectivo)
        {
            repoDirectivo.AddDirectivo(newDirectivo);
        }
    }
}