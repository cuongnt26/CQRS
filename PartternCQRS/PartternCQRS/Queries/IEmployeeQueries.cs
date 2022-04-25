using PartternCQRS.DTOs;

namespace PartternCQRS.Queries
{
    public interface IEmployeeQueries
    {
        EmployeeDTO FindByID(int employeeID);
    }
}
