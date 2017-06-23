using Hundred.Labs.DataAccess.EntityFramework;
using Hundred.Labs.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundred.Labs.Domain
{
    public class ProductRepository
    {
        private SalesDBEntities salesDBContext;

        public ProductRepository() {
            salesDBContext = new SalesDBEntities();
        }

        public List<Entities.Product> GetProductByName(string name)
        {
           var objProduct = salesDBContext.GetProductByName(name);

            var lstProduct = from pr in objProduct
                          select new Entities.Product
                          {
                              ProductId = pr.ProductID,
                              Name = pr.Name,
                              Price = pr.Price
                          };


            return lstProduct.ToList();
        }

        public int InsertProduct(Entities.Product product)
        {
            ObjectParameter outProductId = new ObjectParameter("ProductId", typeof(Int32));

            salesDBContext.InsertProduct(
                product.Name,
                product.Price,
                outProductId
            );

            int productId = Convert.ToInt32(outProductId.Value);

            return productId;
        }
    }
}
