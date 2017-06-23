using Hundred.Labs.BusinessEntities;
using Hundred.Labs.Domain;
using Hundred.Labs.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundred.Labs.BusinessLogic
{
    public class ProductBL
    {

        private ProductRepository productRepository;

        public ProductBL() {
            this.productRepository = new ProductRepository();
        }

        public List<ProductBE> GetProductByName(string name)
        {
            var lstProduct = productRepository.GetProductByName(name);

            var objProductBE = from pr in lstProduct
                               select new ProductBE
                               {
                                   ProductId = pr.ProductId,
                                   Name = pr.Name,
                                   Price = pr.Price
                               };

            return objProductBE.ToList();
        }

        public int InsertProduct(ProductBE productBE)
        {

            var objProduct = ConvertProductToProductBE(productBE);

            var productId = productRepository.InsertProduct(objProduct);

            return productId;

         }

        private Product ConvertProductToProductBE(ProductBE productBE)
        {
            Product product = new Product();

            product.ProductId = productBE.ProductId;
            product.Name = productBE.Name;
            product.Price = productBE.Price;

            return product;
        }
        
    }
}
