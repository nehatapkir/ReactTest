using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Test.DTO;
using Test.Services;

namespace Test.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeSalesController : Controller
    {
        IEmployeeSalesRecordService employeeSalesRecordService;

        public EmployeeSalesController()
        {
            employeeSalesRecordService = new EmployeeSalesRecordService();
        }

        [HttpGet("[action]")]
        public IEnumerable<EmployeeSalesRecordDTO> EmployeeSalesRecord()
        {
            return employeeSalesRecordService.GetEmployeeSalesRecord();
        }    
    }
}
