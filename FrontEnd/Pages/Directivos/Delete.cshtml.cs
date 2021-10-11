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
    public class DeleteModelDirectivo : PageModel
    {
        private readonly IRepositorioDirectivo repoDirectivo;
        public Directivo Directivo { get; set; }
        public DeleteModelDirectivo(IRepositorioDirectivo repo)
        {
            repoDirectivo = repo;
        }

        public void OnGet(int id)
        {
            Directivo = repoDirectivo.GetDirectivo(id);
        }
        public void OnPost(int id)
        {
            repoDirectivo.DeleteDirectivo(id);
        }
    }
}
