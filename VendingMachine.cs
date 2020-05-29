using System;
using System.Collections.Generic;
using System.Linq;

namespace Vending
{
    public class VendingMachine
    {
        private List<Product> _products = new List<Product>();

        public VendingMachine()
        {
            _products.Add(new Product() { Id = 1, Name = "Snickers", Price = .75 });
            _products.Add(new Product() { Id = 2, Name = "Pepsi", Price = 1.25 });
            _products.Add(new Product() { Id = 3, Name = "Diamond Ring", Price = 2_400 });
            _products.Add(new Product() { Id = 4, Name = "Tesla", Price = 85_000 });
            _products.Add(new Product() { Id = 5, Name = "Hot Pocket", Price = 1.50 });
        }

        // Add a new product to the Vending Machine (For stocking machine)
        public void AddProduct(Product newProduct)
        {
            throw new NotImplementedException();
        }

        // Remove a product from the Vending Machine (for purchasing a product)
        public void RemoveProduct(Product productToRemove)
        {
            throw new NotImplementedException();
        }

        // Get all products ordered by price (lowest on top)
        public List<Product> GetAll()
        {
            List<Product> pricedProducts = _products.OrderBy(p => p.Price).ToList();
            return pricedProducts;
        }

        // Find a product by name. Results should be ordered by name)
        public List<Product> SearchByName(string nameCriteria)
        {
            List<Product> foundProduct = _products.Where(p => p.Name == nameCriteria).ToList();
            return foundProduct;
        }

        // Find a product between a range or prices. Results should be ord0ered by price
        public List<Product> SearchByPrice(double minPrice, double maxPrice)
        {
            throw new NotImplementedException();
        }

        // Return a product with a given ID. Return null if not found.
        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        // Return the cheapest product or null if there are no products
        public Product GetCheapest()
        {
            throw new NotImplementedException();
        }

        // Return the most expensive product or null if there are no products
        public Product GetMostExpensive()
        {
            throw new NotImplementedException();
        }

        // Return all the product names in alphabetical ordere
        public List<string> GetProductNames()
        {
            List<String> namedProducts = _products.Select(p => p.Name).ToList();
            namedProducts = namedProducts.OrderBy(p => p).ToList();
            return namedProducts; 
        }

        // Property to represent the total of all the products' prices.
        public double TotalValue
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
