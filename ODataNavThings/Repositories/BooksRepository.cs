using ODataNavThings.Models;
using System.Collections.Generic;
using System.Linq;

namespace ODataNavThings.Repositories
{
    public class BooksRepository : IBooksRepository
    {
        public IQueryable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book { Id = 1, Author = "Adam Smith", ISBN = "123", Price = 10.0M, Title = "The Capitalist Economy"},
                new Book { Id = 2, Author = "Sam Smith", ISBN = "No one but you", Price = 2.50M, Title = "Random Tunes"},
            }.AsQueryable();
        }

        public Book GetBook(int id)
        {
            return GetBooks().Where(e => e.Id == id).FirstOrDefault();
        }
    }
}
