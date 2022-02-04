using System.Collections.Generic;

namespace Rapp_Test.Data
{
    public interface IDataRepository
    {
        IEnumerable<Customer> GetAllCustomers();
        void AddEntity(Customer model);
    }
}