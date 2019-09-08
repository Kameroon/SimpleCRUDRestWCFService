using SimpleRESTServiceCRUD.Repositories.Contracts;
using SimpleRESTServiceCRUD.Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SimpleRESTServiceCRUD
{
    public class BookService : IBookService
    {
        static IBookRepository repository = new BookRepository();

        public List<Book> GetBookList()
        {
            return repository.GetAll();
        }    
        
        public Book GetBookById(string id)
        {
            return repository.GetById(int.Parse(id));
        }

        public string AddBook(Book book, string id)
        {
            Book newBook = repository.AddNew(book);

            return "id=" + newBook.BookId;
        }

        public string UpdateBook(Book book, string id)
        {
            bool updated = repository.Update(book);

            if (updated)
               return "Book with id = " + id + " updated successfully";
            else
               return "Unable to update book with id = " + id;
        }

        public string DeleteBook(string id)
        {
            bool deleted = repository.Delete(int.Parse(id));

            if (deleted)
               return "Book with id = " + id + " deleted successfully.";
            else
               return "Unable to delete book with id = " + id;
        }
    }
}
