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

            Video video = await youtubeClient.Videos.GetAsync("https://www.youtube.com/watch?v=R_dyIBpZ1lw");
            Console.WriteLine(video.Title);
        }

        public async Task DownloadVideo()
        {
            await youtubeClient.Videos.DownloadAsync("https://www.youtube.com/watch?v=R_dyIBpZ1lw", "video.mp4", builder => builder.SetPreset(ConversionPreset.UltraFast));
        }

    }
}
