using Hundred.Labs.BusinessEntities;
using Hundred.Labs.Domain;
using Hundred.Labs.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundred.Labs.BusinessLogic
{
    public class CustomerBL
    {

        private CustomerRepository customerRepository;

        public CustomerBL() {
            this.customerRepository = new CustomerRepository();
        }

        public List<CustomerBE> GetCustomerByName(string name)
        {
            var lstCustomer = customerRepository.GetCustomerByLastName(name);

            var objCustomerBE = from c in lstCustomer
                               select new CustomerBE
                               {
                                   CustomerId = c.CustomerId,
                                   FirstName = c.FirstName,
                                   LastName = c.LastName,
                                   MiddleInitial = c.MiddleInitial
                               };

            return objCustomerBE.ToList();
        }

  
        
    }
}
