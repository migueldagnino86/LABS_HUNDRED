using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Hundred.Labs.DataContracts
{
    [DataContract(Name = "DataListCustomer")]
    public class DataListCustomer
    {
        [DataMember(Name = "LastName", IsRequired = false, EmitDefaultValue = false, Order = 0)]
        public string LastName { get; set; }
    }
}
