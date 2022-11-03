using Practica6.Models;
using Microsoft.EntityFrameworkCore;

namespace Practica6.Data.Services
{
    public class EmpleadosService : IEmpleadosService
    {
        private readonly AppDbContext _context;

        public EmpleadosService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Actualizar(Empleado empleadoActualizar)
        {
            _context.Entry(empleadoActualizar).State = EntityState.Modified;

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Crear(Empleado empleadocrear)
        {

            _context.Empleados.Add(empleadocrear);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Eliminar(Empleado empleado)
        {
            _context.Empleados.Remove(empleado);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Empleado> ObtenerId(int id)
        {
            return await _context.Empleados.FindAsync(id);
        }

        public async Task<List<Empleado>> ObtenerTodos()
        {
            return await _context.Empleados.ToListAsync();
        }

        public async Task<bool> SalvarEmpleado(Empleado empleado)
        {

            if (empleado.IntId > 0)
            {
                return await Actualizar(empleado);
            }
            else
            {
                return await Crear(empleado);
            }


        }

    }
}