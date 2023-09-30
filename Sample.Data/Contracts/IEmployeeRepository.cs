using SampleApp.Core.Entities;

namespace SampleData.Core.Contracts
{
    public interface IEmployeeRepository
    {
        Task<Employee?> GetByIdAsync(int id);
        Task<List<Employee>> GetAllAsync();
    }
}
