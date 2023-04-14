using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket_SecondLAB
{
    internal class Supermarket
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }

        public Supermarket()
        {
            Categories = new List<Category>();
            Products = new List<Product>();
        }

        public void AddCategory(Category category)
        {
            Category.Add(category);
        }

        public void DeleteCategory(Category category)
        {
            Category.Remove(category);
        }

        public Category FindCategory(string nameof)
        {
            return Categories.Find(c => c.Name == nameof);
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void DeleteProduct(Product product)
        {
            Products.Remove(product);
        }

        public Product FindProduct(string nameP)
        {
            return Products.Find(p => p.Name == nameP);
        }

    }
}
