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

        public async Task Actualizar(Empleado empleadoActualizar)
        {
            _context.Empleados.Update(empleadoActualizar);
            await _context.SaveChangesAsync();
        }

        public async Task<Empleado> Crear(Empleado empleadocrear)
        {

            _context.Empleados.Add(empleadocrear);
            await _context.SaveChangesAsync();
            return empleadocrear;
        }

        public async Task Eliminar(Empleado empleado)
        {
            _context.Empleados.Remove(empleado);
            await _context.SaveChangesAsync();
        }

        public async Task<Empleado> ObtenerId(int id)
        {
            return await _context.Empleados.Include(x => x.IntId).FirstOrDefaultAsync(x => x.IntId == id);
        }

        public async Task<List<Empleado>> ObtenerTodos()
        {
            return await _context.Empleados.ToListAsync();
        }
    } 
}
