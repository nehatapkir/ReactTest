using System.Collections.Generic;
using System.Threading.Tasks;
using Test.Models;

namespace Test.Repository
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        List<Employee> GetAllStaff();
        List<Employee> GetAllManagers();
    }
}
