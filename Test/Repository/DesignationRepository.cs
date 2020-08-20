using System.Collections.Generic;
using System.Linq;
using Test.Models;

namespace Test.Repository
{
    public class DesignationRepository : IRepository<Designation>
    {
        private readonly HashSet<Designation> designationData = new HashSet<Designation>();

        public DesignationRepository()
        {
            this.SetUpData();
        }

        void SetUpData()
        {
            Designation designation = new Designation()
            {
                Id = 1,
                Description = "Manager"                
            };
            designationData.Add(designation);
            Designation designation1 = new Designation()
            {
                Id = 2,
                Description = "Staff"
            };
            designationData.Add(designation1);
        }

        public Designation GetById(int id)
        {
           return designationData.FirstOrDefault(e=>e.Id == id);            
        }

        public List<Designation> GetAll()
        {
            return designationData.ToList();
        }
    }
}
