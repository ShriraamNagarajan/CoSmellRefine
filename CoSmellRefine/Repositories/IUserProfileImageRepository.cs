﻿using CoSmellRefine.Models.Domain;

namespace CoSmellRefine.Repositories
{
    public interface IUserProfileImageRepository
    {
        Task<IEnumerable<UserProfileImage>> GetAllAsync();

        Task<UserProfileImage?> GetAsync(Guid id);

        Task<UserProfileImage> AddAsync(UserProfileImage image);

        Task<UserProfileImage?> UpdateAsync(UserProfileImage image);

        Task<UserProfileImage?> DeleteAsync(Guid id);

        Task<UserProfileImage?> GetByUserAsync(string userId);
    }
}
