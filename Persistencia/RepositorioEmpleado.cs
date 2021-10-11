using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepositorioEmpleado : IRepositorioEmpleado
    {
        private readonly AplicacionContext _appContext;

        public RepositorioEmpleado(AplicacionContext appContext){
        
            _appContext = appContext;
        }

        public Empleado AddEmpleado(Empleado empleado)
        {
            var addEmpleado = _appContext.Add(empleado);
            _appContext.SaveChanges();
            return addEmpleado.Entity;
        }

        public void DeleteEmpleado(int Id)
        {
            var deleteEmpleado = _appContext.Empleados.FirstOrDefault(
                p => p.Id == Id
            );

            if(deleteEmpleado == null)
            return;
            _appContext.Remove(deleteEmpleado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Empleado> GetAllEmpleado()
        {
            return _appContext.Empleados;
        }

        public Empleado GetEmpleado(int Id)
        {
            return _appContext.Empleados.FirstOrDefault(
                p => p.Id == Id
            );
        }

        public Empleado UpdateEmpleado(Empleado empleado)
        {
            var updateEmpleado = _appContext.Empleados.FirstOrDefault(
                p => p.Id == empleado.Id
            );
            if(updateEmpleado != null){

                updateEmpleado.Nombre = empleado.Nombre;
                updateEmpleado.Apellido = empleado.Apellido;
                updateEmpleado.Salario = empleado.Salario;
                updateEmpleado.Edad = empleado.Edad;
                updateEmpleado.TipoDocumento = empleado.TipoDocumento;
                updateEmpleado.NumeroDocumento = empleado.NumeroDocumento;
                _appContext.SaveChanges();
            }
            return updateEmpleado;

        }
    }
}