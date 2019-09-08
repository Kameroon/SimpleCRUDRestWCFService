using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleRESTServiceCRUD.Repositories.Generics
{
    // -- https://dotnettutorials.net/lesson/generic-repository-pattern-csharp-mvc/

    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        #region -- Tutorial with EntityFramework --
       /*
        private EmployeeDBContext _context = null;
        private DbSet<T> table = null;

        public GenericRepository()
        {
            this._context = new EmployeeDBContext();
            table = _context.Set<T>();
        }

        public GenericRepository(EmployeeDBContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }

        public void Insert(T obj)
        {
            table.Add(obj);
        }

        public void Update(T obj)
        {
            //table.Attach(obj);
            //_context.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
        */
        #endregion

        #region -- My One MMA --
            
        public GenericRepository()
        {

        }
        
        public T AddNew(T item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(T item)
        {
            throw new NotImplementedException();
        } 
        
        #endregion
    }
}