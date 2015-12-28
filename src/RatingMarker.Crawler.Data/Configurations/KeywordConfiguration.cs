using System.Data.Entity.ModelConfiguration;
using RatingMarker.Crawler.Models;

namespace RatingMarker.Crawler.Data.Configurations
{
    public class KeywordConfiguration: EntityTypeConfiguration<Keyword>
    {
        public KeywordConfiguration()
        {
            HasRequired(p => p.Person)
                .WithMany(p => p.Keywords)
                .HasForeignKey(p => p.PersonId);
        }
    }
}