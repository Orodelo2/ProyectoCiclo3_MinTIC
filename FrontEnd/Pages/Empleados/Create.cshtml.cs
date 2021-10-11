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
    public class CreateModelEmpleado : PageModel
    {
        private IRepositorioEmpleado repoEmpleado;
        public Empleado newEmpleado { get; set; }
        public CreateModelEmpleado(IRepositorioEmpleado repo)
        {
            repoEmpleado = repo;
        }
        public void OnGet(Empleado Empleado)
        {

        }
        public void OnPost(Empleado newEmpleado)
        {
            repoEmpleado.AddEmpleado(newEmpleado);
        }
    }
}