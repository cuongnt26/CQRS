using PartternCQRS.Models;

namespace PartternCQRS.Repositories
{
    public interface IEmployeeCommandsRepository
    {
        void SaveEmployee(Employee employee);
    }
}
