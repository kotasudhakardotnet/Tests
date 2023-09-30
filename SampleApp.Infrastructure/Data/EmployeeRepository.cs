using Microsoft.EntityFrameworkCore;
using SampleApp.Core.Entities;
using SampleData.Core.Contracts;

namespace SampleApp.Infrastructure.Data
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;

        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Employee?> GetByIdAsync(int id)
        {
            return await _context.Employees.FindAsync(id);
            
        }

        public async Task<List<Employee>> GetAllAsync()
        {
            return await _context.Employees.ToListAsync();
        }
    }
}
