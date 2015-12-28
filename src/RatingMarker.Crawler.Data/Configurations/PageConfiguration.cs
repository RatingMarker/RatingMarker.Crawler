using System.Data.Entity.ModelConfiguration;
using RatingMarker.Crawler.Models;

namespace RatingMarker.Crawler.Data.Configurations
{
    public class PageConfiguration: EntityTypeConfiguration<Page>
    {
        public PageConfiguration()
        {
            HasRequired(s => s.Site)
                .WithMany(s => s.Pages)
                .HasForeignKey(s => s.SiteId);

            Property(p => p.FoundDate)
                .IsOptional();
            Property(p => p.LastScanDate)
                .IsOptional();
        }
    }
}