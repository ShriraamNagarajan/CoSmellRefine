using CoSmellRefine.Data;
using CoSmellRefine.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace CoSmellRefine.Repositories
{
    public class ModuleRepository : IModuleRepository
    {
        private readonly ApplicationDbContext dbContext;

        public ModuleRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Module Add(Module module)
        {
            dbContext.Add(module);
            dbContext.SaveChanges();
            return module;
        }

        public Module? Delete(Guid id)
        {
            var existingModule = dbContext.Modules.Find(id);

            if (existingModule != null)
            {
                dbContext.Modules.Remove(existingModule);
                dbContext.SaveChanges();
                return existingModule;
            }
            return null;
        }

        public async Task<IEnumerable<Module>> GetAllAsync(string? searchQuery, string? sortBy, string? sortDirection, int pageNumber = 1, int pageSize = 100)
        {
            var query = dbContext.Modules
                                 .Include(x => x.CodeSmell)
                                 .Include(x => x.CodeSmellCategory)
                                 .Include(x => x.Videos)
                                 .Include(x => x.Flashcards)
                                 .Include(x => x.Quizzes)
                                 .AsQueryable();

            // Filtering
            if (string.IsNullOrWhiteSpace(searchQuery) == false)
            {
                query = query.Where(x =>
                    (x.Title != null && x.Title.ToLower().Contains(searchQuery.ToLower())) ||
                    (x.Description != null && x.Description.ToLower().Contains(searchQuery.ToLower())) ||
                    (x.CodeSmell != null && x.CodeSmell.Name != null && x.CodeSmell.Name.ToLower().Contains(searchQuery.ToLower())) ||
                    (x.Videos != null && x.Videos.Any(v => v.VideoUrl != null && v.VideoUrl.ToLower().Contains(searchQuery.ToLower())))
                );
            }

            // Sorting
            if (string.IsNullOrWhiteSpace(sortBy) == false)
            {
                var isDesc = string.Equals(sortDirection, "Desc", StringComparison.OrdinalIgnoreCase);

                if (string.Equals(sortBy, "Title", StringComparison.OrdinalIgnoreCase))
                {
                    query = isDesc ? query.OrderByDescending(x => x.Title) : query.OrderBy(x => x.Title);
                }
                else if (string.Equals(sortBy, "Description", StringComparison.OrdinalIgnoreCase))
                {
                    query = isDesc ? query.OrderByDescending(x => x.Description) : query.OrderBy(x => x.Description);
                }
                else if (string.Equals(sortBy, "CodeSmell", StringComparison.OrdinalIgnoreCase))
                {
                    query = isDesc ? query.OrderByDescending(x => x.CodeSmell.Name) : query.OrderBy(x => x.CodeSmell.Name);
                }
                else if (string.Equals(sortBy, "VideoUrl", StringComparison.OrdinalIgnoreCase))
                {
                    query = isDesc ? query.OrderByDescending(x => x.Videos.FirstOrDefault().VideoUrl) : query.OrderBy(x => x.Videos.FirstOrDefault().VideoUrl);
                }

                // Add other sorting conditions here if needed
            }

            // Pagination
            var skipResults = (pageNumber - 1) * pageSize;
            query = query.Skip(skipResults).Take(pageSize);

            return await query.ToListAsync();
        }

        public Module? Get(Guid id)
        {
            return dbContext.Modules
                            .Include(x => x.Videos)
                            .Include(x => x.Flashcards)
                            .Include(x => x.Quizzes)
                            .Include(x => x.CodeSmell)
                            .Include(x => x.CodeSmellCategory)
                            .FirstOrDefault(x => x.Id == id);
        }

        public Module? Update(Module module)
        {
     

            var existingModule = dbContext.Modules
                                 .Include(x => x.CodeSmell)
                                 .Include(x => x.Videos)
                                 .Include(x => x.Flashcards)
                                 .Include(x => x.Quizzes)
                                 .FirstOrDefault(x => x.Id == module.Id); ;

            if (existingModule != null)
            {
                existingModule.Id = module.Id;
                existingModule.Title = module.Title;
                existingModule.Description = module.Description;
                existingModule.ReadingContent = module.ReadingContent;
                existingModule.LastModifiedDate = module.LastModifiedDate;
                existingModule.Videos = module.Videos;
                existingModule.Flashcards = module.Flashcards;
                existingModule.Quizzes = module.Quizzes;

                dbContext.SaveChanges();
            }

            return existingModule;
        }

        public int Count()
        {
            return dbContext.Modules.Count();
        }

        public string GetRecentlyUpdatedModule()
        {
            return dbContext.Modules.OrderByDescending(m => m.LastModifiedDate).FirstOrDefault()?.Title ?? "N/A";
        }


    }
}
