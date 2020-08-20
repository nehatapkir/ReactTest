using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using Test.Models;
using Test.Services;

namespace Tests
{
    public class Tests
    {
        EmployeeSalesRecordService employeeSalesRecordService;

        [SetUp]
        public void Setup()
        {
            employeeSalesRecordService = new EmployeeSalesRecordService();        
        }

        [Test]
        public void GetEmployeeRecords_ShouldReturnCorrectCount()
        {
            var data = employeeSalesRecordService.GetEmployeeSalesRecord();
            Assert.AreEqual(data.ToList().Count, 10);
        }

        [Test]
        public void GetEmployeeRecords_ShouldNotContainManagerRecord()
        {
            var data = employeeSalesRecordService.GetEmployeeSalesRecord();
            var managers = data.ToList().Where(e => e.Employee.Id == 1);
            Assert.AreEqual(managers.ToList().Count, 0);
        }

        [Test]
        public void GetEmployeeRecords_CheckCountOfEmployeeWithNoSales()
        {
            var data = employeeSalesRecordService.GetEmployeeSalesRecord();
            var noSales = data.ToList().Where(e => e.TotalSales == 0);
            Assert.AreEqual(noSales.ToList().Count, 3);
        }
    }
}