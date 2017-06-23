using Hundred.Labs.MessageContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Hundred.Labs.ServiceContracts
{
    [ServiceContract(Namespace = "http://hundred.com.pe/servicios/sales",  Name = "ISales")]
    [XmlSerializerFormat(Style = OperationFormatStyle.Document, SupportFaults = true, Use = OperationFormatUse.Literal)]
    public interface ISales
    {
        [OperationContract(IsOneWay = false)]
        ListProductsResponse GetProductByName(ListProductsRequest request);

        [OperationContract(IsOneWay = false)]
        RegisterProductResponse RegisterProduct(RegisterProductRequest request);

        [OperationContract(IsOneWay = false)]
        ListCustomersResponse GetCustomerByLastName(ListCustomersRequest request);
    }
}
