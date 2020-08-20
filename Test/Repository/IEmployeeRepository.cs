using System.Collections.Generic;
using System.Threading.Tasks;

namespace Test.Repository
{
    public interface IRepository<T>
    {
        T GetById(int id);

        List<T> GetAll();
    }
}
