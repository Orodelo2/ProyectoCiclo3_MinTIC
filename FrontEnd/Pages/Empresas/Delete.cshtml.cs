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
    public class DeleteModelEmpresa : PageModel
    {
        private readonly IRepositorioEmpresa repoEmpresa;
        public Empresa Empresa { get; set; }
        public DeleteModelEmpresa(IRepositorioEmpresa repo)
        {
            repoEmpresa = repo;
        }

        public void OnGet(int id)
        {
            Empresa = repoEmpresa.GetEmpresa(id);
        }
        public void OnPost(int id)
        {
            repoEmpresa.DeleteEmpresa(id);
        }
    }
}
