using System.Collections.Generic;
using System.Linq;
using Test.Models;

namespace Test.Repository
{
    public class SalesRepository : IRepository<Sales>
    {
        private readonly HashSet<Sales> salesData = new HashSet<Sales>();

        public SalesRepository()
        {
            this.SetUpData();
        }

        void SetUpData()
        {
            Sales sale1 = new Sales()
            {
                Id = 1,
                EmployeeId = 3,
                TotalSales = 2,
                ProductId = 1
            };
            salesData.Add(sale1);
            Sales sale2 = new Sales()
            {
                Id = 2,
                EmployeeId = 3,
                TotalSales = 4,  
                ProductId = 2
            };
            salesData.Add(sale2);
            Sales sale3 = new Sales()
            {
                Id = 3,
                EmployeeId = 4,
                TotalSales = 1,
                ProductId = 4
            };
            salesData.Add(sale3);
            Sales sale4 = new Sales()
            {
                Id = 4,
                EmployeeId = 5,
                TotalSales = 7,
                ProductId = 1
            };
            salesData.Add(sale4);
            Sales sale5 = new Sales()
            {
                Id = 5,
                EmployeeId = 6,
                TotalSales = 2,
                ProductId = 3
            };
            salesData.Add(sale5);
            Sales sale6 = new Sales()
            {
                Id = 6,
                EmployeeId = 7,
                TotalSales = 12,  
                ProductId = 1
            };
            salesData.Add(sale6);
            Sales sale7 = new Sales()
            {
                Id = 7,
                EmployeeId = 5,
                TotalSales = 2,
                ProductId = 1
            };
            salesData.Add(sale7);
            Sales sale8 = new Sales()
            {
                Id = 8,
                EmployeeId = 8,
                TotalSales = 2,
                ProductId = 3
            };
            salesData.Add(sale8);
            Sales sale9 = new Sales()
            {
                Id = 9,
                EmployeeId = 5,
                TotalSales = 2,     
                ProductId = 1
            };
            salesData.Add(sale9);
            Sales sale10 = new Sales()
            {
                Id = 10,
                EmployeeId = 11,
                TotalSales = 2,
                ProductId = 4
            };
            salesData.Add(sale10);
            Sales sale11 = new Sales()
            {
                Id = 11,
                EmployeeId = 2,
                TotalSales = 2,
                ProductId = 2
            };
            salesData.Add(sale11);
            Sales sale12 = new Sales()
            {
                Id = 12,
                EmployeeId = 7,
                TotalSales = 14,     
                ProductId = 3
            };
            salesData.Add(sale12);
            Sales sale13 = new Sales()
            {
                Id = 13,
                EmployeeId = 5,
                TotalSales = 2,
                ProductId = 3
            };
            salesData.Add(sale13);
        }

        public Sales GetById(int id)
        {
           return salesData.FirstOrDefault(e=>e.Id == id);            
        }

        public List<Sales> GetAll()
        {
            return salesData.ToList();
        }
    }
}
