using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rapp_Test.Data
{
    public class DataRepository:IDataRepository
    {
        public DataRepository()
        {

        }

        List<Customer> customers = new();

        public IEnumerable<Customer> GetAllCustomers()
        {
              
            Customer customer1 = new Customer
            {
                Id = 1,
                Name = "Tudor Boca",
                Email = "tuodr_boca@yahoo.com",
                DateOfBirth = new DateTime(1986, 05, 03)
            };
            customers.Add(customer1);

            Customer customer2 = new Customer
            {
                Id = 2,
                Name = "Francesca Nield",
                Email = "frankee@yahoo.com",
                DateOfBirth = new DateTime(1989,07, 12)
            };
            customers.Add(customer2);

            return customers;
        }

        public void AddEntity(Customer model)
        {
            customers.Add(model);
        }
    }
}
