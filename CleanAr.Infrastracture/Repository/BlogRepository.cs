using CleanAr.Domain.Entity;
using CleanAr.Domain.Repository;
using CleanAr.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CleanAr.Infrastructure.Repository
{
    class BlogRepository : IBlogRepository
    {
        private readonly BlogDbContext _blogDbContext;

        public BlogRepository(BlogDbContext blogDbContext)
        {
            this._blogDbContext = blogDbContext;
        }
        public async Task<Blog> CreateAsync(Blog blog)
        {
            await _blogDbContext.Blogs.AddAsync(blog);
            await _blogDbContext.SaveChangesAsync();
            return blog;
        }

        public async Task<int> DelteAsync(int id)
        {
            return await _blogDbContext.Blogs.Where(modal => modal.id == id).ExecuteDeleteAsync();
        }

        public async Task<List<Blog>> GetAllBlogsAsync()
        {
            return await _blogDbContext.Blogs.ToListAsync();
        }

        public async Task<Blog> GetByIdAsync(int id)
        {
            return await _blogDbContext.Blogs.AsNoTracking().FirstOrDefaultAsync(b => b.id == id);
        }

        public async Task<int> UpdateAsync(int id, Blog blog)
        {
            return await _blogDbContext.Blogs
            .Where(model => model.id == id)
            .ExecuteUpdateAsync(setter =>
            setter
            .SetProperty(m => m.id, blog.id)
            .SetProperty(m => m.Name, blog.Name)
            .SetProperty(m => m.Description, blog.Description)
            .SetProperty(m => m.Author, blog.Author)
            );


        }
    }
}

