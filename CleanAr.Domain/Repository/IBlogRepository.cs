using CleanAr.Domain.Entity;

namespace CleanAr.Domain.Repository
{

    public interface IBlogRepository
    {
        Task<List<Blog>> GetAllBlogsAsync();
        Task<Blog> GetByIdAsync(int id);
        Task<Blog> CreateAsync(Blog blog);
        Task<Blog> UpdateAsync(int id, Blog blog);
        Task<Blog> DelteAsync(int id);

    }

}


