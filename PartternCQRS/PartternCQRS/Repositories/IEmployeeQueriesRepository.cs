using PartternCQRS.Models;

namespace PartternCQRS.Repositories
{
    public interface IEmployeeQueriesRepository
    {
        Employee GetByID(int employeeID);
    }
}
