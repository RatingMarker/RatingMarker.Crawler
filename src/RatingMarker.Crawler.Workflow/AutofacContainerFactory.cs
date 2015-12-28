using Autofac;
using Autofac.Extras.NLog;
using RatingMarker.Crawler.Data.Repositories;
using RatingMarker.Crawler.Workflow.Downloaders;
using RatingMarker.Crawler.Workflow.Services;

namespace RatingMarker.Crawler.Workflow
{
    public class AutofacContainerFactory
    {
        public IContainer Build()
        {
            var builder = new ContainerBuilder();

            RegisterLogging(builder);
            RegisterData(builder);
            RegisterService(builder);

            builder.RegisterType<Downloader>()
                   .As<IDownloader>();
            builder.RegisterType<CrawlerProcessing>()
                   .InstancePerLifetimeScope();

            return builder.Build();
        }

        private void RegisterLogging(ContainerBuilder builder)
        {
            builder.RegisterModule<NLogModule>();
        }

        private void RegisterService(ContainerBuilder builder)
        {
            builder.RegisterType<StorageService>()
                   .As<IStorageService>();
            builder.RegisterType<DownloadService>()
                   .As<IDownloadService>();
            builder.RegisterType<UrlService>().As<IUrlService>();
            builder.RegisterType<CrawlerPersonRankService>()
                   .As<ICrawlerPersonRankService>();
        }

        private void RegisterData(ContainerBuilder builder)
        {
            builder.RegisterType<SiteRepository>()
                   .As<ISiteRepository>();
            builder.RegisterType<PageRepository>()
                   .As<IPageRepository>();
            builder.RegisterType<PersonRepository>()
                   .As<IPersonRepository>();
            builder.RegisterType<PersonPageRankRepository>()
                   .As<IPersonPageRankRepository>();
        }
    }
}