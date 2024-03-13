using System.Collections.Generic;
using System.Linq;

namespace PracticeABC
{

    public class EFCoreProductRepository : IProductRepository
    {
        private readonly ProductContext _context;

        public EFCoreProductRepository(ProductContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return _context.Products.ToListAsync();
        }

        public async Task<Product> GetProductByName(string name)
        {
            return _context.Products.FirstOrDefault(p => p.Name == name);
        }

        public async Task AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChangesAsync();
        }

        public async Task UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChangesAsync();
        }

        public async Task DeleteProduct(string name)
        {
            var product = _context.Products.FirstOrDefault(p => p.Name == name);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChangesAsync();
            }
        }
    }
}
