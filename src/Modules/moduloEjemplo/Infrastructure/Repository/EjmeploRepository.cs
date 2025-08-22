using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using examen.src.Modules.moduloEjemplo.Application.Interfaces;
using examen.src.Modules.moduloEjemplo.Domain.Entities;
using examen.src.Modules.Shared.Context;
using Microsoft.EntityFrameworkCore;

namespace examen.src.Modules.moduloEjemplo.Infrastructure.Repository
{
    public class EjmeploRepository : IEjemploRepositiory
    {
        private readonly AppDbContext _context;

        public EjmeploRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ejemplo?> GetByIdAsync(int id)
        {
            return await _context.Ejemplos.FindAsync(id);
        }

        public async Task<IEnumerable<ejemplo?>> GetAllAsync()
        {
            return await _context.Ejemplos.ToListAsync();
        }

        public void Add(ejemplo entity)
        {
            _context.Ejemplos.Add(entity);
        }

        public void Remove(ejemplo entity)
        {
            _context.Ejemplos.Remove(entity);
        }

        public void Update(ejemplo entity)
        {
            _context.Ejemplos.Update(entity);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}