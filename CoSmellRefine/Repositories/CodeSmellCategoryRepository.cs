﻿using Azure;
using CoSmellRefine.Data;
using CoSmellRefine.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CoSmellRefine.Repositories
{
    public class CodeSmellCategoryRepository : ICodeSmellCategoryRepository
    {
        private readonly ApplicationDbContext dbContext;

        public CodeSmellCategoryRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public async Task<IEnumerable<CodeSmellCategory>> GetAllAsync()
        {
            return await dbContext.CodeSmellCategories
             .Include(c => c.Modules)
             .OrderBy(c => c.Name)
             .ToListAsync();

        }

        public Task<CodeSmellCategory?> GetAsync(Guid id)
        {
            return dbContext.CodeSmellCategories
                .Include(x => x.Modules)
            .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> CountAsync()
        {
            return await dbContext.CodeSmellCategories.CountAsync();
        }
    }
}
