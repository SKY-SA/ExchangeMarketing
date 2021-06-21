using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCategoryDal : ICategoryDal
    {
        List<Category> categories;
        public InMemoryCategoryDal()
        {
            categories = new List<Category>
            {
                new Category{CategoryId = 1 ,CategoryName="Iphone 12"},
                new Category{CategoryId = 2 ,CategoryName="Iphone 12 Pro"},
                new Category{CategoryId = 3 ,CategoryName="Samsung S20"},
                new Category{CategoryId = 4 ,CategoryName="Samsung S20 Ultra"},
                new Category{CategoryId = 5 ,CategoryName="Samsung Note 20"},
                new Category{CategoryId = 6 ,CategoryName="Samsung Note 10"},
                new Category{CategoryId = 7 ,CategoryName="Iphone 11"},
                new Category{CategoryId = 8 ,CategoryName="Iphone 11 Pro"},
            };
        }
        public void Add(Category entity)
        {
            Random rnd = new Random();
            entity.CategoryId = rnd.Next(10, 1000);
            categories.Add(entity);
        }

        public void Delete(Category entity)
        {
            Category categoryToDelete = null;
            foreach (var category in categories)
            {
                if (category.CategoryId == entity.CategoryId)
                    categoryToDelete = entity;
            }
            categories.Remove(categoryToDelete);
        }

        public List<Category> GetList()
        {
            return categories;
        }

        public void Update(Category entity)
        {
            Category categoryToUpdate = null;
            foreach (var category in categories)
            {
                if (category.CategoryId == entity.CategoryId)
                    categoryToUpdate = entity;
            }
            categoryToUpdate.CategoryId = entity.CategoryId;
            categoryToUpdate.CategoryName = entity.CategoryName;
           
        }
    }
}
