using Microsoft.EntityFrameworkCore;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Persistence.Context;
using System.Linq.Expressions;

namespace MultiShop.Order.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly OrderContext _context;
        private readonly DbSet<T> _table;

        public Repository(OrderContext context)
        {
            _context = context;
            _table=_context.Set<T>();
        }

        public async Task CreateAsync(T entity)
        {
           _table.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _table.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _table.ToListAsync();
        }

        public async Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter)
        {
            return await _table.SingleOrDefaultAsync(filter);
        }

        public async Task<T> GetByIdAsync(int id)
        {
           return await _table.FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            _table.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
