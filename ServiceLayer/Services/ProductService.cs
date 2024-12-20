using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceLayer.Data;
using ServiceLayer.Models;

namespace ServiceLayer.Services
{
    public class ProductService
    {
        private readonly ShopContext _context = new();
        public async Task<List<Product>> GetProductsAsync()
            => await _context.Products.ToListAsync();
    }
}
