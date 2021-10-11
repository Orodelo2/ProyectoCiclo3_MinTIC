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
    public class CreateModelCliente : PageModel
    {
        private IRepositorioCliente repoCliente;
        public Cliente newCliente { get; set; }
        public CreateModelCliente(IRepositorioCliente repo)
        {
            repoCliente = repo;
        }
        public void OnGet(Cliente cliente)
        {

        }
        public void OnPost(Cliente newCliente)
        {
            repoCliente.AddCliente(newCliente);
        }
    }
}