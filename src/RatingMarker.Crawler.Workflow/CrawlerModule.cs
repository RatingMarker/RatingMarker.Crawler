using Autofac;
using Autofac.Extras.NLog;
using RatingMarker.Crawler.Data.Repositories;
using RatingMarker.Crawler.Workflow.Services;

namespace RatingMarker.Crawler.Workflow
{
    public class CrawlerModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<NLogModule>();

            builder.RegisterType<SiteRepository>()
                   .As<ISiteRepository>()
                   .InstancePerLifetimeScope();

            builder.RegisterType<PageRepository>()
                   .As<IPageRepository>()
                   .InstancePerLifetimeScope();

            builder.RegisterType<PersonRepository>()
                   .As<IPersonRepository>()
                   .InstancePerLifetimeScope();

            builder.RegisterType<PersonPageRankRepository>()
                   .As<IPersonPageRankRepository>()
                   .InstancePerLifetimeScope();

            builder.RegisterType<StorageService>()
                   .As<IStorageService>()
                   .InstancePerLifetimeScope();

            builder.RegisterType<CrawlerManage>()
                   .InstancePerLifetimeScope();

            builder.RegisterType<CrawlerProcessing>()
                   .InstancePerLifetimeScope();

            builder.RegisterType<AutofacContainerFactory>();
        }
    }
}