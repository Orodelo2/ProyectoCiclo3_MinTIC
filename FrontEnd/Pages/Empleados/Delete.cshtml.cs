using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia;
using Dominio;

namespace MyApp.Namespace.Empleados
{
    public class DeleteModelEmpleado : PageModel
    {
        private readonly IRepositorioEmpleado repoEmpleado;
        public Empleado Empleado { get; set; }
        public DeleteModelEmpleado(IRepositorioEmpleado repo)
        {
            repoEmpleado = repo;
        }

        public void OnGet(int id)
        {
            Empleado = repoEmpleado.GetEmpleado(id);
        }
        public void OnPost(int id)
        {
            repoEmpleado.DeleteEmpleado(id);
        }
    }
}
