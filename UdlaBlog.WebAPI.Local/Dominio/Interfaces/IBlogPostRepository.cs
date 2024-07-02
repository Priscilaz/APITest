﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UdlaBlog.WebAPI.Local.Domain.Models;

namespace UdlaBlog.WebAPI.Local.Domain.Interfaces
{
    public interface IBlogPostRepository
    {
        Task<BlogPost> GetByIdAsync(Guid id);
        Task<BlogPost> GetByIdAndSectionAsync(Guid id, string section); 
        Task<IEnumerable<BlogPost>> GetAllAsync();
        Task<IEnumerable<BlogPost>> GetBySectionAsync(string section);
        Task AddAsync(BlogPost blogPost);
        Task UpdateAsync(BlogPost blogPost);
        Task DeleteAsync(Guid id);
    }
}
