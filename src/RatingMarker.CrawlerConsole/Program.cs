using System;
using Autofac;
using RatingMarker.Crawler.Workflow;

namespace RatingMarker.CrawlerConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ConsoleConfigure();

            AutofacConfig autofacConfig = new AutofacConfig();

            using (var scope = autofacConfig.Build())
            {
                var crawlerManage = scope.Resolve<CrawlerManage>();

                crawlerManage.InitializeCrawler();
            }

            Console.ReadLine();
        }

        private static void ConsoleConfigure()
        {
            Console.WindowWidth = 120;
            Console.BufferWidth = 120;
        }
    }
}