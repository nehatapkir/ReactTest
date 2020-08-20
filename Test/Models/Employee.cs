using System;
using System.Collections.Generic;

namespace Test.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public int DesignationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ManagerId { get; set; }
    }
}
