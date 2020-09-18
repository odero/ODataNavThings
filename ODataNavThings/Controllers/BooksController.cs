using Microsoft.AspNet.OData;
using ODataNavThings.Models;
using ODataNavThings.Repositories;
using System.Linq;

namespace ODataNavThings.Controllers
{
    [EnableQuery]
    public class BooksController : ODataController
    {
        private readonly IBooksRepository _booksRepository;

        public BooksController(IBooksRepository booksRepository)
        {
            _booksRepository = booksRepository;
        }

        public IQueryable<Book> Get()
        {

            return _booksRepository.GetBooks();
        }

        public Book Post(Book book)
        {
            return new Book { Id = 14, Author = "Marcus Garvey", Title = "Sexual Healing" };
        }

    }
}
