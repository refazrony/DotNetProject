﻿using CleanAr.Domain.Entity;

namespace CleanAr.Domain.Repository
{

    public interface IBlogRepository
    {
        Task<List<Blog>> GetAllBlogsAsync();
        Task<Blog> GetByIdAsync(int id);
        Task<Blog> CreateAsync(Blog blog);
        Task<int> UpdateAsync(int id, Blog blog);
        Task<int> DelteAsync(int id);

    }

}


