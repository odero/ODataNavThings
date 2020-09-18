using ODataNavThings.Models;
using System.Linq;

namespace ODataNavThings.Repositories
{
    public interface ICustomerRepository
    {
        Customer GetCustomer(int id);
        IQueryable<Customer> GetCustomers();
    }
}