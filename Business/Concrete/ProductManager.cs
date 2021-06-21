using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

      

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<ProductDto> GetDetailsByCategoryId(List<Category> categories)
        {
            return _productDal.GetDetailsByCategoryId(categories);
        }

        public List<Product> GetList()
        {
            return _productDal.GetList();
        }



        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
