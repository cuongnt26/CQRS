using System;
using PartternCQRS.DTOs;
using PartternCQRS.Repositories;

namespace PartternCQRS.Queries
{
    public class EmployeeQueries : IEmployeeQueries
    {
        private readonly IEmployeeQueriesRepository _repository;
        public EmployeeQueries(IEmployeeQueriesRepository repository)
        {
            _repository = repository;
        }

        public EmployeeDTO FindByID(int employeeID)
        {
            var emp = _repository.GetByID(employeeID);
            return new EmployeeDTO()
            {
                Id = emp.Id,
                Address = emp.Street + " " + emp.City + " " + emp.ZipCode,
                FullName = emp.FirstName + " " + emp.LastName,
                Age = Convert.ToInt32(Math.Abs((DateTime.Now - emp.DateOfBirth).TotalDays / 365))
            };
        }
    }
}
