﻿namespace CoSmellRefine.Repositories
{
    public interface IMediaRepository
    {
        //Task<string> UploadAsync(IFormFile file);
        Task<string> UploadAzureAsync(IFormFile file);
    }
}
