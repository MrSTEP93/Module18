using System;
using System.Threading;
using Module18.Final.Command;

namespace Module18.Final
{
    internal class Program
    {
        /// <summary>
        /// Здесь метод Main() сам выполняет роль инициатора вызова команды (Invoker'a), обращаясь к методам интерфейса IYouTubeCommand
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string videoUrl = args.Length == 0 ? "https://www.youtube.com/watch?v=53xkxGPbIZ4" : args[0];

            Console.WriteLine("Trying to get information about video...");
            IYouTubeCommand ytCommander = new CommandsToYTExplode();
            ytCommander.PrintInfo(videoUrl);

            Console.WriteLine("Trying to start download...");
            ytCommander.DownloadFile(videoUrl);
            Thread.Sleep(10000);
            Console.WriteLine("When downloading WILL BE completed, press any key to exit");
            Console.ReadKey();

        }
    }
}
