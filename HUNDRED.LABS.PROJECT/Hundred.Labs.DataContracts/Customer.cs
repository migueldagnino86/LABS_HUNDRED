using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Hundred.Labs.DataContracts
{
    [DataContract(Name = "Customer")]
    public class Customer
    {
        [DataMember(Name = "CustomerId", IsRequired = false, EmitDefaultValue = false, Order = 0)]
        public int CustomerId { get; set; }

        [DataMember(Name = "FirstName", IsRequired = false, EmitDefaultValue = false, Order = 1)]
        public string FirstName { get; set; }

        [DataMember(Name = "MiddleInitial", IsRequired = false, EmitDefaultValue = false, Order = 2)]
        public string MiddleInitial { get; set; }

        [DataMember(Name = "LastName", IsRequired = false, EmitDefaultValue = false, Order = 3)]
        public string LastName { get; set; }
    }
}
