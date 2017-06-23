using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Hundred.Labs.DataContracts
{
    [DataContract(Name = "Product")]
    public class Product
    {
        [DataMember(Name = "ProductId", IsRequired = false, EmitDefaultValue = false, Order = 0)]
        public int ProductId { get; set; }

        [DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = false, Order = 1)]
        public string Name { get; set; }

        [DataMember(Name = "Price", IsRequired = false, EmitDefaultValue = false, Order = 2)]
        public decimal? Price { get; set; }
    }
}
