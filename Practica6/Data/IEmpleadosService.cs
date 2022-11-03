using Practica6.Models;

namespace Practica6.Data.Services
{
    public interface IEmpleadosService
    {
        public Task<List<Empleado>> ObtenerTodos();
        public Task<Empleado> ObtenerId(int id);
        public Task<bool> Crear(Empleado empleadocrear);
        public Task<bool> Actualizar(Empleado empleadoActualizar);
        public Task<bool> Eliminar(Empleado empleado);
        public Task<bool> SalvarEmpleado(Empleado empleado);
    }
}