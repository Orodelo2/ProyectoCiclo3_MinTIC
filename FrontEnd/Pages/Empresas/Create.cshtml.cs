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
    public class CreateModelEmpresa : PageModel
    {
        private IRepositorioEmpresa repoEmpresa;
        public Empresa newEmpresa { get; set; }
        public CreateModelEmpresa(IRepositorioEmpresa repo)
        {
            repoEmpresa = repo;
        }
        public void OnGet(Empresa Empresa)
        {

        }
        public void OnPost(Empresa newEmpresa)
        {
            repoEmpresa.AddEmpresa(newEmpresa);
        }
    }
}