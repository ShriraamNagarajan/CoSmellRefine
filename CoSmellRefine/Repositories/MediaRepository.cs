using Amazon.S3;
using Amazon;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Azure.Core;

namespace CoSmellRefine.Repositories
{
    public class MediaRepository : IMediaRepository
    {
        //public readonly string BucketName;
        private readonly string _connectionString;
        private readonly string _containerName;
        public MediaRepository(IConfiguration configuration)
        {
            //this.BucketName = "finance-blog-post";
            _connectionString = configuration["AzureStorage:ConnectionString"];
            _containerName = configuration["AzureStorage:ContainerName"];

        }

        //public async Task<string> UploadAsync(IFormFile file)
        //{

        //    var client = new AmazonS3Client(RegionEndpoint.USEast1);

        //    // Check if the bucket exists
        //    var bucketExists = await AmazonS3Util.DoesS3BucketExistV2Async(client, BucketName);
        //    if (!bucketExists)
        //    {
        //        var bucketRequest = new PutBucketRequest()
        //        {
        //            BucketName = BucketName,
        //            UseClientRegion = true
        //        };
        //        await client.PutBucketAsync(bucketRequest);
        //    }

        //    // Upload the file and make it public
        //    var objectRequest = new PutObjectRequest()
        //    {
        //        BucketName = BucketName,
        //        Key = file.FileName,
        //        InputStream = file.OpenReadStream(),
        //        CannedACL = S3CannedACL.PublicRead
        //    };
        //    await client.PutObjectAsync(objectRequest);

        //    // Construct the URL
        //    string fileUrl = $"https://{BucketName}.s3.amazonaws.com/{file.FileName}";

        //    return fileUrl;
        //}


        public async Task<string> UploadAzureAsync(IFormFile file)
        {
            var blobServiceClientOptions = new BlobClientOptions
            {
                Retry =
            {
                Delay = TimeSpan.FromSeconds(2),
                MaxRetries = 6,
                Mode = RetryMode.Exponential,
                NetworkTimeout = TimeSpan.FromMinutes(10) // Increase the network timeout
            }
            };
            var blobServiceClient = new BlobServiceClient(_connectionString, blobServiceClientOptions);
            var blobContainerClient = blobServiceClient.GetBlobContainerClient(_containerName);


            // Ensure the container exists
            await blobContainerClient.CreateIfNotExistsAsync(PublicAccessType.Blob);

            var blobClient = blobContainerClient.GetBlobClient(file.FileName);
            var stream = file.OpenReadStream();
            await blobClient.UploadAsync(stream, new BlobHttpHeaders { ContentType = file.ContentType });

            return blobClient.Uri.ToString();

        }
    }
}
