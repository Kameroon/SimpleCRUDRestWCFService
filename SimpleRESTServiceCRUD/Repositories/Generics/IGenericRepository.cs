using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRESTServiceCRUD.Repositories.Generics
{
    public interface IGenericRepository<T> //where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        T AddNew(T item);
        bool Delete(int id);
        bool Update(T item);
    }
}
