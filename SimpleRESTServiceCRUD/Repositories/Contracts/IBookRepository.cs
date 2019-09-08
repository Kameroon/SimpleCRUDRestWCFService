using SimpleRESTServiceCRUD.Repositories.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRESTServiceCRUD.Repositories.Contracts
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        /*
        List<Book> GetAllBooks();
        Book GetBookById(int id);
        Book AddNewBook(Book item);
        bool DeleteABook(int id);
        bool UpdateABook(Book item);
        */
    }
}
