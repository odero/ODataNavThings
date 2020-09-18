using ODataNavThings.Models;
using System.Linq;

namespace ODataNavThings.Repositories
{
    public interface IBooksRepository
    {
        IQueryable<Book> GetBooks();
        Book GetBook(int id);
    }
}