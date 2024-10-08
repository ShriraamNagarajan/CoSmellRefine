﻿using CoSmellRefine.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CoSmellRefine.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext dbContext;

        public UserRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public async Task<IEnumerable<IdentityUser>> GetAllAsync(string? searchQuery,
                  string? sortBy,
                  string? sortDirection,
                  int pageNumber = 1,
                  int pageSize = 100)
        {


            var query = dbContext.Users.AsQueryable();

            // Filtering
            if (string.IsNullOrWhiteSpace(searchQuery) == false)
            {
                query = query.Where(x => x.UserName.Contains(searchQuery) ||
                                         x.Email.Contains(searchQuery));
            }

            // Sorting
            if (string.IsNullOrWhiteSpace(sortBy) == false)
            {
                var isDesc = string.Equals(sortDirection, "Desc", StringComparison.OrdinalIgnoreCase);

                if (string.Equals(sortBy, "UserName", StringComparison.OrdinalIgnoreCase))
                {
                    query = isDesc ? query.OrderByDescending(x => x.UserName) : query.OrderBy(x => x.UserName);
                }

                if (string.Equals(sortBy, "Email", StringComparison.OrdinalIgnoreCase))
                {
                    query = isDesc ? query.OrderByDescending(x => x.Email) : query.OrderBy(x => x.Email);
                }
            }

            // Pagination

            var skipResults = (pageNumber - 1) * pageSize;
            query = query.Skip(skipResults).Take(pageSize);

            return await query.ToListAsync();
        }

        public async Task<IdentityUser?> GetAsync(string id)
        {
            return await dbContext.Users
            .FirstOrDefaultAsync(x => x.Id == id);

        }


        public async Task<int> CountAsync()
        {
            return await dbContext.Users.CountAsync();
        }
    }
}
