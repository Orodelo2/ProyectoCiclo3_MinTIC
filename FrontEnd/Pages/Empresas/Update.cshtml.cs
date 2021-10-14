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
    public class UpdateModelEmpresa : PageModel
    {
        private IRepositorioEmpresa repoEmpresa;
        public Empresa empresa { get; set; }
        public UpdateModelEmpresa(IRepositorioEmpresa repo)
        {
            repoEmpresa = repo;
        }
        public void OnGet(int Id)
        {
            empresa = repoEmpresa.GetEmpresa(Id);
        }
        public void OnPost(Empresa empresa)
        {
            repoEmpresa.UpdateEmpresa(empresa);
        }
    }
}
