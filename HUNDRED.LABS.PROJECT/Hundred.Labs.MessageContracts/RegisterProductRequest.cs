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
    public class RegisterProductRequest
    {
        [MessageBodyMember(Name = "DatosListarDirectorio", Order = 0)]
        public DataRegisterProduct DataRegisterProduct { get; set; }
    }
}
