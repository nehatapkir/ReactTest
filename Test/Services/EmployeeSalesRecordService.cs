using System.Collections.Generic;
using System.Linq;
using Test.DTO;
using Test.Models;
using Test.Repository;

namespace Test.Services
{
    public class EmployeeSalesRecordService : IEmployeeSalesRecordService
    {
        private readonly IRepository<Sales> salesRepository;
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeSalesRecordService()
        {
            salesRepository = new SalesRepository();
            employeeRepository = new EmployeeRepository();
        }

        public IEnumerable<EmployeeSalesRecordDTO> GetEmployeeSalesRecord()
        {
            var employeeSalesRecordDTO = new List<EmployeeSalesRecordDTO>();
            var sales = salesRepository.GetAll();
            var groupedByEmplyee = sales.GroupBy(e => e.EmployeeId);
            var allEmployees = employeeRepository.GetAllStaff();
            foreach (var emp in allEmployees)
            {
                var group = groupedByEmplyee.FirstOrDefault(g => g.Key == emp.Id);
                var manager = employeeRepository.GetById(emp.ManagerId);
                int totalSales = 0;
                if (group != null)
                {
                    totalSales = group.Sum(s => s.TotalSales);
                }
                employeeSalesRecordDTO.Add(new EmployeeSalesRecordDTO()
                {
                    Employee = emp,
                    TotalSales = totalSales,
                    ManagerName = $"{ manager.FirstName} {manager.LastName}"
                });
            }

            return employeeSalesRecordDTO.OrderByDescending(o => o.TotalSales);
        }
    }
}
