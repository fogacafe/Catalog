using Catalog.Application.Customers.Repositories;
using Catalog.Domain.Costumers.Entities;
using Catalog.Domain.Costumers.Enums;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Infrastructure.EFCore.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {

        private readonly AppContext _context;

        public CustomerRepository(AppContext context)
        {
            _context = context;
        }

        public async Task DeleteAsync(Customer entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(Guid id)
        {
            var customer = new Customer(id, string.Empty, string.Empty, string.Empty, Status.Blocked, new());
            _context.Remove(customer);
            await _context.SaveChangesAsync();
        }

        public async Task<Customer?> FindByIdAsync(Guid id)
        {
            return await _context
                .Customers
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task SaveAsync(Customer entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Customer entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
