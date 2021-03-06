using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF18
{
    public class CommandDownloadVideo : Command
    {
        Receiver receiver;

        public CommandDownloadVideo(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public override async Task Run()
        {
            await receiver.GetInfoAboutVideo();
            await receiver.DownloadVideo();
        }
    }
}
