using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;
using Microsoft.AspNetCore.Authorization;

namespace MyApp.Namespace.Clientes
{
    [Authorize]
    public class ListModelCliente : PageModel
    {
        private readonly IRepositorioCliente _repo;
        public IEnumerable<Cliente> clientes { get; set;}
        
        public ListModelCliente(IRepositorioCliente repositorioCliente)
        {
            _repo = repositorioCliente;
        }
        public void OnGet()
        {
            clientes = _repo.GetAllCliente();
        }
    }
}
