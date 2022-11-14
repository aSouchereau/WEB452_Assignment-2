using AlexBookstore.DataAccess.Data;
using AlexBookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlexsBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            // use linq to get first or default cat obj, pass id as generic entity which matches category ID
            var objFromDb = _db.Categories.FirstOrDefault(s => s.ID == category.ID);
            if (objFromDb != null)  // If not null, then save changes
            {
                objFromDb.Name = category.Name;
            }
        }
    }
}
