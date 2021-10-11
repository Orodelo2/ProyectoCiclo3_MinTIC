using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace MyApp.Namespace.Empleados
{
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
