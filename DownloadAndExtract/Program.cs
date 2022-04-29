using SlavaGu.ConsoleAppLauncher;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DownloadAndExtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("ffmpeg-release-essentials.7z"))
            {
                File.Delete("ffmpeg-release-essentials.7z");
            }
            System.Console.WriteLine("Download is started");

            Start();
            System.Console.WriteLine("All done.");
            System.Console.ReadKey();
        }

        private static void Start()
        {

            Download("https://www.gyan.dev/ffmpeg/builds/ffmpeg-release-essentials.7z", "ffmpeg-release-essentials.7z");
            Extract();

        }

        private static void Extract()
        {
            if (File.Exists("ffmpeg.exe"))
            {
                File.Delete("ffmpeg.exe");
            }
            if (File.Exists("ffprobe.exe"))
            {
                File.Delete("ffprobe.exe");
            }
            ConsoleApp app = new ConsoleApp("7z.exe", "e -r ffmpeg-release-essentials.7z ffmpeg.exe ffprobe.exe");
            app.ConsoleOutput += (o, e) =>
            {
                System.Console.WriteLine(e.Line);
            };
            app.Run();
            app.WaitForExit();
            if (File.Exists("ffmpeg-release-essentials.7z"))
            {
                File.Delete("ffmpeg-release-essentials.7z");
            }
        }

        private static void Download(string uri, string fileName)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            using (WebClient wc = new WebClient())
            {

                wc.DownloadProgressChanged += (o, e) =>
                {
                    System.Console.Write("\rDownloading {0}% ", e.ProgressPercentage);
                };
                wc.DownloadFileCompleted += (o, e) =>
                {
                    System.Console.WriteLine("\nDownload is finished.");
                };

                wc.DownloadFileAsync(new Uri(uri), fileName);

                var spin = new ConsoleSpinner();
                while (wc.IsBusy)
                {
                    spin.Turn();
                }

            }
        }
    }
}
