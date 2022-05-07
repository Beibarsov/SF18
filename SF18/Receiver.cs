using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos;
using YoutubeExplode.Converter;

namespace SF18
{
    public class Receiver
    {
        YoutubeClient youtubeClient;

        public Receiver()
        {
            youtubeClient = new YoutubeClient();
        }


        public async Task GetInfoAboutVideo()
        {
            string url = Config.Url;
            Video video;
            try
            {
                video = await youtubeClient.Videos.GetAsync(url);
                Console.WriteLine(video.Title);
                Console.WriteLine(video.Description);
                Console.WriteLine("Вывод информации завершен");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Что-то пошло не так. Скорее всего, видео по указанной ссылке не существует");
            }
        }

        public async Task DownloadVideo()
        {
            string url = Config.Url;
            try
            {
                Console.WriteLine("Начинается загрузка видео. Это может занять некоторое время");
                await youtubeClient.Videos.DownloadAsync(url, "video.mp4", builder => builder.SetPreset(ConversionPreset.UltraFast));
                Console.WriteLine("Скачивание видео завершено");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Что-то пошло не так. Скорее всего, видео по указанной ссылке не существует");
            }

        }

    }
}
