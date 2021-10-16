using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;
using Microsoft.AspNetCore.Authorization;

namespace MyApp.Namespace.Empleados
{
    [Authorize]
    public class ListModelEmpleado : PageModel
    {
        private readonly IRepositorioEmpleado _repo;
        public IEnumerable<Empleado> empleados { get; set;}
        
        public ListModelEmpleado(IRepositorioEmpleado repositorioEmpleado)
        {
            _repo = repositorioEmpleado;
        }
        public void OnGet()
        {
            empleados = _repo.GetAllEmpleado();
        }
    }
}
