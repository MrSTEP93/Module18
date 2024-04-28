using AngleSharp;
using AngleSharp.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.Streams;

namespace Module18.Final.Command
{
    /// <summary>
    /// Реализация интерфейса IYouTubeCommand через команды YoutubeExplode.
    /// Данные методы инкапсулируют в себе методы для работы с YoutubeExplode и обработку полученных данных.
    /// Инициатор команды (в нашем случае, метод Main) ничего не знает, как это обрабатывается, он просто вызывает метод (команду)
    /// </summary>
    internal class CommandsToYTExplode : IYouTubeCommand
    {
        public void PrintInfo(string url)
        {
            var ytClient = new YoutubeClient();
            var result = ytClient.Videos.GetAsync(url).Result;
            
            Console.WriteLine($"Information about video {url}");
            Type resultType = result.GetType();
            foreach (var prop in resultType.GetProperties())
                Console.WriteLine($"\t {prop.Name}:  {prop.GetValue(result, null)} ");
        }

        public async Task DownloadFile(string url)
        {
            var ytClient = new YoutubeClient();
            var video = await ytClient.Videos.GetAsync(url);
            var streamManifest = await ytClient.Videos.Streams.GetManifestAsync(video.Id);
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

            await Console.Out.WriteLineAsync("Downloading started");           
            if (streamInfo != null)
            {
                var fileName = $"{video.Title}.{streamInfo.Container}";
                var filePath = Path.Combine(Environment.CurrentDirectory, fileName);

                await ytClient.Videos.Streams.DownloadAsync(streamInfo, filePath);
            }
            await Console.Out.WriteLineAsync("Downloading completed");
        }
    }
}
