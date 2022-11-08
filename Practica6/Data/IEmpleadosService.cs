using Practica6.Models;

namespace Practica6.Data.Services
{
    public interface IEmpleadosService
    {
        public Task<List<Empleado>> ObtenerTodos();
        public Task<Empleado> ObtenerId(int id);
        public Task<Empleado> Crear(Empleado empleadocrear);
        public Task Actualizar(Empleado empleadoActualizar);
        public Task Eliminar(Empleado empleado);
        //public Task<bool> SalvarEmpleado(Empleado empleado);
    }
}