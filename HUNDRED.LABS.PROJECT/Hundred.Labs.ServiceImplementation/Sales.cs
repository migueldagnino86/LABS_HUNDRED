using Hundred.Labs.BusinessEntities;
using Hundred.Labs.BusinessLogic;
using Hundred.Labs.DataContracts;
using Hundred.Labs.MessageContracts;
using Hundred.Labs.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Hundred.Labs.ServiceImplementation
{
    [ServiceBehavior(Namespace = "http://hundred.com.pe/servicios/sales", Name = "Sales")]
    public class Sales : ISales
    {
        private ProductBL productBL;
        private CustomerBL customerBL;

        public Sales()
        {
            productBL = new ProductBL();
            customerBL = new CustomerBL();
        }

        public ListProductsResponse GetProductByName(ListProductsRequest request)
        {
            var dataproduct = request.DataListProduct;
            string name = dataproduct.Name;

            var listProductsBL = productBL.GetProductByName(name);

            var listDataProducts = from pr in listProductsBL
                                   select new Product
                                   {
                                       ProductId = pr.ProductId,
                                       Name = pr.Name,
                                       Price = pr.Price
                                   };

            var listProductResponse = new ListProductsResponse();
            listProductResponse.Products = listDataProducts.ToList();

            return listProductResponse;

        }

        public RegisterProductResponse RegisterProduct(RegisterProductRequest request)
        {
            var dataproduct = request.DataRegisterProduct;

            var dataProductBE = new ProductBE()
            {
                Name = dataproduct.Name,
                Price = dataproduct.Price
            };

            var productId = productBL.InsertProduct(dataProductBE);

  
            var regsiterProductResponse = new RegisterProductResponse();
            regsiterProductResponse.ProductId = productId;

            return regsiterProductResponse;

        }

        public ListCustomersResponse GetCustomerByLastName(ListCustomersRequest request)
        {
            var dataCustomer = request.DataListCustomer;
            string name = dataCustomer.LastName;

            var listCustomersBL = customerBL.GetCustomerByName(name);

            var listDatacustomers = from c in listCustomersBL
                                    select new Customer
                                    {
                                        CustomerId = c.CustomerId,
                                        FirstName = c.FirstName,
                                        LastName = c.LastName,
                                        MiddleInitial = c.MiddleInitial
                                    };

            var listcustomerResponse = new ListCustomersResponse();
            listcustomerResponse.Customers = listDatacustomers.ToList();

            return listcustomerResponse;
        }  
    }
}
