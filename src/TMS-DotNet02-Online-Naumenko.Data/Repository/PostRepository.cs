﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_DotNet02_Online_Naumenko.Data.Contexts.MainContext;
using TMS_DotNet02_Online_Naumenko.Data.Models;
using TMS_DotNet02_Online_Naumenko.Data.Repository.Interfaces;

namespace TMS_DotNet02_Online_Naumenko.Data.Repository
{
    public class PostRepository : IPostRepository
    {
        private readonly DbSet<Post> _dbSet;
        private readonly DbContext _context;

        public PostRepository(MainContext context)
        {
            _context = context;
            _dbSet = context.Set<Post>();
        }

        public async Task AddAsync(Post entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Delete(int id)
        {
            var isEmpty = _dbSet.Find(id);

            _dbSet.Remove(isEmpty);
        }

        public void DeleteRange(IEnumerable<Post> entity)
        {
            _dbSet.RemoveRange(entity);
        }

        public IEnumerable<Post> GetAll(Filter filter)
        {
            //return _dbSet.Where(post => post.UserId == filter.UserId);
            return UseFilter(filter);
        }

        public Task SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        public void Update(Post entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public IQueryable<Post> UseFilter(Filter filter)
        {
            IQueryable<Post> filterPosts = _dbSet;

            if (filter.Title != null)
            {
                filterPosts = filterPosts.Where(post => post.Title.Contains(filter.Title));
            }

            if (filter.UserId != 0 && filter.UserId != null)
            {
                filterPosts = filterPosts.Where(post => post.UserId == filter.UserId);
            }

            if(filter.TermsId != null)
            {
                // filterPosts = filterPosts.Where();
            }

            return filterPosts.AsNoTracking();
        }
    }
}
