using Test.Models;

namespace Test.DTO
{
    public class EmployeeSalesRecordDTO
    {
        public Employee Employee { get; set; }
        public int TotalSales { get; set; }      
        public string ManagerName { get; set; }
    }
}
