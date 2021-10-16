using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;
using Microsoft.AspNetCore.Authorization;

namespace MyApp.Namespace.Empresas
{
    [Authorize]
    public class ListModelEmpresa : PageModel
    {
        private readonly IRepositorioEmpresa _repo;
        public IEnumerable<Empresa> empresas { get; set; }

        public ListModelEmpresa(IRepositorioEmpresa repositorioEmpresa)
        {
            _repo = repositorioEmpresa;
        }
        public void OnGet()
        {
            empresas = _repo.GetAllEmpresa();
        }
    }
}
