using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Hundred.Labs.DataContracts
{
    [DataContract(Name = "DataListProduct")]
    public class DataListProduct
    {
        [DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = false, Order = 0)]
        public string Name { get; set; }
    }
}
