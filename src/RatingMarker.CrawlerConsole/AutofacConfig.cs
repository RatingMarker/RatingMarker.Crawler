using Autofac;
using RatingMarker.Crawler.Workflow;

namespace RatingMarker.CrawlerConsole
{
    public class AutofacConfig
    {
         public IContainer Build()
         {
             var builder = new ContainerBuilder();

             RegisterCrawler(builder);

             return builder.Build();
         }

        public void RegisterCrawler(ContainerBuilder builder)
        {
            builder.RegisterModule<CrawlerModule>();
        }
    }
}