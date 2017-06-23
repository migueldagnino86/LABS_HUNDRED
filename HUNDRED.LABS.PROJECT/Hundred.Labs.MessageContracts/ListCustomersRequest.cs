using Hundred.Labs.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Hundred.Labs.MessageContracts
{
    [MessageContract(IsWrapped = false)]
    public class ListCustomersRequest
    {
        [MessageBodyMember(Name = "DataListCustomer", Order = 0)]
        public DataListCustomer DataListCustomer { get; set; }
    }
}
