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
    public class UpdateModelDirectivo : PageModel
    {
        private IRepositorioDirectivo repoDirectivo;
        public Directivo directivo { get; set; }
        public UpdateModelDirectivo(IRepositorioDirectivo repo)
        {
            repoDirectivo = repo;
        }
        public void OnGet(int Id)
        {
            directivo = repoDirectivo.GetDirectivo(Id);
        }
        public void OnPost(Directivo directivo)
        {
            repoDirectivo.UpdateDirectivo(directivo);
        }
    }
}
