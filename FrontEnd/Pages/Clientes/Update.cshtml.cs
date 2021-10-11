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
    public class UpdateModelCliente : PageModel
    {
        private IRepositorioCliente repoCliente;
        public Cliente cliente { get; set; }
        public UpdateModelCliente(IRepositorioCliente repo)
        {
            repoCliente = repo;
        }
        public void OnGet(Cliente cliente)
        {

        }
        public void OnPost(Cliente cliente)
        {
            repoCliente.AddCliente(cliente);
        }
    }
}