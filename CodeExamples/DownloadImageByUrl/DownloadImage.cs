using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

    }
}
