using System;
using System.Collections.Generic;
using Test.DTO;

namespace Test.Services
{
    interface IEmployeeSalesRecordService
    {
        IEnumerable<EmployeeSalesRecordDTO> GetEmployeeSalesRecord();
    }
}
