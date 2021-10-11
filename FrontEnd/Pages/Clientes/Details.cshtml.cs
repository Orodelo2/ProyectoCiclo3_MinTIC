using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia;
using Dominio;

namespace MyApp.Namespace.Clientes
{
    public class DetailsModelCliente : PageModel
    {
        private readonly IRepositorioCliente repoCliente;

        public Cliente cliente { get; set; }
                
        public DetailsModelCliente(IRepositorioCliente repo)
        {
            repoCliente = repo;
        }
        
        public void OnGet(int id)
        {
            cliente = repoCliente.GetCliente(id);
        }
    }
}
