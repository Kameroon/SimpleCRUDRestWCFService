using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleRESTServiceCRUD.Repositories.Generics
{
    public class BookController
    {
        private IRepository<Book> _repository = null;

        public BookController()
        {
            //_repository = new GenericRepository<Book>();
        }

        public BookController(IRepository<Book> repository)
        {
            _repository = repository;
        }
       

        public IEnumerable<Book> GetAll()
        {
            var model = _repository.GetAll();

            return model;
        }
       
        public void AddEmployee(Book model)
        {
            if (model != null)
            {
                _repository.Insert(model);

                _repository.Save();
            }
        }
        
        
        public void EditEmployee(Book model)
        {
            var item = _repository.GetById(model);

            if (item != null)
            {
                _repository.Update(model);

                _repository.Save();
            }
        }

       
        public void Delete(int id)
        {
            var item = _repository.GetById(id);

            if (item != null)
            {
                _repository.Delete(id);

                _repository.Save();
            }
        }
    }
}