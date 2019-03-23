using DiscordCore.Configuration;
using System;
using System.Configuration;
using System.Threading;
using System.Threading.Tasks;

namespace DiscordCore.App
{
    public class DiscordCoreApp
    {
        //private static PluginManager manager;

        public void Start()
        {
            PluginManager manager = new PluginManager();
            manager.Start();

            //Thread worker = new Thread(PluginThread);
            //worker.Start();
            //while (true)
            //{
            //    string command = Console.ReadLine().ToLowerInvariant();
            //    if (command == "quit")
            //    {
            //        break;
            //    }
            //    else if (command == "reload")
            //    {
            //        manager.Stop();
            //        worker.Abort();
            //        worker = new Thread(PluginThread);
            //        worker.Start();
            //    }
            //}
        }

        //private static void PluginThread()
        //{
        //    manager = new PluginManager();
        //    manager.Start();
        //}
    }
}