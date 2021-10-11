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
    public class DetailsModelEmpleado : PageModel
    {
        private readonly IRepositorioEmpleado repoEmpleado;
        public Empleado empleado { get; set; }

        public DetailsModelEmpleado(IRepositorioEmpleado repo)
        {
            repoEmpleado = repo;
        }

        public void OnGet(int id)
        {
            empleado = repoEmpleado.GetEmpleado(id);
        }
    }
}
