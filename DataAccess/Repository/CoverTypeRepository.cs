using AlexBookstore.DataAccess.Data;
using AlexsBooks.Models;
using AlexsBooks.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlexsBooks.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverType coverType)
        {
            // use linq to get first or default cat obj, pass id as generic entity which matches category ID
            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.ID == coverType.ID);
            if (objFromDb != null)  // If not null, then save changes
            {
                objFromDb.Name = coverType.Name;
            }
        }
    }
}
