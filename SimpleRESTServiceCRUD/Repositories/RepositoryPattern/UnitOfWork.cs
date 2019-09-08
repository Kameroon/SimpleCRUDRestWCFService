using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleRESTServiceCRUD.Repositories.RepositoryPattern
{
    public class UnitOfWork : IUnitOfWork
    {
        //private readonly PlutoContext _context

        public ICourseRepository Courses => throw new NotImplementedException();

        public IAuthorsRepository Authors => throw new NotImplementedException();


        public UnitOfWork(/*PlutoContext context*/)
        {
            //_coontext = context;
            //Courses = new CourseRepository(_context);
            //Authors = new AuthorsRepository(_context);
        }

        public int Complete()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            //_context.Dispose();
        }
    }
}