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
    public class UpdateModelEmpleado : PageModel
    {
        private IRepositorioEmpleado repoEmpleado;
        public Empleado empleado { get; set; }
        public UpdateModelEmpleado(IRepositorioEmpleado repo)
        {
            repoEmpleado = repo;
        }
        public void OnGet(int Id)
        {
            empleado = repoEmpleado.GetEmpleado(Id);
        }
        public void OnPost(Empleado empleado)
        {
            repoEmpleado.UpdateEmpleado(empleado);
        }
    }
}
