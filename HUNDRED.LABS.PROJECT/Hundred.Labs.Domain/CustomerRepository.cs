using Hundred.Labs.DataAccess.EntityFramework;
using Hundred.Labs.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundred.Labs.Domain
{
    public class CustomerRepository
    {
        private SalesDBEntities salesDBContext;

        public CustomerRepository() {
            salesDBContext = new SalesDBEntities();
        }

        public List<Entities.Customers> GetCustomerByLastName(string lastName)
        {
           var objCustomer = salesDBContext.GetCustomerByName(lastName);

            var lstCustomer = from c in objCustomer
                             select new Entities.Customers
                             {
                                 CustomerId = c.CustomerID,
                                 FirstName = c.FirstName,
                                 MiddleInitial = c.MiddleInitial,
                                 LastName = c.LastName
                             };


            return lstCustomer.ToList();
        }

    }
}
