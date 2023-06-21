//using System;
//using System.IO;
//using System.Reflection;
//using System.Threading;
//using System.Threading.Tasks;

//using Google.Apis.Auth.OAuth2;
//using Google.Apis.Services;
//using Google.Apis.Upload;
//using Google.Apis.Util.Store;
//using Google.Apis.YouTube.v3;
//using Google.Apis.YouTube.v3.Data;

//namespace Google.Apis.YouTube.Samples
//{
//    /// <summary>
//    /// YouTube Data API v3 sample: upload a video.
//    /// Relies on the Google APIs Client Library for .NET, v1.7.0 or higher.
//    /// See https://developers.google.com/api-client-library/dotnet/get_started
//    /// </summary>
//    internal class UploadVideo
//    {
//        [STAThread]
//        [Obsolete]
//        static void Main(string[] args)
//        {
//            Console.WriteLine("YouTube Data API: Upload Video");
//            Console.WriteLine("==============================");

//            try
//            {
//                new UploadVideo().Run().Wait();
//            }
//            catch (AggregateException ex)
//            {
//                foreach (var e in ex.InnerExceptions)
//                {
//                    Console.WriteLine("Error: " + e.Message);
//                }
//            }

//            Console.WriteLine("Press any key to continue...");
//            Console.ReadKey();
//        }

//        [Obsolete]
//        private async Task Run()
//        {
//            UserCredential credential;
//            await Console.Out.WriteLineAsync(">>>>>> starting >>>>>>");
//            using (var stream = new FileStream(@"C:/Users/sajjad/Downloads/client_secrets.json", FileMode.Open, FileAccess.Read))
//            {
//                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
//                    GoogleClientSecrets.Load(stream).Secrets,
//                    // This OAuth 2.0 access scope allows an application to upload files to the
//                    // authenticated user's YouTube channel, but doesn't allow other types of access.
//                    new[] { YouTubeService.Scope.YoutubeUpload },
//                    "user",
//                    CancellationToken.None
//                );
//            }

//            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
//            {
//                HttpClientInitializer = credential,
//                ApplicationName = Assembly.GetExecutingAssembly().GetName().Name
//            });

//            var video = new Video();
//            video.Snippet = new VideoSnippet();
//            video.Snippet.Title = "Default Video Title";
//            video.Snippet.Description = "Default Video Description";
//            //video.Snippet.Tags = new string[] { "tag1", "tag2" };
//            //video.Snippet.CategoryId = "22"; // See https://developers.google.com/youtube/v3/docs/videoCategories/list
//            video.Status = new VideoStatus();
//            video.Status.PrivacyStatus = "public"; // or "private" or "public"
//            var filePath = @"C:/Users/sajjad/Downloads/pexels-george-morina-2677752-1280x720-30fps.mp4"; // Replace with path to actual movie file.

//            using (var fileStream = new FileStream(filePath, FileMode.Open))
//            {
//                var videosInsertRequest = youtubeService.Videos.Insert(video, "snippet,status", fileStream, "video/*");
//                videosInsertRequest.ProgressChanged += videosInsertRequest_ProgressChanged;
//                videosInsertRequest.ResponseReceived += videosInsertRequest_ResponseReceived;

//                await videosInsertRequest.UploadAsync();
//            }
//        }

//        void videosInsertRequest_ProgressChanged(Google.Apis.Upload.IUploadProgress progress)
//        {
//            switch (progress.Status)
//            {
//                case UploadStatus.Uploading:
//                    Console.WriteLine("{0} bytes sent.", progress.BytesSent);
//                    break;

//                case UploadStatus.Failed:
//                    Console.WriteLine("An error prevented the upload from completing.\n{0}", progress.Exception);
//                    break;
//            }
//        }

//        void videosInsertRequest_ResponseReceived(Video video)
//        {
//            Console.WriteLine("Video id '{0}' was successfully uploaded.", video.Id);
//        }
////    }
//}


using System;
using System.IO;
using System.Text.Json;
using System.Threading;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;

namespace YouTubeUploader
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UserCredential credential;
            ClientSecrets clientSecrets = new ClientSecrets();

            clientSecrets.ClientSecret = "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";
            clientSecrets.ClientId = "390093854916-5mf1ldf3osc9lljkvec1fn3dt3q1pimd.apps.googleusercontent.com";


            string credPath = "tokenFolder";
            credential = Task.Run(()=> GoogleWebAuthorizationBroker.AuthorizeAsync(
                clientSecrets,
                new[] { YouTubeService.Scope.YoutubeUpload },
                "bHlEPLoJZe4_fmO08sZfTw",
                CancellationToken.None,
                new FileDataStore(credPath, true))).Result;

            Console.WriteLine($"Credentials : {JsonSerializer.Serialize(credential)}");


            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "YouTubeUploader"
            });

            var video = new Google.Apis.YouTube.v3.Data.Video();
            video.Snippet = new Google.Apis.YouTube.v3.Data.VideoSnippet();
            video.Snippet.Title = "My Test Video";
            video.Snippet.Description = "This is a test video.";
            video.Snippet.Tags = new string[] { "test", "video" };
            video.Snippet.CategoryId = "22"; // 22 represents the category ID for Entertainment
            video.Status = new Google.Apis.YouTube.v3.Data.VideoStatus();
            video.Status.PrivacyStatus = "public"; // Set as public, private, or unlisted

            var filePath = @"C:/Users/sajjad/Downloads/pexels-george-morina-2677752-1280x720-30fps.mp4";
            using (var fileStream = new FileStream(filePath, FileMode.Open))
            {
                var videosInsertRequest = youtubeService.Videos.Insert(video, "snippet,status", fileStream, "video/*");
                videosInsertRequest.ProgressChanged += VideosInsertRequest_ProgressChanged;
                videosInsertRequest.ResponseReceived += VideosInsertRequest_ResponseReceived;

                var uploadThread = new Thread(() =>
                {
                    videosInsertRequest.Upload();
                });
                uploadThread.Start();
                uploadThread.Join();
            }

            Console.WriteLine("Video uploaded successfully.");
            Console.ReadLine();
        }

        private static void VideosInsertRequest_ProgressChanged(IUploadProgress progress)
        {
            switch (progress.Status)
            {
                case UploadStatus.Uploading:
                    Console.WriteLine($"{progress.BytesSent} bytes uploaded.");
                    break;
                case UploadStatus.Completed:
                    Console.WriteLine("Upload completed.");
                    break;
                case UploadStatus.Failed:
                    Console.WriteLine($"Upload failed. {progress.Exception.Message}");
                    break;
            }
        }

        private static void VideosInsertRequest_ResponseReceived(Google.Apis.YouTube.v3.Data.Video video)
        {
            Console.WriteLine($"Video ID: {video.Id}");
        }
    }
}
