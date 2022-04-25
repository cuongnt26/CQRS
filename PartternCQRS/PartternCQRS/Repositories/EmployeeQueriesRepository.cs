using PartternCQRS.Models;
using System;

namespace PartternCQRS.Repositories
{
    public class EmployeeQueriesRepository : IEmployeeQueriesRepository
    {
        public Employee GetByID(int employeeID)
        {
            return new Employee()
            {
                Id = 100,

                FirstName = "The",

                LastName = "Cuong",

                DateOfBirth = new DateTime(1988, 04, 30),

                Street = "Ha Dong",

                City = "Ha Noi",

                ZipCode = "04"
            };
        }
    }
}
