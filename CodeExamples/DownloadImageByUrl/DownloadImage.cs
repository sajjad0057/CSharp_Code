using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DownloadImageByUrl
{
    public class DownloadImage
    {
        private readonly string _ImageUrl;

        public DownloadImage(string imageUrl)
        {
            _ImageUrl= imageUrl;
        }

        public void download()
        {
            try
            {
                using (var client = new WebClient())
                {
                    var imageBytes = client.DownloadData(_ImageUrl);
                    Console.WriteLine(imageBytes);
                    var rootPath = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.Parent;
                    var folderPath = Path.Combine(rootPath.FullName,"images");
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    Console.WriteLine(folderPath);
                    File.WriteAllBytes($"{folderPath}\\img.jpg", imageBytes);
                    Console.WriteLine("Image downloaded !");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error Occurred : {ex.Message}");
            }
        }


        public async Task DownloadImagesAsync(IEnumerable<string> imageUrls)
        {
            var httpClient = new HttpClient();
            var tasks = new List<Task>();
            using var throttler = new SemaphoreSlim(3);
            foreach (var url in imageUrls)
            {
                await throttler.WaitAsync();
                tasks.Add(Task.Run(async () =>
                {
                    try
                    {
                        var response = await httpClient.GetAsync(url);
                        response.EnsureSuccessStatusCode();
                        var bytes = await response.Content.ReadAsByteArrayAsync();

                        var rootPath = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.Parent;
                        var folderPath = Path.Combine(rootPath.FullName, "images");
                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }

                        var imgName = Guid.NewGuid().ToString()+".jpg";

                        Console.WriteLine($"image name : {imgName}");

                        await Task.Delay(3000);

                        Console.WriteLine($"image name> : {imgName}");

                        File.WriteAllBytes($"{folderPath}\\{imgName}", bytes);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    finally
                    {
                        throttler.Release();
                    }
                }));
            }
            await Task.WhenAll(tasks);
        }

    }
}
