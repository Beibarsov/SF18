
namespace SF18
{
    public class Programm
    {

        public static async Task Main(string[] args)
        {
            Sender sender = new Sender();
            Receiver receiver = new Receiver();

            Command commandInfo = new CommandGetInfoAboutVideo(receiver);
            Command commandDownload = new CommandDownloadVideo(receiver);

            sender.SetCommand(commandInfo);
            await sender.Run();
            sender.SetCommand(commandDownload);
            await sender.Run();

        }
    }




}