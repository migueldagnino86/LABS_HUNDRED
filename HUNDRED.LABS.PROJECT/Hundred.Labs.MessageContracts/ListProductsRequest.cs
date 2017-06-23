﻿using Hundred.Labs.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Hundred.Labs.MessageContracts
{
    [MessageContract(IsWrapped = false)]
    public class ListProductsRequest
    {
        [MessageBodyMember(Name = "DataListProduct", Order = 0)]
        public DataListProduct DataListProduct { get; set; }
    }
}
