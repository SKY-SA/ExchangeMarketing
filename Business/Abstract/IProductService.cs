using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService 
    {
        List<Product> GetList();
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
       
      
        public List<ProductDto> GetDetailsByCategoryId(List<Category> categories);
    }
}
