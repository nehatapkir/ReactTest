using System.Collections.Generic;
using System.Linq;
using Test.Models;

namespace Test.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly HashSet<Employee> employeeData = new HashSet<Employee>();

        public EmployeeRepository()
        {
            this.SetUpData();
        }

        void SetUpData()
        {
            Employee employee1 = new Employee()
            {
                Id = 1,
                DesignationId = 1,
                FirstName = "Bruce",
                LastName = "Wayne"
            };
            employeeData.Add(employee1);
            Employee employee2 = new Employee()
            {
                Id = 2,
                DesignationId = 1,
                FirstName = "Stephen",
                LastName = "Strange"
            };
            employeeData.Add(employee2);
            Employee employee3 = new Employee()
            {
                Id = 3,
                DesignationId = 2,
                FirstName = "Bruce",
                LastName = "Banner",
                ManagerId = 1
            };
            employeeData.Add(employee3);
            Employee employee4 = new Employee()
            {
                Id = 4,
                DesignationId = 2,
                FirstName = "Oliver",
                LastName = "Queen",
                ManagerId = 1
            };
            employeeData.Add(employee4);
            Employee employee5 = new Employee()
            {
                Id = 5,
                DesignationId = 2,
                FirstName = "Clark",
                LastName = "Kent",
                ManagerId = 1
            };
            employeeData.Add(employee5);
            Employee employee6 = new Employee()
            {
                Id = 6,
                DesignationId = 2,
                FirstName = "Peter",
                LastName = "Parker",
                ManagerId = 2
            };
            employeeData.Add(employee6);
            Employee employee7 = new Employee()
            {
                Id = 7,
                DesignationId = 2,
                FirstName = "Steve",
                LastName = "Rogers",
                ManagerId = 2
            };
            employeeData.Add(employee7);
            Employee employee8 = new Employee()
            {
                Id = 8,
                DesignationId = 2,
                FirstName = "Clint",
                LastName = "Barton",
                ManagerId = 2
            };
            employeeData.Add(employee8);
            Employee employee9 = new Employee()
            {
                Id = 9,
                DesignationId = 2,
                FirstName = "Jean",
                LastName = "Grey",
                ManagerId = 2
            };
            employeeData.Add(employee9);
            Employee employee10 = new Employee()
            {
                Id = 10,
                DesignationId = 2,
                FirstName = "Tony",
                LastName = "Stark",
                ManagerId = 1
            };
            employeeData.Add(employee10);
            Employee employee11 = new Employee()
            {
                Id = 11,
                DesignationId = 2,
                FirstName = "Diana",
                LastName = "Prince",
                ManagerId = 1
            };
            employeeData.Add(employee11);
            Employee employee12 = new Employee()
            {
                Id = 12,
                DesignationId = 2,
                FirstName = "Charles",
                LastName = "Xavier",
                ManagerId = 1
            };
            employeeData.Add(employee12);
        }

        public Employee GetById(int id)
        {
           return  employeeData.FirstOrDefault(e=>e.Id == id);            
        }

        public List<Employee> GetAll()
        {
            return employeeData.ToList();
        }

        public List<Employee> GetAllStaff()
        {
            return employeeData.Where(e=>e.DesignationId == 2).ToList();
        }

        public List<Employee> GetAllManagers()
        {
            return employeeData.Where(e => e.DesignationId == 1).ToList();
        }
    }
}
