using System.Data.Entity.ModelConfiguration;
using RatingMarker.Crawler.Models;

namespace RatingMarker.Crawler.Data.Configurations
{
    public class PersonConfiguration: EntityTypeConfiguration<Person>
    {
        public PersonConfiguration()
        {
            ToTable("Persons");
        }
    }
}