using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRESTServiceCRUD.Repositories.RepositoryPattern
{
    public interface IUnitOfWork : IDisposable
    { 
        ICourseRepository Courses { get; }
        IAuthorsRepository Authors { get; }
        int Complete();
    }
}
