using AlexBookstore.DataAccess.Data;
using AlexsBooks.Models;
using AlexsBooks.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlexsBooks.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product product)
        {
            // use linq to get first or default cat obj, pass id as generic entity which matches category ID
            var objFromDb = _db.Products.FirstOrDefault(s => s.ID == product.ID);
            if (objFromDb != null)  // If not null, then save changes
            {
                if (product.ImageUrl != null)
                {
                    objFromDb.ImageUrl = product.ImageUrl;
                }
                objFromDb.Title = product.Title;
                objFromDb.Description = product.Description;
                objFromDb.ISBN = product.ISBN;
                objFromDb.Author = product.Author;
                objFromDb.ListPrice = product.ListPrice;
                objFromDb.CategoryId = product.CategoryId;
                objFromDb.CoverTypeId = product.CoverTypeId;    // all properties of Product object
            }
        }
    }
}
