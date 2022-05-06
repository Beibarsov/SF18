
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

            Console.WriteLine("Вас приветствует программа для скачивания видео с Youtube!");

            while (true)
            {
                System.Threading.Thread.Sleep(5000);
                Console.Clear();
                Console.WriteLine("Нужно скачать или просто вывести информацию? \nНужно ввести 1 скачивания, 2 для информации\nВо всех других случаях программа будет закрыта.");
                Config.Option = Console.ReadLine();
                switch (Config.Option)
                {
                    case "1":
                        sender.SetCommand(commandDownload);
                        break;
                    case "2":
                        sender.SetCommand(commandInfo);
                        break;
                    default:
                        Console.WriteLine("Введена несуществующая опция. Программа будет закрыта");
                        return;
                }
                Console.WriteLine("Вставьте ссылку на видео");
                Config.Url = Console.ReadLine();
                await sender.Run();

            }
        }
    }




}