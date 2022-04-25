using PartternCQRS.Models;

namespace PartternCQRS.Commands
{
    public interface IEmployeeCommands
    {
        void SaveEmployeeData(Employee employee);
    }
}
