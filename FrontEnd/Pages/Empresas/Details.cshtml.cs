using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia;
using Dominio;

namespace MyApp.Namespace.Empresas
{
    public class DetailsModelEmpresa : PageModel
    {
        private readonly IRepositorioEmpresa repoEmpresa;
        public Empresa empresa { get; set; }
        public DetailsModelEmpresa(IRepositorioEmpresa repo)
        {
            repoEmpresa = repo;
        }
                
        public void OnGet(int id)
        {
            empresa = repoEmpresa.GetEmpresa(id);
        }
    }
}
