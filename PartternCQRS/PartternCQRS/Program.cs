using PartternCQRS.Queries;
using PartternCQRS.Repositories;
using System;

namespace PartternCQRS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Command save Employee (insert, update, delete)
            var employeeCommand = new EmployeeCommandsRepository();   
            Console.WriteLine("Employee saved");

            // Query get Employee
            var employeeQuery = new EmployeeQueries(new EmployeeQueriesRepository());
            var employee = employeeQuery.FindByID(100);
            Console.WriteLine("Employee ID:{0}, Name:{1}, Address:{2}, Age:{3}", employee.Id, employee.FullName, employee.Address, employee.Age);
            Console.ReadKey();
        }

    }
}
