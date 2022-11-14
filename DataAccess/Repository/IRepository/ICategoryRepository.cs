using AlexBookstore.Models;
using AlexsBooks.DataAccess.Repository.IRepository;

namespace AlexsBooks.DataAccess.Repository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}