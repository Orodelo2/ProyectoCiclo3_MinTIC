using Dominio;
using System.Collections.Generic;

namespace Persistencia
{
    public interface IRepositorioEmpleado
    {
        IEnumerable<Empleado> GetAllEmpleado();
        Empleado AddEmpleado(Empleado empleado);
        Empleado UpdateEmpleado(Empleado empleado);
        void DeleteEmpleado(int id);
        Empleado GetEmpleado(int id);

    }
}